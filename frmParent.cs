using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
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
            _progressPreuzmi.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                _progressPreuzmi.Value++;
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
    }
}
