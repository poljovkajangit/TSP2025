using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmParent : Form
    {
        PoslovniSistemDataContext _DataContext;

        private MernoMesto SelectedMernoMesto
        {
            get
            {
                return (bsMernaMesta.Current as MernoMesto)!;
            }
        }
        public frmParent()
        {
            InitializeComponent();

            _DataContext = new PoslovniSistemDataContext();

            bsMernaMesta.DataSource = _DataContext.SvaMernaMestaSaPocetnimPraznim;
        }
        private void frmParent_Shown(object sender, EventArgs e)
        {
            var signInForm = new frmSignIn();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                signInForm.Close();
            }
            else
            {
                this.Close();
            }
        }
        private void mnuMatičniPodaci_Click(object sender, EventArgs e)
        {
            var _frmMaticniPodaci = new frmMaticniPodaci();
            _frmMaticniPodaci.MdiParent = this;
            _frmMaticniPodaci.Show();
        }
        private void zatvoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var _frmMernaMesta = new frmMernaMesta();
            _frmMernaMesta.MdiParent = this;
            _frmMernaMesta.Show();
        }
        private void istorijaPreuzimanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessages.ShowExclamation("... under construction ...");
        }

        private void poMeseciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessages.ShowExclamation("... under construction ...");
        }

        private void periodičniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmStanje = new frmStanje();
            frmStanje.MdiParent = this;
            frmStanje.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Izvestaji za potrosnju
        private void trenutniMesecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dnevnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _frmPotrosnjaMesecno = new frmPotrosnjaMesecno();
            _frmPotrosnjaMesecno.MdiParent = this;
            _frmPotrosnjaMesecno.Show();
        }
        private void godišnjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _frmPotrosnjaGodisnja = new frmPotrosnjaGodisnja();
            _frmPotrosnjaGodisnja.MdiParent = this;
            _frmPotrosnjaGodisnja.Show();
        }

        private void periodičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            tbPullInfo.ForeColor = Color.Green;
            tbPullInfo.Text = "Provera ...";
            pbPullProgress.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                pbPullProgress.Value++;
            }

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString.Replace("TSP2025", "TSP2025SCADA")))
            {
                var cmd = new SqlCommand($"Select COUNT({tbSourceColumn.Text}) From {tbSourceTable.Text};", conn);
                int newProdID;
                try
                {
                    conn.Open();
                    newProdID = (Int32)cmd.ExecuteScalar();
                    tbPullInfo.Text += $"{Environment.NewLine}Pronađeno je {newProdID} unosa";
                    tbPullInfo.Text += $"{Environment.NewLine}Provera je uspešno izvršena";
                }
                catch (Exception ex)
                {
                    tbPullInfo.ForeColor = Color.Red;
                    tbPullInfo.Text += $"{Environment.NewLine}Došlo je do greške prilikom poveozivanja: {ex.Message}";
                }
            }

        }
        private void bsMernaMesta_CurrentChanged(object sender, EventArgs e)
        {
            if (bsMernaMesta.Current != null && SelectedMernoMesto != null)
            {
                tbSourceTable.Text = SelectedMernoMesto.ScadaTabela;
                tbSourceColumn.Text = SelectedMernoMesto.ScadaKolona;
            }
        }

        private void btnPullMernaMestaRefresh_Click(object sender, EventArgs e)
        {
            _DataContext.OcistiMernaMesta();
            bsMernaMesta.DataSource = _DataContext.SvaMernaMestaSaPocetnimPraznim;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            tbPullInfo.ForeColor = Color.Green;
            tbPullInfo.Text = "Upis ...";
            pbPullProgress.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                pbPullProgress.Value++;
            }

            try
            {
                using (var insertCommand = new SqlCommand())
                {
                    using (insertCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string insertQuery = @$"Truncate Table TSP2025.dbo.Ocitavanje;Insert Into TSP2025.dbo.Ocitavanje (MernoMestoId, Datum, Vrednost) Select {SelectedMernoMesto.Id}, t1.FLTIME, t1.{SelectedMernoMesto.ScadaKolona} From TSP2025SCADA.dbo.{SelectedMernoMesto.ScadaTabela} t1";

                        insertCommand.CommandText = insertQuery;
                        insertCommand.Connection.Open();
                        int affected = (int)insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();

                        tbPullInfo.Text += $"{Environment.NewLine}Upis ({affected} zapisa) je uspešno izvršen";
                    }
                }
            }
            catch (Exception ex)
            {
                tbPullInfo.ForeColor = Color.Red;
                tbPullInfo.Text += $"{Environment.NewLine}Došlo je do greške prilikom upida: {ex.Message}";
            }
        }

        private void oAplikacijiTSP2025ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessages.ShowInformation("TSP2025 Free Trial Version ... under construction ...");
        }
    }
}
