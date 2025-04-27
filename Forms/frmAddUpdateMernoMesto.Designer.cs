
namespace TSP2025
{
    partial class frmAddUpdateMernoMesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateMernoMesto));
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
            tbPotrosacId = new TextBox();
            groupBox1 = new GroupBox();
            btnTestConnection = new Button();
            label6 = new Label();
            tbScadaKolona = new TextBox();
            label5 = new Label();
            tbScadaTabela = new TextBox();
            label3 = new Label();
            tbIdMernogMesta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(110, 404);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 35);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Odustani";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(208, 404);
            btnOk.Margin = new Padding(2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 35);
            btnOk.TabIndex = 5;
            btnOk.Text = "Sačuvaj";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tbOznakaKalorimetra
            // 
            tbOznakaKalorimetra.BackColor = Color.White;
            tbOznakaKalorimetra.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaKalorimetra.Location = new Point(12, 164);
            tbOznakaKalorimetra.Margin = new Padding(2);
            tbOznakaKalorimetra.Name = "tbOznakaKalorimetra";
            tbOznakaKalorimetra.Size = new Size(284, 23);
            tbOznakaKalorimetra.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 145);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Oznaka kalorimetar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 99);
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
            rbPodstanica.Location = new Point(105, 10);
            rbPodstanica.Margin = new Padding(2);
            rbPodstanica.Name = "rbPodstanica";
            rbPodstanica.Size = new Size(83, 19);
            rbPodstanica.TabIndex = 8;
            rbPodstanica.TabStop = true;
            rbPodstanica.Text = "Podstanica";
            rbPodstanica.UseVisualStyleBackColor = true;
            // 
            // rbIndividualni
            // 
            rbIndividualni.AutoSize = true;
            rbIndividualni.Enabled = false;
            rbIndividualni.Location = new Point(105, 34);
            rbIndividualni.Margin = new Padding(2);
            rbIndividualni.Name = "rbIndividualni";
            rbIndividualni.Size = new Size(136, 19);
            rbIndividualni.TabIndex = 9;
            rbIndividualni.Text = "Individualni potrošač";
            rbIndividualni.UseVisualStyleBackColor = true;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(12, 210);
            cbGrupeMernihMesta.Margin = new Padding(2);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(285, 23);
            cbGrupeMernihMesta.TabIndex = 3;
            cbGrupeMernihMesta.ValueMember = "Id";
            // 
            // bsGrupeMernihMesta
            // 
            bsGrupeMernihMesta.DataMember = "SveGrupeMernihMesta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 191);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 11;
            label4.Text = "Pripada grupi:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tbOznakaMernogMesta
            // 
            tbOznakaMernogMesta.BackColor = Color.White;
            tbOznakaMernogMesta.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaMernogMesta.Location = new Point(12, 118);
            tbOznakaMernogMesta.Margin = new Padding(2);
            tbOznakaMernogMesta.Name = "tbOznakaMernogMesta";
            tbOznakaMernogMesta.Size = new Size(284, 23);
            tbOznakaMernogMesta.TabIndex = 1;
            // 
            // tbPotrosacId
            // 
            tbPotrosacId.BackColor = Color.White;
            tbPotrosacId.BorderStyle = BorderStyle.FixedSingle;
            tbPotrosacId.Enabled = false;
            tbPotrosacId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbPotrosacId.Location = new Point(245, 6);
            tbPotrosacId.Margin = new Padding(2);
            tbPotrosacId.Name = "tbPotrosacId";
            tbPotrosacId.ReadOnly = true;
            tbPotrosacId.Size = new Size(57, 23);
            tbPotrosacId.TabIndex = 14;
            tbPotrosacId.TextAlign = HorizontalAlignment.Center;
            tbPotrosacId.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTestConnection);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbScadaKolona);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbScadaTabela);
            groupBox1.Location = new Point(8, 240);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(293, 158);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SCADA";
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(4, 115);
            btnTestConnection.Margin = new Padding(2);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(127, 36);
            btnTestConnection.TabIndex = 2;
            btnTestConnection.Text = "Proveri konekciju ...";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 67);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 7;
            label6.Text = "Naziv kolone u source bazi:";
            // 
            // tbScadaKolona
            // 
            tbScadaKolona.BackColor = Color.White;
            tbScadaKolona.BorderStyle = BorderStyle.FixedSingle;
            tbScadaKolona.Location = new Point(4, 86);
            tbScadaKolona.Margin = new Padding(2);
            tbScadaKolona.Name = "tbScadaKolona";
            tbScadaKolona.Size = new Size(284, 23);
            tbScadaKolona.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 21);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 5;
            label5.Text = "Naziv tabele u source bazi:";
            // 
            // tbScadaTabela
            // 
            tbScadaTabela.BackColor = Color.White;
            tbScadaTabela.BorderStyle = BorderStyle.FixedSingle;
            tbScadaTabela.Location = new Point(4, 40);
            tbScadaTabela.Margin = new Padding(2);
            tbScadaTabela.Name = "tbScadaTabela";
            tbScadaTabela.Size = new Size(284, 23);
            tbScadaTabela.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 66);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 16;
            label3.Text = "Auto ID:";
            // 
            // tbIdMernogMesta
            // 
            tbIdMernogMesta.BackColor = Color.White;
            tbIdMernogMesta.BorderStyle = BorderStyle.FixedSingle;
            tbIdMernogMesta.Enabled = false;
            tbIdMernogMesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbIdMernogMesta.Location = new Point(160, 63);
            tbIdMernogMesta.Margin = new Padding(2);
            tbIdMernogMesta.Name = "tbIdMernogMesta";
            tbIdMernogMesta.ReadOnly = true;
            tbIdMernogMesta.Size = new Size(57, 23);
            tbIdMernogMesta.TabIndex = 17;
            tbIdMernogMesta.TextAlign = HorizontalAlignment.Center;
            // 
            // frmAddUpdateMernoMesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(311, 444);
            Controls.Add(tbIdMernogMesta);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(tbPotrosacId);
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
            Name = "frmAddUpdateMernoMesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Merno mesto";
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
        private BindingSource bsGrupeMernihMesta;
        private TextBox tbPotrosacId;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox tbScadaKolona;
        private Label label5;
        private TextBox tbScadaTabela;
        private Button btnTestConnection;
        private Label label3;
        private TextBox tbIdMernogMesta;
    }
}