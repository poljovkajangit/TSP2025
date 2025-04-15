using ScottPlot;
using ScottPlot.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TSP2025.Reports
{
    public partial class frmBarPlotReport : Form
    {
        public frmBarPlotReport(List<double> values, List<string> labels, string mernoMesto)
        {
            InitializeComponent();

            lblMernoMesto.Text = mernoMesto;

            var ticks = new Tick[values.Count];
            var positions = new List<double>();

            Tick tick;
            for (int i = 0; i < values.Count; i++)
            {
                tick = new Tick(i, labels[i]);
                ticks[i] = tick;
                positions.Add(i);
            }


            var barPlot = formsPlot1.Plot.Add.Bars(positions, values);
            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();
            }

            barPlot.ValueLabelStyle.Bold = false;
            barPlot.ValueLabelStyle.FontSize = 16;



            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            formsPlot1.Plot.HideGrid();

            // tell the plot to autoscale with no padding beneath the bars
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            formsPlot1.Plot.Axes.Left.TickLabelStyle.IsVisible = false;
            formsPlot1.Plot.Axes.Left.MajorTickStyle.Length = 0;
            formsPlot1.Plot.Axes.Left.MinorTickStyle.Length = 0;

            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.FontSize = 16;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Bold = false;



            formsPlot1.Refresh();
        }
    }
}
