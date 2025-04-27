using TSP2025.Data;

namespace TSP2025.Forms
{
    public partial class frmDataSourceForReports : Form
    {
        public frmDataSourceForReports()
        {
            InitializeComponent();
            cbGodina.SelectedIndex = 0;
            cbKorakMinuti.SelectedIndex = 0;
        }
        public int Godina
        {
            get
            {
                return int.Parse(cbGodina.Text);
            }            
        }
        public int KorakMinutama
        {
            get
            {
                return int.Parse(cbKorakMinuti.Text);
            }
        }

        public DataSourceMode DataSourceMode
        {
            get
            {
                if (rbDB.Checked)
                {
                    return DataSourceMode.FromDatabase;
                }
                else
                {
                    return DataSourceMode.FromRAM;
                }
            }
        }
    }
}
