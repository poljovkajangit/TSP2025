using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP2025.Data.Model
{
    public class Ocitavanje
    {
        public int Id { get; set; }
        public DateTime Vreme { get; set; }
        public decimal Vrednost { get; set; }
        public int MernoMestoId { get; set; }
        public string MernoMesto { get; set; }
        public string VremeFormatirano
        {
            get
            {
                return Vreme.ToString("dd/MM/yyyy HH:mm");
            }
        }
        public string MesecGodina
        {
            get
            {
                switch (Vreme.Month)
                {
                    case 1:
                        return "Januar " + Vreme.Year;
                    case 2:
                        return "Februar " + Vreme.Year;
                    case 3:
                        return "Mart " + Vreme.Year;
                    case 4:
                        return "April " + Vreme.Year;
                    case 5:
                        return "Maj " + Vreme.Year;
                    case 6:
                        return "Jun " + Vreme.Year;
                    case 7:
                        return "Jul " + Vreme.Year;
                    case 8:
                        return "Avgust " + Vreme.Year;
                    case 9:
                        return "Septembar " + Vreme.Year;
                    case 10:
                        return "Oktobar " + Vreme.Year;
                    case 11:
                        return "Novembar " + Vreme.Year;
                    case 12:
                        return "Decembar " + Vreme.Year;
                    default:
                        return string.Empty;
                }
            }
        }

        public decimal Razlika { get; set; }
    }
}
