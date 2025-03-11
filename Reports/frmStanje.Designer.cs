namespace TSP2025
{
    partial class frmStanje
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStanje));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtDanOd = new DateTimePicker();
            dgOcitavanja = new DataGridView();
            bsOcitavanja = new BindingSource(components);
            btnPrikazi = new Button();
            label1 = new Label();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            bsGrupaMernihMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            btnExport = new Button();
            label2 = new Label();
            dtDanDo = new DateTimePicker();
            label3 = new Label();
            cbProredi = new ComboBox();
            label4 = new Label();
            lblUkupno = new Label();
            cbMesec = new ComboBox();
            label5 = new Label();
            btnShowGraph = new Button();
            vremeFormatiranoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mernoMestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mesecGodinaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrednostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razlikaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dtDanOd
            // 
            dtDanOd.CustomFormat = "dd/MM/yyyy";
            dtDanOd.Format = DateTimePickerFormat.Custom;
            dtDanOd.Location = new Point(11, 43);
            dtDanOd.Name = "dtDanOd";
            dtDanOd.Size = new Size(205, 31);
            dtDanOd.TabIndex = 0;
            // 
            // dgOcitavanja
            // 
            dgOcitavanja.AllowUserToAddRows = false;
            dgOcitavanja.AllowUserToDeleteRows = false;
            dgOcitavanja.AllowUserToResizeRows = false;
            dgOcitavanja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgOcitavanja.AutoGenerateColumns = false;
            dgOcitavanja.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgOcitavanja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgOcitavanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOcitavanja.Columns.AddRange(new DataGridViewColumn[] { vremeFormatiranoDataGridViewTextBoxColumn, mernoMestoDataGridViewTextBoxColumn, mesecGodinaDataGridViewTextBoxColumn, vrednostDataGridViewTextBoxColumn, razlikaDataGridViewTextBoxColumn });
            dgOcitavanja.DataSource = bsOcitavanja;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.EnableHeadersVisualStyles = false;
            dgOcitavanja.Location = new Point(11, 82);
            dgOcitavanja.MultiSelect = false;
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersWidth = 32;
            dgOcitavanja.ScrollBars = ScrollBars.Vertical;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(1797, 923);
            dgOcitavanja.TabIndex = 2;
            // 
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "Ocitavanja";
            bsOcitavanja.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(1254, 41);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(130, 39);
            btnPrikazi.TabIndex = 3;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 4;
            label1.Text = "Za period:";
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.BackColor = Color.White;
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(459, 43);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(252, 33);
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
            btnExport.Location = new Point(1744, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(64, 64);
            btnExport.TabIndex = 8;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 13);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 9;
            label2.Text = "Merno mesto:";
            // 
            // dtDanDo
            // 
            dtDanDo.CustomFormat = "dd/MM/yyyy";
            dtDanDo.Format = DateTimePickerFormat.Custom;
            dtDanDo.Location = new Point(250, 45);
            dtDanDo.Name = "dtDanDo";
            dtDanDo.Size = new Size(203, 31);
            dtDanDo.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 45);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 11;
            label3.Text = "-";
            // 
            // cbProredi
            // 
            cbProredi.BackColor = Color.White;
            cbProredi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProredi.FormattingEnabled = true;
            cbProredi.Items.AddRange(new object[] { "Sve", "Po satu", "Pa danu", "Po mesecu" });
            cbProredi.Location = new Point(717, 43);
            cbProredi.Name = "cbProredi";
            cbProredi.Size = new Size(277, 33);
            cbProredi.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 15);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 13;
            label4.Text = "Proredi po:";
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
            // cbMesec
            // 
            cbMesec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesec.FormattingEnabled = true;
            cbMesec.Items.AddRange(new object[] { "", "Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust", "Septembar", "Oktobar", "Novembar", "Decembar" });
            cbMesec.Location = new Point(1000, 43);
            cbMesec.Name = "cbMesec";
            cbMesec.Size = new Size(248, 33);
            cbMesec.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1000, 9);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 17;
            label5.Text = "Mesec:";
            // 
            // btnShowGraph
            // 
            btnShowGraph.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowGraph.Enabled = false;
            btnShowGraph.Image = (Image)resources.GetObject("btnShowGraph.Image");
            btnShowGraph.Location = new Point(1668, 12);
            btnShowGraph.Name = "btnShowGraph";
            btnShowGraph.Size = new Size(64, 64);
            btnShowGraph.TabIndex = 18;
            btnShowGraph.UseVisualStyleBackColor = true;
            btnShowGraph.Click += cbGraph_Click;
            // 
            // vremeFormatiranoDataGridViewTextBoxColumn
            // 
            vremeFormatiranoDataGridViewTextBoxColumn.DataPropertyName = "VremeFormatirano";
            vremeFormatiranoDataGridViewTextBoxColumn.HeaderText = "Vreme";
            vremeFormatiranoDataGridViewTextBoxColumn.MinimumWidth = 8;
            vremeFormatiranoDataGridViewTextBoxColumn.Name = "vremeFormatiranoDataGridViewTextBoxColumn";
            vremeFormatiranoDataGridViewTextBoxColumn.ReadOnly = true;
            vremeFormatiranoDataGridViewTextBoxColumn.Width = 150;
            // 
            // mernoMestoDataGridViewTextBoxColumn
            // 
            mernoMestoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mernoMestoDataGridViewTextBoxColumn.DataPropertyName = "MernoMesto";
            mernoMestoDataGridViewTextBoxColumn.HeaderText = "Merno mesto";
            mernoMestoDataGridViewTextBoxColumn.MinimumWidth = 8;
            mernoMestoDataGridViewTextBoxColumn.Name = "mernoMestoDataGridViewTextBoxColumn";
            // 
            // mesecGodinaDataGridViewTextBoxColumn
            // 
            mesecGodinaDataGridViewTextBoxColumn.DataPropertyName = "MesecGodina";
            mesecGodinaDataGridViewTextBoxColumn.HeaderText = "Mesec";
            mesecGodinaDataGridViewTextBoxColumn.MinimumWidth = 8;
            mesecGodinaDataGridViewTextBoxColumn.Name = "mesecGodinaDataGridViewTextBoxColumn";
            mesecGodinaDataGridViewTextBoxColumn.ReadOnly = true;
            mesecGodinaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vrednostDataGridViewTextBoxColumn
            // 
            vrednostDataGridViewTextBoxColumn.DataPropertyName = "Vrednost";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            vrednostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            vrednostDataGridViewTextBoxColumn.HeaderText = "Stanje";
            vrednostDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrednostDataGridViewTextBoxColumn.Name = "vrednostDataGridViewTextBoxColumn";
            vrednostDataGridViewTextBoxColumn.Width = 150;
            // 
            // razlikaDataGridViewTextBoxColumn
            // 
            razlikaDataGridViewTextBoxColumn.DataPropertyName = "Razlika";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            razlikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            razlikaDataGridViewTextBoxColumn.HeaderText = "Potrošnja";
            razlikaDataGridViewTextBoxColumn.MinimumWidth = 8;
            razlikaDataGridViewTextBoxColumn.Name = "razlikaDataGridViewTextBoxColumn";
            razlikaDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmStanje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 1058);
            Controls.Add(btnShowGraph);
            Controls.Add(label5);
            Controls.Add(cbMesec);
            Controls.Add(lblUkupno);
            Controls.Add(label4);
            Controls.Add(cbProredi);
            Controls.Add(label3);
            Controls.Add(dtDanDo);
            Controls.Add(label2);
            Controls.Add(btnExport);
            Controls.Add(cbMernoMesto);
            Controls.Add(label1);
            Controls.Add(btnPrikazi);
            Controls.Add(dgOcitavanja);
            Controls.Add(dtDanOd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStanje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izveštaj o stanju stanju";
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDanOd;
        private DataGridView dgOcitavanja;
        private Button btnPrikazi;
        private Label label1;
        private ComboBox cbMernoMesto;
        private BindingSource bsMernaMesta;
        private BindingSource bindingSource1;
        private BindingSource bsGrupaMernihMesta;
        private BindingSource bsOcitavanja;
        private Button btnExport;
        private Label label2;
        private DateTimePicker dtDanDo;
        private Label label3;
        private ComboBox cbProredi;
        private Label label4;
        private Label lblUkupno;
        private ComboBox cbMesec;
        private Label label5;
        private Button btnShowGraph;
        private DataGridViewTextBoxColumn vremeFormatiranoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mernoMestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mesecGodinaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrednostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razlikaDataGridViewTextBoxColumn;
    }
}