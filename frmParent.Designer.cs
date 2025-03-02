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
            pgrPull = new ToolStripProgressBar();
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
            izveštajiToolStripMenuItem1 = new ToolStripMenuItem();
            trenutniMesecToolStripMenuItem = new ToolStripMenuItem();
            dnevnaToolStripMenuItem = new ToolStripMenuItem();
            godišnjaToolStripMenuItem = new ToolStripMenuItem();
            periodičnoToolStripMenuItem = new ToolStripMenuItem();
            pomoćToolStripMenuItem = new ToolStripMenuItem();
            preuzmiPodatkeToolStripMenuItem = new ToolStripMenuItem();
            istorijaPreuzimanjaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            tbSourceColumn = new TextBox();
            label4 = new Label();
            tbSourceTable = new TextBox();
            label3 = new Label();
            btnTestConnection = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            SuspendLayout();
            // 
            // sbStatusBar
            // 
            sbStatusBar.GripStyle = ToolStripGripStyle.Visible;
            sbStatusBar.ImageScalingSize = new Size(24, 24);
            sbStatusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, pgrPull });
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
            // pgrPull
            // 
            pgrPull.Name = "pgrPull";
            pgrPull.Size = new Size(800, 24);
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
            izveštajiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, izveštajiToolStripMenuItem1 });
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
            // izveštajiToolStripMenuItem1
            // 
            izveštajiToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { trenutniMesecToolStripMenuItem, dnevnaToolStripMenuItem, godišnjaToolStripMenuItem, periodičnoToolStripMenuItem });
            izveštajiToolStripMenuItem1.Name = "izveštajiToolStripMenuItem1";
            izveštajiToolStripMenuItem1.Size = new Size(311, 34);
            izveštajiToolStripMenuItem1.Text = "Potrošnja";
            // 
            // trenutniMesecToolStripMenuItem
            // 
            trenutniMesecToolStripMenuItem.Name = "trenutniMesecToolStripMenuItem";
            trenutniMesecToolStripMenuItem.Size = new Size(231, 34);
            trenutniMesecToolStripMenuItem.Text = "Trenutni mesec";
            trenutniMesecToolStripMenuItem.Click += trenutniMesecToolStripMenuItem_Click;
            // 
            // dnevnaToolStripMenuItem
            // 
            dnevnaToolStripMenuItem.Name = "dnevnaToolStripMenuItem";
            dnevnaToolStripMenuItem.Size = new Size(231, 34);
            dnevnaToolStripMenuItem.Text = "Mesečna";
            dnevnaToolStripMenuItem.Click += dnevnaToolStripMenuItem_Click;
            // 
            // godišnjaToolStripMenuItem
            // 
            godišnjaToolStripMenuItem.Name = "godišnjaToolStripMenuItem";
            godišnjaToolStripMenuItem.Size = new Size(231, 34);
            godišnjaToolStripMenuItem.Text = "Godišnja";
            godišnjaToolStripMenuItem.Click += godišnjaToolStripMenuItem_Click;
            // 
            // periodičnoToolStripMenuItem
            // 
            periodičnoToolStripMenuItem.Name = "periodičnoToolStripMenuItem";
            periodičnoToolStripMenuItem.Size = new Size(231, 34);
            periodičnoToolStripMenuItem.Text = "Periodično";
            periodičnoToolStripMenuItem.Click += periodičnoToolStripMenuItem_Click;
            // 
            // pomoćToolStripMenuItem
            // 
            pomoćToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preuzmiPodatkeToolStripMenuItem, istorijaPreuzimanjaToolStripMenuItem });
            pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            pomoćToolStripMenuItem.Size = new Size(215, 38);
            pomoćToolStripMenuItem.Text = "Sinhornizacija podataka";
            // 
            // preuzmiPodatkeToolStripMenuItem
            // 
            preuzmiPodatkeToolStripMenuItem.Name = "preuzmiPodatkeToolStripMenuItem";
            preuzmiPodatkeToolStripMenuItem.Size = new Size(285, 34);
            preuzmiPodatkeToolStripMenuItem.Text = "Preuzmi podatke";
            preuzmiPodatkeToolStripMenuItem.Click += preuzmiPodatkeToolStripMenuItem_Click;
            // 
            // istorijaPreuzimanjaToolStripMenuItem
            // 
            istorijaPreuzimanjaToolStripMenuItem.Name = "istorijaPreuzimanjaToolStripMenuItem";
            istorijaPreuzimanjaToolStripMenuItem.Size = new Size(285, 34);
            istorijaPreuzimanjaToolStripMenuItem.Text = "Istorija preuzimanja ...";
            istorijaPreuzimanjaToolStripMenuItem.Click += istorijaPreuzimanjaToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2123, 956);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(tbSourceColumn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbSourceTable);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnTestConnection);
            groupBox1.Controls.Add(tbSourceDatabase);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnPull);
            groupBox1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(24, 658);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 353);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pull operacija";
            // 
            // tbSourceColumn
            // 
            tbSourceColumn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceColumn.Location = new Point(181, 229);
            tbSourceColumn.Name = "tbSourceColumn";
            tbSourceColumn.Size = new Size(310, 39);
            tbSourceColumn.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(6, 232);
            label4.Name = "label4";
            label4.Size = new Size(175, 32);
            label4.TabIndex = 8;
            label4.Text = "Source kolona:";
            // 
            // tbSourceTable
            // 
            tbSourceTable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceTable.Location = new Point(181, 184);
            tbSourceTable.Name = "tbSourceTable";
            tbSourceTable.Size = new Size(310, 39);
            tbSourceTable.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(6, 187);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 6;
            label3.Text = "Source tabela:";
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.Teal;
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(6, 288);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(221, 57);
            btnTestConnection.TabIndex = 5;
            btnTestConnection.Text = "Test connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // tbSourceDatabase
            // 
            tbSourceDatabase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceDatabase.Location = new Point(181, 139);
            tbSourceDatabase.Name = "tbSourceDatabase";
            tbSourceDatabase.Size = new Size(309, 39);
            tbSourceDatabase.TabIndex = 4;
            tbSourceDatabase.Text = "TSP2025SCADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(6, 142);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 3;
            label2.Text = "Source baza:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 2;
            label1.Text = "Merno mesto:";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bsMernaMesta;
            comboBox1.DisplayMember = "OznakaMernogMesta";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(485, 40);
            comboBox1.TabIndex = 1;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            bsMernaMesta.CurrentChanged += bsMernaMesta_CurrentChanged;
            // 
            // btnPull
            // 
            btnPull.BackColor = Color.Teal;
            btnPull.FlatStyle = FlatStyle.Flat;
            btnPull.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPull.ForeColor = Color.White;
            btnPull.Location = new Point(360, 288);
            btnPull.Name = "btnPull";
            btnPull.Size = new Size(131, 57);
            btnPull.TabIndex = 0;
            btnPull.Text = "Execute";
            btnPull.UseVisualStyleBackColor = false;
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
            label6.Size = new Size(477, 60);
            label6.TabIndex = 8;
            label6.Text = "... under construction ...";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F);
            label7.Location = new Point(1661, 62);
            label7.Name = "label7";
            label7.Size = new Size(477, 60);
            label7.TabIndex = 9;
            label7.Text = "... under construction ...";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(2159, 1062);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(sbStatusBar);
            Controls.Add(menuStrip1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripProgressBar pgrPull;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem izveštajiToolStripMenuItem;
        private ToolStripMenuItem pomoćToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem preuzmiPodatkeToolStripMenuItem;
        private ToolStripMenuItem istorijaPreuzimanjaToolStripMenuItem;
        private ToolStripMenuItem periodičniToolStripMenuItem;
        private ToolStripMenuItem izveštajiToolStripMenuItem1;
        private ToolStripMenuItem dnevnaToolStripMenuItem;
        private ToolStripMenuItem trenutniMesecToolStripMenuItem;
        private ToolStripMenuItem periodičnoToolStripMenuItem;
        private ToolStripMenuItem godišnjaToolStripMenuItem;
        private ToolStripMenuItem toplanaToolStripMenuItem;
        private ToolStripMenuItem oAplikacijiTSP2025ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem izlazToolStripMenuItem;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnPull;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox tbSourceDatabase;
        private Button btnTestConnection;
        private TextBox tbSourceColumn;
        private Label label4;
        private TextBox tbSourceTable;
        private Label label3;
        private BindingSource bsMernaMesta;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}