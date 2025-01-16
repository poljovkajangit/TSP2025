namespace TSP2025
{
    partial class frmDnevniIzveštaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDnevniIzveštaj));
            dtDan = new DateTimePicker();
            dgOcitavanja = new DataGridView();
            vremeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mernoMestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrednostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsOcitavanja = new BindingSource(components);
            btnPrikazi = new Button();
            label1 = new Label();
            label3 = new Label();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            bsGrupaMernihMesta = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dtDan
            // 
            dtDan.CustomFormat = "dd/MM/yyyy";
            dtDan.Format = DateTimePickerFormat.Custom;
            dtDan.Location = new Point(36, 54);
            dtDan.Name = "dtDan";
            dtDan.Size = new Size(264, 31);
            dtDan.TabIndex = 0;
            // 
            // dgOcitavanja
            // 
            dgOcitavanja.AllowUserToAddRows = false;
            dgOcitavanja.AllowUserToDeleteRows = false;
            dgOcitavanja.AllowUserToResizeRows = false;
            dgOcitavanja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgOcitavanja.AutoGenerateColumns = false;
            dgOcitavanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOcitavanja.Columns.AddRange(new DataGridViewColumn[] { vremeDataGridViewTextBoxColumn, mernoMestoDataGridViewTextBoxColumn, vrednostDataGridViewTextBoxColumn });
            dgOcitavanja.DataSource = bsOcitavanja;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.Location = new Point(12, 110);
            dgOcitavanja.MultiSelect = false;
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersWidth = 32;
            dgOcitavanja.ScrollBars = ScrollBars.Vertical;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(1812, 884);
            dgOcitavanja.TabIndex = 2;
            // 
            // vremeDataGridViewTextBoxColumn
            // 
            vremeDataGridViewTextBoxColumn.DataPropertyName = "Vreme";
            vremeDataGridViewTextBoxColumn.HeaderText = "Vreme";
            vremeDataGridViewTextBoxColumn.MinimumWidth = 8;
            vremeDataGridViewTextBoxColumn.Name = "vremeDataGridViewTextBoxColumn";
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
            // vrednostDataGridViewTextBoxColumn
            // 
            vrednostDataGridViewTextBoxColumn.DataPropertyName = "Vrednost";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            vrednostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            vrednostDataGridViewTextBoxColumn.HeaderText = "Vrednost";
            vrednostDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrednostDataGridViewTextBoxColumn.Name = "vrednostDataGridViewTextBoxColumn";
            vrednostDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "SvaOcitavanja";
            bsOcitavanja.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(648, 52);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(112, 36);
            btnPrikazi.TabIndex = 3;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 4;
            label1.Text = "Za dan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 24);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 6;
            label3.Text = "Merno mesto:";
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.BackColor = Color.White;
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(306, 53);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(336, 33);
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
            btnExport.Location = new Point(1760, 40);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(64, 64);
            btnExport.TabIndex = 8;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // frmDnevniIzveštaj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 1006);
            Controls.Add(btnExport);
            Controls.Add(cbMernoMesto);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnPrikazi);
            Controls.Add(dgOcitavanja);
            Controls.Add(dtDan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDnevniIzveštaj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dnevni izveštaj";
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDan;
        private DataGridView dgOcitavanja;
        private Button btnPrikazi;
        private Label label1;
        private Label label3;
        private ComboBox cbMernoMesto;
        private BindingSource bsMernaMesta;
        private BindingSource bindingSource1;
        private BindingSource bsGrupaMernihMesta;
        private BindingSource bsOcitavanja;
        private DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mernoMestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrednostDataGridViewTextBoxColumn;
        private Button btnExport;
    }
}