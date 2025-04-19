namespace TSP2025
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = DateTime.Now.ToString("HH:mm:ss");
            lblBrojOcitavanja.Text = (int.Parse(lblBrojOcitavanja.Text) + 1).ToString();
        }

        private void frmDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Prevent the form from closing
            this.Hide(); // Hide the form instead
        }
    }
}
