namespace TSP2025
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            lblUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lblLozinka = new Label();
            btnOk = new Button();
            pbPipes = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPipes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblUsername.Location = new Point(85, 367);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(373, 65);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Korisničko ime:";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(97, 435);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(361, 31);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(97, 547);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(361, 31);
            tbPassword.TabIndex = 1;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLozinka.Location = new Point(83, 479);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(214, 65);
            lblLozinka.TabIndex = 2;
            lblLozinka.Text = "Lozinka:";
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ButtonFace;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(97, 622);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(361, 76);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // pbPipes
            // 
            pbPipes.BorderStyle = BorderStyle.Fixed3D;
            pbPipes.Dock = DockStyle.Left;
            pbPipes.Image = (Image)resources.GetObject("pbPipes.Image");
            pbPipes.Location = new Point(0, 0);
            pbPipes.Name = "pbPipes";
            pbPipes.Size = new Size(590, 1144);
            pbPipes.SizeMode = PictureBoxSizeMode.AutoSize;
            pbPipes.TabIndex = 3;
            pbPipes.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(lblLozinka);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(609, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 1144);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonFace;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 204);
            label3.Name = "label3";
            label3.Size = new Size(677, 52);
            label3.TabIndex = 7;
            label3.Text = "2025";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonFace;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 142);
            label2.Name = "label2";
            label2.Size = new Size(677, 62);
            label2.TabIndex = 6;
            label2.Text = "Stara Pazova";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(677, 142);
            label1.TabIndex = 5;
            label1.Text = "Toplana";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1290, 1144);
            Controls.Add(panel1);
            Controls.Add(pbPipes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pbPipes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblLozinka;
        private Button btnOk;
        private PictureBox pbPipes;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}