namespace TSP2025
{
    partial class frmPotrosnjaGodisnja
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPotrosnjaGodisnja));
            dgOcitavanja = new DataGridView();
            vremeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mernoMestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Razlika = new DataGridViewTextBoxColumn();
            bsOcitavanja = new BindingSource(components);
            label1 = new Label();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            bsGrupaMernihMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            btnExport = new Button();
            label2 = new Label();
            lblUkupno = new Label();
            cbGodina = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgOcitavanja
            // 
            dgOcitavanja.AllowUserToAddRows = false;
            dgOcitavanja.AllowUserToDeleteRows = false;
            dgOcitavanja.AllowUserToResizeRows = false;
            dgOcitavanja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgOcitavanja.AutoGenerateColumns = false;
            dgOcitavanja.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgOcitavanja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgOcitavanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOcitavanja.Columns.AddRange(new DataGridViewColumn[] { vremeDataGridViewTextBoxColumn, mernoMestoDataGridViewTextBoxColumn, Razlika });
            dgOcitavanja.DataSource = bsOcitavanja;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.EnableHeadersVisualStyles = false;
            dgOcitavanja.Location = new Point(12, 160);
            dgOcitavanja.MultiSelect = false;
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersWidth = 32;
            dgOcitavanja.ScrollBars = ScrollBars.Vertical;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(1797, 860);
            dgOcitavanja.TabIndex = 2;
            // 
            // vremeDataGridViewTextBoxColumn
            // 
            vremeDataGridViewTextBoxColumn.DataPropertyName = "VremeFormatirano";
            vremeDataGridViewTextBoxColumn.HeaderText = "Vreme";
            vremeDataGridViewTextBoxColumn.MinimumWidth = 8;
            vremeDataGridViewTextBoxColumn.Name = "vremeDataGridViewTextBoxColumn";
            vremeDataGridViewTextBoxColumn.ReadOnly = true;
            vremeDataGridViewTextBoxColumn.Width = 200;
            // 
            // mernoMestoDataGridViewTextBoxColumn
            // 
            mernoMestoDataGridViewTextBoxColumn.DataPropertyName = "MernoMesto";
            mernoMestoDataGridViewTextBoxColumn.HeaderText = "Merno mesto";
            mernoMestoDataGridViewTextBoxColumn.MinimumWidth = 8;
            mernoMestoDataGridViewTextBoxColumn.Name = "mernoMestoDataGridViewTextBoxColumn";
            mernoMestoDataGridViewTextBoxColumn.Width = 400;
            // 
            // Razlika
            // 
            Razlika.DataPropertyName = "Razlika";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Razlika.DefaultCellStyle = dataGridViewCellStyle4;
            Razlika.HeaderText = "Potrošnja";
            Razlika.MinimumWidth = 8;
            Razlika.Name = "Razlika";
            Razlika.Width = 150;
            // 
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "SvaOcitavanja";
            bsOcitavanja.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "Za godinu:";
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.BackColor = Color.White;
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(12, 117);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(441, 33);
            cbMernoMesto.TabIndex = 7;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // bsGrupaMernihMesta
            // 
            bsGrupaMernihMesta.DataMember = "SveGrupaMernihMestaSaPocetnimPraznim";
            bsGrupaMernihMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(1744, 86);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(64, 64);
            btnExport.TabIndex = 8;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 9;
            label2.Text = "Merno mesto:";
            // 
            // lblUkupno
            // 
            lblUkupno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblUkupno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUkupno.Location = new Point(1331, 1022);
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(477, 32);
            lblUkupno.TabIndex = 14;
            lblUkupno.TextAlign = ContentAlignment.TopRight;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cbGodina.Location = new Point(12, 48);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(171, 33);
            cbGodina.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(459, 117);
            button1.Name = "button1";
            button1.Size = new Size(163, 33);
            button1.TabIndex = 17;
            button1.Text = "Prikaži";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPrikazi_Click;
            // 
            // frmPotrosnjaGodisnja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 1059);
            Controls.Add(button1);
            Controls.Add(cbGodina);
            Controls.Add(lblUkupno);
            Controls.Add(label2);
            Controls.Add(btnExport);
            Controls.Add(cbMernoMesto);
            Controls.Add(label1);
            Controls.Add(dgOcitavanja);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPotrosnjaGodisnja";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Po mesecima u godini";
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgOcitavanja;
        private Label label1;
        private ComboBox cbMernoMesto;
        private BindingSource bsMernaMesta;
        private BindingSource bindingSource1;
        private BindingSource bsGrupaMernihMesta;
        private BindingSource bsOcitavanja;
        private Button btnExport;
        private Label label2;
        private Label lblUkupno;
        private DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mernoMestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Razlika;
        private ComboBox cbGodina;
        private Button button1;
    }
}