using System.Diagnostics.Eventing.Reader;
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
            if (btnSaveToplane.Visible || btnSaveKotlarnice.Visible || btnSavePodstanice.Visible || btnSavePotrosaci.Visible)
            {
                FormMessages.ShowExclamation("Saèuvaj ili poništi izmene na formi");
                e.Cancel = true;
            }
        }

        private void btnPodstaniceDodajMernoMesto_Click(object sender, EventArgs e)
        {
            //za podstanicu tip = 1
            var formaZaDodavanje = new frmDodajMernoMesto(tbPodstanicaNaziv.Text, TipMernogMesta.Podstanica, _DataSource, (_BsPodstanice.Current as Podstanica).Id);
            formaZaDodavanje.ShowDialog();
        }

        private void btnMernoMestoIndividualniPotrosac_Click(object sender, EventArgs e)
        {
            //za individualnog tip = 2
            var formaZaDodavanje = new frmDodajMernoMesto(tbIndividualniPotrosacNaziv.Text, TipMernogMesta.IndividualniPotrosac, _DataSource, (_BsIndividualniPotrosaci.Current as IndividualniPotrosac).Id);
            formaZaDodavanje.ShowDialog();
        }

        #region TOPLANE
        private void btnDodajToplanu_Click(object sender, EventArgs e)
        {
            var newToplana = new Toplana() { Id = 0, Naziv = "<bavezno polje>", IsChanged = true };
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
            var toplaneteZaUpdate = (_BsToplane.List as IList<Toplana>).Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
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
            var toplaneteZaCreate = (_BsToplane.List as IList<Toplana>).Where(t => t.IsChanged && !t.IsDeleted && t.Id == 0).ToList();
            foreach (var item in toplaneteZaCreate)
            {
                try
                {
                    item.Create();
                    //_DataSource.SveToplane.Add(item);
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
            if (_BsToplane.Current == null)
            {
                FormMessages.ShowExclamation("Izaberite toplanu");
                return;
            }
            tabMaticniPodaci.SelectedIndex = 1;
        }
        #endregion

        #region KOTLARNICE

        private void btnKotlarniceDodaj_Click(object sender, EventArgs e)
        {
            //var novaKotlarnica = new Kotlarnica() { Id = 0, Naziv = "<bavezno polje>", IsChanged = true, Toplana = _BsToplane.Current as Toplana, ToplanaId = (_BsToplane.Current as Toplana).Id };
            var novaKotlarnica = _BsKotlarnice.AddNew() as Kotlarnica; //Add(novaKotlarnica);
            novaKotlarnica.Id = 0;
            novaKotlarnica.Naziv = "<bavezno polje>";
            novaKotlarnica.IsChanged = true;
            //novaKotlarnica.Toplana = _BsToplane.Current as Toplana;
            novaKotlarnica.ToplanaId = (_BsToplane.Current as Toplana).Id;
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
                    _DataSource.SveKotlarnice.Add(item);
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
            if (_BsKotlarnice.Current == null)
            {
                FormMessages.ShowExclamation("Morate izabrati kotlarnicu");
                return;
            }
            tabMaticniPodaci.SelectedIndex = 2;
        }

        #endregion

        #region PODSTANICE
        private void btnKPodstaniceDodaj_Click(object sender, EventArgs e)
        {
            var novaPodstanica = new Podstanica() { Id = 0, KotlarnicaId = (_BsKotlarnice.Current as Kotlarnica).Id, Naziv = "<bavezno polje>" };
            _BsPodstanice.Add(novaPodstanica);
            _BsPodstanice.MoveLast();
            tbPodstanicaNaziv.Focus();
            tbPodstanicaNaziv.SelectAll();

            btnSavePodstanice.Visible = true;
            btnUndoPodstanice.Visible = true;
            btnPodstaniceKotlarnice.Enabled = false;
            btnPostaniceIndividualni.Enabled = false;
            btnMernoMestoPodstanica.Enabled = false;
        }
        private void btnKPodstaniceObrisi_Click(object sender, EventArgs e)
        {
            if (_BsPodstanice.Current != null)
            {
                _BsPodstanice.RemoveCurrent();

                btnSavePodstanice.Visible = true;
                btnUndoPodstanice.Visible = true;
                btnPodstaniceKotlarnice.Enabled = false;
                btnPostaniceIndividualni.Enabled = false;
                btnMernoMestoPodstanica.Enabled = false;
            }
        }
        private void btnUndoPodstanice_Click(object sender, EventArgs e)
        {
            _DataSource.ReloadDataModel();

            btnSavePodstanice.Visible = false;
            btnUndoPodstanice.Visible = false;
            btnPodstaniceKotlarnice.Enabled = true;
            btnPostaniceIndividualni.Enabled = true;
            btnMernoMestoPodstanica.Enabled = true;
        }
        private void btnSavePodstanice_Click(object sender, EventArgs e)
        {
            // brisanje
            var podstaniceZaBrisanje = _DataSource.SvePodstanice.Where(t => t.IsDeleted && t.Id > 0).ToList();
            foreach (var item in podstaniceZaBrisanje)
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

            // update
            var podstaniceZaUpdate = (_BsPodstanice.List as IList<Podstanica>).Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
            foreach (var item in podstaniceZaUpdate)
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

            //// create
            var podstaniceZaCreate = (_BsPodstanice.List as IList<Podstanica>).Where(k => k.Id == 0 && !k.IsDeleted && k.IsChanged).ToList();
            foreach (var item in podstaniceZaCreate)
            {
                try
                {
                    item.Create();
                    _DataSource.SvePodstanice.Add(item);
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            btnSavePodstanice.Visible = false;
            btnUndoPodstanice.Visible = false;
            btnPodstaniceKotlarnice.Enabled = true;
            btnPostaniceIndividualni.Enabled = true;
            btnMernoMestoPodstanica.Enabled = true;
        }
        private void btnPodstaniceKotlarnice_Click(object sender, EventArgs e)
        {
            tabMaticniPodaci.SelectedIndex = 1;
        }
        private void btnPostaniceIndividualni_Click(object sender, EventArgs e)
        {
            if (_BsPodstanice.Current == null)
            {
                FormMessages.ShowExclamation("Morate izabrati podstanicu.");
                return;
            }
            tabMaticniPodaci.SelectedIndex = 3;
        }
        #endregion

        #region Individualni
        private void btnDodajIndividualni_Click(object sender, EventArgs e)
        {
            var noviIPotrosac = new IndividualniPotrosac() { Id = 0, Naziv = "<obavezno polje>", PodstanicaId = (_BsPodstanice.Current as Podstanica).Id };
            _BsIndividualniPotrosaci.Add(noviIPotrosac);
            _BsIndividualniPotrosaci.MoveLast();
            tbIndividualniPotrosacNaziv.Focus();
            tbIndividualniPotrosacNaziv.SelectAll();

            btnSavePotrosaci.Visible = true;
            btnUndoPotrosaci.Visible = true;
            btnIndividualniPodstanice.Enabled = false;
            btnMernoMestoIndividualniPotrosac.Enabled = false;
        }

        private void btnObrisiIndividualni_Click(object sender, EventArgs e)
        {
            if (_BsIndividualniPotrosaci.Current != null)
            {
                _BsIndividualniPotrosaci.RemoveCurrent();

                btnSavePotrosaci.Visible = true;
                btnUndoPotrosaci.Visible = true;
                btnIndividualniPodstanice.Enabled = false;
                btnMernoMestoIndividualniPotrosac.Enabled = false;
            }
        }

        private void btnUndoPotrosaci_Click(object sender, EventArgs e)
        {
            _DataSource.ReloadDataModel();

            btnSavePotrosaci.Visible = false;
            btnUndoPotrosaci.Visible = false;
            btnIndividualniPodstanice.Enabled = true;
            btnMernoMestoIndividualniPotrosac.Enabled = true;
        }

        private void btnSavePotrosaci_Click(object sender, EventArgs e)
        {
            // brisanje
            var potrosaciZaBrisanje = _DataSource.SviIndividualniPotrosaci.Where(t => t.IsDeleted && t.Id > 0).ToList();
            foreach (var item in potrosaciZaBrisanje)
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

            // update
            var potrosaciZaUpdate = (_BsIndividualniPotrosaci.List as IList<IndividualniPotrosac>).Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
            foreach (var item in potrosaciZaUpdate)
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

            //// create
            var potrosaciZaCreate = (_BsIndividualniPotrosaci.List as IList<IndividualniPotrosac>).Where(k => k.Id == 0 && !k.IsDeleted && k.IsChanged).ToList();
            foreach (var item in potrosaciZaCreate)
            {
                try
                {
                    item.Create();
                    _DataSource.SviIndividualniPotrosaci.Add(item);
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            btnSavePotrosaci.Visible = false;
            btnUndoPotrosaci.Visible = false;
            btnIndividualniPodstanice.Enabled = true;
            btnMernoMestoIndividualniPotrosac.Enabled = true;
        }

        private void btnIndividualniPodstanice_Click(object sender, EventArgs e)
        {
            tabMaticniPodaci.SelectedIndex = 2;
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
            else if (entity == "Podstanica")
            {
                btnSavePodstanice.Visible = true;
                btnUndoPodstanice.Visible = true;
                btnPodstaniceKotlarnice.Enabled = false;
                btnPostaniceIndividualni.Enabled = false;
            }
            else if (entity == "IndividualniPotrosac")
            {
                btnSavePotrosaci.Visible = true;
                btnUndoPotrosaci.Visible = true;
                btnIndividualniPodstanice.Enabled = false;
                btnMernoMestoIndividualniPotrosac.Enabled = false;
            }
        }

        private void tabMaticniPodaci_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (btnSaveToplane.Visible || btnSaveKotlarnice.Visible || btnSavePodstanice.Visible || btnSavePotrosaci.Visible)
            {
                FormMessages.ShowExclamation("Saèuvaj ili poništi izmene na formi");
                e.Cancel = true;
            }

            if (e.TabPageIndex > 0 && _BsToplane.Current == null)
            {
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 1 && _BsKotlarnice.Current == null)
            {
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 2 && _BsPodstanice.Current == null)
            {
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 3 && _BsPodstanice.Current == null)
            {
                e.Cancel = true;
            }
        }
        private void _BsToplane_PositionChanged(object sender, EventArgs e)
        {
            if (_BsToplane.Position > -1)
            {
                gbUnosToplane.Enabled = true;
            }
            else
            {
                gbUnosToplane.Enabled = false;
            }
        }
        private void _BsKotlarnice_PositionChanged(object sender, EventArgs e)
        {
            if (_BsKotlarnice.Position > -1)
            {
                gbKotlarnice.Enabled = true;
            }
            else
            {
                gbKotlarnice.Enabled = false;
            }
        }
        private void _BsPodstanice_PositionChanged(object sender, EventArgs e)
        {
            if (_BsPodstanice.Position > -1)
            {
                gbUnosPodstanica.Enabled = true;
            }
            else
            {
                gbUnosPodstanica.Enabled = false;
            }
        }

        private void _BsIndividualniPotrosaci_PositionChanged(object sender, EventArgs e)
        {
            if (_BsIndividualniPotrosaci.Position > -1)
            {
                gUnosbIndividualniPotrosac.Enabled = true;
            }
            else
            {
                gUnosbIndividualniPotrosac.Enabled = false;
            }
        }
    }
}
