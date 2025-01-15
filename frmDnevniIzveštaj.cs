using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSP2025.Data;

namespace TSP2025
{
    public partial class frmDnevniIzveštaj : Form
    {
        PoslovniSistemDataContext _DataSource;
        public frmDnevniIzveštaj()
        {
            InitializeComponent();

            _DataSource = new PoslovniSistemDataContext();

            bsGrupaMernihMesta.DataSource = _DataSource.SveGrupaMernihMestaSaPocetnimPraznim;
            //bsMernaMesta.DataSource = _DataSource.SvaMernaMesta;
            bsOcitavanja.DataSource = _DataSource.SvaOcitavanja;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            bsOcitavanja.DataSource = _DataSource.SvaOcitavanja.Where(o => o.MernoMesto == cbMernoMesto.Text).ToList();
        }

        private void frmDnevniIzveštaj_Load(object sender, EventArgs e)
        {

        }
    }
}
