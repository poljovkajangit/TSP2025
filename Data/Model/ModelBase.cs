
namespace TSP2025.Data.Model
{
    public delegate void ModelChangedEventHandler(string entity);

    public abstract class ModelBase
    {
        public event ModelChangedEventHandler ModelChanged;

        private bool isChanged = false;
        private bool isDeleted = false;
        public int Id { get; set; }
        public bool IsChanged
        {
            get => isChanged;
            set
            {
                if (isChanged != value)
                {
                    isChanged = value;
                    ModelChanged?.Invoke(this.GetType().Name);
                }
            }
        }
        public bool IsDeleted
        {
            get => isDeleted;
            set
            {
                isDeleted = value;
                ModelChanged?.Invoke(this.GetType().Name);
            }
        }
    }
}
