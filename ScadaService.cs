
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;

namespace TSP2025
{
    public enum ScadaMessageType
    {
        Info,
        Exclamation,
        Warning,
        Error,
    }
    public sealed class ScadaService
    {
        private static ScadaService instance = null;
        private static readonly object padlock = new object();
        ScadaService()
        {
        }

        public static ScadaService Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ScadaService();
                    }
                    return instance;
                }
            }
        }

        public class ScadaMessageEventArgs : EventArgs
        {
            public ScadaMessageEventArgs(string message, ScadaMessageType messageType)
            {
                Message = message;
                MessageType = messageType;
            }

            public string Message { get; set; } = string.Empty;
            public ScadaMessageType MessageType { get; set; } = ScadaMessageType.Info;
        }

        public delegate void ScadaMessageEventHandler(object sender, ScadaMessageEventArgs e);

        public event ScadaMessageEventHandler ScadaMessage;

        System.Timers.Timer _timer;
        private int _callbackCount = 1;
        public void Stop()
        {
            // Stop the SCADA service
            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs(Environment.NewLine + "Scada service stoped." + Environment.NewLine, ScadaMessageType.Info));
            if (_timer != null)
            {
                _timer.Stop();
            }
            _callbackCount = 1;
        }

        private List<MernoMesto> _svaMernaMesta;
        private MernoMesto _zaMernoMesto;
        private int _pullInterval = 10000; // 10 seconds
        public void Start(List<MernoMesto> svaMernaMesta)
        {
            // Initialize the SCADA service
            _svaMernaMesta = svaMernaMesta;
            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"SCADA service started at {DateTime.Now:dd/MM/yy HH:mm:ss}", ScadaMessageType.Info));
            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"Checking DB connection.... PASSED", ScadaMessageType.Exclamation));
            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"Pull interval set to {_pullInterval}ms", ScadaMessageType.Info));

            _timer = new System.Timers.Timer();
            _timer.Interval = _pullInterval;
            _timer.Elapsed += PullDoWork;
            _timer.AutoReset = true;
            _timer.Start();
        }

        private void PullDoWork(object? sender, System.Timers.ElapsedEventArgs e)
        {
            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"{Environment.NewLine}[#{_callbackCount}] Provera SCADA zapisa započeta u {DateTime.Now:dd/MM/yy HH:mm:ss} ...", ScadaMessageType.Exclamation));
            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"Detektovano mernih mesta: {_svaMernaMesta.Count}", ScadaMessageType.Exclamation));

            try
            {
                using (var sqlCommand = new SqlCommand())
                {
                    using (sqlCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        foreach (var mernoMesto in _svaMernaMesta)
                        {
                            _zaMernoMesto = mernoMesto;

                            // get last date from PullHistory
                            string getQuery = @$"Select top 1 ph.Vreme from PullHistory ph Where ph.MernoMestoId = {_zaMernoMesto.Id} And Status = 1 Order by Vreme desc";
                            sqlCommand.CommandText = getQuery;
                            sqlCommand.Connection.Open();
                            var lastPullDate = new DateTime(2022, 1, 1);
                            using (var reader = sqlCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    lastPullDate = reader.GetDateTime(0);
                                }
                                reader.Close();
                            }
                            sqlCommand.Connection.Close();

                            // pull Ocistavanja from SCADA and save to db
                            string insertOcivanjaQuery =
                                    @$" Insert Into TSP2025.dbo.Ocitavanje (MernoMestoId, Datum, Vrednost, SourceId) 
                                Select {_zaMernoMesto.Id}, t1.FLTIME, t1.{_zaMernoMesto.ScadaKolona}, -1 
                                From TSP2025SCADA.dbo.{_zaMernoMesto.ScadaTabela} t1 Where t1.FLTIME > @lastPullDate And t1.FLTIME > @lastPullDate";

                            sqlCommand.CommandText = insertOcivanjaQuery;
                            sqlCommand.Parameters.Clear();
                            sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@lastPullDate", DbType = DbType.DateTime, Direction = ParameterDirection.Input, Value = lastPullDate });
                            sqlCommand.Connection.Open();
                            int affected = (int)sqlCommand.ExecuteNonQuery();
                            sqlCommand.Connection.Close();

                            string insertPullHistoryQuery = @$"
                                Insert Into PullHistory (MernoMestoId, PrenetoZapisa, Status, Poruka) 
                                Values ({_zaMernoMesto.Id}, {affected}, 1, 'Za: {_zaMernoMesto.OznakaMernogMesta} preneto - {affected}')";

                            sqlCommand.CommandText = insertPullHistoryQuery;
                            sqlCommand.Parameters.Clear();
                            sqlCommand.Connection.Open();
                            sqlCommand.ExecuteNonQuery();
                            sqlCommand.Connection.Close();

                            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"Za: [{_zaMernoMesto.OznakaMernogMesta}] preneto - [{affected}]", ScadaMessageType.Info));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"Došlo je do greške prilikom prenosa: {ex.Message}", ScadaMessageType.Error));

                var errorInsert = @$"
                                Insert Into PullHistory (MernoMestoId, PrenetoZapisa, Status, Poruka) 
                                Values ({_zaMernoMesto.Id}, 0, 0, '{ex.Message}')";

                using (var insertCommand = new SqlCommand())
                {
                    using (insertCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        insertCommand.CommandText = errorInsert;
                        insertCommand.Connection.Open();
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();
                    }
                }
            }

            ScadaMessage?.Invoke(this, new ScadaMessageEventArgs($"Prenos SCADA zapisa [#{_callbackCount++}] završen u  {DateTime.Now:dd/MM/yy HH:mm:ss}.", ScadaMessageType.Exclamation));
        }
    }
}
