namespace TSP2025.Data.Model
{
    public interface IEntity
    {
        int Id { get; }
        bool ImaMernoMesto { get; set; }
        bool IsChanged { get; }
        bool IsDeleted { get; }
        void Create();
        void Update();
        void Delete();
    }
}
