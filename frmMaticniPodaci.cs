using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmMaticniPodaci : Form
    {
        private PoslovniSistemDataContext _DataSource;

        private Toplana SelectedToplana
        {
            get
            {
                return _BsToplane.Current as Toplana;
            }
        }
        public frmMaticniPodaci()
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();
            _DataSource.ReloadDataModel();

            _BsToplane.DataSource = _DataSource.SveToplane;

            _DataSource.ModelChanged += _DataSource_ModelChanged; ;
        }

        private void frmMaticniPodaci_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnPodstaniceDodajMernoMesto_Click(object sender, EventArgs e)
        {
            //za podstanicu tip = 0
            var formaZaDodavanje = new frmDodajMernoMesto(tbPodstanicaNaziv.Text, 0, _DataSource);
            formaZaDodavanje.ShowDialog();
        }

        private void btnMernoMestoIndividualniPotrosac_Click(object sender, EventArgs e)
        {
            //za individualnog tip = 0
            var formaZaDodavanje = new frmDodajMernoMesto(tbIndividualniPotrosacNaziv.Text, 1, _DataSource);
            formaZaDodavanje.ShowDialog();
        }

        #region TOPLANE
        private void btnDodajToplanu_Click(object sender, EventArgs e)
        {
            var newToplana = new Toplana() { Id = 0, Naziv = "<uneti>", IsChanged = true };
            _BsToplane.Add(newToplana);
            _BsToplane.MoveLast();
            tbToplanaNaziv.Focus();
            tbToplanaNaziv.SelectAll();

            btnSaveToplane.Visible = true;
            btnUndoToplane.Visible = true;
            btnKotlarnice.Enabled = false;
        }
        private void btnObrisiToplanu_Click(object sender, EventArgs e)
        {
            if (_BsToplane.Current != null)
            {
                _BsToplane.RemoveCurrent();
                btnSaveToplane.Visible = true;
                btnUndoToplane.Visible = true;
                btnKotlarnice.Enabled = false;
            }
        }
        private void btnUndoIzmena_Click(object sender, EventArgs e)
        {
            _DataSource.ReloadDataModel();

            btnSaveToplane.Visible = false;
            btnUndoToplane.Visible = false;
            btnKotlarnice.Enabled = true;
        }
        private void btnSaveEnabled_Click(object sender, EventArgs e)
        {
            // za brisanje
            var toplaneteZaBrisanje = _DataSource.MojeToplane.Where(t => t.IsDeleted && t.Id > 0).ToList();
            foreach (var item in toplaneteZaBrisanje)
            {
                try
                {
                    item.Delete();
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            // za update
            var toplaneteZaUpdate = _DataSource.MojeToplane.Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
            foreach (var item in toplaneteZaUpdate)
            {
                try
                {
                    item.Update();
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            // za create
            var toplaneteZaCreate = _DataSource.SveToplane.Where(t => t.IsChanged && !t.IsDeleted && t.Id == 0).ToList();
            foreach (var item in toplaneteZaCreate)
            {
                try
                {
                    item.Create();
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            btnSaveToplane.Visible = false;
            btnUndoToplane.Visible = false;
            btnKotlarnice.Enabled = true;
        }
        private void btnKotlarnice_Click(object sender, EventArgs e)
        {
            tabMaticniPodaci.SelectedIndex = 1;
        }
        #endregion

        #region KOTLARNICE

        private void btnKotlarniceDodaj_Click(object sender, EventArgs e)
        {
            var novaKotlarnica = new Kotlarnica() { Id = 0, Naziv = "<uneti>", IsChanged = true, Toplana = _BsToplane.Current as Toplana, ToplanaId = (_BsToplane.Current as Toplana).Id };
            _BsKotlarnice.MoveLast();
            tbKotlarnicaNaziv.Focus();
            tbKotlarnicaNaziv.SelectAll();

            btnSaveKotlarnice.Visible = true;
            btnUndoKotlarnice.Visible = true;
            btnToplane.Enabled = false;
            btnPodstanice.Enabled = false;
        }
        private void btnKotlarniceObrisi_Click(object sender, EventArgs e)
        {
            if (_BsKotlarnice.Current != null)
            {
                _BsKotlarnice.RemoveCurrent();

                btnSaveKotlarnice.Visible = true;
                btnUndoKotlarnice.Visible = true;
                btnToplane.Enabled = false;
                btnPodstanice.Enabled = false;
            }
        }
        private void btnUndoKotlarnice_Click(object sender, EventArgs e)
        {
            _DataSource.ReloadDataModel();

            btnSaveKotlarnice.Visible = false;
            btnUndoKotlarnice.Visible = false;
            btnToplane.Enabled = true;
            btnPodstanice.Enabled = true;
        }
        private void btnSaveKotlarnice_Click(object sender, EventArgs e)
        {
            // za brisanje
            var kotlarniceZaBrisanje = _DataSource.SveKotlarnice.Where(t => t.IsDeleted && t.Id > 0).ToList();
            foreach (var item in kotlarniceZaBrisanje)
            {
                try
                {
                    item.Delete();
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            // za update
            var kotlarniceZaUpdate = (_BsKotlarnice.List as IList<Kotlarnica>).Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
            foreach (var item in kotlarniceZaUpdate)
            {
                try
                {
                    item.Update();
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            // za create
            var kotlarniceZaCreate = (_BsKotlarnice.List as IList<Kotlarnica>).Where(k => k.Id == 0 && !k.IsDeleted && k.IsChanged).ToList();
            foreach (var item in kotlarniceZaCreate)
            {
                try
                {
                    item.Create();
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            btnSaveKotlarnice.Visible = false;
            btnUndoKotlarnice.Visible = false;
            btnToplane.Enabled = true;
            btnPodstanice.Enabled = true;
        }
        private void btnToplane_Click(object sender, EventArgs e)
        {
            tabMaticniPodaci.SelectedIndex = 0;
        }
        private void btnPodstanice_Click(object sender, EventArgs e)
        {
            tabMaticniPodaci.SelectedIndex = 2;
        }

        #endregion


        #region PODSTANICE
        private void btnKPodstaniceDodaj_Click(object sender, EventArgs e)
        {

        }
        private void btnKPodstaniceObrisi_Click(object sender, EventArgs e)
        {

        }
        private void btnUndoPodstanice_Click(object sender, EventArgs e)
        {

        }
        private void btnSavePodstanice_Click(object sender, EventArgs e)
        {

        }
        private void btnPodstaniceKotlarnice_Click(object sender, EventArgs e)
        {

        }
        private void btnIndividualni_Click(object sender, EventArgs e)
        {

        }

        #endregion


        private void _DataSource_ModelChanged(string entity)
        {
            if (entity == "Toplana")
            {
                btnSaveToplane.Visible = true;
                btnUndoToplane.Visible = true;
                btnKotlarnice.Enabled = false;
            }
            else if (entity == "Kotlarnica")
            {
                btnSaveKotlarnice.Visible = true;
                btnUndoKotlarnice.Visible = true;
                btnToplane.Enabled = false;
                btnPodstanice.Enabled = false;
            }
            else if (entity == "Podstanice")
            {
                btnSaveKotlarnice.Visible = true;
                btnUndoKotlarnice.Visible = true;
                btnToplane.Enabled = false;
                btnPodstanice.Enabled = false;
            }
        }
    }
}
