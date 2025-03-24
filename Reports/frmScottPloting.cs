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

namespace TSP2025.Reports
{
    public partial class frmScottPloting: Form
    {
        public frmScottPloting()
        {
            InitializeComponent();

            // create a bar plot
            double[] values = { 5, 10, 7, 13, 25, 60 };
            formsPlot1.Plot.Add.Bars(values);
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            // create a tick for each bar
            Tick[] ticks =
            {
                new(0, "First Long Title"),
                new(1, "Second Long Title"),
                new(2, "Third Long Title"),
                new(3, "Fourth Long Title"),
                new(4, "Fifth Long Title"),
                new(5, "Sixth Long Title")
            };
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Rotation = 90;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

            // determine the width of the largest tick label
            float largestLabelWidth = 0;
            using SKPaint paint = new();
            foreach (Tick tick in ticks)
            {
                PixelSize size = formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Measure(tick.Label, paint).Size;
                largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
            }

            // ensure axis panels do not get smaller than the largest label
            formsPlot1.Plot.Axes.Bottom.MinimumSize = largestLabelWidth;
            formsPlot1.Plot.Axes.Right.MinimumSize = largestLabelWidth;

            formsPlot1.Refresh();
        }
    }
}
