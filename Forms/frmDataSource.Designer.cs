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
            cbGodina = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbKorakMinuti = new ComboBox();
            rbDB = new RadioButton();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(246, 215);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(69, 33);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // rbRAM
            // 
            rbRAM.AutoSize = true;
            rbRAM.Checked = true;
            rbRAM.Location = new Point(12, 60);
            rbRAM.Name = "rbRAM";
            rbRAM.Size = new Size(182, 19);
            rbRAM.TabIndex = 2;
            rbRAM.TabStop = true;
            rbRAM.Text = "Nasumično generisani podaci";
            rbRAM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 3;
            label1.Text = "Izeberite izvor podataka:";
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "3", "4", "5" });
            cbGodina.Location = new Point(133, 85);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(49, 23);
            cbGodina.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 5;
            label2.Text = "Broj godina u nazad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 7;
            label3.Text = "Očitavanje na svakih minuta:";
            // 
            // cbKorakMinuti
            // 
            cbKorakMinuti.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKorakMinuti.FormattingEnabled = true;
            cbKorakMinuti.Items.AddRange(new object[] { "15", "30", "60" });
            cbKorakMinuti.Location = new Point(177, 114);
            cbKorakMinuti.Name = "cbKorakMinuti";
            cbKorakMinuti.Size = new Size(49, 23);
            cbKorakMinuti.TabIndex = 6;
            // 
            // rbDB
            // 
            rbDB.AutoSize = true;
            rbDB.Location = new Point(12, 165);
            rbDB.Name = "rbDB";
            rbDB.Size = new Size(193, 19);
            rbDB.TabIndex = 8;
            rbDB.Text = "Postojeći podaci u bazi TSP2025";
            rbDB.UseVisualStyleBackColor = true;
            // 
            // frmDataSourceForReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(327, 260);
            Controls.Add(rbDB);
            Controls.Add(label3);
            Controls.Add(cbKorakMinuti);
            Controls.Add(label2);
            Controls.Add(cbGodina);
            Controls.Add(label1);
            Controls.Add(rbRAM);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDataSourceForReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izvor podataka?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private RadioButton rbRAM;
        private Label label1;
        private ComboBox cbGodina;
        private Label label2;
        private Label label3;
        private ComboBox cbKorakMinuti;
        private RadioButton rbDB;
    }
}