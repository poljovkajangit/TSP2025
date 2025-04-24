namespace TSP2025
{
    partial class frmMesecnaPotrosnja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesecnaPotrosnja));
            btnPrikazi = new Button();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            cbMesec = new ComboBox();
            label5 = new Label();
            pltPotrosnjaMesecena = new ScottPlot.WinForms.FormsPlot();
            statusStrip1 = new StatusStrip();
            lblUkupno = new ToolStripStatusLabel();
            panel1 = new Panel();
            label1 = new Label();
            cbGodina = new ComboBox();
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
            btnPrikazi.Location = new Point(495, 16);
            btnPrikazi.Margin = new Padding(2, 2, 2, 2);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(91, 27);
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
            cbMernoMesto.Location = new Point(7, 19);
            cbMernoMesto.Margin = new Padding(2, 2, 2, 2);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(268, 23);
            cbMernoMesto.TabIndex = 7;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 9;
            label2.Text = "Merno mesto:";
            // 
            // cbMesec
            // 
            cbMesec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesec.FormattingEnabled = true;
            cbMesec.Items.AddRange(new object[] { "Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust", "Septembar", "Oktobar", "Novembar", "Decembar" });
            cbMesec.Location = new Point(278, 19);
            cbMesec.Margin = new Padding(2, 2, 2, 2);
            cbMesec.Name = "cbMesec";
            cbMesec.Size = new Size(106, 23);
            cbMesec.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 4);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 17;
            label5.Text = "Mesec:";
            // 
            // pltPotrosnjaMesecena
            // 
            pltPotrosnjaMesecena.BorderStyle = BorderStyle.Fixed3D;
            pltPotrosnjaMesecena.DisplayScale = 1.5F;
            pltPotrosnjaMesecena.Dock = DockStyle.Fill;
            pltPotrosnjaMesecena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            pltPotrosnjaMesecena.Location = new Point(0, 53);
            pltPotrosnjaMesecena.Name = "pltPotrosnjaMesecena";
            pltPotrosnjaMesecena.Size = new Size(1771, 562);
            pltPotrosnjaMesecena.TabIndex = 19;
            pltPotrosnjaMesecena.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUkupno });
            statusStrip1.Location = new Point(0, 615);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(10, 0, 1, 0);
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1771, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUkupno
            // 
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(0, 17);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbGodina);
            panel1.Controls.Add(btnPrikazi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbMernoMesto);
            panel1.Controls.Add(cbMesec);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1771, 53);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 19;
            label1.Text = "Godina:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            cbGodina.Location = new Point(386, 19);
            cbGodina.Margin = new Padding(2, 2, 2, 2);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(106, 23);
            cbGodina.TabIndex = 18;
            // 
            // pbGraph
            // 
            pbGraph.BackgroundImage = (Image)resources.GetObject("pbGraph.BackgroundImage");
            pbGraph.BackgroundImageLayout = ImageLayout.Center;
            pbGraph.Dock = DockStyle.Fill;
            pbGraph.InitialImage = null;
            pbGraph.Location = new Point(0, 0);
            pbGraph.Margin = new Padding(2, 2, 2, 2);
            pbGraph.Name = "pbGraph";
            pbGraph.Size = new Size(1771, 637);
            pbGraph.TabIndex = 22;
            pbGraph.TabStop = false;
            // 
            // btnClearPlot
            // 
            btnClearPlot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearPlot.BackgroundImage = (Image)resources.GetObject("btnClearPlot.BackgroundImage");
            btnClearPlot.BackgroundImageLayout = ImageLayout.Stretch;
            btnClearPlot.Location = new Point(1707, 73);
            btnClearPlot.Margin = new Padding(2, 2, 2, 2);
            btnClearPlot.Name = "btnClearPlot";
            btnClearPlot.Size = new Size(45, 38);
            btnClearPlot.TabIndex = 20;
            btnClearPlot.UseVisualStyleBackColor = true;
            btnClearPlot.Visible = false;
            btnClearPlot.Click += btnClearPlot_Click;
            // 
            // frmMesecnaPotrosnja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 637);
            Controls.Add(btnClearPlot);
            Controls.Add(pltPotrosnjaMesecena);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(pbGraph);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmMesecnaPotrosnja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesečna potrošnja";
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
        private ComboBox cbMesec;
        private Label label5;
        private ScottPlot.WinForms.FormsPlot pltPotrosnjaMesecena;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUkupno;
        private Panel panel1;
        private PictureBox pbGraph;
        private Label label1;
        private ComboBox cbGodina;
        private Button btnClearPlot;
    }
}