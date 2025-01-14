using System.Data;
using TSP2025.Data;
using TSP2025.Data.Model;

namespace TSP2025
{
    public partial class frmMernaMesta : Form
    {
        private PoslovniSistemDataContext _DataSource;
        public frmMernaMesta()
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();

            bsGrupeMernihMesta.DataSource = _DataSource.SvaGrupaMernihMesta;
            bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
        }

        private void frmMernaMesta_Load(object sender, EventArgs e)
        {

        }

        private void cbGrupeMernihMesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrupeMernihMesta.SelectedIndex == 0)
            {
                bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
            }
            else
            {
                if (cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta != null)
                {
                    bsMernaMesta.DataSource = _DataSource.SvaMernaMesta.Where(mm => mm.GrupaMernogMestaId == (cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta).Id).ToList();
                }
            }
        }
    }
}
