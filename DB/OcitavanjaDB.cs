using Microsoft.Data.SqlClient;
using TSP2025.Data.Model;
using TSP2025.Data;
using TSP2025.Utils;
using System.Configuration;

namespace TSP2025.DB
{
    public static class OcitavanjaDB
    {
        public static IList<Ocitavanje> GetSvaOcitavanja(DataSourceMode sourceMode, int godinaUnazad, int korakUMinutama, IList<MernoMesto> SvaMernaMesta)
        {
            var svaOcitavanja = new List<Ocitavanje>();

            if (sourceMode == DataSourceMode.FromRAM)
            {
                var vreme = DateTime.Now.Date.AddYears(-godinaUnazad);
                decimal vrednost = 0M;
                while (vreme < DateTime.Now.Date)
                {
                    for (int i = 0; i < SvaMernaMesta.Count; i++)
                    {
                        {
                            svaOcitavanja.Add(new Ocitavanje() { Vreme = vreme, MernoMestoId = SvaMernaMesta[i].Id, MernoMesto = SvaMernaMesta[i].OznakaMernogMesta, Vrednost = vrednost });
                        }
                        vreme = vreme.AddMinutes(korakUMinutama);
                        vrednost += (new Random()).Next(100);
                    }
                }
            }
            else if (sourceMode == DataSourceMode.FromDatabase)
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var command = new SqlCommand("select o.Datum, o.MernoMestoId, o.Vrednost From TSP2025.dbo.Ocitavanje o Order By o.Datum", connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            svaOcitavanja.Add(new Ocitavanje() { Vreme = reader.GetDateTime(0), MernoMestoId = reader.GetInt32(1), MernoMesto = SvaMernaMesta.First(m => m.Id == reader.GetInt32(1)).OznakaMernogMesta, Vrednost = (decimal)reader.GetDouble(2) });
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        FormMessages.ShowError("Greška. " + ex.Message);
                    }

                }
            }

            return svaOcitavanja;

        }
    }
}
