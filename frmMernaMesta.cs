using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmMernaMesta : Form
    {
        private PoslovniSistemDataContext _DataSource;
        public frmMernaMesta()
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();
            bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
            bsGrupeMernihMesta.DataSource = _DataSource.SveGrupaMernihMestaSaPocetnimPraznim;
        }

        private void cbGrupeMernihMesta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbPretraga.Text = "";
            if (bsGrupeMernihMesta.DataSource != null)
            {
                if ((cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta).Id > 0)
                {
                    bsMernaMesta.DataSource = _DataSource.SvaMernaMesta.Where(mm => mm.GrupaMernogMestaId == (cbGrupeMernihMesta.SelectedItem as GrupaMernihMesta).Id).ToList();
                }
                else
                {
                    bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            cbGrupeMernihMesta.SelectedIndex = 0;

            if (!string.IsNullOrWhiteSpace(tbPretraga.Text))
            {
                bsMernaMesta.DataSource = _DataSource.SvaMernaMesta.Where(mm => mm.OznakaMernogMesta.Contains(tbPretraga.Text)).ToList();
            }
            else
            {
                bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
            }
        }
        private void btnMesecniIzvestaj_Click(object sender, EventArgs e)
        {
            FormMessages.ShowExclamation("... under construction ...");
        }

        private void btnGodisnjiIzvestaj_Click(object sender, EventArgs e)
        {

        }

        private void dgMernaMesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var mernomesto = bsMernaMesta.Current as MernoMesto;
                var _frmPeriodicniIzveštaj = new frmStanje(mernomesto);
                _frmPeriodicniIzveštaj.ShowDialog();
            }
        }
    }
}
