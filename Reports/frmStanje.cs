using System.ComponentModel.DataAnnotations;
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

        MernoMesto SelectedMernoMesto
        {
            get
            {
                return (bsMernaMesta.Current as MernoMesto)!;
            }
        }

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

            bsGrupaMernihMesta.DataSource = _DataSource.SveGrupeMernihMestaSaPocetnimSve;
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

            cbProredi.SelectedIndex = 0;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (SelectedMernoMesto == null || SelectedMernoMesto.Id == 0)
            {
                return;
            }

            var frmDataSource = new frmDataSourceForReports();
            frmDataSource.ShowDialog();

            var pristunaOcitavanja = OcitavanjaDB.GetSvaOcitavanja(frmDataSource.DataSourceMode, frmDataSource.Godina, frmDataSource.KorakMinutama, _DataSource.SvaMernaMesta);

            switch (cbProredi.SelectedIndex)
            {
                case 0:
                    bsOcitavanja.DataSource = pristunaOcitavanja.Where(
                    o =>
                    o.MernoMestoId == SelectedMernoMesto.Id
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
                    o.MernoMestoId == SelectedMernoMesto.Id
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
                    o.MernoMestoId == SelectedMernoMesto.Id
                    &&
                    o.Vreme >= dtDanOd.SelectedDate.Date
                    &&
                    o.Vreme < dtDanDo.SelectedDate.AddDays(1).Date)
                    .ToList();
                    break;
                case 3:
                    //if (cbMesec.SelectedIndex > 0)
                    //{
                    //    bsOcitavanja.DataSource = _DataSource.SvaOcitavanja(dsMode).Where(
                    //    o =>
                    //    o.Vreme.Date.Day == 1 && o.Vreme.Month == cbMesec.SelectedIndex && o.Vreme.Hour == 0 && o.Vreme.Minute == 0
                    //    &&
                    //    o.MernoMestoId == SelectedMernoMesto.Id
                    //    &&
                    //    o.Vreme >= dtDanOd.SelectedDate!.Value.Date
                    //    &&
                    //    o.Vreme < dtDanDo.SelectedDate!.Value.AddDays(1).Date
                    //    )
                    //    .ToList();
                    //}
                    //else
                    //{
                    bsOcitavanja.DataSource = pristunaOcitavanja.Where(
                    o =>
                    o.Vreme.Date.Day == 1 && o.Vreme.Hour == 0 && o.Vreme.Minute == 0
                    &&
                    o.MernoMestoId == SelectedMernoMesto.Id
                    &&
                    o.Vreme >= dtDanOd.SelectedDate.Date
                    &&
                    o.Vreme < dtDanDo.SelectedDate.AddDays(1).Date
                    )
                    .ToList();
                    //}
                    break;
                case 4:
                case 5:
                    FormMessages.ShowInformation("... under construction ...");
                    return;
            }

            for (int i = 1; i < bsOcitavanja.Count; i++)
            {
                Ocitavanja[i].Razlika = Ocitavanja[i].Vrednost - Ocitavanja[i - 1].Vrednost;
            }

            lblUkupno.Text = "Ukupno: " + bsOcitavanja.Count;

            pltStanje.Plot.Clear();
            // plot data using DateTime values on the horizontal axis
            DateTime[] xs = [.. (bsOcitavanja.DataSource as IList<Ocitavanje>)!.Select(o => o.Vreme)];
            double[] ys = [.. (bsOcitavanja.DataSource as IList<Ocitavanje>)!.Select(o => (double)o.Vrednost)];
            //double[] razlika = [.. (bsOcitavanja.DataSource as IList<Ocitavanje>)!.Select(o => (double)o.Razlika)];
            var mainScatter = pltStanje.Plot.Add.Scatter(xs, ys);
            //double[] ys0 = Generate.Consecutive(xs.Length, ys[0], 0);
            //var projScatter = pltStanje.Plot.Add.Scatter(xs, ys0);


            //var errorbars = pltStanje.Plot.Add.ErrorBar(xs, ys, razlika);
            //errorbars.Color = scatter.Color;

            //var fill = pltStanje.Plot.Add.FillY(mainScatter, projScatter);
            //fill.FillColor = Colors.Blue.WithAlpha(100);
            //fill.LineColor = Colors.Blue;
            //fill.MarkerColor = Colors.Blue;
            //fill.LineWidth = 2;

            // setup the bottom axis to use DateTime ticks
            var axis = pltStanje.Plot.Axes.DateTimeTicksBottom();
            // create a custom formatter to return a string with
            // date only when zoomed out and time only when zoomed in
            static string CustomFormatter(DateTime dt)
            {
                bool isMidnight = dt is { Hour: 0, Minute: 0, Second: 0 };
                return isMidnight
                    ? DateOnly.FromDateTime(dt).ToString()//$"{dt:MMM} '{dt:yyyy}" 
                    : TimeOnly.FromDateTime(dt).ToString();
            }
            // apply our custom tick formatter
            var tickGen = (ScottPlot.TickGenerators.DateTimeAutomatic)axis.TickGenerator;
            tickGen.LabelFormatter = CustomFormatter;


            pltStanje.Refresh();

            pbGraph.Visible = false;
            pltStanje.Visible = true;

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
    }
}
