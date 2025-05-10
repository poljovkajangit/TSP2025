using System.ComponentModel;

namespace TSP2025.UserControls
{
    public partial class SmartDateUC : UserControl, INotifyPropertyChanged
    {
        public SmartDateUC()
        {
            InitializeComponent();


            if (!DesignMode)
            {
                //years
                cbYear.SelectedIndex = 2;
                cbYear.SelectedIndexChanged += CbYear_SelectedIndexChanged;
                //monts
                cbMonth.SelectedIndex = DateTime.Now.Month - 1;
                cbMonth.SelectedIndexChanged += CbMonth_SelectedIndexChanged;
                //days
                SetDaysList();
                cbDay.SelectedIndex = DateTime.Now.Day - 1;
                cbDay.SelectedIndexChanged += CbDay_SelectedIndexChanged;

                _Date = DateTime.Now.Date;
            }
        }

        private void SetDaysList()
        {
            cbDay.Items.Clear();
            for (var i = 0; i < DateTime.DaysInMonth(cbYear.SelectedIndex + 1, cbMonth.SelectedIndex + 1); i++)
            {
                cbDay.Items.Add((i + 1));
            }
            cbDay.SelectedIndex = 0;
        }

        private void CbDay_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SelectedDate = new DateTime(Int32.Parse(cbYear.Text), cbMonth.SelectedIndex + 1, cbDay.SelectedIndex + 1);
        }
        private void CbMonth_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SetDaysList();
            SelectedDate = new DateTime(Int32.Parse(cbYear.Text), cbMonth.SelectedIndex + 1, cbDay.SelectedIndex + 1);
        }
        private void CbYear_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SetDaysList();
            SelectedDate = new DateTime(Int32.Parse(cbYear.Text), cbMonth.SelectedIndex + 1, cbDay.SelectedIndex + 1);
        }

        private DateTime _Date = DateTime.Now.Date;

        public event PropertyChangedEventHandler? PropertyChanged;

        public DateTime SelectedDate
        {
            get => _Date;
            set
            {
                if (value != _Date)
                {
                    _Date = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedDate)));
                }
            }
        }


    }
}
