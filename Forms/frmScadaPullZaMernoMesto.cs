using Microsoft.Data.SqlClient;
using System.Configuration;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025.Forms
{
    public partial class frmScadaPullZaMernoMesto : Form
    {
        TSP2025DataContext _DataContext;

        public frmScadaPullZaMernoMesto()
        {
            InitializeComponent();

            _DataContext = new TSP2025DataContext();
            bsMernaMesta.DataSource = _DataContext.SvaMernaMestaSaPocetnimPraznim;
        }

        private void btnPullMernaMestaRefresh_Click(object sender, EventArgs e)
        {
            _DataContext.ClearSvaMernaMesta();
            bsMernaMesta.DataSource = _DataContext.SvaMernaMestaSaPocetnimPraznim;
        }

        private void bsMernaMesta_CurrentChanged(object sender, EventArgs e)
        {
            if (bsMernaMesta.Current != null && SelectedMernoMesto != null)
            {
                tbSourceTable.Text = SelectedMernoMesto.ScadaTabela;
                tbSourceColumn.Text = SelectedMernoMesto.ScadaKolona;
            }

        }
        private MernoMesto SelectedMernoMesto
        {
            get
            {
                return (bsMernaMesta.Current as MernoMesto)!;
            }
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString.Replace("TSP2025", "TSP2025SCADA")))
            {
                var cmd = new SqlCommand($"Select COUNT({tbSourceColumn.Text}) From {tbSourceTable.Text};", conn);
                int newProdID;
                try
                {
                    conn.Open();
                    newProdID = (Int32)cmd.ExecuteScalar();
                    FormMessages.ShowInformation("Ok");
                }
                catch (Exception ex)
                {
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}