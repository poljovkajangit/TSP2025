using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2005;
using TSP2025.Data.Model;

namespace TSP2025.Data
{
    public class PoslovniSistemDataContext
    {
        public static bool IsLoading { get; set; } = false;
        public ImprovedBindingList<Toplana> SveToplane { get; set; } = new ImprovedBindingList<Toplana>();
        public ImprovedBindingList<Kotlarnica> SveKotlarnice { get; set; } = new ImprovedBindingList<Kotlarnica>();
        public ImprovedBindingList<Podstanica> SvePodstanice { get; set; } = new ImprovedBindingList<Podstanica>();
        public ImprovedBindingList<IndividualniPotrosac> SviIndividualniPotrosaci { get; set; } = new ImprovedBindingList<IndividualniPotrosac>();
        public ImprovedBindingList<GrupaMernihMesta> SvaGrupaMernihMesta { get; set; } = new ImprovedBindingList<GrupaMernihMesta>();
        public ImprovedBindingList<MernoMesto> SvaMernaMesta
        {
            get
            {
                var svaMernaMesta = new ImprovedBindingList<MernoMesto>();
                svaMernaMesta.Add(new MernoMesto() { Id = 1, PodstanicaId = 1, OznakaKalorimetra = "kalorimetar1111", OznakaMernogMesta = "TREND_TSTP1_TP1_1", GrupaMernogMestaId = 1, Tip = 1, GrupaMernogMesta = SvaGrupaMernihMesta[1] });
                svaMernaMesta.Add(new MernoMesto() { Id = 1, PodstanicaId = 2, OznakaKalorimetra = "kalorimetar2222", OznakaMernogMesta = "TREND_TSTP1_TP1_2", GrupaMernogMestaId = 2, Tip = 1, GrupaMernogMesta = SvaGrupaMernihMesta[2] });
                svaMernaMesta.Add(new MernoMesto() { Id = 1, PodstanicaId = 3, OznakaKalorimetra = "kalorimetar2222", OznakaMernogMesta = "TREND_TSTP1_TP1_3", GrupaMernogMestaId = 3, Tip = 1, GrupaMernogMesta = SvaGrupaMernihMesta[3] });
                svaMernaMesta.Add(new MernoMesto() { Id = 1, PodstanicaId = 2, OznakaKalorimetra = "kalorimetar2222", OznakaMernogMesta = "TREND_TSTP1_TP2_1", GrupaMernogMestaId = 1, Tip = 1, GrupaMernogMesta = SvaGrupaMernihMesta[1] });
                svaMernaMesta.Add(new MernoMesto() { Id = 1, PodstanicaId = 2, OznakaKalorimetra = "kalorimetar2222", OznakaMernogMesta = "TREND_TSTP1_TP2_1", GrupaMernogMestaId = 1, Tip = 1, GrupaMernogMesta = SvaGrupaMernihMesta[1] });
                svaMernaMesta.Add(new MernoMesto() { Id = 1, PodstanicaId = 2, OznakaKalorimetra = "kalorimetar2222", OznakaMernogMesta = "TREND_TSTP1_TP3_1", GrupaMernogMestaId = 1, Tip = 1, GrupaMernogMesta = SvaGrupaMernihMesta[2] });
                return svaMernaMesta;
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
        public ImprovedBindingList<Toplana> MojeToplane { get; set; }

        public PoslovniSistemDataContext()
        {
            MojeToplane = new ImprovedBindingList<Toplana>();
            SveToplane.BeforeRemove += MojeToplane_BeforeRemove;
        }

        private void MojeToplane_BeforeRemove(object deletedItem)
        {
            (deletedItem as Toplana).IsDeleted = true;
        }

        public void ReloadDataModel()
        {
            SveToplane.Clear();
            SveKotlarnice.Clear();
            SvePodstanice.Clear();
            SviIndividualniPotrosaci.Clear();
            SvaGrupaMernihMesta.Clear();
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
                    SviIndividualniPotrosaci.Add(individualniPotrosac);
                }

                // GRUPE MERNIH MEESTA
                foreach (DataRow grupaMernihMestaRow in ds.Tables[4].Rows)
                {
                    GrupaMernihMesta grupaMernihMesta = new()
                    {
                        Id = GetRowData<int>(grupaMernihMestaRow, "Id"),
                        Naziv = GetRowData<string>(grupaMernihMestaRow, "Naziv"),
                    };
                    SvaGrupaMernihMesta.Add(grupaMernihMesta);
                }
            }
            #endregion

            IsLoading = false;

        }

        private void ModelChangedEventHandler(string entity)
        {
            ModelChanged?.Invoke(entity);
        }

        public event ModelChangedEventHandler ModelChanged;


    }
}
