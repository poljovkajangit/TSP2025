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
            bsGrupeMernihMesta.DataSource = _DataSource.SveGrupaMernihMestaSaPocetnimPraznim;
            //if (_DataSource != null)
            //{
            //    if (bsGrupeMernihMesta.Current != null && (bsGrupeMernihMesta.Current as GrupaMernihMesta).Id > 0)
            //    {
            //        bsMernaMesta.DataSource = _DataSource.SvaMernaMesta.Where(mm => mm.GrupaMernogMestaId == (bsGrupeMernihMesta.Current as GrupaMernihMesta).Id).ToList();
            //    }
            //    else
            //    {
            bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
            //    }
            //}
        }

        private void frmMernaMesta_Load(object sender, EventArgs e)
        {

        }
    }
}
