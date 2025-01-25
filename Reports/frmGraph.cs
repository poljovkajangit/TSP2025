using System.Windows.Forms;

namespace TSP2025.Reports
{
    public partial class frmGraph : Form
    {
        public frmGraph()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g  = e.Graphics;
            Pen selPen = new Pen(Color.Blue);
            g.DrawRectangle(selPen, 100, 100, 500, 500);

        }
    }
}
