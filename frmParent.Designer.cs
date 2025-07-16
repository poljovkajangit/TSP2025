namespace TSP2025
{
    partial class frmParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            sbStatusBar = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            toplanaToolStripMenuItem = new ToolStripMenuItem();
            oAplikacijiTSP2025ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            izlazToolStripMenuItem = new ToolStripMenuItem();
            mnuOpcije = new ToolStripMenuItem();
            mnuMatičniPodaci = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            izveštajiToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            periodičniToolStripMenuItem = new ToolStripMenuItem();
            potrošnjaToolStripMenuItem = new ToolStripMenuItem();
            dnevnaToolStripMenuItem = new ToolStripMenuItem();
            mnuMesecnaPotrosnja = new ToolStripMenuItem();
            godišnjaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            višegodišnjaToolStripMenuItem = new ToolStripMenuItem();
            pomoćToolStripMenuItem = new ToolStripMenuItem();
            preuzmiPodatkeToolStripMenuItem = new ToolStripMenuItem();
            istorijaPreuzimanjaToolStripMenuItem = new ToolStripMenuItem();
            gbPullOperacija = new GroupBox();
            lblPullStatus = new Label();
            tbPullInfo = new TextBox();
            btnPull = new Button();
            bsMernaMesta = new BindingSource(components);
            tm = new System.Windows.Forms.Timer(components);
            btnDashboard = new Button();
            sbStatusBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            gbPullOperacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            SuspendLayout();
            // 
            // sbStatusBar
            // 
            sbStatusBar.GripStyle = ToolStripGripStyle.Visible;
            sbStatusBar.ImageScalingSize = new Size(24, 24);
            sbStatusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            sbStatusBar.Location = new Point(1, 858);
            sbStatusBar.Name = "sbStatusBar";
            sbStatusBar.Padding = new Padding(1, 0, 10, 0);
            sbStatusBar.Size = new Size(1595, 22);
            sbStatusBar.TabIndex = 0;
            sbStatusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(156, 17);
            toolStripStatusLabel1.Text = "Development Force (C) 2025";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toplanaToolStripMenuItem, mnuOpcije, izveštajiToolStripMenuItem, pomoćToolStripMenuItem });
            menuStrip1.Location = new Point(1, 1);
            menuStrip1.MinimumSize = new Size(0, 25);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1595, 25);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toplanaToolStripMenuItem
            // 
            toplanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikacijiTSP2025ToolStripMenuItem, toolStripMenuItem1, izlazToolStripMenuItem });
            toplanaToolStripMenuItem.Name = "toplanaToolStripMenuItem";
            toplanaToolStripMenuItem.Size = new Size(61, 23);
            toplanaToolStripMenuItem.Text = "Toplana";
            // 
            // oAplikacijiTSP2025ToolStripMenuItem
            // 
            oAplikacijiTSP2025ToolStripMenuItem.Name = "oAplikacijiTSP2025ToolStripMenuItem";
            oAplikacijiTSP2025ToolStripMenuItem.Size = new Size(179, 22);
            oAplikacijiTSP2025ToolStripMenuItem.Text = "O aplikaciji TSP2025";
            oAplikacijiTSP2025ToolStripMenuItem.Click += oAplikacijiTSP2025ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(176, 6);
            // 
            // izlazToolStripMenuItem
            // 
            izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            izlazToolStripMenuItem.Size = new Size(179, 22);
            izlazToolStripMenuItem.Text = "Izlaz";
            izlazToolStripMenuItem.Click += izlazToolStripMenuItem_Click;
            // 
            // mnuOpcije
            // 
            mnuOpcije.DropDownItems.AddRange(new ToolStripItem[] { mnuMatičniPodaci, toolStripMenuItem2 });
            mnuOpcije.Name = "mnuOpcije";
            mnuOpcije.Size = new Size(55, 23);
            mnuOpcije.Text = "Podaci";
            // 
            // mnuMatičniPodaci
            // 
            mnuMatičniPodaci.Image = (Image)resources.GetObject("mnuMatičniPodaci.Image");
            mnuMatičniPodaci.Name = "mnuMatičniPodaci";
            mnuMatičniPodaci.Size = new Size(153, 22);
            mnuMatičniPodaci.Text = "&Matični podaci";
            mnuMatičniPodaci.Click += mnuMatičniPodaci_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(153, 22);
            toolStripMenuItem2.Text = "M&erna mesta";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // izveštajiToolStripMenuItem
            // 
            izveštajiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, potrošnjaToolStripMenuItem });
            izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            izveštajiToolStripMenuItem.Size = new Size(60, 23);
            izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { periodičniToolStripMenuItem });
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(124, 22);
            toolStripMenuItem3.Text = "Stanje";
            // 
            // periodičniToolStripMenuItem
            // 
            periodičniToolStripMenuItem.Name = "periodičniToolStripMenuItem";
            periodičniToolStripMenuItem.Size = new Size(168, 22);
            periodičniToolStripMenuItem.Text = "Za izabrani period";
            periodičniToolStripMenuItem.Click += periodičniToolStripMenuItem_Click;
            // 
            // potrošnjaToolStripMenuItem
            // 
            potrošnjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dnevnaToolStripMenuItem, mnuMesecnaPotrosnja, godišnjaToolStripMenuItem, toolStripMenuItem4, višegodišnjaToolStripMenuItem });
            potrošnjaToolStripMenuItem.Image = (Image)resources.GetObject("potrošnjaToolStripMenuItem.Image");
            potrošnjaToolStripMenuItem.Name = "potrošnjaToolStripMenuItem";
            potrošnjaToolStripMenuItem.Size = new Size(124, 22);
            potrošnjaToolStripMenuItem.Text = "Potrošnja";
            // 
            // dnevnaToolStripMenuItem
            // 
            dnevnaToolStripMenuItem.Name = "dnevnaToolStripMenuItem";
            dnevnaToolStripMenuItem.Size = new Size(140, 22);
            dnevnaToolStripMenuItem.Text = "Dnevna";
            dnevnaToolStripMenuItem.Click += dnevnaToolStripMenuItem_Click;
            // 
            // mnuMesecnaPotrosnja
            // 
            mnuMesecnaPotrosnja.Name = "mnuMesecnaPotrosnja";
            mnuMesecnaPotrosnja.Size = new Size(140, 22);
            mnuMesecnaPotrosnja.Text = "Mesečna";
            mnuMesecnaPotrosnja.Click += mnuMesecnaPotrosnja_Click;
            // 
            // godišnjaToolStripMenuItem
            // 
            godišnjaToolStripMenuItem.Name = "godišnjaToolStripMenuItem";
            godišnjaToolStripMenuItem.Size = new Size(140, 22);
            godišnjaToolStripMenuItem.Text = "Godišnja";
            godišnjaToolStripMenuItem.Click += godišnjaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(137, 6);
            // 
            // višegodišnjaToolStripMenuItem
            // 
            višegodišnjaToolStripMenuItem.Name = "višegodišnjaToolStripMenuItem";
            višegodišnjaToolStripMenuItem.Size = new Size(140, 22);
            višegodišnjaToolStripMenuItem.Text = "Višegodišnja";
            višegodišnjaToolStripMenuItem.Click += višegodišnjaToolStripMenuItem_Click;
            // 
            // pomoćToolStripMenuItem
            // 
            pomoćToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preuzmiPodatkeToolStripMenuItem, istorijaPreuzimanjaToolStripMenuItem });
            pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            pomoćToolStripMenuItem.Size = new Size(96, 23);
            pomoćToolStripMenuItem.Text = "SCADA prenos";
            // 
            // preuzmiPodatkeToolStripMenuItem
            // 
            preuzmiPodatkeToolStripMenuItem.Image = (Image)resources.GetObject("preuzmiPodatkeToolStripMenuItem.Image");
            preuzmiPodatkeToolStripMenuItem.Name = "preuzmiPodatkeToolStripMenuItem";
            preuzmiPodatkeToolStripMenuItem.Size = new Size(189, 22);
            preuzmiPodatkeToolStripMenuItem.Text = "Preuzmi podatke";
            // 
            // istorijaPreuzimanjaToolStripMenuItem
            // 
            istorijaPreuzimanjaToolStripMenuItem.Name = "istorijaPreuzimanjaToolStripMenuItem";
            istorijaPreuzimanjaToolStripMenuItem.Size = new Size(189, 22);
            istorijaPreuzimanjaToolStripMenuItem.Text = "Istorija preuzimanja ...";
            istorijaPreuzimanjaToolStripMenuItem.Click += istorijaPreuzimanjaToolStripMenuItem_Click;
            // 
            // gbPullOperacija
            // 
            gbPullOperacija.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbPullOperacija.BackColor = Color.WhiteSmoke;
            gbPullOperacija.Controls.Add(lblPullStatus);
            gbPullOperacija.Controls.Add(tbPullInfo);
            gbPullOperacija.Controls.Add(btnPull);
            gbPullOperacija.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            gbPullOperacija.ForeColor = Color.Black;
            gbPullOperacija.Location = new Point(1244, 36);
            gbPullOperacija.Margin = new Padding(2);
            gbPullOperacija.Name = "gbPullOperacija";
            gbPullOperacija.Padding = new Padding(2);
            gbPullOperacija.Size = new Size(341, 810);
            gbPullOperacija.TabIndex = 4;
            gbPullOperacija.TabStop = false;
            gbPullOperacija.Text = "Sinhroni prenos ScadaDB podataka";
            // 
            // lblPullStatus
            // 
            lblPullStatus.BackColor = Color.Gainsboro;
            lblPullStatus.BorderStyle = BorderStyle.FixedSingle;
            lblPullStatus.Location = new Point(8, 28);
            lblPullStatus.Name = "lblPullStatus";
            lblPullStatus.Size = new Size(105, 19);
            lblPullStatus.TabIndex = 15;
            lblPullStatus.Text = "ZAUSTAVLJEN";
            lblPullStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPullInfo
            // 
            tbPullInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPullInfo.BackColor = Color.White;
            tbPullInfo.BorderStyle = BorderStyle.FixedSingle;
            tbPullInfo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbPullInfo.Location = new Point(7, 56);
            tbPullInfo.Margin = new Padding(2);
            tbPullInfo.Multiline = true;
            tbPullInfo.Name = "tbPullInfo";
            tbPullInfo.ReadOnly = true;
            tbPullInfo.ScrollBars = ScrollBars.Vertical;
            tbPullInfo.Size = new Size(328, 750);
            tbPullInfo.TabIndex = 12;
            // 
            // btnPull
            // 
            btnPull.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPull.BackColor = SystemColors.Control;
            btnPull.FlatAppearance.BorderColor = Color.Black;
            btnPull.FlatStyle = FlatStyle.Flat;
            btnPull.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPull.ForeColor = Color.Black;
            btnPull.ImageAlign = ContentAlignment.MiddleRight;
            btnPull.Location = new Point(237, 20);
            btnPull.Margin = new Padding(2);
            btnPull.Name = "btnPull";
            btnPull.Size = new Size(98, 32);
            btnPull.TabIndex = 0;
            btnPull.Text = "Pokreni";
            btnPull.UseVisualStyleBackColor = false;
            btnPull.Click += btnPull_Click;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(4, 29);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(130, 27);
            btnDashboard.TabIndex = 10;
            btnDashboard.Text = "btnDashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Visible = false;
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1597, 881);
            Controls.Add(btnDashboard);
            Controls.Add(gbPullOperacija);
            Controls.Add(sbStatusBar);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmParent";
            Padding = new Padding(1);
            Text = "TSP2025 v 1.0";
            WindowState = FormWindowState.Maximized;
            Shown += frmParent_Shown;
            sbStatusBar.ResumeLayout(false);
            sbStatusBar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbPullOperacija.ResumeLayout(false);
            gbPullOperacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip sbStatusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuOpcije;
        private ToolStripMenuItem mnuMatičniPodaci;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem izveštajiToolStripMenuItem;
        private ToolStripMenuItem pomoćToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem preuzmiPodatkeToolStripMenuItem;
        private ToolStripMenuItem istorijaPreuzimanjaToolStripMenuItem;
        private ToolStripMenuItem periodičniToolStripMenuItem;
        private ToolStripMenuItem toplanaToolStripMenuItem;
        private ToolStripMenuItem oAplikacijiTSP2025ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem izlazToolStripMenuItem;
        private GroupBox gbPullOperacija;
        private Button btnPull;
        private BindingSource bsMernaMesta;
        private TextBox tbPullInfo;
        private ToolStripMenuItem potrošnjaToolStripMenuItem;
        private ToolStripMenuItem mnuMesecnaPotrosnja;
        private ToolStripMenuItem dnevnaToolStripMenuItem;
        private ToolStripMenuItem godišnjaToolStripMenuItem;
        private System.Windows.Forms.Timer tm;
        private Label lblPullStatus;
        private UserControls.SmartDateUC dtOdDatuma;
        private Button btnDashboard;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem višegodišnjaToolStripMenuItem;
    }
}