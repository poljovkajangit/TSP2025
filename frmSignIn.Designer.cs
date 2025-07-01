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
            lblUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUsername.Location = new Point(74, 177);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(174, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Korisničko ime:";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(74, 211);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(253, 23);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(74, 286);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(253, 23);
            tbPassword.TabIndex = 1;
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLozinka.Location = new Point(74, 252);
            lblLozinka.Margin = new Padding(2, 0, 2, 0);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(99, 32);
            lblLozinka.TabIndex = 2;
            lblLozinka.Text = "Lozinka:";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.BackColor = SystemColors.ButtonFace;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(370, 487);
            btnOk.Margin = new Padding(2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(130, 46);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // pbPipes
            // 
            pbPipes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPipes.BorderStyle = BorderStyle.Fixed3D;
            pbPipes.Image = (Image)resources.GetObject("pbPipes.Image");
            pbPipes.Location = new Point(0, 0);
            pbPipes.Margin = new Padding(2);
            pbPipes.Name = "pbPipes";
            pbPipes.Size = new Size(402, 545);
            pbPipes.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPipes.TabIndex = 3;
            pbPipes.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(lblLozinka);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Location = new Point(415, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 536);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonFace;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(503, 32);
            label3.TabIndex = 7;
            label3.Text = "v0.99";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonFace;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(503, 31);
            label2.TabIndex = 6;
            label2.Text = "Stara Pazova";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 63);
            label1.TabIndex = 5;
            label1.Text = "Toplana";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(926, 544);
            Controls.Add(pbPipes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dobrodošli";
            ((System.ComponentModel.ISupportInitialize)pbPipes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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