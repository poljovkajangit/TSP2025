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
        public frmDodajMernoMesto(string oznakaMernogMesta, TipMernogMesta tip, PoslovniSistemDataContext dataSource, int id)
        {
            InitializeComponent();

            tbOznakaMernogMesta.Text = oznakaMernogMesta;
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
                        string insertQuery = "Insert into MernoMesto (OznakaMernogMesta, OznakaKalorimetra, IndividualniPotrosacId, PodstanicaId, GrupaMernihMestaId, Tip) " +
                            " Values (@OznakaMernogMesta, @OznakaKalorimetra, @IndividualniPotrosacId, @PodstanicaId, @GrupaMernihMestaId, @Tip)";

                        insertCommand.CommandText = insertQuery;

                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OznakaMernogMesta", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = tbOznakaMernogMesta.Text });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OznakaKalorimetra", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = tbOznakaKalorimetra.Text });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@GrupaMernihMestaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (bsGrupeMernihMesta.Current as GrupaMernihMesta).Id });
                        if (rbPodstanica.Checked)
                        {
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Tip", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (int)TipMernogMesta.Podstanica });
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@PodstanicaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = tbId.Text });
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IndividualniPotrosacId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = DBNull.Value });
                        }
                        else if (rbIndividualni.Checked)
                        {
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Tip", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = (int)TipMernogMesta.IndividualniPotrosac });
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@IndividualniPotrosacId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = tbId.Text });
                            insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@PodstanicaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = DBNull.Value });
                        }

                        insertCommand.Connection.Open();
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();

                        if (rbPodstanica.Checked)
                        {
                            FormMessages.ShowConfirm("Uspešno vezano novo merno mesto za podstanicu");
                        }
                        else
                        {
                            FormMessages.ShowConfirm("Uspešno vezano novo merno mesto za individualnog potrošača");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
