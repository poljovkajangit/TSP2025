using System.Data;
using System.Text;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmPotrosnjaGodisnja : Form
    {
        PoslovniSistemDataContext _DataSource;
        public frmPotrosnjaGodisnja(MernoMesto mernoMesto = null)
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

            cbGodina.SelectedIndex = 2;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var godina = new DateTime(Convert.ToInt16(cbGodina.Text), 1, 1);
            bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                o =>
                o.Vreme.Year == godina.Year && o.Vreme.Date.Day == 1 && o.Vreme.Date.Hour == 0 && o.Vreme.Minute == 0 && o.Vreme.Second == 0
                &&
                o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                &&
                o.Vreme >= godina
                &&
                o.Vreme < godina.AddYears(1))
                .ToList();

            for (int i = 1; i < bsOcitavanja.Count; i++)
            {
                (bsOcitavanja.List as List<Ocitavanje>)[i].Razlika = (bsOcitavanja.List as List<Ocitavanje>)[i].Vrednost - (bsOcitavanja.List as List<Ocitavanje>)[i - 1].Vrednost;
            }

            lblUkupno.Text = "Ukupno: " + bsOcitavanja.Count;
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
