using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmParent : Form
    {
        PoslovniSistemDataContext _DataContext;
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
        private void preuzmiPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgrPull.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                pgrPull.Value++;
            }
            FormMessages.ShowExclamation("... under construction ...");
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
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString.Replace("TSP2025", "TSP2025SCADA")))
            {
                var cmd = new SqlCommand("Select COUNT(TP1_1_KUM_PROTOK) From TREND_TSTP1_TP1_1; ", conn);
                int newProdID;
                try
                {
                    conn.Open();
                    newProdID = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do greške prilikom poveozivanja na bazu: {ex.Message} ", "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show($"Komanda je uspešno izvršena", "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void bsMernaMesta_CurrentChanged(object sender, EventArgs e)
        {
            if (bsMernaMesta.Current != null && (bsMernaMesta.Current as MernoMesto) != null)
            {
                tbSourceTable.Text = (bsMernaMesta.Current as MernoMesto).ScadaTabela;
                tbSourceColumn.Text = (bsMernaMesta.Current as MernoMesto).ScadaKolona;
            }
        }
    }
}
