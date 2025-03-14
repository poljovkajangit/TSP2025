﻿namespace TSP2025
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
            pomoćToolStripMenuItem = new ToolStripMenuItem();
            preuzmiPodatkeToolStripMenuItem = new ToolStripMenuItem();
            istorijaPreuzimanjaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            tbPullInfo = new TextBox();
            pbPullProgress = new ProgressBar();
            btnPullMernaMestaRefresh = new Button();
            tbSourceColumn = new TextBox();
            label4 = new Label();
            tbSourceTable = new TextBox();
            label3 = new Label();
            btnCheck = new Button();
            tbSourceDatabase = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            btnPull = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            sbStatusBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            SuspendLayout();
            // 
            // sbStatusBar
            // 
            sbStatusBar.GripStyle = ToolStripGripStyle.Visible;
            sbStatusBar.ImageScalingSize = new Size(24, 24);
            sbStatusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            sbStatusBar.Location = new Point(1, 1028);
            sbStatusBar.Name = "sbStatusBar";
            sbStatusBar.Size = new Size(2157, 32);
            sbStatusBar.TabIndex = 0;
            sbStatusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(238, 25);
            toolStripStatusLabel1.Text = "Development Force (C) 2025";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toplanaToolStripMenuItem, mnuOpcije, izveštajiToolStripMenuItem, pomoćToolStripMenuItem });
            menuStrip1.Location = new Point(1, 2);
            menuStrip1.MinimumSize = new Size(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2157, 42);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toplanaToolStripMenuItem
            // 
            toplanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikacijiTSP2025ToolStripMenuItem, toolStripMenuItem1, izlazToolStripMenuItem });
            toplanaToolStripMenuItem.Name = "toplanaToolStripMenuItem";
            toplanaToolStripMenuItem.Size = new Size(89, 38);
            toplanaToolStripMenuItem.Text = "Toplana";
            // 
            // oAplikacijiTSP2025ToolStripMenuItem
            // 
            oAplikacijiTSP2025ToolStripMenuItem.Name = "oAplikacijiTSP2025ToolStripMenuItem";
            oAplikacijiTSP2025ToolStripMenuItem.Size = new Size(290, 34);
            oAplikacijiTSP2025ToolStripMenuItem.Text = "O aplikaciji TSP2025 ...";
            oAplikacijiTSP2025ToolStripMenuItem.Click += oAplikacijiTSP2025ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(287, 6);
            // 
            // izlazToolStripMenuItem
            // 
            izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            izlazToolStripMenuItem.Size = new Size(290, 34);
            izlazToolStripMenuItem.Text = "Izlaz";
            izlazToolStripMenuItem.Click += izlazToolStripMenuItem_Click;
            // 
            // mnuOpcije
            // 
            mnuOpcije.DropDownItems.AddRange(new ToolStripItem[] { mnuMatičniPodaci, toolStripMenuItem2 });
            mnuOpcije.Name = "mnuOpcije";
            mnuOpcije.Size = new Size(80, 38);
            mnuOpcije.Text = "Podaci";
            // 
            // mnuMatičniPodaci
            // 
            mnuMatičniPodaci.Name = "mnuMatičniPodaci";
            mnuMatičniPodaci.Size = new Size(311, 34);
            mnuMatičniPodaci.Text = "&Uredi matične podatke ...";
            mnuMatičniPodaci.Click += mnuMatičniPodaci_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(311, 34);
            toolStripMenuItem2.Text = "Merna mesta ...";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // izveštajiToolStripMenuItem
            // 
            izveštajiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            izveštajiToolStripMenuItem.Size = new Size(90, 38);
            izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { periodičniToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(311, 34);
            toolStripMenuItem3.Text = "Stanje naplatnog registra";
            // 
            // periodičniToolStripMenuItem
            // 
            periodičniToolStripMenuItem.Name = "periodičniToolStripMenuItem";
            periodičniToolStripMenuItem.Size = new Size(190, 34);
            periodičniToolStripMenuItem.Text = "Periodični";
            periodičniToolStripMenuItem.Click += periodičniToolStripMenuItem_Click;
            // 
            // pomoćToolStripMenuItem
            // 
            pomoćToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preuzmiPodatkeToolStripMenuItem, istorijaPreuzimanjaToolStripMenuItem });
            pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            pomoćToolStripMenuItem.Size = new Size(215, 38);
            pomoćToolStripMenuItem.Text = "Sinhornizacija podataka";
            pomoćToolStripMenuItem.Visible = false;
            // 
            // preuzmiPodatkeToolStripMenuItem
            // 
            preuzmiPodatkeToolStripMenuItem.Name = "preuzmiPodatkeToolStripMenuItem";
            preuzmiPodatkeToolStripMenuItem.Size = new Size(285, 34);
            preuzmiPodatkeToolStripMenuItem.Text = "Preuzmi podatke";
            // 
            // istorijaPreuzimanjaToolStripMenuItem
            // 
            istorijaPreuzimanjaToolStripMenuItem.Name = "istorijaPreuzimanjaToolStripMenuItem";
            istorijaPreuzimanjaToolStripMenuItem.Size = new Size(285, 34);
            istorijaPreuzimanjaToolStripMenuItem.Text = "Istorija preuzimanja ...";
            istorijaPreuzimanjaToolStripMenuItem.Click += istorijaPreuzimanjaToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tbPullInfo);
            groupBox1.Controls.Add(pbPullProgress);
            groupBox1.Controls.Add(btnPullMernaMestaRefresh);
            groupBox1.Controls.Add(tbSourceColumn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbSourceTable);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCheck);
            groupBox1.Controls.Add(tbSourceDatabase);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnPull);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(7, 617);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 403);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pull operacija";
            // 
            // tbPullInfo
            // 
            tbPullInfo.BackColor = Color.White;
            tbPullInfo.BorderStyle = BorderStyle.FixedSingle;
            tbPullInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbPullInfo.Location = new Point(6, 255);
            tbPullInfo.Multiline = true;
            tbPullInfo.Name = "tbPullInfo";
            tbPullInfo.ReadOnly = true;
            tbPullInfo.ScrollBars = ScrollBars.Vertical;
            tbPullInfo.Size = new Size(348, 142);
            tbPullInfo.TabIndex = 12;
            // 
            // pbPullProgress
            // 
            pbPullProgress.Location = new Point(362, 379);
            pbPullProgress.Name = "pbPullProgress";
            pbPullProgress.Size = new Size(128, 18);
            pbPullProgress.TabIndex = 11;
            // 
            // btnPullMernaMestaRefresh
            // 
            btnPullMernaMestaRefresh.BackColor = Color.White;
            btnPullMernaMestaRefresh.FlatStyle = FlatStyle.Flat;
            btnPullMernaMestaRefresh.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 200);
            btnPullMernaMestaRefresh.ForeColor = Color.White;
            btnPullMernaMestaRefresh.Image = (Image)resources.GetObject("btnPullMernaMestaRefresh.Image");
            btnPullMernaMestaRefresh.Location = new Point(442, 72);
            btnPullMernaMestaRefresh.Name = "btnPullMernaMestaRefresh";
            btnPullMernaMestaRefresh.Size = new Size(46, 48);
            btnPullMernaMestaRefresh.TabIndex = 10;
            btnPullMernaMestaRefresh.UseVisualStyleBackColor = false;
            btnPullMernaMestaRefresh.Click += btnPullMernaMestaRefresh_Click;
            // 
            // tbSourceColumn
            // 
            tbSourceColumn.BorderStyle = BorderStyle.FixedSingle;
            tbSourceColumn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceColumn.Location = new Point(146, 218);
            tbSourceColumn.Name = "tbSourceColumn";
            tbSourceColumn.Size = new Size(345, 31);
            tbSourceColumn.TabIndex = 9;
            tbSourceColumn.Text = "TP1_1_KUM_SNAGA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 221);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 8;
            label4.Text = "Source kolona:";
            // 
            // tbSourceTable
            // 
            tbSourceTable.BorderStyle = BorderStyle.FixedSingle;
            tbSourceTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceTable.Location = new Point(146, 173);
            tbSourceTable.Name = "tbSourceTable";
            tbSourceTable.Size = new Size(345, 31);
            tbSourceTable.TabIndex = 7;
            tbSourceTable.Text = "TREND_TSTP1_TP1_1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 176);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 6;
            label3.Text = "Source tabela:";
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCheck.BackColor = Color.Teal;
            btnCheck.Font = new Font("Perpetua", 18F, FontStyle.Regular, GraphicsUnit.Point, 200);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(360, 311);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(62, 62);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "?";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnTestConnection_Click;
            // 
            // tbSourceDatabase
            // 
            tbSourceDatabase.BorderStyle = BorderStyle.FixedSingle;
            tbSourceDatabase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbSourceDatabase.Location = new Point(146, 128);
            tbSourceDatabase.Name = "tbSourceDatabase";
            tbSourceDatabase.Size = new Size(344, 31);
            tbSourceDatabase.TabIndex = 4;
            tbSourceDatabase.Text = "TSP2025SCADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 131);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 3;
            label2.Text = "Source baza:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 2;
            label1.Text = "Merno mesto:";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bsMernaMesta;
            comboBox1.DisplayMember = "OznakaMernogMesta";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(432, 33);
            comboBox1.TabIndex = 1;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.CurrentChanged += bsMernaMesta_CurrentChanged;
            // 
            // btnPull
            // 
            btnPull.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPull.BackColor = Color.Teal;
            btnPull.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 200);
            btnPull.ForeColor = Color.White;
            btnPull.Image = (Image)resources.GetObject("btnPull.Image");
            btnPull.Location = new Point(428, 311);
            btnPull.Name = "btnPull";
            btnPull.Size = new Size(62, 62);
            btnPull.TabIndex = 0;
            btnPull.UseVisualStyleBackColor = false;
            btnPull.Click += btnPull_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F);
            label5.Location = new Point(1655, 943);
            label5.Name = "label5";
            label5.Size = new Size(477, 60);
            label5.TabIndex = 6;
            label5.Text = "... under construction ...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 22F);
            label6.Location = new Point(24, 62);
            label6.Name = "label6";
            label6.Size = new Size(191, 60);
            label6.TabIndex = 8;
            label6.Text = "TSP2025";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(1855, 62);
            label7.Name = "label7";
            label7.Size = new Size(277, 48);
            label7.TabIndex = 9;
            label7.Text = "free trial version";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(2159, 1062);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(sbStatusBar);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Padding = new Padding(1, 2, 1, 2);
            Text = "TSP2025 - u razvoju ...";
            WindowState = FormWindowState.Maximized;
            Shown += frmParent_Shown;
            sbStatusBar.ResumeLayout(false);
            sbStatusBar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btnPull;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox tbSourceDatabase;
        private Button btnCheck;
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
    }
}