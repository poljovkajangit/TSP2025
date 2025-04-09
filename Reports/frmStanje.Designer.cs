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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStanje));
            dtDanOd = new DateTimePicker();
            dgOcitavanja = new DataGridView();
            vremeFormatiranoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mernoMestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mesecGodinaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrednostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razlikaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            pltStanje = new ScottPlot.WinForms.FormsPlot();
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
            dtDanOd.Location = new Point(8, 23);
            dtDanOd.Margin = new Padding(2, 2, 2, 2);
            dtDanOd.Name = "dtDanOd";
            dtDanOd.Size = new Size(145, 23);
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgOcitavanja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgOcitavanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOcitavanja.Columns.AddRange(new DataGridViewColumn[] { vremeFormatiranoDataGridViewTextBoxColumn, mernoMestoDataGridViewTextBoxColumn, mesecGodinaDataGridViewTextBoxColumn, vrednostDataGridViewTextBoxColumn, razlikaDataGridViewTextBoxColumn });
            dgOcitavanja.DataSource = bsOcitavanja;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.EnableHeadersVisualStyles = false;
            dgOcitavanja.Location = new Point(8, 49);
            dgOcitavanja.Margin = new Padding(2, 2, 2, 2);
            dgOcitavanja.MultiSelect = false;
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersWidth = 32;
            dgOcitavanja.ScrollBars = ScrollBars.Vertical;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(1368, 335);
            dgOcitavanja.TabIndex = 2;
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            vrednostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            vrednostDataGridViewTextBoxColumn.HeaderText = "Stanje";
            vrednostDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrednostDataGridViewTextBoxColumn.Name = "vrednostDataGridViewTextBoxColumn";
            vrednostDataGridViewTextBoxColumn.Width = 150;
            // 
            // razlikaDataGridViewTextBoxColumn
            // 
            razlikaDataGridViewTextBoxColumn.DataPropertyName = "Razlika";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            razlikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            razlikaDataGridViewTextBoxColumn.HeaderText = "Potrošnja";
            razlikaDataGridViewTextBoxColumn.MinimumWidth = 8;
            razlikaDataGridViewTextBoxColumn.Name = "razlikaDataGridViewTextBoxColumn";
            razlikaDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "Ocitavanja";
            bsOcitavanja.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(878, 20);
            btnPrikazi.Margin = new Padding(2, 2, 2, 2);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(91, 27);
            btnPrikazi.TabIndex = 3;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
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
            cbMernoMesto.Location = new Point(321, 23);
            cbMernoMesto.Margin = new Padding(2, 2, 2, 2);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(178, 23);
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
            btnExport.Location = new Point(1331, 7);
            btnExport.Margin = new Padding(2, 2, 2, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(45, 38);
            btnExport.TabIndex = 8;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 9;
            label2.Text = "Merno mesto:";
            // 
            // dtDanDo
            // 
            dtDanDo.CustomFormat = "dd/MM/yyyy";
            dtDanDo.Format = DateTimePickerFormat.Custom;
            dtDanDo.Location = new Point(175, 23);
            dtDanDo.Margin = new Padding(2, 2, 2, 2);
            dtDanDo.Name = "dtDanDo";
            dtDanDo.Size = new Size(143, 23);
            dtDanDo.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 11;
            label3.Text = "-";
            // 
            // cbProredi
            // 
            cbProredi.BackColor = Color.White;
            cbProredi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProredi.FormattingEnabled = true;
            cbProredi.Items.AddRange(new object[] { "Sve", "Po satu", "Pa danu", "Po mesecu" });
            cbProredi.Location = new Point(502, 23);
            cbProredi.Margin = new Padding(2, 2, 2, 2);
            cbProredi.Name = "cbProredi";
            cbProredi.Size = new Size(195, 23);
            cbProredi.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 13;
            label4.Text = "Proredi po:";
            // 
            // lblUkupno
            // 
            lblUkupno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblUkupno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUkupno.Location = new Point(1042, 750);
            lblUkupno.Margin = new Padding(2, 0, 2, 0);
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(334, 19);
            lblUkupno.TabIndex = 14;
            lblUkupno.TextAlign = ContentAlignment.TopRight;
            // 
            // cbMesec
            // 
            cbMesec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesec.FormattingEnabled = true;
            cbMesec.Items.AddRange(new object[] { "", "Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust", "Septembar", "Oktobar", "Novembar", "Decembar" });
            cbMesec.Location = new Point(700, 23);
            cbMesec.Margin = new Padding(2, 2, 2, 2);
            cbMesec.Name = "cbMesec";
            cbMesec.Size = new Size(175, 23);
            cbMesec.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(699, 5);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 17;
            label5.Text = "Mesec:";
            // 
            // btnShowGraph
            // 
            btnShowGraph.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowGraph.Enabled = false;
            btnShowGraph.Image = (Image)resources.GetObject("btnShowGraph.Image");
            btnShowGraph.Location = new Point(1278, 7);
            btnShowGraph.Margin = new Padding(2, 2, 2, 2);
            btnShowGraph.Name = "btnShowGraph";
            btnShowGraph.Size = new Size(45, 38);
            btnShowGraph.TabIndex = 18;
            btnShowGraph.UseVisualStyleBackColor = true;
            btnShowGraph.Visible = false;
            btnShowGraph.Click += cbGraph_Click;
            // 
            // pltStanje
            // 
            pltStanje.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pltStanje.BorderStyle = BorderStyle.Fixed3D;
            pltStanje.DisplayScale = 1.5F;
            pltStanje.Location = new Point(6, 388);
            pltStanje.Margin = new Padding(2, 2, 2, 2);
            pltStanje.Name = "pltStanje";
            pltStanje.Size = new Size(1370, 330);
            pltStanje.TabIndex = 19;
            // 
            // frmStanje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 729);
            Controls.Add(pltStanje);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmStanje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izveštaj o stanju";
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
        private ScottPlot.WinForms.FormsPlot pltStanje;
    }
}