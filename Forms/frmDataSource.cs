using TSP2025.Data;

namespace TSP2025.Forms
{
    public partial class frmDataSourceForReports : Form
    {
        public frmDataSourceForReports()
        {
            InitializeComponent();
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

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
