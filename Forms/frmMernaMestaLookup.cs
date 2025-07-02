using TSP2005;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;
using TSP2025.DBServices;

namespace TSP2025
{
    public partial class frmMernaMestaLookup : Form
    {
        private static readonly Lazy<frmMernaMestaLookup> lazy = new(() => new frmMernaMestaLookup());
        public static frmMernaMestaLookup Instance()
        {
            return lazy.Value;
        }

        private ImprovedBindingList<MernoMesto> _SvaMernaMestaInBindingList;
        private frmMernaMestaLookup()
        {
            InitializeComponent();
            _SvaMernaMestaInBindingList = ImprovedBindingListFactory<MernoMesto>.Create(MernoMestoDBService.GetAll().ToList<MernoMesto>());
            bsMernaMesta.DataSource = _SvaMernaMestaInBindingList;
            bsGrupeMernihMesta.DataSource = GrupaMernihMestaDBService.GetAll().ToList();
        }

        private void cbGrupeMernihMesta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbOznakaPretraga.Text = "";
            if (bsGrupeMernihMesta.DataSource != null)
            {
                if ((cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta)!.Id > 0)
                {
                    bsMernaMesta.DataSource = ImprovedBindingListFactory<MernoMesto>.Create(_SvaMernaMestaInBindingList.Where(mm => mm.GrupaMernogMestaId == (cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta)!.Id).ToList());
                }
                else
                {
                    bsMernaMesta.DataSource = _SvaMernaMestaInBindingList;
                }
            }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            cbGrupeMernihMesta.SelectedIndex = 0;

            if (!string.IsNullOrWhiteSpace(tbOznakaPretraga.Text.Trim()))
            {
                bsMernaMesta.DataSource = ImprovedBindingListFactory<MernoMesto>.Create(MernoMestoDBService.GetAllByOznakaMernogMesta(tbOznakaPretraga.Text.Trim()).ToList());
            }
            else
            {
                bsMernaMesta.DataSource = _SvaMernaMestaInBindingList;
            }
        }

        private void dgMernaMesta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public MernoMesto SelectedMernoMesto
        {
            get
            {
                if (bsMernaMesta.Current is MernoMesto mernoMesto)
                {
                    return mernoMesto;
                }
                return null;
            }
        }
    }
}
