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
            //_frmMaticniPodaci.MdiParent = this;
            _frmMaticniPodaci.ShowDialog();
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
            new frmScadaPrenos().ShowDialog();
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
                        string insertQuery = @$"
                                Truncate Table TSP2025.dbo.Ocitavanje;
                                Insert Into TSP2025.dbo.Ocitavanje (MernoMestoId, Datum, Vrednost) 
                                Select {SelectedMernoMesto.Id}, t1.FLTIME, t1.{SelectedMernoMesto.ScadaKolona} From TSP2025SCADA.dbo.{SelectedMernoMesto.ScadaTabela} t1";

                        insertCommand.CommandText = insertQuery;
                        insertCommand.Connection.Open();
                        int affected = (int)insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();

                        tbPullInfo.Text += $"{Environment.NewLine}Scada prenos ({affected} zapisa) je uspešno izvršen";

                        insertQuery = @$"
                                Insert Into PullHistory (MernoMestoId, PrenetoZapisa, Status, Poruka) 
                                Values ({SelectedMernoMesto.Id}, {affected}, 1, '{tbPullInfo.Text}')";

                        insertCommand.CommandText = insertQuery;
                        insertCommand.Connection.Open();
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                tbPullInfo.ForeColor = Color.Red;
                tbPullInfo.Text += $"{Environment.NewLine}Došlo je do greške prilikom prenosa: {ex.Message}";

                var errorInsert = @$"
                                Insert Into PullHistory (MernoMestoId, PrenetoZapisa, Status, Poruka) 
                                Values ({SelectedMernoMesto.Id}, 0, 0, '{tbPullInfo.Text.Replace("'", "")}')";

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
        }

        private void oAplikacijiTSP2025ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessages.ShowInformation("TSP2025 Free Trial Version ... under construction ...");
        }

        private void btnPullOperacijaToggleView_Click(object sender, EventArgs e)
        {
            if (btnPullOperacijaToggleView.Text == "Prikaži")
            {
                gbPullOperacija.Height = 540;
                btnPullOperacijaToggleView.Text = "Sakrij";
            }
            else
            {
                gbPullOperacija.Height = 75;
                btnPullOperacijaToggleView.Text = "Prikaži";
            }
        }

        private void mnuMesecnaPotrosnja_Click(object sender, EventArgs e)
        {
            var frmMesecnaPotrosnja = new frmMesecnaPotrosnja();
            frmMesecnaPotrosnja.ShowDialog();
        }

        private void preuzmiPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbPullOperacija.Height = 540;
            btnPullOperacijaToggleView.Text = "Sakrij";
        }

        private void godišnjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGodisnja = new frmGodisnjaPotrosnja();
            frmGodisnja.ShowDialog();
        }

        private frmDashBoard _frmDashBoard = null;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_frmDashBoard == null)
            {
                _frmDashBoard = new frmDashBoard();
                _frmDashBoard.MdiParent = this;
                _frmDashBoard.Left = 10;
                _frmDashBoard.Top = 10;
                btnDashboard.Visible = false;
                _frmDashBoard.FormClosing += (s, args) => { btnDashboard.Visible = true; };
                _frmDashBoard.Show();
            }
            else
            {
                btnDashboard.Visible = false;
                _frmDashBoard.Show();
                _frmDashBoard.BringToFront();
            }
        }

        private void dnevnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDnevna = new frmDnevnaPotrosnja();
            frmDnevna.ShowDialog();
        }
    }
}
