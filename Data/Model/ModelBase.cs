
using System.ComponentModel;

namespace TSP2025.Data.Model
{
    public delegate void ModelChangedEventHandler(string entity);

    public abstract class ModelBase : INotifyPropertyChanged
    {
        public event ModelChangedEventHandler ModelChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool isChanged = false;
        private bool isDeleted = false;
        private int id = 0;
        private bool imaMernoMesto = false;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }   
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id != value)
                {
                    id = value;
                    IsChanged = true;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdCaption)));
                    ModelChanged?.Invoke(this.GetType().Name);
                }
            }
        }

        public string IdCaption
        {
            get
            {
                return "Id: " + Id;
            }
        }
        public bool ImaMernoMesto
        {
            set
            {
                if (imaMernoMesto != value)
                {
                    imaMernoMesto = value;
                    IsChanged = true;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImaMernoMesto)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImaMernoMestoPreview)));
                    ModelChanged?.Invoke(nameof(ImaMernoMesto));
                }
            }
            get
            {
                return imaMernoMesto;
            }
        }
        public string ImaMernoMestoPreview
        {
            get
            {
                if (imaMernoMesto)
                {
                    return "Ima";
                }
                else
                {
                    return "Nema";
                }
            }
        }
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
