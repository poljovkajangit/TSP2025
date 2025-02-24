using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
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

    public partial class frmDodajMernoMesto : Form
    {
        private string _oznakaMernogMesta;
        public frmDodajMernoMesto(string oznakaMernogMesta, TipMernogMesta tip, PoslovniSistemDataContext dataSource, int id)
        {
            InitializeComponent();

            tbOznakaMernogMesta.Text = _oznakaMernogMesta = oznakaMernogMesta;
            tbId.Text = id.ToString();
            switch (tip)
            {
                case TipMernogMesta.Podstanica:
                    rbPodstanica.Checked = true;
                    rbIndividualni.Checked = false;
                    rbPodstanica.Visible = true;
                    rbIndividualni.Visible = false;
                    break;
                case TipMernogMesta.IndividualniPotrosac:
                    rbPodstanica.Checked = false;
                    rbIndividualni.Checked = true;
                    rbPodstanica.Visible = false;
                    rbIndividualni.Visible = true;
                    break;
            }

            bsGrupeMernihMesta.DataSource = dataSource;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                using (var insertCommand = new SqlCommand())
                {
                    using (insertCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string insertQuery = "Insert into MernoMesto (OznakaMernogMesta, OznakaKalorimetra, PotrosacId, GrupaMernogMestaId, Tip, ScadaTabela, ScadaKolona) " +
                            " Values (@OznakaMernogMesta, @OznakaKalorimetra, @PotrosacId, @GrupaMernogMestaId, @Tip, @ScadaTabela, @ScadaKolona)";

                        insertCommand.CommandText = insertQuery;

                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OznakaMernogMesta", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = tbOznakaMernogMesta.Text });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OznakaKalorimetra", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = tbOznakaKalorimetra.Text });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@GrupaMernogMestaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (bsGrupeMernihMesta.Current as GrupaMernihMesta).Id });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@ScadaTabela", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = tbScadaTabela.Text });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@ScadaKolona", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = tbScadaKolona.Text });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@PotrosacId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = tbId.Text });
                        if (rbPodstanica.Checked)
                        {
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Tip", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (int)TipMernogMesta.Podstanica });
                        }
                        else if (rbIndividualni.Checked)
                        {
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Tip", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (int)TipMernogMesta.IndividualniPotrosac });
                        }

                        insertCommand.Connection.Open();
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();

                        if (rbPodstanica.Checked)
                        {
                            FormMessages.ShowInformation("Uspešno vezano novo merno mesto za podstanicu: " + _oznakaMernogMesta);
                        }
                        else
                        {
                            FormMessages.ShowInformation("Uspešno vezano novo merno mesto za individualnog potrošača: " + _oznakaMernogMesta);
                        }
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                FormMessages.ShowError("Došlo je do greške prilikom unosa: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajMernoMesto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<to do>");
        }
    }
}
