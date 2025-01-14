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
    }
}
