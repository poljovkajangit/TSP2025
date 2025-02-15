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
            sbStatusBar.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sbStatusBar
            // 
            sbStatusBar.GripStyle = ToolStripGripStyle.Visible;
            sbStatusBar.ImageScalingSize = new Size(24, 24);
            sbStatusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, _progressPreuzmi });
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
            toolStripStatusLabel1.Size = new Size(124, 17);
            toolStripStatusLabel1.Text = "Development (C) 2025";
            // 
            // _progressPreuzmi
            // 
            _progressPreuzmi.Name = "_progressPreuzmi";
            _progressPreuzmi.Size = new Size(280, 16);
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
            oAplikacijiTSP2025ToolStripMenuItem.Size = new Size(191, 22);
            oAplikacijiTSP2025ToolStripMenuItem.Text = "O aplikaciji TSP2025 ...";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(188, 6);
            // 
            // izlazToolStripMenuItem
            // 
            izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            izlazToolStripMenuItem.Size = new Size(191, 22);
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
            mnuMatičniPodaci.Name = "mnuMatičniPodaci";
            mnuMatičniPodaci.Size = new Size(206, 22);
            mnuMatičniPodaci.Text = "&Uredi matične podatke ...";
            mnuMatičniPodaci.Click += mnuMatičniPodaci_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(206, 22);
            toolStripMenuItem2.Text = "Merna mesta ...";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // izveštajiToolStripMenuItem
            // 
            izveštajiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, izveštajiToolStripMenuItem1 });
            izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            izveštajiToolStripMenuItem.Size = new Size(60, 23);
            izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { periodičniToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(205, 22);
            toolStripMenuItem3.Text = "Stanje naplatnog registra";
            // 
            // periodičniToolStripMenuItem
            // 
            periodičniToolStripMenuItem.Name = "periodičniToolStripMenuItem";
            periodičniToolStripMenuItem.Size = new Size(127, 22);
            periodičniToolStripMenuItem.Text = "Periodični";
            periodičniToolStripMenuItem.Click += periodičniToolStripMenuItem_Click;
            // 
            // izveštajiToolStripMenuItem1
            // 
            izveštajiToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { trenutniMesecToolStripMenuItem, dnevnaToolStripMenuItem, godišnjaToolStripMenuItem, periodičnoToolStripMenuItem });
            izveštajiToolStripMenuItem1.Name = "izveštajiToolStripMenuItem1";
            izveštajiToolStripMenuItem1.Size = new Size(205, 22);
            izveštajiToolStripMenuItem1.Text = "Potrošnja";
            // 
            // trenutniMesecToolStripMenuItem
            // 
            trenutniMesecToolStripMenuItem.Name = "trenutniMesecToolStripMenuItem";
            trenutniMesecToolStripMenuItem.Size = new Size(155, 22);
            trenutniMesecToolStripMenuItem.Text = "Trenutni mesec";
            // 
            // dnevnaToolStripMenuItem
            // 
            dnevnaToolStripMenuItem.Name = "dnevnaToolStripMenuItem";
            dnevnaToolStripMenuItem.Size = new Size(155, 22);
            dnevnaToolStripMenuItem.Text = "Mesečna";
            dnevnaToolStripMenuItem.Click += dnevnaToolStripMenuItem_Click;
            // 
            // godišnjaToolStripMenuItem
            // 
            godišnjaToolStripMenuItem.Name = "godišnjaToolStripMenuItem";
            godišnjaToolStripMenuItem.Size = new Size(155, 22);
            godišnjaToolStripMenuItem.Text = "Godišnja";
            godišnjaToolStripMenuItem.Click += godišnjaToolStripMenuItem_Click;
            // 
            // periodičnoToolStripMenuItem
            // 
            periodičnoToolStripMenuItem.Name = "periodičnoToolStripMenuItem";
            periodičnoToolStripMenuItem.Size = new Size(155, 22);
            periodičnoToolStripMenuItem.Text = "Periodično";
            // 
            // pomoćToolStripMenuItem
            // 
            pomoćToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preuzmiPodatkeToolStripMenuItem, istorijaPreuzimanjaToolStripMenuItem });
            pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            pomoćToolStripMenuItem.Size = new Size(144, 23);
            pomoćToolStripMenuItem.Text = "Sinhornizacija podataka";
            // 
            // preuzmiPodatkeToolStripMenuItem
            // 
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
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1511, 637);
            Controls.Add(sbStatusBar);
            Controls.Add(menuStrip1);
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
    }
}