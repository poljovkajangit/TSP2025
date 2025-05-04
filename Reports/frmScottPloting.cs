using ScottPlot;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSP2025.Data.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TSP2025.Reports
{
    public partial class frmScottPloting : Form
    {
        public frmScottPloting()
        {
            InitializeComponent();


            //double[] xs1 = { 1, 3, 5, 7 };
            //double[] ys1 = { 5, 10, 7, 13 };
            //var bars1 = formsPlot1.Plot.Add.Bars(xs1, ys1);
            //bars1.LegendText = "Alpha";

            //double[] xs2 = { 2, 4, 6, 8 };
            //double[] ys2 = { 7, 12, 9, 15 };
            //var bars2 = formsPlot1.Plot.Add.Bars(xs2, ys2);
            //bars2.LegendText = "Beta";

            //formsPlot1.Plot.ShowLegend(Alignment.UpperLeft);
            //formsPlot1.Plot.Axes.Margins(bottom: 0);

            //formsPlot1.Refresh();

            double[] xs1 = { 1, 3, 5, 7, 9 };
            double[] ys1 = { 5, 10, 7, 13, 15 };
            var barPlot = formsPlot1.Plot.Add.Bars(xs1, ys1);
            barPlot.LegendText = "Alpha";

            double[] xs2 = { 2, 4, 6, 8, 10 };
            double[] ys2 = { 5.50, 12, 8, 14, 10 };
            var barPlot2 = formsPlot1.Plot.Add.Bars(xs2, ys2);
            barPlot2.LegendText = "Beta";


            // define the content of labels
            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();
            }

            // define the content of labels
            foreach (var bar in barPlot2.Bars)
            {
                bar.Label = bar.Value.ToString();
            }

            // customize label style
            barPlot.ValueLabelStyle.Bold = true;
            barPlot.ValueLabelStyle.FontSize = 18;
            barPlot2.ValueLabelStyle.Bold = true;
            barPlot2.ValueLabelStyle.FontSize = 18;

            formsPlot1.Plot.Legend.FontSize = 64;
            formsPlot1.Plot.ShowLegend(Alignment.UpperLeft);
            formsPlot1.Plot.Axes.Margins(bottom: 0);


            //ticks
            var ticks = new Tick[11];
            Tick tick;
            for (int i = 1; i <= 10; i++)
            {
                tick = new Tick(i, i.ToString());
                ticks[i] = tick;
            }

            formsPlot1.Plot.Axes.Left.MajorTickStyle.Length = 0;
            formsPlot1.Plot.Axes.Left.TickLabelStyle.IsVisible = false;
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.FontSize = 22;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Bold = false;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.ForeColor = ScottPlot.Colors.White;

            formsPlot1.Plot.HideGrid();

            formsPlot1.Refresh();

        }
    }
}
