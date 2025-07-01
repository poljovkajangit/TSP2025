using TSP2025.Data.Model;

namespace TSP2025.Managers
{
    public interface IMaticniPodaciFormManager
    {
        void Add(IEntity newEntity);
        void Edit();
        void Remove();
        void Save();
        void Cancel();
        void Next();
        void Previous();
    }
}
