using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Managers;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmMaticniPodaci : Form
    {
        private PoslovniSistemDataContext _DataSource;

        private IManager _ToplanaManager;
        private IManager _KotlarnicaManager;
        private IManager _PodstanicaManager;
        private IManager _IndividualniManager;
        public frmMaticniPodaci()
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();
            _DataSource.ReloadDataModel();

            _BsToplane.DataSource = _DataSource.SveToplane;

            _ToplanaManager = new Manager<Toplana>(btnDodajToplanu, btnObrisiToplanu, btnSaveToplane, btnUndoToplane, btnKotlarnice, null, dgToplane, gbToplane, tbToplanaNaziv, null, _BsToplane, _DataSource, tabMaticniPodaci, null);
            _KotlarnicaManager = new Manager<Kotlarnica>(btnKotlarniceDodaj, btnKotlarniceObrisi, btnSaveKotlarnice, btnUndoKotlarnice, btnToplane, btnPodstanice, dgKotlarnice, gbKotlarnice, tbKotlarnicaNaziv, cbToplane, _BsKotlarnice, _DataSource, tabMaticniPodaci, null);
            _PodstanicaManager = new Manager<Podstanica>(btnPodstaniceDodaj, btnPodstaniceObrisi, btnSavePodstanice, btnUndoPodstanice, btnPostaniceIndividualni, btnPodstaniceKotlarnice, dgPodstanice, gbPodstanice, tbPodstanicaNaziv, cbKotlarnice, _BsPodstanice, _DataSource, tabMaticniPodaci, btnPodstanicaMernoMesto);
            _IndividualniManager = new Manager<IndividualniPotrosac>(btnDodajIndividualni, btnObrisiIndividualni, btnSavePotrosaci, btnUndoPotrosaci, null, btnIndividualniPodstanice, dgIndividualniPotrosaci, gbIndividualniPotrosaci, tbIndividualniPotrosacSifraKorisnika, cbPodstanice, _BsIndividualniPotrosaci, _DataSource, tabMaticniPodaci, btnIndividualniPotrosacMernoMesto);
        }

        #region Toplane
        private void btnDodajToplanu_Click(object sender, EventArgs e)
        {
            _ToplanaManager.Add(new Toplana() { Id = 0, Naziv = "<obavezno polje>", ImaMernoMesto = false });
        }
        private void dgToplane_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _ToplanaManager.Edit();
        }
        private void btnObrisiToplanu_Click(object sender, EventArgs e)
        {
            _ToplanaManager.Remove();
        }
        private void btnUndoIzmena_Click(object sender, EventArgs e)
        {
            _ToplanaManager.Cancel();
        }
        private void btnSaveEnabled_Click(object sender, EventArgs e)
        {
            _ToplanaManager.Save();
        }
        private void btnKotlarnice_Click(object sender, EventArgs e)
        {
            if (_BsToplane.Current == null)
            {
                FormMessages.ShowExclamation("Morate izabrati toplanu");
                return;
            }
            _ToplanaManager.Next();
        }
        #endregion

        #region Kotlarnice

        private void btnKotlarniceDodaj_Click(object sender, EventArgs e)
        {
            _KotlarnicaManager.Add(new Kotlarnica() { Id = 0, ToplanaId = (_BsToplane.Current as Toplana)!.Id, Naziv = "<obavezno polje>", ImaMernoMesto = false });
        }
        private void btnKotlarniceObrisi_Click(object sender, EventArgs e)
        {
            _KotlarnicaManager.Remove();
        }
        private void dgKotlarnice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _KotlarnicaManager.Edit();
        }
        private void btnUndoKotlarnice_Click(object sender, EventArgs e)
        {
            _KotlarnicaManager.Cancel();
        }
        private void btnSaveKotlarnice_Click(object sender, EventArgs e)
        {
            _KotlarnicaManager.Save();
        }
        private void btnToplane_Click(object sender, EventArgs e)
        {
            _KotlarnicaManager.Previous();
        }
        private void btnPodstanice_Click(object sender, EventArgs e)
        {
            if (_BsKotlarnice.Current == null)
            {
                FormMessages.ShowExclamation("Morate izabrati kotlarnicu");
                return;
            }
            _KotlarnicaManager.Next();
        }

        #endregion

        #region Podstanice
        private void btnPodstaniceDodaj_Click(object sender, EventArgs e)
        {
            _PodstanicaManager.Add(new Podstanica() { Id = 0, KotlarnicaId = (_BsKotlarnice.Current as Kotlarnica)!.Id, Naziv = "<obavezno polje>", ImaMernoMesto = false });
        }
        private void btnKPodstaniceObrisi_Click(object sender, EventArgs e)
        {
            _PodstanicaManager.Remove();
        }
        private void btnUndoPodstanice_Click(object sender, EventArgs e)
        {
            _PodstanicaManager.Cancel();
        }
        private void btnSavePodstanice_Click(object sender, EventArgs e)
        {
            _PodstanicaManager.Save();
        }
        private void btnPodstaniceKotlarnice_Click(object sender, EventArgs e)
        {
            _PodstanicaManager.Previous();
        }
        private void btnPostaniceIndividualni_Click(object sender, EventArgs e)
        {
            if (_BsPodstanice.Current == null)
            {
                FormMessages.ShowExclamation("Morate izabrati podstanicu.");
                return;
            }
            _PodstanicaManager.Next();
        }
        private void dgPodstanice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _PodstanicaManager.Edit();
        }
        #endregion

        #region Individualni
        private void btnDodajIndividualni_Click(object sender, EventArgs e)
        {
            _IndividualniManager.Add(new IndividualniPotrosac() { Naziv = "<obavezno polje>", PodstanicaId = (_BsPodstanice.Current as Podstanica)!.Id, Id = 0, SifraKorisnika = "<obavezno polje>", ImaMernoMesto = false });
        }
        private void btnObrisiIndividualni_Click(object sender, EventArgs e)
        {
            _IndividualniManager.Remove();
        }
        private void btnUndoPotrosaci_Click(object sender, EventArgs e)
        {
            _IndividualniManager.Cancel();
        }
        private void btnSavePotrosaci_Click(object sender, EventArgs e)
        {
            _IndividualniManager.Save();
        }
        private void btnIndividualniPodstanice_Click(object sender, EventArgs e)
        {
            _IndividualniManager.Previous();
        }
        private void dgIndividualniPotrosaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _IndividualniManager.Edit();
        }
        #endregion

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
            var formaZaDodavanje = new frmDodajMernoMesto(tbPodstanicaNaziv.Text, TipMernogMesta.Podstanica, _DataSource, _BsPodstanice.Current as Podstanica, btnPodstanicaMernoMesto);
            formaZaDodavanje.ShowDialog();
        }
        private void btnIndividualniPotrosacMernoMesto_Click(object sender, EventArgs e)
        {
            //za individualnog tip = 2
            var formaZaDodavanje = new frmDodajMernoMesto(tbIndividualniPotrosacNaziv.Text, TipMernogMesta.IndividualniPotrosac, _DataSource, _BsIndividualniPotrosaci.Current as IndividualniPotrosac, btnIndividualniPotrosacMernoMesto);
            formaZaDodavanje.ShowDialog();
        }
        private void tabMaticniPodaci_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (gbToplane.Enabled || gbKotlarnice.Enabled || gbPodstanice.Enabled || gbIndividualniPotrosaci.Enabled)
            {
                FormMessages.ShowExclamation("Saèuvaj ili poništi unete izemene.");
                e.Cancel = true;
                return;
            }

            if (e.TabPageIndex > 0 && _BsToplane.Current == null)
            {
                FormMessages.ShowExclamation("Izaberite toplanu.");
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 1 && _BsKotlarnice.Current == null)
            {
                FormMessages.ShowExclamation("Izaberite kotlarnicu.");
                e.Cancel = true;
            }
            else if (e.TabPageIndex > 2 && _BsPodstanice.Current == null)
            {
                FormMessages.ShowExclamation("Izaberite podstanicu.");
                e.Cancel = true;
            }
        }


    }
}
