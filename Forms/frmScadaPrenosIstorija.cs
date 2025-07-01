using TSP2025.Data;
using TSP2025.DB;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmScadaPrenosIstorija : Form
    {
        public frmScadaPrenosIstorija()
        {
            InitializeComponent();

            bsScadaPrenosIstorija.DataSource = TSP2025DataContext.PullHistory;
        }

        private void btnObrisiSvePreneto_Click(object sender, EventArgs e)
        {
            ScadaDBService.ClearAllScadaPull();
            FormMessages.ShowInformation("Svi preneti podaci iz SCADA baze su obrisani");
            bsScadaPrenosIstorija.DataSource = TSP2025DataContext.PullHistory;
        }
    }
}
