using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2005;
using TSP2025.Data.Model;

namespace TSP2025.Data
{
    public class PoslovniSistemDataContext
    {
        public ImprovedBindingList<Toplana> MojeToplane { get; set; }
        public static bool IsLoading { get; set; } = false;
        public ImprovedBindingList<Toplana> SveToplane { get; set; } = new ImprovedBindingList<Toplana>();
        public ImprovedBindingList<Kotlarnica> SveKotlarnice { get; set; } = new ImprovedBindingList<Kotlarnica>();
        public ImprovedBindingList<Podstanica> SvePodstanice { get; set; } = new ImprovedBindingList<Podstanica>();
        public ImprovedBindingList<IndividualniPotrosac> SviIndividualniPotrosaci { get; set; } = new ImprovedBindingList<IndividualniPotrosac>();

        private List<GrupaMernihMesta> _SveGrupaMernihMesta = null;

        private List<MernoMesto> _SvaMernaMesta = null;

        public List<MernoMesto> SvaMernaMesta
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
        public List<GrupaMernihMesta> SveGrupaMernihMestaSaPocetnimPraznim
        {
            get
            {
                if (_SveGrupaMernihMesta == null)
                {
                    UcitajGrupeMernihMesta();
                    _SveGrupaMernihMesta.Insert(0, new GrupaMernihMesta() { Id = 0, Naziv = "" });
                }
                return _SveGrupaMernihMesta;
            }
        }
        public void UcitajGrupeMernihMesta()
        {
            _SveGrupaMernihMesta = new List<GrupaMernihMesta>();
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
                        };
                        _SveGrupaMernihMesta.Add(gmm);
                    }
                }
            }
        }

        public void UcitajMernaMesta()
        {
            _SvaMernaMesta = new List<MernoMesto>();
            using (var ds = new DataSet())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var cmd = new SqlCommand("Select mm.Id, mm.OznakaKalorimetra, mm.OznakaMernogMesta, mm.Tip, mm.IndividualniPotrosacId, mm.PodstanicaId, g.Naziv, g.Id as GrupaId " +
                        "from MernoMesto mm join GrupaMernihMesta g on g.Id = mm.GrupaMernihMestaId ", con);

                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    foreach (DataRow mernoMestoRow in ds.Tables[0].Rows)
                    {
                        MernoMesto mm = new()
                        {
                            Id = (int)mernoMestoRow["Id"],
                            GrupaMernogMesta = new GrupaMernihMesta() { Id = (int)mernoMestoRow["GrupaId"], Naziv = (string)mernoMestoRow["Naziv"] },
                            IndividualniPotrosacId = mernoMestoRow["IndividualniPotrosacId"] == DBNull.Value ? null : (int)mernoMestoRow["IndividualniPotrosacId"],
                            OznakaKalorimetra = (string)mernoMestoRow["OznakaKalorimetra"],
                            OznakaMernogMesta = (string)mernoMestoRow["OznakaMernogMesta"],
                            Tip = (int)mernoMestoRow["Tip"],
                            PodstanicaId = mernoMestoRow["PodstanicaId"] == DBNull.Value ? null : (int)mernoMestoRow["PodstanicaId"],
                            GrupaMernogMestaId = (int)mernoMestoRow["GrupaId"]
                        };
                        _SvaMernaMesta.Add(mm);
                    }

                }
            }
        }
        public ImprovedBindingList<Ocitavanje> SvaOcitavanja
        {
            get
            {
                var svaOcitavanja = new ImprovedBindingList<Ocitavanje>();
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(0), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 100.10M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(1), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 200.10M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(2), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 300.10M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(3), MernoMesto = "TREND_TSTP1_TP1_2", Vrednost = 300.80M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(4), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 400.10M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(5), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 400.50M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(6), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 600.10M });
                svaOcitavanja.Add(new Ocitavanje() { Vreme = DateTime.Now.AddDays(7), MernoMesto = "TREND_TSTP1_TP1_1", Vrednost = 900.10M });
                return svaOcitavanja;
            }
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
        public PoslovniSistemDataContext()
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
                            Select * from Podstanica;
                            Select * from IndividualniPotrosac;
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
                        Napomena = (string)toplanaRow["Napomena"]
                    };
                    toplana.ModelChanged += ModelChangedEventHandler;
                    MojeToplane.Add(toplana);
                    SveToplane.Add(toplana);
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
                        Toplana = SveToplane.Where(t => t.Id == (int)kotlarnicaRow["ToplanaId"]).First(),
                        Adresa = GetRowData<string>(kotlarnicaRow, "Adresa"),
                        Sef = GetRowData<string>(kotlarnicaRow, "Sef"),
                        Telefon = GetRowData<string>(kotlarnicaRow, "Telefon"),
                    };
                    kotlarnica.ModelChanged += ModelChangedEventHandler;
                    SveKotlarnice.Add(kotlarnica);
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
                        KOLONA_NAPLANTONG_REGISTRA = GetRowData<string>(podstanicaRow, "KOLONA_NAPLANTONG_REGISTRA"),
                        TABELA_NAPLATNOG_REGISTRA = GetRowData<string>(podstanicaRow, "TABELA_NAPLATNOG_REGISTRA"),
                    };
                    podstanica.ModelChanged += ModelChangedEventHandler;
                    SvePodstanice.Add(podstanica);
                    SvePodstanice.BeforeRemove += Podstanice_BeforeRemove;
                    podstanica.Kotlarnica.Podstanice.BeforeRemove += Podstanice_BeforeRemove;
                }

                // INDIVIDUALNI POTROSACI
                foreach (DataRow individualniPotrosacRow in ds.Tables[3].Rows)
                {
                    IndividualniPotrosac individualniPotrosac = new()
                    {
                        Id = GetRowData<int>(individualniPotrosacRow, "Id"),
                        Naziv = GetRowData<string>(individualniPotrosacRow, "Naziv"),
                        Email = GetRowData<string>(individualniPotrosacRow, "Email"),
                        Adresa = GetRowData<string>(individualniPotrosacRow, "Adresa"),
                        Telefon = GetRowData<string>(individualniPotrosacRow, "Telefon"),
                        PodstanicaId = GetRowData<int>(individualniPotrosacRow, "PodstanicaId"),
                        Podstanica = SvePodstanice.Where(k => k.Id == (int)individualniPotrosacRow["PodstanicaId"]).First(),
                    };
                    individualniPotrosac.ModelChanged += ModelChangedEventHandler;
                    SviIndividualniPotrosaci.BeforeRemove += SviIndividualniPotrosaci_BeforeRemove;
                    SviIndividualniPotrosaci.Add(individualniPotrosac);
                }
            }
            #endregion

            IsLoading = false;

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

        public event ModelChangedEventHandler ModelChanged;


    }
}
