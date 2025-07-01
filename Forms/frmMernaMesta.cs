using TSP2005;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmMernaMesta : Form
    {
        private TSP2025DataContext _DataSource;
        public frmMernaMesta()
        {
            InitializeComponent();

            _DataSource = new TSP2025DataContext();
            _SvaMernaMestaInBindingList = ImprovedBindingListFactory<MernoMesto>.Create(MernoMestoDBService.GetAll().ToList<MernoMesto>());
            bsMernaMesta.DataSource = _SvaMernaMestaInBindingList;
            bsGrupeMernihMesta.DataSource = _DataSource.SveGrupeMernihMestaSaPocetnimSve;
        }


        private ImprovedBindingList<MernoMesto> _SvaMernaMestaInBindingList;
        private void cbGrupeMernihMesta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbPretraga.Text = "";
            if (bsGrupeMernihMesta.DataSource != null)
            {
                if ((cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta)!.Id > 0)
                {
                    bsMernaMesta.DataSource = ImprovedBindingListFactory<MernoMesto>.Create([.. _SvaMernaMestaInBindingList.Where(mm => mm.GrupaMernogMestaId == (cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta)!.Id)]);
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

            if (!string.IsNullOrWhiteSpace(tbPretraga.Text.Trim()))
            {
                bsMernaMesta.DataSource = ImprovedBindingListFactory<MernoMesto>.Create([.. MernoMestoDBService.GetAllByOznakaMernogMesta(tbPretraga.Text.Trim())]);
            }
            else
            {
                bsMernaMesta.DataSource = _SvaMernaMestaInBindingList;
            }
        }
        private void btnMesecniIzvestaj_Click(object sender, EventArgs e)
        {
            FormMessages.ShowExclamation("... under construction ...");
        }

        private void dgMernaMesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var mernomesto = bsMernaMesta.Current as MernoMesto;
                var _frmPeriodicniIzveštaj = new frmStanje(mernomesto!);
                _frmPeriodicniIzveštaj.ShowDialog();
            }
        }

        private void dgMernaMesta_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    dgMernaMesta.ClearSelection();
                    dgMernaMesta.Rows[rowSelected].Selected = true;
                    bsMernaMesta.Position = rowSelected;
                }
            }
        }

        private void izmeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mernomesto = bsMernaMesta.Current as MernoMesto;
            if (mernomesto != null)
            {
                var mernoMestoEditFrm = new frmAddUpdateMernoMesto(mernomesto, _DataSource);
                if (mernoMestoEditFrm.ShowDialog() == DialogResult.OK)
                {
                    dgMernaMesta.Refresh();
                }
            }
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bsMernaMesta.Current == null)
            {
                FormMessages.ShowError("Merno mesto nije selektovano.");
                return;
            }

            try
            {
                if (FormMessages.AreYouSure() == DialogResult.Yes)
                {
                    _DataSource.DeleteMernoMesto(bsMernaMesta.Current as MernoMesto);
                    bsMernaMesta.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {

                FormMessages.ShowError("Greška prilikom brisanja mernog mesta." + Common.TSP2025Helper.EnvironmentNewLines(2) + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbGrupeMernihMesta.SelectedIndex = 0;
            tbPretraga.Text = "";
            bsMernaMesta.DataSource = _SvaMernaMestaInBindingList;
        }
    }
}
