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
                        return "Jan '" + Vreme.Year.ToString().Substring(2, 2);
                    case 2:
                        return "Feb '" + Vreme.Year.ToString().Substring(2, 2);
                    case 3:
                        return "Mar '" + Vreme.Year.ToString().Substring(2, 2);
                    case 4:
                        return "Apr '" + Vreme.Year.ToString().Substring(2, 2);
                    case 5:
                        return "Maj '" + Vreme.Year.ToString().Substring(2, 2);
                    case 6:
                        return "Jun '" + Vreme.Year.ToString().Substring(2, 2);
                    case 7:
                        return "Jul '" + Vreme.Year.ToString().Substring(2, 2);
                    case 8:
                        return "Avg '" + Vreme.Year.ToString().Substring(2, 2);
                    case 9:
                        return "Sep '" + Vreme.Year.ToString().Substring(2, 2);
                    case 10:
                        return "Okt '" + Vreme.Year.ToString().Substring(2, 2);
                    case 11:
                        return "Nov '" + Vreme.Year.ToString().Substring(2, 2);
                    case 12:
                        return "Dec '" + Vreme.Year.ToString().Substring(2, 2);
                    default:
                        return string.Empty;
                }
            }
        }

        public decimal Razlika { get; set; }
    }
}
