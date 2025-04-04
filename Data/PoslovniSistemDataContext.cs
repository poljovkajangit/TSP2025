﻿using Microsoft.Data.SqlClient;
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
    public class PoslovniSistemDataContext
    {
        public ImprovedBindingList<Toplana> MojeToplane { get; set; }
        public ImprovedBindingList<Toplana> SveToplane { get; set; } = new ImprovedBindingList<Toplana>();
        public ImprovedBindingList<Kotlarnica> SveKotlarnice { get; set; } = new ImprovedBindingList<Kotlarnica>();
        public ImprovedBindingList<Podstanica> SvePodstanice { get; set; } = new ImprovedBindingList<Podstanica>();
        public ImprovedBindingList<IndividualniPotrosac> SviIndividualniPotrosaci { get; set; } = new ImprovedBindingList<IndividualniPotrosac>();



        public static bool IsLoading { get; set; } = false;

        private List<GrupaMernihMesta> _SveGrupaMernihMesta = null;

        private ImprovedBindingList<MernoMesto> _SvaMernaMesta = null;

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
                    _SvaMernaMesta.Insert(0, new MernoMesto() { Id = 0, OznakaMernogMesta = "" });
                }
                return _SvaMernaMesta;
            }
        }

        public void OcistiMernaMesta()
        {
            _SvaMernaMesta = null;
        }

        public List<GrupaMernihMesta> SveGrupaMernihMestaSaPocetnimPraznim
        {
            get
            {
                if (_SveGrupaMernihMesta == null)
                {
                    UcitajGrupeMernihMesta();
                    _SveGrupaMernihMesta.Insert(0, new GrupaMernihMesta() { Id = 0, Naziv = "<Sve>" });
                }
                return _SveGrupaMernihMesta;
            }
        }
        public List<GrupaMernihMesta> SveGrupaMernihMesta
        {
            get
            {
                if (_SveGrupaMernihMesta == null)
                {
                    UcitajGrupeMernihMesta();
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
                            GrupaMernogMesta = new GrupaMernihMesta() { Id = (int)mernoMestoRow["GrupaId"], Naziv = (string)mernoMestoRow["Naziv"] },
                            OznakaKalorimetra = (string)mernoMestoRow["OznakaKalorimetra"],
                            OznakaMernogMesta = (string)mernoMestoRow["OznakaMernogMesta"],
                            Tip = (int)mernoMestoRow["Tip"],
                            PotrosacId = (int)mernoMestoRow["PotrosacId"],
                            GrupaMernogMestaId = (int)mernoMestoRow["GrupaId"],
                            VremeDodavanja = (DateTime)mernoMestoRow["VremeDodavanja"],
                            ScadaKolona = (string)mernoMestoRow["ScadaKolona"],
                            ScadaTabela = (string)mernoMestoRow["ScadaTabela"],
                        };
                        _SvaMernaMesta.Add(mm);
                    }

                }
            }
        }
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
                    var command = new SqlCommand("select o.Datum, o.MernoMestoId, o.Vrednost From TSP2025.dbo.Ocitavanje o", connection);

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
