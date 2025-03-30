using System.Diagnostics.Eventing.Reader;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmMaticniPodaci : Form
    {
        private PoslovniSistemDataContext _DataSource;

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
            if (gbToplane.Enabled || gbKotlarnice.Enabled || gbPodstanice.Enabled || gbIndividualniPotrosaci.Enabled)
            {
                FormMessages.ShowExclamation("Saèuvaj ili poništi unete izemene.");
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
            var newToplana = new Toplana() { Id = 0, Naziv = "<obavezno polje>", IsChanged = true };
            _BsToplane.Add(newToplana);
            _BsToplane.MoveLast();

            dgToplane.Enabled = false;
            btnKotlarnice.Enabled = false;
            gbToplane.Enabled = true;
            btnDodajToplanu.Enabled = false;
            btnObrisiToplanu.Enabled = false;
            tbToplanaNaziv.Focus();
            tbToplanaNaziv.SelectAll();
        }
        private void dgToplane_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgToplane.Enabled = false;
            btnKotlarnice.Enabled = false;
            gbToplane.Enabled = true;
            btnDodajToplanu.Enabled = false;
            btnObrisiToplanu.Enabled = false;
            tbToplanaNaziv.Focus();
            tbToplanaNaziv.SelectAll();
        }
        private void btnObrisiToplanu_Click(object sender, EventArgs e)
        {
            if (_BsToplane.Current != null)
            {
                _BsToplane.RemoveCurrent();

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
                        throw;
                    }
                }
            }
        }
        private void btnUndoIzmena_Click(object sender, EventArgs e)
        {
            _BsToplane.RemoveCurrent();
            dgToplane.Enabled = true;
            btnKotlarnice.Enabled = true;
            gbToplane.Enabled = false;
            btnDodajToplanu.Enabled = true;
            btnObrisiToplanu.Enabled = true;
        }
        private void btnSaveEnabled_Click(object sender, EventArgs e)
        {
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
                    throw;
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
                    throw;
                }
            }

            dgToplane.Enabled = true;
            btnKotlarnice.Enabled = true;
            gbToplane.Enabled = false;
            btnDodajToplanu.Enabled = true;
            btnObrisiToplanu.Enabled = true;
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
            var novaKotlarnica = new Kotlarnica() { Id = 0, Naziv = "<obavezno polje>", IsChanged = true, ToplanaId = (_BsToplane.Current as Toplana)!.Id, Toplana = (_BsToplane.Current as Toplana)! };
            _DataSource.SveKotlarnice.Add(novaKotlarnica);
            //(_BsToplane.Current as Toplana)!.Kotlarnice.Add(novaKotlarnica);
            //_BsKotlarnice.Add(novaKotlarnica);
            _BsKotlarnice.MoveLast();
            dgKotlarnice.Enabled = false;
            btnToplane.Enabled = false;
            btnPodstanice.Enabled = false;
            gbKotlarnice.Enabled = true;
            btnKotlarniceDodaj.Enabled = false;
            btnKotlarniceObrisi.Enabled = false;
            tbKotlarnicaNaziv.Focus();
            tbKotlarnicaNaziv.SelectAll();
        }
        private void btnKotlarniceObrisi_Click(object sender, EventArgs e)
        {
            if (_BsKotlarnice.Current != null)
            {
                _BsKotlarnice.RemoveCurrent();
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
            }
        }
        private void dgKotlarnice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgKotlarnice.Enabled = false;
            gbKotlarnice.Enabled = true;
            btnKotlarniceDodaj.Enabled = false;
            btnKotlarniceObrisi.Enabled = false;
            btnToplane.Enabled = false;
            btnPodstanice.Enabled = false;
            tbKotlarnicaNaziv.Focus();
            tbKotlarnicaNaziv.SelectAll();
        }
        private void btnUndoKotlarnice_Click(object sender, EventArgs e)
        {
            _BsKotlarnice.RemoveCurrent();
            dgKotlarnice.Enabled = true;
            btnToplane.Enabled = true;
            btnPodstanice.Enabled = true;
            gbKotlarnice.Enabled = false;
            btnKotlarniceDodaj.Enabled = true;
            btnKotlarniceObrisi.Enabled = true;
        }
        private void btnSaveKotlarnice_Click(object sender, EventArgs e)
        {
            // za update
            var kotlarniceZaUpdate = (_BsKotlarnice.List as IList<Kotlarnica>)!.Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
            foreach (var item in kotlarniceZaUpdate)
            {
                try
                {
                    item.Update();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            // za create
            var kotlarniceZaCreate = (_BsKotlarnice.List as IList<Kotlarnica>)!.Where(k => k.Id == 0 && !k.IsDeleted && k.IsChanged).ToList();
            foreach (var item in kotlarniceZaCreate)
            {
                try
                {
                    item.Create();
                    _DataSource.SveKotlarnice.Add(item);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            dgKotlarnice.Enabled = true;
            btnToplane.Enabled = true;
            btnPodstanice.Enabled = true;
            gbKotlarnice.Enabled = false;
            btnKotlarniceDodaj.Enabled = true;
            btnKotlarniceObrisi.Enabled = true;
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
            var novaPodstanica = new Podstanica() { Id = 0, KotlarnicaId = (_BsKotlarnice.Current as Kotlarnica).Id, Naziv = "<obavezno polje>" };
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
            if (gbToplane.Enabled || gbKotlarnice.Enabled || gbPodstanice.Enabled || gbIndividualniPotrosaci.Enabled)
            {
                FormMessages.ShowExclamation("Saèuvaj ili poništi unete izemene.");
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
    }
}
