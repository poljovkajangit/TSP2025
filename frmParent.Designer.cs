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
            toolStripProgressBar1 = new ToolStripProgressBar();
            menuStrip1 = new MenuStrip();
            ackcijeToolStripMenuItem = new ToolStripMenuItem();
            zatvoriToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            zatvoriToolStripMenuItem1 = new ToolStripMenuItem();
            mnuOpcije = new ToolStripMenuItem();
            mnuMatičniPodaci = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            izveštajiToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            poDanimaToolStripMenuItem = new ToolStripMenuItem();
            poMeseciaToolStripMenuItem = new ToolStripMenuItem();
            poGoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            svaOčitavanjaToolStripMenuItem = new ToolStripMenuItem();
            pomoćToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            sbStatusBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sbStatusBar
            // 
            sbStatusBar.GripStyle = ToolStripGripStyle.Visible;
            sbStatusBar.ImageScalingSize = new Size(24, 24);
            sbStatusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
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
            toolStripStatusLabel1.Size = new Size(281, 25);
            toolStripStatusLabel1.Text = "Anonymus Development (C) 2025";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(200, 24);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ackcijeToolStripMenuItem, mnuOpcije, izveštajiToolStripMenuItem, pomoćToolStripMenuItem });
            menuStrip1.Location = new Point(1, 1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2156, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ackcijeToolStripMenuItem
            // 
            ackcijeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zatvoriToolStripMenuItem, toolStripMenuItem5, zatvoriToolStripMenuItem1 });
            ackcijeToolStripMenuItem.Name = "ackcijeToolStripMenuItem";
            ackcijeToolStripMenuItem.Size = new Size(82, 29);
            ackcijeToolStripMenuItem.Text = "Ackcije";
            // 
            // zatvoriToolStripMenuItem
            // 
            zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            zatvoriToolStripMenuItem.Size = new Size(212, 34);
            zatvoriToolStripMenuItem.Text = "Podešavanja";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(209, 6);
            // 
            // zatvoriToolStripMenuItem1
            // 
            zatvoriToolStripMenuItem1.Name = "zatvoriToolStripMenuItem1";
            zatvoriToolStripMenuItem1.Size = new Size(212, 34);
            zatvoriToolStripMenuItem1.Text = "Zatvori";
            zatvoriToolStripMenuItem1.Click += zatvoriToolStripMenuItem1_Click;
            // 
            // mnuOpcije
            // 
            mnuOpcije.DropDownItems.AddRange(new ToolStripItem[] { mnuMatičniPodaci, toolStripMenuItem2 });
            mnuOpcije.Name = "mnuOpcije";
            mnuOpcije.Size = new Size(144, 29);
            mnuOpcije.Text = "Matični podaci";
            // 
            // mnuMatičniPodaci
            // 
            mnuMatičniPodaci.Name = "mnuMatičniPodaci";
            mnuMatičniPodaci.Size = new Size(320, 34);
            mnuMatičniPodaci.Text = "&Uredi podatke o toplani ...";
            mnuMatičniPodaci.Click += mnuMatičniPodaci_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(320, 34);
            toolStripMenuItem2.Text = "Pregled mernih mesta ...";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // izveštajiToolStripMenuItem
            // 
            izveštajiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            izveštajiToolStripMenuItem.Size = new Size(90, 29);
            izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { poDanimaToolStripMenuItem, poMeseciaToolStripMenuItem, poGoToolStripMenuItem, toolStripMenuItem4, svaOčitavanjaToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(311, 34);
            toolStripMenuItem3.Text = "Stanje naplatnog registra";
            // 
            // poDanimaToolStripMenuItem
            // 
            poDanimaToolStripMenuItem.Name = "poDanimaToolStripMenuItem";
            poDanimaToolStripMenuItem.Size = new Size(270, 34);
            poDanimaToolStripMenuItem.Text = "Dnevni";
            poDanimaToolStripMenuItem.Click += poDanimaToolStripMenuItem_Click;
            // 
            // poMeseciaToolStripMenuItem
            // 
            poMeseciaToolStripMenuItem.Name = "poMeseciaToolStripMenuItem";
            poMeseciaToolStripMenuItem.Size = new Size(270, 34);
            poMeseciaToolStripMenuItem.Text = "Mesečni";
            // 
            // poGoToolStripMenuItem
            // 
            poGoToolStripMenuItem.Name = "poGoToolStripMenuItem";
            poGoToolStripMenuItem.Size = new Size(270, 34);
            poGoToolStripMenuItem.Text = "Godišnji";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(267, 6);
            // 
            // svaOčitavanjaToolStripMenuItem
            // 
            svaOčitavanjaToolStripMenuItem.Name = "svaOčitavanjaToolStripMenuItem";
            svaOčitavanjaToolStripMenuItem.Size = new Size(270, 34);
            svaOčitavanjaToolStripMenuItem.Text = "Sva očitavanja";
            // 
            // pomoćToolStripMenuItem
            // 
            pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            pomoćToolStripMenuItem.Size = new Size(83, 29);
            pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(1, 34);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(2156, 90);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(214, 85);
            toolStripButton1.Text = "Preuzmi podatke";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(2158, 1248);
            Controls.Add(toolStrip1);
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip sbStatusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuOpcije;
        private ToolStripMenuItem mnuMatičniPodaci;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem izveštajiToolStripMenuItem;
        private ToolStripMenuItem pomoćToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem poDanimaToolStripMenuItem;
        private ToolStripMenuItem poMeseciaToolStripMenuItem;
        private ToolStripMenuItem poGoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem svaOčitavanjaToolStripMenuItem;
        private ToolStripMenuItem ackcijeToolStripMenuItem;
        private ToolStripMenuItem zatvoriToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem zatvoriToolStripMenuItem1;
    }
}