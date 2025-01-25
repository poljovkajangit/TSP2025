using System.Data;
using System.Text;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmPotrosnjaMesecno : Form
    {
        PoslovniSistemDataContext _DataSource;
        public frmPotrosnjaMesecno(MernoMesto mernoMesto = null)
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
            cbMesec.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var mesec = new DateTime(Convert.ToInt16(cbGodina.Text), cbMesec.SelectedIndex + 1, 1);
            bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(
                o =>
                o.Vreme.Date == o.Vreme
                &&
                o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id
                &&
                o.Vreme >= mesec
                &&
                o.Vreme < mesec.AddMonths(1))
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
