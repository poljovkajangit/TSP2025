namespace TSP2025.Forms
{
    partial class frmDataSourceForReports
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
            btnOk = new Button();
            rbRAM = new RadioButton();
            label1 = new Label();
            rbDB = new RadioButton();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(212, 154);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(69, 33);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // rbRAM
            // 
            rbRAM.AutoSize = true;
            rbRAM.Checked = true;
            rbRAM.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rbRAM.Location = new Point(12, 60);
            rbRAM.Name = "rbRAM";
            rbRAM.Size = new Size(252, 24);
            rbRAM.TabIndex = 2;
            rbRAM.TabStop = true;
            rbRAM.Text = "Random podaci iz RAM memorije";
            rbRAM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 3;
            label1.Text = "Izaberite izvor podataka:";
            // 
            // rbDB
            // 
            rbDB.AutoSize = true;
            rbDB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rbDB.Location = new Point(12, 107);
            rbDB.Name = "rbDB";
            rbDB.Size = new Size(269, 24);
            rbDB.TabIndex = 8;
            rbDB.Text = "Podaci iz SQL Server baze \"TSP2025\"";
            rbDB.UseVisualStyleBackColor = true;
            // 
            // frmDataSourceForReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(289, 199);
            Controls.Add(rbDB);
            Controls.Add(label1);
            Controls.Add(rbRAM);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDataSourceForReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izbor izvora podataka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private RadioButton rbRAM;
        private Label label1;
        private RadioButton rbDB;
    }
}