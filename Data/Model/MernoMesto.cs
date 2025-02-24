
namespace TSP2025.Data.Model
{
    public class MernoMesto : ModelBase
    {
        private GrupaMernihMesta grupaMernogMesta;
        private int? grupaMernogMestaId;
        private string oznakaMernogMesta;
        private string oznakaKalorimetra;
        private int tip;
        private string scadaTabela;
        private string scadaKolona;
        private DateTime vremeDodavanja;
        private int potrosacId;
        public string GrupaMernogMestaNaziv
        {
            get
            {
                return this.GrupaMernogMesta.Naziv;
            }
        }

        public GrupaMernihMesta GrupaMernogMesta
        {
            get => grupaMernogMesta;
            set
            {
                if (value != grupaMernogMesta)
                {
                    grupaMernogMesta = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public int? GrupaMernogMestaId
        {
            get => grupaMernogMestaId;
            set
            {
                if (value != grupaMernogMestaId)
                {
                    grupaMernogMestaId = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string OznakaMernogMesta
        {
            get => oznakaMernogMesta;
            set
            {
                if (value != oznakaMernogMesta)
                {
                    oznakaMernogMesta = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string OznakaKalorimetra
        {
            get => oznakaKalorimetra;
            set
            {
                if (value != oznakaKalorimetra)
                {
                    oznakaKalorimetra = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public int Tip
        {
            get => tip;
            set
            {
                if (value != tip)
                {
                    tip = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public int PotrosacId
        {
            get => potrosacId;
            set
            {
                if (value != potrosacId)
                {
                    potrosacId = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public DateTime VremeDodavanja
        {
            get => vremeDodavanja;
            set
            {
                if (value != vremeDodavanja)
                {
                    vremeDodavanja = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string ScadaTabela
        {
            get => scadaTabela;
            set
            {
                if (value != scadaTabela)
                {
                    scadaTabela = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string ScadaKolona
        {
            get => scadaKolona;
            set
            {
                if (value != scadaKolona)
                {
                    scadaKolona = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
    }
}
