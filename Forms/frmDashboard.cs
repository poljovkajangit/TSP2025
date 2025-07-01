namespace TSP2025
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        private void timer_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = "Sada je: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblBrojOcitavanja.Text = (int.Parse(lblBrojOcitavanja.Text) + 1).ToString();

            lblBrojOcitavanja.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void frmDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Prevent the form from closing
            this.Hide(); // Hide the form instead
        }
    }
}
