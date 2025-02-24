using System.Data;
using System.Text;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Reports;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmStanje : Form
    {
        PoslovniSistemDataContext _DataSource;
        public frmStanje(MernoMesto mernoMesto = null)
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();

            bsGrupaMernihMesta.DataSource = _DataSource.SveGrupaMernihMestaSaPocetnimPraznim;
            bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;

            if (mernoMesto != null)
            {
                foreach (var item in bsMernaMesta.List)
                {
                    if ((item as MernoMesto).Id == mernoMesto.Id)
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
            switch (cbProredi.SelectedIndex)
            {
                case 0:
                    bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                    o =>
                    o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                    &&
                    o.Vreme >= dtDanOd.Value.Date
                    &&
                    o.Vreme < dtDanDo.Value.AddDays(1).Date)
                    .ToList();
                    break;
                case 1:
                    bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                    o =>
                    o.Vreme.Minute == 0
                    &&
                    o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                    &&
                    o.Vreme >= dtDanOd.Value.Date
                    &&
                    o.Vreme < dtDanDo.Value.AddDays(1).Date)
                    .ToList();
                    break;
                case 2:
                    bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                    o =>
                    o.Vreme.Date == o.Vreme
                    &&
                    o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                    &&
                    o.Vreme >= dtDanOd.Value.Date
                    &&
                    o.Vreme < dtDanDo.Value.AddDays(1).Date)
                    .ToList();
                    break;
                case 3:
                    if (cbMesec.SelectedIndex > 0)
                    {
                        bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                        o =>
                        o.Vreme.Date.Day == 1 && o.Vreme.Month == cbMesec.SelectedIndex && o.Vreme.Hour == 0 && o.Vreme.Minute == 0
                        &&
                        o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                        &&
                        o.Vreme >= dtDanOd.Value.Date
                        &&
                        o.Vreme < dtDanDo.Value.AddDays(1).Date
                        )
                        .ToList();
                    }
                    else
                    {
                        bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                        o =>
                        o.Vreme.Date.Day == 1 && o.Vreme.Hour == 0 && o.Vreme.Minute == 0
                        &&
                        o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                        &&
                        o.Vreme >= dtDanOd.Value.Date
                        &&
                        o.Vreme < dtDanDo.Value.AddDays(1).Date
                        )
                        .ToList();
                    }
                    break;
            }


            for (int i = 1; i < bsOcitavanja.Count; i++)
            {
                (bsOcitavanja.List as List<Ocitavanje>)[i].Razlika = (bsOcitavanja.List as List<Ocitavanje>)[i].Vrednost - (bsOcitavanja.List as List<Ocitavanje>)[i - 1].Vrednost;
            }

            lblUkupno.Text = "Ukupno: " + bsOcitavanja.Count;

            btnShowGraph.Enabled = true;
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

        private void cbGraph_Click(object sender, EventArgs e)
        {
            var listaRazlika = (bsOcitavanja.List as List<Ocitavanje>).Select(o => (double)o.Razlika).ToList();
            List<string> listaLabela = null;

            switch (cbProredi.SelectedIndex)
            {
                case 0:
                    listaLabela = (bsOcitavanja.List as List<Ocitavanje>).Select(o => o.VremeFormatirano).ToList();
                    break;
                case 1:
                    listaLabela = (bsOcitavanja.List as List<Ocitavanje>).Select(o => o.VremeFormatirano).ToList();
                    break;
                case 2:
                    listaLabela = (bsOcitavanja.List as List<Ocitavanje>).Select(o => o.VremeFormatirano.Substring(0, 8)).ToList();
                    break;
                case 3:
                    listaLabela = (bsOcitavanja.List as List<Ocitavanje>).Select(o => o.MesecGodina).ToList();
                    break;
            }

            var frmGraph = new frmGraph(listaRazlika, listaLabela, (bsMernaMesta.Current as MernoMesto).OznakaMernogMesta);
            frmGraph.ShowDialog();
        }
    }
}
