using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2005;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025.Data
{
    public enum DataSourceMode
    {
        FromDatabase,
        FromRAM,
        None
    }
    public class TSP2025DataContext
    {
        private List<GrupaMernihMesta> _Sve_GrupaMernihMesta = null;
        private List<GrupaMernihMesta> _Sve_GrupaMernihMestaSaPocetnimSve = null;
        private ImprovedBindingList<MernoMesto> _SvaMernaMesta = null;

        public event ModelChangedEventHandler ModelChanged;

        public ImprovedBindingList<Toplana> MojeToplane { get; set; }
        public ImprovedBindingList<Toplana> SveToplane { get; set; } = new ImprovedBindingList<Toplana>();
        public ImprovedBindingList<Kotlarnica> SveKotlarnice { get; set; } = new ImprovedBindingList<Kotlarnica>();
        public ImprovedBindingList<Podstanica> SvePodstanice { get; set; } = new ImprovedBindingList<Podstanica>();
        public ImprovedBindingList<IndividualniPotrosac> SviIndividualniPotrosaci { get; set; } = new ImprovedBindingList<IndividualniPotrosac>();
        public static List<PullHistory> PullHistory
        {
            get
            {
                var pullHistory = new List<PullHistory>();
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var command = new SqlCommand("Select ph.Id, ph.Vreme, ph.MernoMestoId, ph.PrenetoZapisa, ph.Status, ph.Poruka, mm.OznakaMernogMesta from PullHistory ph join MernoMesto mm on ph.MernoMestoId = mm.Id Order By ph.Vreme desc", connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            pullHistory.Add(new PullHistory()
                            {
                                Id = reader.GetInt32(0),
                                Vreme = reader.GetDateTime(1),
                                MernoMestoId = reader.GetInt32(2),
                                PrenetoZapisa = reader.GetInt32(3),
                                Status = reader.GetInt32(4),
                                Poruka = reader.GetString(5),
                                MernoMesto = reader.GetString(6),
                            });
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        FormMessages.ShowError("Greška. " + ex.Message);
                    }
                }
                return pullHistory;
            }
        }
        public static bool IsLoading { get; set; } = false;
        public ImprovedBindingList<MernoMesto> SvaMernaMesta
        {
            get
            {
                if (_SvaMernaMesta == null)
                {
                    UcitajMernaMesta();
                }
                return _SvaMernaMesta;
            }
        }
        public ImprovedBindingList<MernoMesto> SvaMernaMestaSaPocetnimPraznim
        {
            get
            {
                if (_SvaMernaMesta == null)
                {
                    UcitajMernaMesta();
                    _SvaMernaMesta.Insert(0, new MernoMesto() { Id = 0, OznakaMernogMesta = "", ImaMernoMesto = false });
                }
                return _SvaMernaMesta;
            }
        }
        public void OcistiMernaMesta()
        {
            _SvaMernaMesta = null;
        }
        public List<GrupaMernihMesta> SveGrupeMernihMestaSaPocetnimSve
        {
            get
            {
                if (_Sve_GrupaMernihMestaSaPocetnimSve == null)
                {
                    _Sve_GrupaMernihMestaSaPocetnimSve = UcitajGrupeMernihMesta();
                    _Sve_GrupaMernihMestaSaPocetnimSve.Insert(0, new GrupaMernihMesta() { Id = 0, Naziv = "<Sve>", ImaMernoMesto = false });
                }
                return _Sve_GrupaMernihMestaSaPocetnimSve;
            }
        }
        public List<GrupaMernihMesta> SveGrupeMernihMesta
        {
            get
            {
                if (_Sve_GrupaMernihMesta == null)
                {
                    _Sve_GrupaMernihMesta = UcitajGrupeMernihMesta();
                }
                return _Sve_GrupaMernihMesta;
            }
        }
        /// <summary>
        /// Dummy property to simulate data binding
        /// </summary>
        public ImprovedBindingList<Ocitavanje> Ocitavanja
        {
            get
            {
                return new ImprovedBindingList<Ocitavanje>();
            }
        }
        public IList<Ocitavanje> SvaOcitavanja(DataSourceMode sourceMode)
        {

            var svaOcitavanja = new List<Ocitavanje>();

            if (sourceMode == DataSourceMode.FromRAM)
            {
                var dateTime = DateTime.Now.Date.AddYears(-5);
                decimal vrednost = 0M;
                for (int dan = 0; dan < 1780; dan++)
                {
                    for (int sat = 0; sat < 24; sat++)
                    {
                        for (int minut = 0; minut < 5; minut++)
                        {
                            svaOcitavanja.Add(new Ocitavanje() { Vreme = dateTime, MernoMestoId = this.SvaMernaMesta[0].Id, MernoMesto = this.SvaMernaMesta[0].OznakaMernogMesta, Vrednost = vrednost });
                            if (this.SvaMernaMesta.Count > 1)
                            {
                                svaOcitavanja.Add(new Ocitavanje() { Vreme = dateTime, MernoMestoId = this.SvaMernaMesta[1].Id, MernoMesto = this.SvaMernaMesta[1].OznakaMernogMesta, Vrednost = vrednost });
                            }
                            if (this.SvaMernaMesta.Count > 2)
                            {
                                svaOcitavanja.Add(new Ocitavanje() { Vreme = dateTime, MernoMestoId = this.SvaMernaMesta[2].Id, MernoMesto = this.SvaMernaMesta[2].OznakaMernogMesta, Vrednost = vrednost });
                            }
                            if (this.SvaMernaMesta.Count > 3)
                            {
                                svaOcitavanja.Add(new Ocitavanje() { Vreme = dateTime, MernoMestoId = this.SvaMernaMesta[3].Id, MernoMesto = this.SvaMernaMesta[3].OznakaMernogMesta, Vrednost = vrednost });
                            }
                            if (this.SvaMernaMesta.Count > 4)
                            {
                                svaOcitavanja.Add(new Ocitavanje() { Vreme = dateTime, MernoMestoId = this.SvaMernaMesta[4].Id, MernoMesto = this.SvaMernaMesta[4].OznakaMernogMesta, Vrednost = vrednost });
                            }
                            dateTime = dateTime.AddMinutes(15);
                            vrednost += (new Random()).Next(10);
                        }
                    }
                }
            }
            else if (sourceMode == DataSourceMode.FromDatabase)
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var command = new SqlCommand("select o.Datum, o.MernoMestoId, o.Vrednost From TSP2025.dbo.Ocitavanje o Order By o.Datum", connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            svaOcitavanja.Add(new Ocitavanje() { Vreme = reader.GetDateTime(0), MernoMestoId = reader.GetInt32(1), MernoMesto = this.SvaMernaMesta.First(m => m.Id == reader.GetInt32(1)).OznakaMernogMesta, Vrednost = (decimal)reader.GetDouble(2) });
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        FormMessages.ShowError("Greška. " + ex.Message);
                    }

                }
            }

            return svaOcitavanja;

        }
        public TSP2025DataContext()
        {
            MojeToplane = new ImprovedBindingList<Toplana>();
        }
        public void ReloadDataModel()
        {
            SveToplane.Clear();
            SveKotlarnice.Clear();
            SvePodstanice.Clear();
            SviIndividualniPotrosaci.Clear();
            MojeToplane.Clear();

            IsLoading = true;

            #region Load data from database
            using (var ds = new DataSet())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var cmd = new SqlCommand(
                        @"  Select * from Toplana;
                            Select * from Kotlarnica;
                            Select p.*, (Select count(Id) From MernoMesto mm Where mm.Tip = 1 and mm.PotrosacId = p.Id) As Mm from Podstanica p;
                            Select ip.*, (Select count(Id) From MernoMesto mm Where mm.Tip = 2 and mm.PotrosacId = ip.Id) As Mm from IndividualniPotrosac ip;
                            Select * from GrupaMernihMesta", con);
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }

                // TOPLANE
                foreach (DataRow toplanaRow in ds.Tables[0].Rows)
                {
                    Toplana toplana = new()
                    {
                        Id = (int)toplanaRow["Id"],
                        Naziv = (string)toplanaRow["Naziv"],
                        Napomena = (string)toplanaRow["Napomena"],
                        ImaMernoMesto = false
                    };
                    MojeToplane.Add(toplana);
                    SveToplane.Add(toplana);
                    toplana.ModelChanged += ModelChangedEventHandler;
                    MojeToplane.BeforeRemove += MojeToplane_BeforeRemove;
                    SveToplane.BeforeRemove += MojeToplane_BeforeRemove;
                }

                // KOTLARNICE
                foreach (DataRow kotlarnicaRow in ds.Tables[1].Rows)
                {
                    Kotlarnica kotlarnica = new()
                    {
                        Id = GetRowData<int>(kotlarnicaRow, "Id"),
                        Naziv = GetRowData<string>(kotlarnicaRow, "Naziv"),
                        Napomena = GetRowData<string>(kotlarnicaRow, "Napomena"),
                        ToplanaId = GetRowData<int>(kotlarnicaRow, "ToplanaId"),
                        Adresa = GetRowData<string>(kotlarnicaRow, "Adresa"),
                        Sef = GetRowData<string>(kotlarnicaRow, "Sef"),
                        Telefon = GetRowData<string>(kotlarnicaRow, "Telefon"),
                        Toplana = SveToplane.Where(t => t.Id == (int)kotlarnicaRow["ToplanaId"]).First(),
                        ImaMernoMesto = false
                    };
                    SveKotlarnice.Add(kotlarnica);
                    kotlarnica.ModelChanged += ModelChangedEventHandler;
                    kotlarnica.Toplana.Kotlarnice.BeforeRemove += Kotlarnice_BeforeRemove;

                }

                // PODSTANICE
                foreach (DataRow podstanicaRow in ds.Tables[2].Rows)
                {
                    Podstanica podstanica = new()
                    {
                        Id = GetRowData<int>(podstanicaRow, "Id"),
                        Naziv = GetRowData<string>(podstanicaRow, "Naziv"),
                        Napomena = GetRowData<string>(podstanicaRow, "Napomena"),
                        Adresa = GetRowData<string>(podstanicaRow, "Adresa"),
                        OdgovornoLice = GetRowData<string>(podstanicaRow, "OdgovornoLice"),
                        KotlarnicaId = GetRowData<int>(podstanicaRow, "KotlarnicaId"),
                        Kotlarnica = SveKotlarnice.Where(k => k.Id == (int)podstanicaRow["KotlarnicaId"]).First(),
                        ImaMernoMesto = GetRowData<int>(podstanicaRow, "Mm") == 0 ? false : true,
                    };
                    SvePodstanice.Add(podstanica);
                    podstanica.ModelChanged += ModelChangedEventHandler;
                    podstanica.Kotlarnica.Podstanice.BeforeRemove += Podstanice_BeforeRemove;
                }

                // INDIVIDUALNI POTROSACI
                foreach (DataRow individualniPotrosacRow in ds.Tables[3].Rows)
                {
                    IndividualniPotrosac individualniPotrosac = new()
                    {
                        Id = GetRowData<int>(individualniPotrosacRow, "Id"),
                        SifraKorisnika = GetRowData<string>(individualniPotrosacRow, "SifraKorisnika"),
                        Naziv = GetRowData<string>(individualniPotrosacRow, "Naziv"),
                        Email = GetRowData<string>(individualniPotrosacRow, "Email"),
                        Adresa = GetRowData<string>(individualniPotrosacRow, "Adresa"),
                        Telefon = GetRowData<string>(individualniPotrosacRow, "Telefon"),
                        PodstanicaId = GetRowData<int>(individualniPotrosacRow, "PodstanicaId"),
                        Podstanica = SvePodstanice.Where(k => k.Id == (int)individualniPotrosacRow["PodstanicaId"]).First(),
                        ImaMernoMesto = GetRowData<int>(individualniPotrosacRow, "Mm") == 0 ? false : true,
                    };
                    SviIndividualniPotrosaci.Add(individualniPotrosac);
                    individualniPotrosac.ModelChanged += ModelChangedEventHandler;
                    individualniPotrosac.Podstanica.IndividualniPotrosaci.BeforeRemove += SviIndividualniPotrosaci_BeforeRemove;
                }
            }
            #endregion

            IsLoading = false;

        }
        public void DeleteMernoMesto(MernoMesto mernoMesto)
        {
            try
            {
                DB.MernoMesto.Delete(mernoMesto.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void SviIndividualniPotrosaci_BeforeRemove(object deletedItem)
        {
            (deletedItem as IndividualniPotrosac).IsDeleted = true;
        }
        private void Podstanice_BeforeRemove(object deletedItem)
        {
            (deletedItem as Podstanica).IsDeleted = true;
        }
        private void MojeToplane_BeforeRemove(object deletedItem)
        {
            (deletedItem as Toplana).IsDeleted = true;
        }
        private void Kotlarnice_BeforeRemove(object deletedItem)
        {
            (deletedItem as Kotlarnica).IsDeleted = true;
        }
        private void ModelChangedEventHandler(string entity)
        {
            ModelChanged?.Invoke(entity);
        }
        private T GetRowData<T>(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return default;
            }
            else
            {
                return (T)row[column];
            }
        }
        private List<GrupaMernihMesta> UcitajGrupeMernihMesta()
        {
            var retList = new List<GrupaMernihMesta>();
            using (var ds = new DataSet())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var cmd = new SqlCommand("Select * From GrupaMernihMesta", con);

                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    foreach (DataRow gMernoMestoRow in ds.Tables[0].Rows)
                    {
                        GrupaMernihMesta gmm = new()
                        {
                            Id = (int)gMernoMestoRow["Id"],
                            Naziv = (string)gMernoMestoRow["Naziv"],
                            ImaMernoMesto = false,
                        };
                        retList.Add(gmm);
                    }
                }
            }
            return retList;
        }
        private void UcitajMernaMesta()
        {
            _SvaMernaMesta = new ImprovedBindingList<MernoMesto>();
            using (var ds = new DataSet())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var cmd = new SqlCommand("Select mm.Id, mm.OznakaKalorimetra, mm.OznakaMernogMesta, mm.Tip, mm.PotrosacId, mm.ScadaTabela, mm.ScadaKolona, mm.VremeDodavanja, g.Naziv, g.Id as GrupaId " +
                        "from MernoMesto mm join GrupaMernihMesta g on g.Id = mm.GrupaMernogMestaId ", con);

                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    foreach (DataRow mernoMestoRow in ds.Tables[0].Rows)
                    {
                        MernoMesto mm = new()
                        {
                            Id = (int)mernoMestoRow["Id"],
                            GrupaMernogMesta = new GrupaMernihMesta() { Id = (int)mernoMestoRow["GrupaId"], Naziv = (string)mernoMestoRow["Naziv"], ImaMernoMesto = false },
                            OznakaKalorimetra = (string)mernoMestoRow["OznakaKalorimetra"],
                            OznakaMernogMesta = (string)mernoMestoRow["OznakaMernogMesta"],
                            Tip = (int)mernoMestoRow["Tip"],
                            PotrosacId = (int)mernoMestoRow["PotrosacId"],
                            GrupaMernogMestaId = (int)mernoMestoRow["GrupaId"],
                            VremeDodavanja = (DateTime)mernoMestoRow["VremeDodavanja"],
                            ScadaKolona = (string)mernoMestoRow["ScadaKolona"],
                            ScadaTabela = (string)mernoMestoRow["ScadaTabela"],
                            ImaMernoMesto = false,
                        };
                        _SvaMernaMesta.Add(mm);
                    }

                }
            }
        }
    }
}
