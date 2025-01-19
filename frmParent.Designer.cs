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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            sbStatusBar = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            _progressPreuzmi = new ToolStripProgressBar();
            menuStrip1 = new MenuStrip();
            mnuOpcije = new ToolStripMenuItem();
            mnuMatičniPodaci = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            izveštajiToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            poDanimaToolStripMenuItem = new ToolStripMenuItem();
            poMeseciaToolStripMenuItem = new ToolStripMenuItem();
            periodičniToolStripMenuItem = new ToolStripMenuItem();
            izveštajiToolStripMenuItem1 = new ToolStripMenuItem();
            dnevnaToolStripMenuItem = new ToolStripMenuItem();
            pomoćToolStripMenuItem = new ToolStripMenuItem();
            preuzmiPodatkeToolStripMenuItem = new ToolStripMenuItem();
            istorijaPreuzimanjaToolStripMenuItem = new ToolStripMenuItem();
            sbStatusBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sbStatusBar
            // 
            sbStatusBar.GripStyle = ToolStripGripStyle.Visible;
            sbStatusBar.ImageScalingSize = new Size(24, 24);
            sbStatusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, _progressPreuzmi });
            sbStatusBar.Location = new Point(1, 1215);
            sbStatusBar.Name = "sbStatusBar";
            sbStatusBar.Size = new Size(2156, 32);
            sbStatusBar.TabIndex = 0;
            sbStatusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(190, 25);
            toolStripStatusLabel1.Text = "Development (C) 2025";
            // 
            // _progressPreuzmi
            // 
            _progressPreuzmi.Name = "_progressPreuzmi";
            _progressPreuzmi.Size = new Size(400, 24);
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuOpcije, izveštajiToolStripMenuItem, pomoćToolStripMenuItem });
            menuStrip1.Location = new Point(1, 1);
            menuStrip1.MinimumSize = new Size(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2156, 42);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuOpcije
            // 
            mnuOpcije.DropDownItems.AddRange(new ToolStripItem[] { mnuMatičniPodaci, toolStripMenuItem2 });
            mnuOpcije.Name = "mnuOpcije";
            mnuOpcije.Size = new Size(144, 38);
            mnuOpcije.Text = "Matični podaci";
            // 
            // mnuMatičniPodaci
            // 
            mnuMatičniPodaci.Name = "mnuMatičniPodaci";
            mnuMatičniPodaci.Size = new Size(304, 34);
            mnuMatičniPodaci.Text = "&Uredi podatke ...";
            mnuMatičniPodaci.Click += mnuMatičniPodaci_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(304, 34);
            toolStripMenuItem2.Text = "Pregled mernih mesta ...";
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
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { poDanimaToolStripMenuItem, poMeseciaToolStripMenuItem, periodičniToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(311, 34);
            toolStripMenuItem3.Text = "Stanje naplatnog registra";
            // 
            // poDanimaToolStripMenuItem
            // 
            poDanimaToolStripMenuItem.Name = "poDanimaToolStripMenuItem";
            poDanimaToolStripMenuItem.Size = new Size(190, 34);
            poDanimaToolStripMenuItem.Text = "Dnevni";
            poDanimaToolStripMenuItem.Click += poDanimaToolStripMenuItem_Click;
            // 
            // poMeseciaToolStripMenuItem
            // 
            poMeseciaToolStripMenuItem.Name = "poMeseciaToolStripMenuItem";
            poMeseciaToolStripMenuItem.Size = new Size(190, 34);
            poMeseciaToolStripMenuItem.Text = "Mesečni";
            poMeseciaToolStripMenuItem.Click += poMeseciaToolStripMenuItem_Click;
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
            izveštajiToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { dnevnaToolStripMenuItem });
            izveštajiToolStripMenuItem1.Name = "izveštajiToolStripMenuItem1";
            izveštajiToolStripMenuItem1.Size = new Size(311, 34);
            izveštajiToolStripMenuItem1.Text = "Potrošnja";
            // 
            // dnevnaToolStripMenuItem
            // 
            dnevnaToolStripMenuItem.Name = "dnevnaToolStripMenuItem";
            dnevnaToolStripMenuItem.Size = new Size(174, 34);
            dnevnaToolStripMenuItem.Text = "Dnevna";
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
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(2158, 1248);
            Controls.Add(sbStatusBar);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Padding = new Padding(1);
            Text = "TSP2025 - u razvoju ...";
            WindowState = FormWindowState.Maximized;
            Shown += frmParent_Shown;
            sbStatusBar.ResumeLayout(false);
            sbStatusBar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip sbStatusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuOpcije;
        private ToolStripMenuItem mnuMatičniPodaci;
        private ToolStripProgressBar _progressPreuzmi;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem izveštajiToolStripMenuItem;
        private ToolStripMenuItem pomoćToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem poDanimaToolStripMenuItem;
        private ToolStripMenuItem poMeseciaToolStripMenuItem;
        private ToolStripMenuItem preuzmiPodatkeToolStripMenuItem;
        private ToolStripMenuItem istorijaPreuzimanjaToolStripMenuItem;
        private ToolStripMenuItem periodičniToolStripMenuItem;
        private ToolStripMenuItem izveštajiToolStripMenuItem1;
        private ToolStripMenuItem dnevnaToolStripMenuItem;
    }
}