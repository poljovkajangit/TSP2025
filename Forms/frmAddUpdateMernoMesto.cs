using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2025.Common;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public enum TipMernogMesta : int
    {
        Podstanica = 1,
        IndividualniPotrosac = 2
    }

    public partial class frmAddUpdateMernoMesto : Form
    {
        private string _oznakaMernogMesta;
        private IEntity _potrosac;
        private Button _btnParentDodajMernoMesto;
        private FormMode _mode;
        private MernoMesto _mernoMesto;
        public frmAddUpdateMernoMesto(string oznakaMernogMesta, TipMernogMesta tip, TSP2025DataContext dataSource, IEntity potrosac, Button parentDodajButton)
        {
            InitializeComponent();
            bsGrupeMernihMesta.DataSource = dataSource;

            _mode = FormMode.Add;
            _potrosac = potrosac;
            tbOznakaMernogMesta.Text = _oznakaMernogMesta = oznakaMernogMesta;
            tbPotrosacId.Text = potrosac.Id.ToString();
            _btnParentDodajMernoMesto = parentDodajButton;
            switch (tip)
            {
                case TipMernogMesta.Podstanica:
                    rbPodstanica.Checked = true;
                    rbIndividualni.Checked = false;
                    break;
                case TipMernogMesta.IndividualniPotrosac:
                    rbPodstanica.Checked = false;
                    rbIndividualni.Checked = true;
                    break;
            }
        }

        public frmAddUpdateMernoMesto(MernoMesto mernoMesto, TSP2025DataContext dataSource)
        {
            InitializeComponent();
            bsGrupeMernihMesta.DataSource = dataSource;

            _mode = FormMode.Update;
            _mernoMesto = mernoMesto;
            tbOznakaMernogMesta.Text = _oznakaMernogMesta = mernoMesto.OznakaMernogMesta;
            tbPotrosacId.Text = mernoMesto.PotrosacId.ToString();
            tbOznakaKalorimetra.Text = mernoMesto.OznakaKalorimetra;
            cbGrupeMernihMesta.SelectedValue = mernoMesto.GrupaMernogMestaId;
            tbScadaTabela.Text = mernoMesto.ScadaTabela;
            tbScadaKolona.Text = mernoMesto.ScadaKolona;
            tbIdMernogMesta.Text = mernoMesto.Id.ToString();
            switch (mernoMesto.Tip)
            {
                case (int)TipMernogMesta.Podstanica:
                    rbPodstanica.Checked = true;
                    rbIndividualni.Checked = false;
                    break;
                case (int)TipMernogMesta.IndividualniPotrosac:
                    rbPodstanica.Checked = false;
                    rbIndividualni.Checked = true;
                    break;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sqlCommand = new SqlCommand())
                {
                    using (sqlCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string sqlQuery = string.Empty;
                        if (_mode == FormMode.Add)
                        {
                            sqlQuery = "Insert into MernoMesto (OznakaMernogMesta, OznakaKalorimetra, PotrosacId, GrupaMernogMestaId, Tip, ScadaTabela, ScadaKolona) " +
                                " Values (@OznakaMernogMesta, @OznakaKalorimetra, @PotrosacId, @GrupaMernogMestaId, @Tip, @ScadaTabela, @ScadaKolona)";
                            sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@PotrosacId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = tbPotrosacId.Text });
                            if (rbPodstanica.Checked)
                            {
                                sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Tip", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (int)TipMernogMesta.Podstanica });
                            }
                            else if (rbIndividualni.Checked)
                            {
                                sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Tip", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (int)TipMernogMesta.IndividualniPotrosac });
                            }

                        }
                        else if (_mode == FormMode.Update)
                        {
                            sqlQuery = "Update MernoMesto Set OznakaMernogMesta=@OznakaMernogMesta, OznakaKalorimetra=@OznakaKalorimetra, GrupaMernogMestaId=@GrupaMernogMestaId, ScadaTabela=@ScadaTabela, ScadaKolona=@ScadaKolona Where Id=@Id";
                            sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = _mernoMesto.Id });
                        }

                        sqlCommand.CommandText = sqlQuery;

                        sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OznakaMernogMesta", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = tbOznakaMernogMesta.Text });
                        sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OznakaKalorimetra", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = tbOznakaKalorimetra.Text });
                        sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@GrupaMernogMestaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (bsGrupeMernihMesta.Current as GrupaMernihMesta)!.Id });
                        sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@ScadaTabela", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = tbScadaTabela.Text });
                        sqlCommand.Parameters.Add(new SqlParameter() { ParameterName = "@ScadaKolona", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = tbScadaKolona.Text });


                        sqlCommand.Connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Connection.Close();

                        if (_mode == FormMode.Add)
                        {
                            if (rbPodstanica.Checked)
                            {
                                FormMessages.ShowInformation("Uspešno vezano novo merno mesto za podstanicu: " + _oznakaMernogMesta);
                            }
                            else
                            {
                                FormMessages.ShowInformation("Uspešno vezano novo merno mesto za individualnog potrošača: " + _oznakaMernogMesta);
                            }
                            _btnParentDodajMernoMesto.Visible = false;
                            _potrosac.ImaMernoMesto = true;
                        }
                    }

                    if (_mode == FormMode.Update)
                    {
                        _mernoMesto.OznakaKalorimetra = tbOznakaKalorimetra.Text;
                        _mernoMesto.OznakaMernogMesta = tbOznakaMernogMesta.Text;
                        _mernoMesto.ScadaTabela = tbScadaTabela.Text;
                        _mernoMesto.ScadaKolona = tbScadaKolona.Text;
                        _mernoMesto.GrupaMernogMestaId = (bsGrupeMernihMesta.Current as GrupaMernihMesta)!.Id;
                        _mernoMesto.GrupaMernogMesta = (bsGrupeMernihMesta.Current as GrupaMernihMesta)!;
                        _mernoMesto.GrupaMernogMestaId = (bsGrupeMernihMesta.Current as GrupaMernihMesta)!.Id;
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                FormMessages.ShowError("Došlo je do greške prilikom unosa/izmene: " + TSP2025Helper.EnvironmentNewLines(2) + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (var command = new SqlCommand())
                {
                    using (command.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string query = @$"Select count(t.{tbScadaKolona.Text}) From TSP2025SCADA.dbo.{tbScadaTabela.Text} t";

                        command.CommandText = query;
                        command.Connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FormMessages.ShowInformation($"Uspešno. U tabeli {tbScadaTabela.Text} postoji {reader.GetInt32(0)} zapisa.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormMessages.ShowError("Provera nije uspela, proverite nazive SCADA tabela i kolona." + TSP2025Helper.EnvironmentNewLines(2) + ex.Message);
            }
        }
    }
}
