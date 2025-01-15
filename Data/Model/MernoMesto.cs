
namespace TSP2025.Data.Model
{
    public class MernoMesto : ModelBase
    {
        private GrupaMernihMesta grupaMernogMesta;
        private int? grupaMernogMestaId;
        private string oznakaMernogMesta;
        private string oznakaKalorimetra;
        private int tip;
        private int? podstanicaId;
        private int? individualniPotrosacId;
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
        public int? PodstanicaId
        {
            get => podstanicaId;
            set
            {
                if (value != podstanicaId)
                {
                    podstanicaId = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public int? IndividualniPotrosacId
        {
            get => individualniPotrosacId;
            set
            {
                if (value != individualniPotrosacId)
                {
                    individualniPotrosacId = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
    }
}
