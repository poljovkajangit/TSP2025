using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using TSP2025.Data;
using TSP2025.Data.Model;
using TSP2025.DB;
using TSP2025.Utils;

namespace TSP2025
{
    public partial class frmParent : Form
    {
        TSP2025DataContext _DataContext;

        public frmParent()
        {
            InitializeComponent();

            _DataContext = new TSP2025DataContext();

            bsMernaMesta.DataSource = _DataContext.SvaMernaMestaSaPocetnimPraznim;
        }
        private void frmParent_Shown(object sender, EventArgs e)
        {
            var signInForm = new frmSignIn();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                signInForm.Close();
            }
            else
            {
                this.Close();
            }
        }
        private void mnuMatičniPodaci_Click(object sender, EventArgs e)
        {
            var _frmMaticniPodaci = new frmMaticniPodaci();
            //_frmMaticniPodaci.MdiParent = this;
            _frmMaticniPodaci.ShowDialog();
        }
        private void zatvoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var _frmMernaMesta = new frmMernaMesta();
            _frmMernaMesta.MdiParent = this;
            _frmMernaMesta.Show();
        }
        private void istorijaPreuzimanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmScadaPrenos().ShowDialog();
        }

        private void periodičniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmStanje = new frmStanje();
            frmStanje.MdiParent = this;
            frmStanje.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ZaustaviPullProces()
        {
            ScadaService.Instance.Stop();
            ScadaService.Instance.ScadaMessage -= Instance_ScadaMessage;

            btnPull.Text = "Pokreni prenos";
            lblPullStatus.Text = "ZAUSTAVLJEN";
            lblPullStatus.BackColor = Color.Gainsboro;
        }

        private void PokreniPullProces()
        {
            _DataContext.ClearSvaMernaMesta();
            ScadaService.Instance.ScadaMessage += Instance_ScadaMessage;
            ScadaService.Instance.Start(_DataContext.SvaMernaMesta.ToList());

            btnPull.Text = "Zaustavi prenos";
            lblPullStatus.Text = "POKRENUT";
            lblPullStatus.BackColor = Color.LightGreen;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            if (btnPull.Text == "Pokreni prenos")
            {
                PokreniPullProces();
            }
            else
            {
                ZaustaviPullProces();
            }
        }

        private void Instance_ScadaMessage(object sender, ScadaService.ScadaMessageEventArgs e)
        {
            AppendPullTextSafe(e.Message, e.MessageType);
        }

        private void AppendPullTextSafe(string text, ScadaMessageType messageType)
        {
            // Check if the call is not the on UI thread
            if (tbPullInfo.InvokeRequired)
            {
                Action safeWrite = delegate
                {
                    AppendPullTextSafe(text, messageType);
                };
                // Executes the safeWrite delegate on the UI thread which owns the tbPullInfo control (underlying window handle)
                tbPullInfo.Invoke(safeWrite);
            }
            else
            {
                tbPullInfo.Text += Environment.NewLine + text;
                tbPullInfo.SelectionStart = tbPullInfo.TextLength;
                tbPullInfo.ScrollToCaret();
            }
        }

        private void oAplikacijiTSP2025ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessages.ShowInformation("TSP2025 Free Trial Version ... under construction ...");
        }

        private void mnuMesecnaPotrosnja_Click(object sender, EventArgs e)
        {
            var frmMesecnaPotrosnja = new frmMesecnaPotrosnja();
            frmMesecnaPotrosnja.ShowDialog();
        }

        private void godišnjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGodisnja = new frmGodisnjaPotrosnja();
            frmGodisnja.ShowDialog();
        }

        private frmDashBoard _frmDashBoard = null;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_frmDashBoard == null)
            {
                _frmDashBoard = new frmDashBoard();
                _frmDashBoard.MdiParent = this;
                _frmDashBoard.Left = 10;
                _frmDashBoard.Top = 10;
                btnDashboard.Visible = false;
                _frmDashBoard.FormClosing += (s, args) => { btnDashboard.Visible = true; };
                _frmDashBoard.Show();
            }
            else
            {
                btnDashboard.Visible = false;
                _frmDashBoard.Show();
                _frmDashBoard.BringToFront();
            }
        }

        private void dnevnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDnevna = new frmDnevnaPotrosnja();
            frmDnevna.ShowDialog();
        }

        private void btnClearAllPull_Click(object sender, EventArgs e)
        {
            ZaustaviPullProces();
            ScadaDb.ClearAllScadaPull();
            tbPullInfo.Text = "Svi preneti SCADA podaci obrisani.";
        }
    }
}
