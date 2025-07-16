using ScottPlot;
using System.Data;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;
using TSP2025.Forms;

namespace TSP2025.Reports
{
    public partial class frmMedjugodisnja : Form
    {

        TSP2025DataContext _DataSource;

        MernoMesto SelectedMernoMesto
        {
            get
            {
                return (bsMernaMesta.Current as MernoMesto)!;
            }
        }
        private frmMedjugodisnja() { }

        public frmMedjugodisnja(MernoMesto mernoMesto = null)
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

        private void button1_Click(object sender, EventArgs e)
        {

            var fromDate = new DateTime(2023, 1, 1).AddMonths(-1);
            var toDate = fromDate.AddMonths(37);

            var frmDataSource = new frmDataSourceForReports();
            frmDataSource.ShowDialog();

            var pristunaOcitavanja = OcitavanjaDBService.GetSvaOcitavanja(frmDataSource.DataSourceMode, 5, 1_440, _DataSource.SvaMernaMesta.Where(mm => mm.Id == SelectedMernoMesto.Id).ToList());

            var ocitavanja = pristunaOcitavanja.Where(
             o =>
                 o.Vreme.Date.Day == 1 && o.Vreme.Hour == 0 && o.Vreme.Minute == 0
                 &&
                 o.MernoMestoId == SelectedMernoMesto.Id
                 &&
                 o.Vreme >= fromDate
                 &&
                 o.Vreme < toDate
             ).ToList();

            for (int i = 1; i < ocitavanja.Count; i++)
            {
                ocitavanja[i].Razlika = ocitavanja[i].Vrednost - ocitavanja[i - 1].Vrednost;
            }

            if (ocitavanja.Count > 0)
            {
                ocitavanja.RemoveAt(0);
            }


            ScottPlot.Palettes.Category10 palette = new();

            ScottPlot.Bar[] bars =
            {
                // jan
                new() { Position = 1, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 1 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 2, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 1 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue},
                new() { Position = 3, Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 1 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // feb
                new() { Position = 5, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 2 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 6, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 2 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 7,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 2 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // mar
                new() { Position = 9, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 3 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 10, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 3 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 11,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 3 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // apr
                new() { Position = 13, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 4 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 14, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 4 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 15,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 4 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // maj
                new() { Position = 17, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 5 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 18, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 5 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 19,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 5 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // jun
                new() { Position = 21, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 6 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 22, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 6 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 23,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 6 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // jul
                new() { Position = 25, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 7 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 26, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 7 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 27,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 7 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // avg
                new() { Position = 29, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 8 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 30, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 8 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 31,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 8 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // sep
                new() { Position = 33, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 9 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 34, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 9 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 35,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 9 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // okt
                new() { Position = 37, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 10 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 38, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 10 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 39,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 10 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // nov
                new() { Position = 41, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 11 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 42, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 11 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 43,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 11 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },

                // dec
                new() { Position = 45, Value = ocitavanja.Where(o=>o.Vreme.Year==2023 && o.Vreme.Month == 12 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightSteelBlue },
                new() { Position = 46, Value = ocitavanja.Where(o=>o.Vreme.Year==2024 && o.Vreme.Month == 12 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.SteelBlue },
                new() { Position = 47,Value = ocitavanja.Where(o=>o.Vreme.Year==2025 && o.Vreme.Month == 12 && o.Vreme.Day==1).Select(r=>(double)r.Razlika).FirstOrDefault(), FillColor = ScottPlot.Colors.LightBlue },
            };

            formsPlot1.Plot.Add.Bars(bars);

            // build the legend manually
            formsPlot1.Plot.Legend.IsVisible = true;
            formsPlot1.Plot.Legend.Alignment = Alignment.UpperLeft;
            formsPlot1.Plot.Legend.ManualItems.Add(new() { LabelText = "2023", FillColor = ScottPlot.Colors.LightSteelBlue, LabelFontSize = 18 });
            formsPlot1.Plot.Legend.ManualItems.Add(new() { LabelText = "2024", FillColor = ScottPlot.Colors.SteelBlue, LabelFontSize = 18 });
            formsPlot1.Plot.Legend.ManualItems.Add(new() { LabelText = "2025", FillColor = ScottPlot.Colors.LightBlue, LabelFontSize = 18 });


            // show group labels on the bottom axis
            Tick[] ticks =
            {
                new(2, "jan"),
                new(6, "feb"),
                new(10, "mar"),
                new(14, "apr"),
                new(18, "maj"),
                new(22, "jun"),
                new(26, "jul"),
                new(30, "avg"),
                new(34, "sep"),
                new(38, "okt"),
                new(42, "nov"),
                new(46, "dec"),
            };
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.FontSize = 18;
            formsPlot1.Plot.HideGrid();

            // tell the plot to autoscale with no padding beneath the bars
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            formsPlot1.Refresh();
        }
    }
}
