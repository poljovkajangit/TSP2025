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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStanje));
            dgOcitavanja = new DataGridView();
            vremeFormatiranoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrednostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsOcitavanja = new BindingSource(components);
            btnPrikazi = new Button();
            bsGrupaMernihMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            btnExport = new Button();
            label3 = new Label();
            cbProredi = new ComboBox();
            label4 = new Label();
            pltStanje = new ScottPlot.WinForms.FormsPlot();
            statusStrip1 = new StatusStrip();
            lblUkupno = new ToolStripStatusLabel();
            pnlFilter = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            dtDanOd = new TSP2025.UserControls.SmartDateUC();
            dtDanDo = new TSP2025.UserControls.SmartDateUC();
            btnIzborMernogMesta = new Button();
            label2 = new Label();
            label1 = new Label();
            lblMernoMesto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            statusStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgOcitavanja
            // 
            dgOcitavanja.AllowUserToAddRows = false;
            dgOcitavanja.AllowUserToDeleteRows = false;
            dgOcitavanja.AllowUserToResizeRows = false;
            dgOcitavanja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            dgOcitavanja.Columns.AddRange(new DataGridViewColumn[] { vremeFormatiranoDataGridViewTextBoxColumn, vrednostDataGridViewTextBoxColumn });
            dgOcitavanja.DataSource = bsOcitavanja;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.EnableHeadersVisualStyles = false;
            dgOcitavanja.Location = new Point(5, 76);
            dgOcitavanja.Margin = new Padding(2);
            dgOcitavanja.MultiSelect = false;
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersVisible = false;
            dgOcitavanja.RowHeadersWidth = 32;
            dgOcitavanja.ScrollBars = ScrollBars.Vertical;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(386, 837);
            dgOcitavanja.TabIndex = 2;
            dgOcitavanja.SelectionChanged += dgOcitavanja_SelectionChanged;
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
            // vrednostDataGridViewTextBoxColumn
            // 
            vrednostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vrednostDataGridViewTextBoxColumn.DataPropertyName = "Vrednost";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            vrednostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            vrednostDataGridViewTextBoxColumn.HeaderText = "Stanje";
            vrednostDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrednostDataGridViewTextBoxColumn.Name = "vrednostDataGridViewTextBoxColumn";
            // 
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "Ocitavanja";
            bsOcitavanja.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(1085, 31);
            btnPrikazi.Margin = new Padding(2);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(91, 31);
            btnPrikazi.TabIndex = 3;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // bsGrupaMernihMesta
            // 
            bsGrupaMernihMesta.DataMember = "SveGrupeMernihMestaSaPocetnimSve";
            bsGrupaMernihMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // btnExport
            // 
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(1834, 10);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(45, 38);
            btnExport.TabIndex = 8;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 9);
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
            cbProredi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbProredi.FormattingEnabled = true;
            cbProredi.ItemHeight = 17;
            cbProredi.Items.AddRange(new object[] { "Prikaži sve", "Samo za pun sat", "Samo za svaki dan u 00 sati i 00 minuta", "Samo za prve dane u mesecu u  00 sati i 00 minuta" });
            cbProredi.Location = new Point(784, 34);
            cbProredi.Margin = new Padding(2);
            cbProredi.Name = "cbProredi";
            cbProredi.Size = new Size(297, 25);
            cbProredi.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(784, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 13;
            label4.Text = "Vremenski odabir:";
            // 
            // pltStanje
            // 
            pltStanje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pltStanje.BorderStyle = BorderStyle.FixedSingle;
            pltStanje.DisplayScale = 1.5F;
            pltStanje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            pltStanje.Location = new Point(399, 76);
            pltStanje.Name = "pltStanje";
            pltStanje.Size = new Size(1492, 837);
            pltStanje.TabIndex = 19;
            pltStanje.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUkupno });
            statusStrip1.Location = new Point(0, 916);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(10, 0, 1, 0);
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1891, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUkupno
            // 
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(0, 17);
            // 
            // pnlFilter
            // 
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(button1);
            pnlFilter.Controls.Add(panel1);
            pnlFilter.Controls.Add(btnIzborMernogMesta);
            pnlFilter.Controls.Add(cbProredi);
            pnlFilter.Controls.Add(label2);
            pnlFilter.Controls.Add(label1);
            pnlFilter.Controls.Add(btnExport);
            pnlFilter.Controls.Add(btnPrikazi);
            pnlFilter.Controls.Add(label4);
            pnlFilter.Controls.Add(lblMernoMesto);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Margin = new Padding(2);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1891, 71);
            pnlFilter.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(1774, 10);
            button1.Name = "button1";
            button1.Size = new Size(55, 38);
            button1.TabIndex = 28;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtDanOd);
            panel1.Controls.Add(dtDanDo);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(398, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 32);
            panel1.TabIndex = 27;
            // 
            // dtDanOd
            // 
            dtDanOd.BackColor = Color.White;
            dtDanOd.Location = new Point(4, 2);
            dtDanOd.Margin = new Padding(1);
            dtDanOd.Name = "dtDanOd";
            dtDanOd.SelectedDate = new DateTime(2025, 5, 1, 0, 0, 0, 0);
            dtDanOd.Size = new Size(178, 29);
            dtDanOd.TabIndex = 19;
            // 
            // dtDanDo
            // 
            dtDanDo.BackColor = Color.White;
            dtDanDo.Location = new Point(200, 2);
            dtDanDo.Margin = new Padding(1);
            dtDanDo.Name = "dtDanDo";
            dtDanDo.SelectedDate = new DateTime(2025, 5, 1, 0, 0, 0, 0);
            dtDanDo.Size = new Size(178, 29);
            dtDanDo.TabIndex = 20;
            // 
            // btnIzborMernogMesta
            // 
            btnIzborMernogMesta.BackgroundImage = (Image)resources.GetObject("btnIzborMernogMesta.BackgroundImage");
            btnIzborMernogMesta.BackgroundImageLayout = ImageLayout.Center;
            btnIzborMernogMesta.Location = new Point(353, 29);
            btnIzborMernogMesta.Name = "btnIzborMernogMesta";
            btnIzborMernogMesta.Size = new Size(38, 32);
            btnIzborMernogMesta.TabIndex = 24;
            btnIzborMernogMesta.UseVisualStyleBackColor = true;
            btnIzborMernogMesta.Click += btnIzborMernogMesta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 26;
            label2.Text = "Period:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 25;
            label1.Text = "Merno mesto:";
            // 
            // lblMernoMesto
            // 
            lblMernoMesto.AutoEllipsis = true;
            lblMernoMesto.BackColor = Color.White;
            lblMernoMesto.BorderStyle = BorderStyle.FixedSingle;
            lblMernoMesto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMernoMesto.Location = new Point(4, 30);
            lblMernoMesto.Name = "lblMernoMesto";
            lblMernoMesto.Size = new Size(344, 29);
            lblMernoMesto.TabIndex = 23;
            lblMernoMesto.TextAlign = ContentAlignment.MiddleLeft;
            lblMernoMesto.Click += lblMernoMesto_Click;
            // 
            // frmStanje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1891, 938);
            Controls.Add(pltStanje);
            Controls.Add(dgOcitavanja);
            Controls.Add(pnlFilter);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmStanje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Očitavanja za merno mesto";
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgOcitavanja;
        private Button btnPrikazi;
        private BindingSource bindingSource1;
        private BindingSource bsGrupaMernihMesta;
        private BindingSource bsOcitavanja;
        private Button btnExport;
        private Label label3;
        private ComboBox cbProredi;
        private Label label4;
        private ScottPlot.WinForms.FormsPlot pltStanje;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUkupno;
        private Panel pnlFilter;
        private UserControls.SmartDateUC dtDanOd;
        private UserControls.SmartDateUC dtDanDo;
        private Label lblMernoMesto;
        private Button btnIzborMernogMesta;
        private DataGridViewTextBoxColumn vremeFormatiranoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrednostDataGridViewTextBoxColumn;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}