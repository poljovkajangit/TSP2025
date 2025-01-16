namespace TSP2025
{
    partial class frmMernaMesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMernaMesta));
            bsGrupeMernihMesta = new BindingSource(components);
            bsMernaMesta = new BindingSource(components);
            dgMernaMesta = new DataGridView();
            label1 = new Label();
            tbPretraga = new TextBox();
            cbGrupeMernihMesta = new ComboBox();
            label2 = new Label();
            btnPretrazi = new Button();
            _BtnDnevniIzvestaj = new Button();
            _btnMesecniIzvestaj = new Button();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            grupaMernogMestaNazivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).BeginInit();
            SuspendLayout();
            // 
            // bsGrupeMernihMesta
            // 
            bsGrupeMernihMesta.DataMember = "SveGrupaMernihMestaSaPocetnimPraznim";
            bsGrupeMernihMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // dgMernaMesta
            // 
            dgMernaMesta.AllowUserToAddRows = false;
            dgMernaMesta.AllowUserToResizeRows = false;
            dgMernaMesta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgMernaMesta.AutoGenerateColumns = false;
            dgMernaMesta.BackgroundColor = Color.LightGray;
            dgMernaMesta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgMernaMesta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMernaMesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMernaMesta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, grupaMernogMestaNazivDataGridViewTextBoxColumn, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgMernaMesta.DataSource = bsMernaMesta;
            dgMernaMesta.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgMernaMesta.EnableHeadersVisualStyles = false;
            dgMernaMesta.Location = new Point(12, 71);
            dgMernaMesta.MultiSelect = false;
            dgMernaMesta.Name = "dgMernaMesta";
            dgMernaMesta.ReadOnly = true;
            dgMernaMesta.RowHeadersWidth = 32;
            dgMernaMesta.ScrollBars = ScrollBars.Vertical;
            dgMernaMesta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMernaMesta.Size = new Size(1682, 1181);
            dgMernaMesta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(424, 24);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 1;
            label1.Text = "Oznaka mernog mesta:";
            // 
            // tbPretraga
            // 
            tbPretraga.BorderStyle = BorderStyle.FixedSingle;
            tbPretraga.Location = new Point(659, 25);
            tbPretraga.Name = "tbPretraga";
            tbPretraga.Size = new Size(327, 31);
            tbPretraga.TabIndex = 2;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(97, 24);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(321, 33);
            cbGrupeMernihMesta.TabIndex = 3;
            cbGrupeMernihMesta.SelectionChangeCommitted += cbGrupeMernihMesta_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(17, 24);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 4;
            label2.Text = "Grupa:";
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(992, 23);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(112, 34);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // _BtnDnevniIzvestaj
            // 
            _BtnDnevniIzvestaj.Image = (Image)resources.GetObject("_BtnDnevniIzvestaj.Image");
            _BtnDnevniIzvestaj.ImageAlign = ContentAlignment.MiddleLeft;
            _BtnDnevniIzvestaj.Location = new Point(12, 1273);
            _BtnDnevniIzvestaj.Name = "_BtnDnevniIzvestaj";
            _BtnDnevniIzvestaj.Size = new Size(260, 64);
            _BtnDnevniIzvestaj.TabIndex = 6;
            _BtnDnevniIzvestaj.Text = "Dnevni izveštaj ...";
            _BtnDnevniIzvestaj.UseVisualStyleBackColor = true;
            // 
            // _btnMesecniIzvestaj
            // 
            _btnMesecniIzvestaj.Image = (Image)resources.GetObject("_btnMesecniIzvestaj.Image");
            _btnMesecniIzvestaj.ImageAlign = ContentAlignment.MiddleLeft;
            _btnMesecniIzvestaj.Location = new Point(278, 1273);
            _btnMesecniIzvestaj.Name = "_btnMesecniIzvestaj";
            _btnMesecniIzvestaj.Size = new Size(260, 64);
            _btnMesecniIzvestaj.TabIndex = 7;
            _btnMesecniIzvestaj.Text = "Mesečni izveštaj ...";
            _btnMesecniIzvestaj.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "OznakaMernogMesta";
            dataGridViewTextBoxColumn5.HeaderText = "Oznaka mernog mesta";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // grupaMernogMestaNazivDataGridViewTextBoxColumn
            // 
            grupaMernogMestaNazivDataGridViewTextBoxColumn.DataPropertyName = "GrupaMernogMestaNaziv";
            grupaMernogMestaNazivDataGridViewTextBoxColumn.HeaderText = "Grupa mernog mesta";
            grupaMernogMestaNazivDataGridViewTextBoxColumn.MinimumWidth = 8;
            grupaMernogMestaNazivDataGridViewTextBoxColumn.Name = "grupaMernogMestaNazivDataGridViewTextBoxColumn";
            grupaMernogMestaNazivDataGridViewTextBoxColumn.ReadOnly = true;
            grupaMernogMestaNazivDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "OznakaKalorimetra";
            dataGridViewTextBoxColumn6.HeaderText = "Oznaka kalorimetra";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 300;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Tip";
            dataGridViewTextBoxColumn7.HeaderText = "Tip";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 300;
            // 
            // frmMernaMesta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 1349);
            Controls.Add(_btnMesecniIzvestaj);
            Controls.Add(_BtnDnevniIzvestaj);
            Controls.Add(btnPretrazi);
            Controls.Add(label2);
            Controls.Add(cbGrupeMernihMesta);
            Controls.Add(tbPretraga);
            Controls.Add(label1);
            Controls.Add(dgMernaMesta);
            Name = "frmMernaMesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uneta merna mesta";
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsGrupeMernihMesta;
        private BindingSource bsMernaMesta;
        private DataGridView dgMernaMesta;
        private Label label1;
        private TextBox tbPretraga;
        private ComboBox cbGrupeMernihMesta;
        private Label label2;
        private DataGridViewTextBoxColumn oznakaMernogMestaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oznakaKalorimetraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn podstanicaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn individualniPotrosacIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn grupaMernogMestaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnPretrazi;
        private Button _BtnDnevniIzvestaj;
        private Button _btnMesecniIzvestaj;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn grupaMernogMestaNazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}