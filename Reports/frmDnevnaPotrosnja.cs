using ScottPlot;
using System.Data;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;
using TSP2025.Forms;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmDnevnaPotrosnja : Form
    {
        TSP2025DataContext _DataSource;

        MernoMesto SelectedMernoMesto
        {
            get
            {
                return (bsMernaMesta.Current as MernoMesto)!;
            }
        }
        private frmDnevnaPotrosnja() { }

        public frmDnevnaPotrosnja(MernoMesto mernoMesto = null)
        {
            InitializeComponent();

            _DataSource = new TSP2025DataContext();

            bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;

            if (mernoMesto != null)
            {
                foreach (var item in bsMernaMesta.List)
                {
                    if ((item as MernoMesto)!.Id == mernoMesto.Id)
                    {
                        int foundIndex = bsMernaMesta.IndexOf(item);
                        cbMernoMesto.SelectedIndex = foundIndex;
                        bsMernaMesta.Position = foundIndex;
                        break;
                    }
                }
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (SelectedMernoMesto == null || SelectedMernoMesto.Id == 0)
            {
                FormMessages.ShowError("Izaberite merno mesto.");
                return;
            }

            var fromDate = dtDan.SelectedDate.Date.AddHours(-1);
            var toDate = fromDate.AddDays(1).AddHours(1);

            var frmDataSource = new frmDataSourceForReports();
            frmDataSource.ShowDialog();

            var pristunaOcitavanja = OcitavanjaDBService.GetSvaOcitavanja(frmDataSource.DataSourceMode, 3, 15, _DataSource.SvaMernaMesta);

            var ocitavanja = pristunaOcitavanja.Where(
            o =>
                o.Vreme.Minute == 0 && o.Vreme.Second == 0
                &&
                o.MernoMestoId == SelectedMernoMesto.Id
                &&
                o.Vreme >= fromDate
                &&
                o.Vreme < toDate
             )
             .ToList();

            for (int i = 1; i < ocitavanja.Count; i++)
            {
                ocitavanja[i].Razlika = ocitavanja[i].Vrednost - ocitavanja[i - 1].Vrednost;
            }

            if (ocitavanja.Count > 0)
            {
                ocitavanja.RemoveAt(0);
            }

            lblUkupno.Text = "Ukupno: " + ocitavanja.Count;

            btnPrikazi.Enabled = true;

            pbGraph.Visible = false;

            // bar plot
            var positions = new List<double>();
            var ticks = new Tick[ocitavanja.Count];
            double[] values = [.. ocitavanja.Select(o => (double)o.Razlika)];
            List<string> labels = [.. ocitavanja.Select(o => o.Vreme.ToString("HH") + "h")];
            Tick tick;
            for (int i = 0; i < ocitavanja.Count; i++)
            {
                tick = new Tick(i, labels[i]);
                ticks[i] = tick;
                positions.Add(i);
            }

            var bars = pltPotrosnjaMesecena.Plot.Add.Bars(positions, values);

            bars.LegendText = dtDan.SelectedDate.ToString("dd/MM/yyyy");
            pltPotrosnjaMesecena.Plot.ShowLegend(Alignment.UpperLeft);

            for (int i = 0; i < bars.Bars.Count; i++)
            {
                bars.Bars[i].Label = ocitavanja[i].Razlika.ToString();
            }
            bars.ValueLabelStyle.Bold = true;
            bars.ValueLabelStyle.FontSize = 18;

            pltPotrosnjaMesecena.Plot.HideGrid();
            pltPotrosnjaMesecena.Plot.Axes.Margins(bottom: 0);

            //ticks
            pltPotrosnjaMesecena.Plot.Axes.Left.MajorTickStyle.Length = 0;
            pltPotrosnjaMesecena.Plot.Axes.Left.TickLabelStyle.IsVisible = false;
            pltPotrosnjaMesecena.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            pltPotrosnjaMesecena.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            pltPotrosnjaMesecena.Plot.Axes.Bottom.TickLabelStyle.FontSize = 18;
            pltPotrosnjaMesecena.Plot.Axes.Bottom.TickLabelStyle.Bold = false;

            if (pltPotrosnjaMesecena.Menu != null)
            {
                pltPotrosnjaMesecena.Menu.Clear();
            }

            pltPotrosnjaMesecena.UserInputProcessor.Disable();

            pltPotrosnjaMesecena.Refresh();
            btnClearPlot.Visible = true;
            pltPotrosnjaMesecena.Visible = true;

        }

        private void btnClearPlot_Click(object sender, EventArgs e)
        {
            pltPotrosnjaMesecena.Plot.Clear();
            pltPotrosnjaMesecena.Refresh();
        }
    }
}
