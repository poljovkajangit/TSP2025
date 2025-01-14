using TSP2025.Data;

namespace TSP2025
{
    public partial class frmDodajMernoMesto : Form
    {
        public frmDodajMernoMesto(string oznakaMernogMesta, int tip, PoslovniSistemDataContext dataSource)
        {
            InitializeComponent();

            tbOznakaMernogMesta.Text = oznakaMernogMesta;
            switch (tip)
            {
                case 0:
                    rbPodstanica.Checked = true;
                    rbIndividualni.Checked = false;
                    rbPodstanica.Visible = true;
                    rbIndividualni.Visible = false;
                    break;
                case 1:
                    rbPodstanica.Checked = false;
                    rbIndividualni.Checked = true;
                    rbPodstanica.Visible = false;
                    rbIndividualni.Visible = true;
                    break;
            }

            bsGrupeMernihMesta.DataSource = dataSource;
        }

        private void frmDodajMernoMesto_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
