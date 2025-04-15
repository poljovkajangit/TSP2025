namespace TSP2025.Data.Model
{
    public class PullHistory
    {
        public int Id { get; set; }
        public DateTime Vreme { get; set; }
        public int MernoMestoId { get; set; }
        public string MernoMesto { get; set; } = string.Empty;
        public int PrenetoZapisa { get; set; }
        public int Status { get; set; }
        public string Poruka { get; set; } = string.Empty;
    }
}
