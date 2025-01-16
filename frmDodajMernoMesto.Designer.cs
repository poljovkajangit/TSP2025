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
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(155, 461);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 58);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Odustani";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(305, 461);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 58);
            btnOk.TabIndex = 4;
            btnOk.Text = "Dodaj";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tbOznakaKalorimetra
            // 
            tbOznakaKalorimetra.BackColor = Color.White;
            tbOznakaKalorimetra.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaKalorimetra.Location = new Point(16, 302);
            tbOznakaKalorimetra.Name = "tbOznakaKalorimetra";
            tbOznakaKalorimetra.Size = new Size(423, 31);
            tbOznakaKalorimetra.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 273);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 3;
            label1.Text = "Oznaka kalorimetar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 210);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 5;
            label2.Text = "Oznaka mernog mesta:";
            // 
            // rbPodstanica
            // 
            rbPodstanica.AutoSize = true;
            rbPodstanica.Checked = true;
            rbPodstanica.Enabled = false;
            rbPodstanica.Location = new Point(166, 53);
            rbPodstanica.Name = "rbPodstanica";
            rbPodstanica.Size = new Size(123, 29);
            rbPodstanica.TabIndex = 8;
            rbPodstanica.TabStop = true;
            rbPodstanica.Text = "Podstanicu";
            rbPodstanica.UseVisualStyleBackColor = true;
            // 
            // rbIndividualni
            // 
            rbIndividualni.AutoSize = true;
            rbIndividualni.Enabled = false;
            rbIndividualni.Location = new Point(166, 88);
            rbIndividualni.Name = "rbIndividualni";
            rbIndividualni.Size = new Size(230, 29);
            rbIndividualni.TabIndex = 9;
            rbIndividualni.Text = "Individualnog potrošača";
            rbIndividualni.UseVisualStyleBackColor = true;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(16, 364);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(423, 33);
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
            label4.Location = new Point(11, 336);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 11;
            label4.Text = "Pripada grupi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 132);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tbOznakaMernogMesta
            // 
            tbOznakaMernogMesta.BackColor = Color.White;
            tbOznakaMernogMesta.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaMernogMesta.Location = new Point(16, 239);
            tbOznakaMernogMesta.Name = "tbOznakaMernogMesta";
            tbOznakaMernogMesta.Size = new Size(423, 31);
            tbOznakaMernogMesta.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(160, 12);
            label3.Name = "label3";
            label3.Size = new Size(45, 32);
            label3.TabIndex = 13;
            label3.Text = "Za:";
            // 
            // tbId
            // 
            tbId.BackColor = Color.White;
            tbId.BorderStyle = BorderStyle.FixedSingle;
            tbId.Enabled = false;
            tbId.Location = new Point(359, 16);
            tbId.Name = "tbId";
            tbId.Size = new Size(80, 31);
            tbId.TabIndex = 14;
            tbId.TextAlign = HorizontalAlignment.Center;
            // 
            // frmDodajMernoMesto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 531);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDodajMernoMesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pridruži merno mesto";
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}