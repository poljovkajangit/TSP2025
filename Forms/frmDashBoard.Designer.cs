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
            label1.Name = "label1";
            label1.Size = new Size(464, 33);
            label1.TabIndex = 0;
            label1.Text = "Dashboard - under construction";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVreme
            // 
            lblVreme.BackColor = Color.White;
            lblVreme.Dock = DockStyle.Bottom;
            lblVreme.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblVreme.Location = new Point(0, 408);
            lblVreme.Name = "lblVreme";
            lblVreme.Size = new Size(464, 33);
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
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 2;
            label2.Text = "Snaga: 100W";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 83);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 32);
            label3.TabIndex = 3;
            label3.Text = "Pritisak u kotlu: 1000Pa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(8, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(260, 32);
            label4.TabIndex = 4;
            label4.Text = "Temperatura kotla: 30C";
            // 
            // lblUkupnoOčitavanja
            // 
            lblUkupnoOčitavanja.BackColor = Color.White;
            lblUkupnoOčitavanja.BorderStyle = BorderStyle.FixedSingle;
            lblUkupnoOčitavanja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUkupnoOčitavanja.ForeColor = Color.Green;
            lblUkupnoOčitavanja.Location = new Point(8, 321);
            lblUkupnoOčitavanja.Margin = new Padding(2, 0, 2, 0);
            lblUkupnoOčitavanja.Name = "lblUkupnoOčitavanja";
            lblUkupnoOčitavanja.Size = new Size(344, 38);
            lblUkupnoOčitavanja.TabIndex = 5;
            lblUkupnoOčitavanja.Text = "Neki kritični rastući broj:";
            // 
            // lblBrojOcitavanja
            // 
            lblBrojOcitavanja.BorderStyle = BorderStyle.FixedSingle;
            lblBrojOcitavanja.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblBrojOcitavanja.ForeColor = Color.Green;
            lblBrojOcitavanja.Location = new Point(359, 321);
            lblBrojOcitavanja.Margin = new Padding(2, 0, 2, 0);
            lblBrojOcitavanja.Name = "lblBrojOcitavanja";
            lblBrojOcitavanja.Size = new Size(94, 78);
            lblBrojOcitavanja.TabIndex = 6;
            lblBrojOcitavanja.Text = "1";
            lblBrojOcitavanja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(464, 441);
            Controls.Add(lblBrojOcitavanja);
            Controls.Add(lblUkupnoOčitavanja);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblVreme);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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