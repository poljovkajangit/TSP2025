using TSP2025.Data;

namespace TSP2025
{
    public partial class frmScadaPrenos : Form
    {
        public frmScadaPrenos()
        {
            InitializeComponent();

            bsScadaPrenosIstorija.DataSource = TSP2025DataContext.PullHistory;
        }
    }
}
