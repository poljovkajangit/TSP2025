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
            pomoćToolStripMenuItem = new ToolStripMenuItem();
            preuzmiPodatkeToolStripMenuItem = new ToolStripMenuItem();
            istorijaPreuzimanjaToolStripMenuItem = new ToolStripMenuItem();
            gbPullOperacija = new GroupBox();
            btnPullOperacijaToggleView = new Button();
            tbPullInfo = new TextBox();
            pbPullProgress = new ProgressBar();
            btnPullMernaMestaRefresh = new Button();
            tbSourceColumn = new TextBox();
            label4 = new Label();
            tbSourceTable = new TextBox();
            label3 = new Label();
            tbSourceDatabase = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            btnPull = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            sbStatusBar.Location = new Point(1, 614);
            sbStatusBar.Name = "sbStatusBar";
            sbStatusBar.Padding = new Padding(1, 0, 10, 0);
            sbStatusBar.Size = new Size(1509, 22);
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
            menuStrip1.Size = new Size(1509, 25);
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
            periodičniToolStripMenuItem.Size = new Size(127, 22);
            periodičniToolStripMenuItem.Text = "Periodični";
            periodičniToolStripMenuItem.Click += periodičniToolStripMenuItem_Click;
            // 
            // potrošnjaToolStripMenuItem
            // 
            potrošnjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dnevnaToolStripMenuItem, mnuMesecnaPotrosnja, godišnjaToolStripMenuItem });
            potrošnjaToolStripMenuItem.Image = (Image)resources.GetObject("potrošnjaToolStripMenuItem.Image");
            potrošnjaToolStripMenuItem.Name = "potrošnjaToolStripMenuItem";
            potrošnjaToolStripMenuItem.Size = new Size(124, 22);
            potrošnjaToolStripMenuItem.Text = "Potrošnja";
            // 
            // dnevnaToolStripMenuItem
            // 
            dnevnaToolStripMenuItem.Name = "dnevnaToolStripMenuItem";
            dnevnaToolStripMenuItem.Size = new Size(121, 22);
            dnevnaToolStripMenuItem.Text = "Dnevna";
            // 
            // mnuMesecnaPotrosnja
            // 
            mnuMesecnaPotrosnja.Name = "mnuMesecnaPotrosnja";
            mnuMesecnaPotrosnja.Size = new Size(121, 22);
            mnuMesecnaPotrosnja.Text = "Mesečna";
            mnuMesecnaPotrosnja.Click += mnuMesecnaPotrosnja_Click;
            // 
            // godišnjaToolStripMenuItem
            // 
            godišnjaToolStripMenuItem.Name = "godišnjaToolStripMenuItem";
            godišnjaToolStripMenuItem.Size = new Size(121, 22);
            godišnjaToolStripMenuItem.Text = "Godišnja";
            godišnjaToolStripMenuItem.Click += godišnjaToolStripMenuItem_Click;
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
            preuzmiPodatkeToolStripMenuItem.Click += preuzmiPodatkeToolStripMenuItem_Click;
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
            gbPullOperacija.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbPullOperacija.BackColor = Color.WhiteSmoke;
            gbPullOperacija.Controls.Add(btnPullOperacijaToggleView);
            gbPullOperacija.Controls.Add(tbPullInfo);
            gbPullOperacija.Controls.Add(pbPullProgress);
            gbPullOperacija.Controls.Add(btnPullMernaMestaRefresh);
            gbPullOperacija.Controls.Add(tbSourceColumn);
            gbPullOperacija.Controls.Add(label4);
            gbPullOperacija.Controls.Add(tbSourceTable);
            gbPullOperacija.Controls.Add(label3);
            gbPullOperacija.Controls.Add(tbSourceDatabase);
            gbPullOperacija.Controls.Add(label2);
            gbPullOperacija.Controls.Add(label1);
            gbPullOperacija.Controls.Add(comboBox1);
            gbPullOperacija.Controls.Add(btnPull);
            gbPullOperacija.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            gbPullOperacija.ForeColor = Color.Black;
            gbPullOperacija.Location = new Point(1158, 28);
            gbPullOperacija.Margin = new Padding(2);
            gbPullOperacija.Name = "gbPullOperacija";
            gbPullOperacija.Padding = new Padding(2);
            gbPullOperacija.Size = new Size(348, 30);
            gbPullOperacija.TabIndex = 4;
            gbPullOperacija.TabStop = false;
            gbPullOperacija.Text = "Prenos SCADA podataka";
            // 
            // btnPullOperacijaToggleView
            // 
            btnPullOperacijaToggleView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPullOperacijaToggleView.FlatStyle = FlatStyle.Flat;
            btnPullOperacijaToggleView.Location = new Point(290, 3);
            btnPullOperacijaToggleView.Margin = new Padding(2);
            btnPullOperacijaToggleView.Name = "btnPullOperacijaToggleView";
            btnPullOperacijaToggleView.Size = new Size(54, 23);
            btnPullOperacijaToggleView.TabIndex = 11;
            btnPullOperacijaToggleView.Text = "Prikaži";
            btnPullOperacijaToggleView.UseVisualStyleBackColor = true;
            btnPullOperacijaToggleView.Click += btnPullOperacijaToggleView_Click;
            // 
            // tbPullInfo
            // 
            tbPullInfo.BackColor = Color.White;
            tbPullInfo.BorderStyle = BorderStyle.FixedSingle;
            tbPullInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbPullInfo.Location = new Point(4, 158);
            tbPullInfo.Margin = new Padding(2);
            tbPullInfo.Multiline = true;
            tbPullInfo.Name = "tbPullInfo";
            tbPullInfo.ReadOnly = true;
            tbPullInfo.ScrollBars = ScrollBars.Vertical;
            tbPullInfo.Size = new Size(292, 79);
            tbPullInfo.TabIndex = 12;
            // 
            // pbPullProgress
            // 
            pbPullProgress.Location = new Point(4, 239);
            pbPullProgress.Margin = new Padding(2);
            pbPullProgress.Name = "pbPullProgress";
            pbPullProgress.Size = new Size(337, 11);
            pbPullProgress.TabIndex = 11;
            // 
            // btnPullMernaMestaRefresh
            // 
            btnPullMernaMestaRefresh.BackColor = SystemColors.Control;
            btnPullMernaMestaRefresh.BackgroundImage = (Image)resources.GetObject("btnPullMernaMestaRefresh.BackgroundImage");
            btnPullMernaMestaRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnPullMernaMestaRefresh.FlatStyle = FlatStyle.Flat;
            btnPullMernaMestaRefresh.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 200);
            btnPullMernaMestaRefresh.ForeColor = Color.White;
            btnPullMernaMestaRefresh.Location = new Point(309, 43);
            btnPullMernaMestaRefresh.Margin = new Padding(2);
            btnPullMernaMestaRefresh.Name = "btnPullMernaMestaRefresh";
            btnPullMernaMestaRefresh.Size = new Size(32, 29);
            btnPullMernaMestaRefresh.TabIndex = 10;
            btnPullMernaMestaRefresh.UseVisualStyleBackColor = false;
            btnPullMernaMestaRefresh.Click += btnPullMernaMestaRefresh_Click;
            // 
            // tbSourceColumn
            // 
            tbSourceColumn.BorderStyle = BorderStyle.FixedSingle;
            tbSourceColumn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceColumn.Location = new Point(102, 131);
            tbSourceColumn.Margin = new Padding(2);
            tbSourceColumn.Name = "tbSourceColumn";
            tbSourceColumn.ReadOnly = true;
            tbSourceColumn.Size = new Size(242, 23);
            tbSourceColumn.TabIndex = 9;
            tbSourceColumn.Text = "TP1_1_KUM_SNAGA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(4, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Source kolona:";
            // 
            // tbSourceTable
            // 
            tbSourceTable.BorderStyle = BorderStyle.FixedSingle;
            tbSourceTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceTable.Location = new Point(102, 104);
            tbSourceTable.Margin = new Padding(2);
            tbSourceTable.Name = "tbSourceTable";
            tbSourceTable.ReadOnly = true;
            tbSourceTable.Size = new Size(242, 23);
            tbSourceTable.TabIndex = 7;
            tbSourceTable.Text = "TREND_TSTP1_TP1_1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4, 106);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Source tabela:";
            // 
            // tbSourceDatabase
            // 
            tbSourceDatabase.BorderStyle = BorderStyle.FixedSingle;
            tbSourceDatabase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbSourceDatabase.Location = new Point(102, 77);
            tbSourceDatabase.Margin = new Padding(2);
            tbSourceDatabase.Name = "tbSourceDatabase";
            tbSourceDatabase.ReadOnly = true;
            tbSourceDatabase.Size = new Size(241, 23);
            tbSourceDatabase.TabIndex = 4;
            tbSourceDatabase.Text = "TSP2025SCADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(4, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Source baza:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Za merno mesto:";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bsMernaMesta;
            comboBox1.DisplayMember = "OznakaMernogMesta";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(4, 46);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 23);
            comboBox1.TabIndex = 1;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.CurrentChanged += bsMernaMesta_CurrentChanged;
            // 
            // btnPull
            // 
            btnPull.BackColor = SystemColors.Control;
            btnPull.BackgroundImage = (Image)resources.GetObject("btnPull.BackgroundImage");
            btnPull.BackgroundImageLayout = ImageLayout.Stretch;
            btnPull.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 200);
            btnPull.ForeColor = Color.White;
            btnPull.Location = new Point(300, 199);
            btnPull.Margin = new Padding(2);
            btnPull.Name = "btnPull";
            btnPull.Size = new Size(43, 37);
            btnPull.TabIndex = 0;
            btnPull.UseVisualStyleBackColor = false;
            btnPull.Click += btnPull_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(1227, 575);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(260, 32);
            label5.TabIndex = 6;
            label5.Text = "... under construction ...";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 22F);
            label6.Location = new Point(8, 517);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 41);
            label6.TabIndex = 8;
            label6.Text = "TSP2025";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(8, 568);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(187, 32);
            label7.TabIndex = 9;
            label7.Text = "free trial version";
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Location = new Point(4, 29);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(64, 64);
            btnDashboard.TabIndex = 11;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1511, 637);
            Controls.Add(btnDashboard);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
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
            Text = "TSP2025 - u razvoju ...";
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
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox tbSourceDatabase;
        private TextBox tbSourceColumn;
        private Label label4;
        private TextBox tbSourceTable;
        private Label label3;
        private BindingSource bsMernaMesta;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnPullMernaMestaRefresh;
        private ProgressBar pbPullProgress;
        private TextBox tbPullInfo;
        private Button btnPullOperacijaToggleView;
        private ToolStripMenuItem potrošnjaToolStripMenuItem;
        private ToolStripMenuItem mnuMesecnaPotrosnja;
        private ToolStripMenuItem dnevnaToolStripMenuItem;
        private ToolStripMenuItem godišnjaToolStripMenuItem;
        private Button btnDashboard;
    }
}