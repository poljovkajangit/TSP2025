using ScottPlot;
using ScottPlot.Plottables;
using System.Data;
using System.Text;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;
using TSP2025.Forms;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmStanje : Form
    {
        TSP2025DataContext _DataSource;
        DateTime[] xs;
        double[] ys;
        Marker selectedDataItemPlotMarker = null;
        MernoMesto _SelectedMernoMesto = null;

        List<Ocitavanje> Ocitavanja
        {
            get
            {
                return (bsOcitavanja.List as List<Ocitavanje>)!;
            }
        }

        private frmStanje() { }
        public frmStanje(MernoMesto mernoMesto = null)
        {
            InitializeComponent();

            _DataSource = new TSP2025DataContext();
            dtDanOd.SelectedDate = new DateTime(2025, 5, 1);
            _SelectedMernoMesto = mernoMesto;
            if (mernoMesto != null)
            {
                lblMernoMesto.Text = _SelectedMernoMesto.OznakaMernogMesta;
            }
            cbProredi.SelectedIndex = 0;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var frmDataSource = new frmDataSourceForReports();
            frmDataSource.ShowDialog();

            var pristunaOcitavanja = OcitavanjaDBService.GetSvaOcitavanja(frmDataSource.DataSourceMode, 3, 15, _DataSource.SvaMernaMesta);

            switch (cbProredi.SelectedIndex)
            {
                case 0:
                    bsOcitavanja.DataSource = pristunaOcitavanja.Where(
                    o =>
                    o.MernoMestoId == _SelectedMernoMesto.Id
                    &&
                    o.Vreme >= dtDanOd.SelectedDate.Date
                    &&
                    o.Vreme < dtDanDo.SelectedDate.AddDays(1).Date)
                    .ToList();
                    break;
                case 1:
                    bsOcitavanja.DataSource = pristunaOcitavanja.Where(
                    o =>
                    o.Vreme.Minute == 0
                    &&
                    o.MernoMestoId == _SelectedMernoMesto.Id
                    &&
                    o.Vreme >= dtDanOd.SelectedDate.Date
                    &&
                    o.Vreme < dtDanDo.SelectedDate.AddDays(1).Date)
                    .ToList();
                    break;
                case 2:
                    bsOcitavanja.DataSource = pristunaOcitavanja.Where(
                    o =>
                    o.Vreme.Date == o.Vreme
                    &&
                    o.MernoMestoId == _SelectedMernoMesto.Id
                    &&
                    o.Vreme >= dtDanOd.SelectedDate.Date
                    &&
                    o.Vreme < dtDanDo.SelectedDate.AddDays(1).Date)
                    .ToList();
                    break;
                case 3:
                    bsOcitavanja.DataSource = pristunaOcitavanja.Where(
                    o =>
                    o.Vreme.Date.Day == 1 && o.Vreme.Hour == 0 && o.Vreme.Minute == 0
                    &&
                    o.MernoMestoId == _SelectedMernoMesto.Id
                    &&
                    o.Vreme >= dtDanOd.SelectedDate.Date
                    &&
                    o.Vreme < dtDanDo.SelectedDate.AddDays(1).Date
                    )
                    .ToList();
                    break;
            }

            for (int i = 1; i < bsOcitavanja.Count; i++)
            {
                Ocitavanja[i].Razlika = Ocitavanja[i].Vrednost - Ocitavanja[i - 1].Vrednost;
            }

            lblUkupno.Text = "Ukupno: " + bsOcitavanja.Count;

            pltStanje.Plot.Clear();

            // plot data using DateTime values on the horizontal axis
            xs = [.. (bsOcitavanja.DataSource as IList<Ocitavanje>)!.Select(o => o.Vreme)];
            ys = [.. (bsOcitavanja.DataSource as IList<Ocitavanje>)!.Select(o => (double)o.Vrednost)];
            var mainScatter = pltStanje.Plot.Add.Scatter(xs, ys);

            // customize the scatter plot line
            mainScatter.Color = Colors.DeepSkyBlue;
            mainScatter.LineWidth = 2;
            mainScatter.MarkerSize = 5;
            mainScatter.MarkerShape = MarkerShape.FilledCircle;
            mainScatter.LinePattern = LinePattern.Solid;

            pltStanje.Plot.Axes.Bottom.TickLabelStyle.PointSize = 5;
            //pltStanje.Plot.Axes.Axes.Bottom.TickLabelStyle

            // setup the bottom axis to use DateTime ticks
            var axis = pltStanje.Plot.Axes.DateTimeTicksBottom();

            // apply our custom tick formatter
            var tickGen = (ScottPlot.TickGenerators.DateTimeAutomatic)axis.TickGenerator;
            tickGen.LabelFormatter = CustomLabelsFormatter;

            pltStanje.Refresh();

            pltStanje.Visible = true;

            dgOcitavanja.ClearSelection();

        }

        // create a custom formatter to return a string with
        // date only when zoomed out and time only when zoomed in
        private string CustomLabelsFormatter(DateTime dt)
        {
            bool isMidnight = dt is { Hour: 0, Minute: 0, Second: 0 };
            return isMidnight
                 ? dt.ToString("dd/MM/yy") // " DateOnly.FromDateTime(dt).ToString()//$"{dt:MMM} '{dt:yyyy}" 
                  : TimeOnly.FromDateTime(dt).ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV Documents (*.csv)|*.csv";
                sfd.FileName = "ocitavanja.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();

                    var headers = dgOcitavanja.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                    foreach (DataGridViewRow row in dgOcitavanja.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                    }

                    var text = sb.ToString();

                    File.WriteAllText(sfd.FileName, text);

                    FormMessages.ShowInformation($"{sfd.FileName} uspešno snimljen.");
                }
            }
            catch (Exception ex)
            {
                FormMessages.ShowError("Došlo je do greške");
            }
        }

        private void btnIzborMernogMesta_Click(object sender, EventArgs e)
        {
            if (frmMernaMestaLookup.Instance().ShowDialog() == DialogResult.OK)
            {
                _SelectedMernoMesto = frmMernaMestaLookup.Instance().SelectedMernoMesto;
                lblMernoMesto.Text = _SelectedMernoMesto.OznakaMernogMesta;
            }
        }

        private void lblMernoMesto_Click(object sender, EventArgs e)
        {
            btnIzborMernogMesta_Click(this, null);
        }

        private void dgOcitavanja_SelectionChanged(object sender, EventArgs e)
        {
            if (xs != null && ys != null && dgOcitavanja.SelectedRows.Count > 0)
            {
                if (selectedDataItemPlotMarker != null)
                {
                    pltStanje.Plot.Remove(selectedDataItemPlotMarker);
                }

                var prikazanaOcitavanja = (bsOcitavanja.DataSource as IList<Ocitavanje>);

                var selectedRowIndex = dgOcitavanja.SelectedRows[0].Index;

                selectedDataItemPlotMarker = pltStanje.Plot.Add.Marker(xs[selectedRowIndex].ToOADate(), ys[selectedRowIndex], shape: MarkerShape.FilledCircle, size: 10, color: Colors.Red);

                //pltStanje.Plot.Axes.AutoScale();

                pltStanje.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = selectedDataItemPlotMarker;
            pltStanje.Plot.Axes.Pan(new PixelOffset(100, 100));

            pltStanje.Refresh();
        }
    }
}