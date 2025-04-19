namespace TSP2025
{
    partial class frmDnevnaPotrosnja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDnevnaPotrosnja));
            btnPrikazi = new Button();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            pltPotrosnjaMesecena = new ScottPlot.WinForms.FormsPlot();
            statusStrip1 = new StatusStrip();
            lblUkupno = new ToolStripStatusLabel();
            panel1 = new Panel();
            dtDan = new TSP2025.UserControls.SmartDateUC();
            pbGraph = new PictureBox();
            btnClearPlot = new Button();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGraph).BeginInit();
            SuspendLayout();
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(656, 25);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(130, 45);
            btnPrikazi.TabIndex = 3;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.BackColor = Color.White;
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(10, 32);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(381, 33);
            cbMernoMesto.TabIndex = 7;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 9;
            label2.Text = "Merno mesto:";
            // 
            // pltPotrosnjaMesecena
            // 
            pltPotrosnjaMesecena.BorderStyle = BorderStyle.Fixed3D;
            pltPotrosnjaMesecena.DisplayScale = 1.5F;
            pltPotrosnjaMesecena.Dock = DockStyle.Fill;
            pltPotrosnjaMesecena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            pltPotrosnjaMesecena.Location = new Point(0, 86);
            pltPotrosnjaMesecena.Margin = new Padding(4, 5, 4, 5);
            pltPotrosnjaMesecena.Name = "pltPotrosnjaMesecena";
            pltPotrosnjaMesecena.Size = new Size(2530, 954);
            pltPotrosnjaMesecena.TabIndex = 19;
            pltPotrosnjaMesecena.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUkupno });
            statusStrip1.Location = new Point(0, 1040);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(2530, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUkupno
            // 
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(0, 15);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dtDan);
            panel1.Controls.Add(btnPrikazi);
            panel1.Controls.Add(cbMernoMesto);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2530, 86);
            panel1.TabIndex = 21;
            // 
            // dtDan
            // 
            dtDan.BorderStyle = BorderStyle.FixedSingle;
            dtDan.Location = new Point(397, 27);
            dtDan.Name = "dtDan";
            dtDan.SelectedDate = new DateTime(2025, 4, 19, 0, 0, 0, 0);
            dtDan.Size = new Size(254, 42);
            dtDan.TabIndex = 10;
            // 
            // pbGraph
            // 
            pbGraph.BackgroundImage = (Image)resources.GetObject("pbGraph.BackgroundImage");
            pbGraph.BackgroundImageLayout = ImageLayout.Center;
            pbGraph.Dock = DockStyle.Fill;
            pbGraph.InitialImage = null;
            pbGraph.Location = new Point(0, 0);
            pbGraph.Name = "pbGraph";
            pbGraph.Size = new Size(2530, 1062);
            pbGraph.TabIndex = 22;
            pbGraph.TabStop = false;
            // 
            // btnClearPlot
            // 
            btnClearPlot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearPlot.BackgroundImage = (Image)resources.GetObject("btnClearPlot.BackgroundImage");
            btnClearPlot.BackgroundImageLayout = ImageLayout.Stretch;
            btnClearPlot.Location = new Point(2439, 122);
            btnClearPlot.Name = "btnClearPlot";
            btnClearPlot.Size = new Size(64, 63);
            btnClearPlot.TabIndex = 20;
            btnClearPlot.UseVisualStyleBackColor = true;
            btnClearPlot.Visible = false;
            btnClearPlot.Click += btnClearPlot_Click;
            // 
            // frmDnevnaPotrosnja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2530, 1062);
            Controls.Add(btnClearPlot);
            Controls.Add(pltPotrosnjaMesecena);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(pbGraph);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDnevnaPotrosnja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dnevna potrošnja";
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPrikazi;
        private ComboBox cbMernoMesto;
        private BindingSource bsMernaMesta;
        private BindingSource bindingSource1;
        private Label label2;
        private ScottPlot.WinForms.FormsPlot pltPotrosnjaMesecena;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUkupno;
        private Panel panel1;
        private PictureBox pbGraph;
        private Button btnClearPlot;
        private UserControls.SmartDateUC dtDan;
    }
}