namespace TSP2025
{
    partial class frmDodajMernoMesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajMernoMesto));
            btnCancel = new Button();
            btnOk = new Button();
            tbOznakaKalorimetra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rbPodstanica = new RadioButton();
            rbIndividualni = new RadioButton();
            cbGrupeMernihMesta = new ComboBox();
            bsGrupeMernihMesta = new BindingSource(components);
            label4 = new Label();
            pictureBox1 = new PictureBox();
            tbOznakaMernogMesta = new TextBox();
            label3 = new Label();
            tbId = new TextBox();
            groupBox1 = new GroupBox();
            btnTestConnection = new Button();
            label6 = new Label();
            tbScadaKolona = new TextBox();
            label5 = new Label();
            tbScadaTabela = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(111, 383);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Odustani";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(209, 383);
            btnOk.Margin = new Padding(2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 35);
            btnOk.TabIndex = 6;
            btnOk.Text = "Dodaj";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tbOznakaKalorimetra
            // 
            tbOznakaKalorimetra.BackColor = Color.White;
            tbOznakaKalorimetra.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaKalorimetra.Location = new Point(7, 155);
            tbOznakaKalorimetra.Margin = new Padding(2);
            tbOznakaKalorimetra.Name = "tbOznakaKalorimetra";
            tbOznakaKalorimetra.Size = new Size(297, 23);
            tbOznakaKalorimetra.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Oznaka kalorimetar:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 5;
            label2.Text = "Oznaka mernog mesta:";
            // 
            // rbPodstanica
            // 
            rbPodstanica.AutoSize = true;
            rbPodstanica.Checked = true;
            rbPodstanica.Enabled = false;
            rbPodstanica.Location = new Point(106, 26);
            rbPodstanica.Margin = new Padding(2);
            rbPodstanica.Name = "rbPodstanica";
            rbPodstanica.Size = new Size(84, 19);
            rbPodstanica.TabIndex = 8;
            rbPodstanica.TabStop = true;
            rbPodstanica.Text = "Podstanicu";
            rbPodstanica.UseVisualStyleBackColor = true;
            // 
            // rbIndividualni
            // 
            rbIndividualni.AutoSize = true;
            rbIndividualni.Enabled = false;
            rbIndividualni.Location = new Point(104, 49);
            rbIndividualni.Margin = new Padding(2);
            rbIndividualni.Name = "rbIndividualni";
            rbIndividualni.Size = new Size(153, 19);
            rbIndividualni.TabIndex = 9;
            rbIndividualni.Text = "Individualnog potrošača";
            rbIndividualni.UseVisualStyleBackColor = true;
            rbIndividualni.Visible = false;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(7, 198);
            cbGrupeMernihMesta.Margin = new Padding(2);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(297, 23);
            cbGrupeMernihMesta.TabIndex = 3;
            // 
            // bsGrupeMernihMesta
            // 
            bsGrupeMernihMesta.DataMember = "SveGrupaMernihMesta";
            bsGrupeMernihMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 11;
            label4.Text = "Pripada grupi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tbOznakaMernogMesta
            // 
            tbOznakaMernogMesta.BackColor = Color.White;
            tbOznakaMernogMesta.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaMernogMesta.Location = new Point(7, 110);
            tbOznakaMernogMesta.Margin = new Padding(2);
            tbOznakaMernogMesta.Name = "tbOznakaMernogMesta";
            tbOznakaMernogMesta.Size = new Size(297, 23);
            tbOznakaMernogMesta.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(104, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 13;
            label3.Text = "Za:";
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.Control;
            tbId.BorderStyle = BorderStyle.FixedSingle;
            tbId.Enabled = false;
            tbId.Location = new Point(248, 5);
            tbId.Margin = new Padding(2);
            tbId.Name = "tbId";
            tbId.Size = new Size(57, 23);
            tbId.TabIndex = 14;
            tbId.TextAlign = HorizontalAlignment.Center;
            tbId.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTestConnection);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbScadaKolona);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbScadaTabela);
            groupBox1.Location = new Point(8, 221);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(293, 158);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(3, 108);
            btnTestConnection.Margin = new Padding(2);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(116, 41);
            btnTestConnection.TabIndex = 8;
            btnTestConnection.Text = "Test connection ...";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 61);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 15);
            label6.TabIndex = 7;
            label6.Text = "Naziv SCADA kolone u source bazi:";
            // 
            // tbScadaKolona
            // 
            tbScadaKolona.BackColor = Color.White;
            tbScadaKolona.BorderStyle = BorderStyle.FixedSingle;
            tbScadaKolona.Location = new Point(4, 78);
            tbScadaKolona.Margin = new Padding(2);
            tbScadaKolona.Name = "tbScadaKolona";
            tbScadaKolona.Size = new Size(284, 23);
            tbScadaKolona.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 18);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 5;
            label5.Text = "Naziv SCADA tabele u source bazi:";
            // 
            // tbScadaTabela
            // 
            tbScadaTabela.BackColor = Color.White;
            tbScadaTabela.BorderStyle = BorderStyle.FixedSingle;
            tbScadaTabela.Location = new Point(4, 35);
            tbScadaTabela.Margin = new Padding(2);
            tbScadaTabela.Name = "tbScadaTabela";
            tbScadaTabela.Size = new Size(284, 23);
            tbScadaTabela.TabIndex = 4;
            // 
            // frmDodajMernoMesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 425);
            Controls.Add(groupBox1);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(cbGrupeMernihMesta);
            Controls.Add(rbIndividualni);
            Controls.Add(rbPodstanica);
            Controls.Add(label2);
            Controls.Add(tbOznakaMernogMesta);
            Controls.Add(label1);
            Controls.Add(tbOznakaKalorimetra);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDodajMernoMesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj merno mesto";
            Load += frmDodajMernoMesto_Load;
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private TextBox tbOznakaKalorimetra;
        private Label label1;
        private Label label2;
        private RadioButton rbPodstanica;
        private RadioButton rbIndividualni;
        private ComboBox cbGrupeMernihMesta;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox tbOznakaMernogMesta;
        private Label label3;
        private BindingSource bsGrupeMernihMesta;
        private TextBox tbId;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox tbScadaKolona;
        private Label label5;
        private TextBox tbScadaTabela;
        private Button btnTestConnection;
    }
}