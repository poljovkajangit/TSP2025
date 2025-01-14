namespace TSP2025
{
    public partial class frmParent : Form
    {
        frmMaticniPodaci _frmMaticniPodaci;
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
            if (_frmMaticniPodaci == null)
            {
                _frmMaticniPodaci = new frmMaticniPodaci();
                _frmMaticniPodaci.MdiParent = this;
            }

            _frmMaticniPodaci.Show();
            _frmMaticniPodaci.Focus();
            _frmMaticniPodaci.Activate();
            _frmMaticniPodaci.TopMost = true;
        }

        private void zatvoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            (new frmMernaMesta()).Show();
        }

        private void poDanimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmDnevniIzveštaj()).Show();
        }
    }
}
