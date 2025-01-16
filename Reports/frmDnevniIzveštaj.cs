using System.Data;
using System.Text;
using System.Windows.Forms;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmDnevniIzveštaj : Form
    {
        PoslovniSistemDataContext _DataSource;
        public frmDnevniIzveštaj(MernoMesto mernoMesto = null)
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();

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
                    }
                }
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(o => o.MernoMestoId == (bsMernaMesta.Current as MernoMesto).Id && o.Vreme.Date == dtDan.Value.Date).ToList();
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
