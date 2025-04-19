namespace TSP2025
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            label1 = new Label();
            lblVreme = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblUkupnoOčitavanja = new Label();
            lblBrojOcitavanja = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(663, 55);
            label1.TabIndex = 0;
            label1.Text = "Dashboard - under construction";
            // 
            // lblVreme
            // 
            lblVreme.BackColor = Color.White;
            lblVreme.Dock = DockStyle.Bottom;
            lblVreme.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblVreme.Location = new Point(0, 680);
            lblVreme.Margin = new Padding(4, 0, 4, 0);
            lblVreme.Name = "lblVreme";
            lblVreme.Size = new Size(663, 55);
            lblVreme.TabIndex = 1;
            lblVreme.Text = "HH:mm:ss";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(562, 48);
            label2.TabIndex = 2;
            label2.Text = "Kritični indikator #1 .................. 99%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(541, 48);
            label3.TabIndex = 3;
            label3.Text = "Kritični indikator #2 ............. 101%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(522, 48);
            label4.TabIndex = 4;
            label4.Text = "Kritični indikator #2 ............. 30%";
            // 
            // lblUkupnoOčitavanja
            // 
            lblUkupnoOčitavanja.AutoSize = true;
            lblUkupnoOčitavanja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUkupnoOčitavanja.ForeColor = Color.Green;
            lblUkupnoOčitavanja.Location = new Point(12, 616);
            lblUkupnoOčitavanja.Name = "lblUkupnoOčitavanja";
            lblUkupnoOčitavanja.Size = new Size(322, 48);
            lblUkupnoOčitavanja.TabIndex = 5;
            lblUkupnoOčitavanja.Text = "Ukupno očitavanja:";
            // 
            // lblBrojOcitavanja
            // 
            lblBrojOcitavanja.AutoSize = true;
            lblBrojOcitavanja.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblBrojOcitavanja.ForeColor = Color.Green;
            lblBrojOcitavanja.Location = new Point(330, 578);
            lblBrojOcitavanja.Name = "lblBrojOcitavanja";
            lblBrojOcitavanja.Size = new Size(79, 96);
            lblBrojOcitavanja.TabIndex = 6;
            lblBrojOcitavanja.Text = "1";
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(663, 735);
            Controls.Add(lblBrojOcitavanja);
            Controls.Add(lblUkupnoOčitavanja);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblVreme);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDashBoard";
            StartPosition = FormStartPosition.Manual;
            Text = "Dashboard";
            FormClosing += frmDashBoard_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVreme;
        private System.Windows.Forms.Timer timer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblUkupnoOčitavanja;
        private Label lblBrojOcitavanja;
    }
}