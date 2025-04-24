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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStanje));
            dgOcitavanja = new DataGridView();
            vremeFormatiranoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mernoMestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mesecGodinaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrednostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            razlikaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsOcitavanja = new BindingSource(components);
            btnPrikazi = new Button();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            bsGrupaMernihMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            btnExport = new Button();
            label2 = new Label();
            label3 = new Label();
            cbProredi = new ComboBox();
            label4 = new Label();
            pltStanje = new ScottPlot.WinForms.FormsPlot();
            statusStrip1 = new StatusStrip();
            lblUkupno = new ToolStripStatusLabel();
            panel1 = new Panel();
            label1 = new Label();
            dtDanDo = new TSP2025.UserControls.SmartDateUC();
            dtDanOd = new TSP2025.UserControls.SmartDateUC();
            pbGraph = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGraph).BeginInit();
            SuspendLayout();
            // 
            // dgOcitavanja
            // 
            dgOcitavanja.AllowUserToAddRows = false;
            dgOcitavanja.AllowUserToDeleteRows = false;
            dgOcitavanja.AllowUserToResizeRows = false;
            dgOcitavanja.AutoGenerateColumns = false;
            dgOcitavanja.BackgroundColor = Color.LightGray;
            dgOcitavanja.BorderStyle = BorderStyle.None;
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
            dgOcitavanja.Dock = DockStyle.Top;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.EnableHeadersVisualStyles = false;
            dgOcitavanja.Location = new Point(0, 87);
            dgOcitavanja.MultiSelect = false;
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersVisible = false;
            dgOcitavanja.RowHeadersWidth = 32;
            dgOcitavanja.ScrollBars = ScrollBars.Vertical;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(2167, 335);
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
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "Ocitavanja";
            bsOcitavanja.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(1419, 21);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(130, 45);
            btnPrikazi.TabIndex = 3;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.BackColor = Color.White;
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(760, 26);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(253, 33);
            cbMernoMesto.TabIndex = 7;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // bsGrupaMernihMesta
            // 
            bsGrupaMernihMesta.DataMember = "SveGrupeMernihMestaSaPocetnimSve";
            bsGrupaMernihMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(2089, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(64, 63);
            btnExport.TabIndex = 8;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(631, 30);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 9;
            label2.Text = "Merno mesto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 30);
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
            cbProredi.Items.AddRange(new object[] { "dd/mm/yy hh:mm", "dd/mm/yy hh:00", "dd/mm/yy 00:00", "01/mm/yy 00:00", "-01/01/yy 00:00", "-dd/mm/yy hh:00..15..30..45" });
            cbProredi.Location = new Point(1164, 26);
            cbProredi.Name = "cbProredi";
            cbProredi.Size = new Size(249, 33);
            cbProredi.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1019, 29);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 13;
            label4.Text = "Format datuma:";
            // 
            // pltStanje
            // 
            pltStanje.BorderStyle = BorderStyle.Fixed3D;
            pltStanje.DisplayScale = 1.5F;
            pltStanje.Dock = DockStyle.Fill;
            pltStanje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            pltStanje.Location = new Point(0, 422);
            pltStanje.Margin = new Padding(4, 5, 4, 5);
            pltStanje.Name = "pltStanje";
            pltStanje.Size = new Size(2167, 706);
            pltStanje.TabIndex = 19;
            pltStanje.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUkupno });
            statusStrip1.Location = new Point(0, 1128);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(2167, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUkupno
            // 
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(0, 15);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtDanDo);
            panel1.Controls.Add(dtDanOd);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnPrikazi);
            panel1.Controls.Add(cbMernoMesto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbProredi);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2167, 87);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 21;
            label1.Text = "Period:";
            // 
            // dtDanDo
            // 
            dtDanDo.BorderStyle = BorderStyle.FixedSingle;
            dtDanDo.Location = new Point(371, 21);
            dtDanDo.Name = "dtDanDo";
            dtDanDo.SelectedDate = new DateTime(2025, 4, 19, 0, 0, 0, 0);
            dtDanDo.Size = new Size(254, 41);
            dtDanDo.TabIndex = 20;
            // 
            // dtDanOd
            // 
            dtDanOd.BorderStyle = BorderStyle.FixedSingle;
            dtDanOd.Location = new Point(85, 21);
            dtDanOd.Name = "dtDanOd";
            dtDanOd.SelectedDate = new DateTime(2025, 4, 19, 0, 0, 0, 0);
            dtDanOd.Size = new Size(254, 41);
            dtDanOd.TabIndex = 19;
            // 
            // pbGraph
            // 
            pbGraph.BackgroundImage = (Image)resources.GetObject("pbGraph.BackgroundImage");
            pbGraph.BackgroundImageLayout = ImageLayout.Zoom;
            pbGraph.Dock = DockStyle.Fill;
            pbGraph.InitialImage = null;
            pbGraph.Location = new Point(0, 422);
            pbGraph.Name = "pbGraph";
            pbGraph.Size = new Size(2167, 706);
            pbGraph.TabIndex = 22;
            pbGraph.TabStop = false;
            // 
            // frmStanje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2167, 1150);
            Controls.Add(pbGraph);
            Controls.Add(pltStanje);
            Controls.Add(statusStrip1);
            Controls.Add(dgOcitavanja);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStanje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izveštaj o stanju";
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgOcitavanja;
        private Button btnPrikazi;
        private ComboBox cbMernoMesto;
        private BindingSource bsMernaMesta;
        private BindingSource bindingSource1;
        private BindingSource bsGrupaMernihMesta;
        private BindingSource bsOcitavanja;
        private Button btnExport;
        private Label label2;
        private Label label3;
        private ComboBox cbProredi;
        private Label label4;
        private DataGridViewTextBoxColumn vremeFormatiranoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mernoMestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mesecGodinaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrednostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razlikaDataGridViewTextBoxColumn;
        private ScottPlot.WinForms.FormsPlot pltStanje;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUkupno;
        private Panel panel1;
        private PictureBox pbGraph;
        private UserControls.SmartDateUC dtDanOd;
        private UserControls.SmartDateUC dtDanDo;
        private Label label1;
    }
}