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
            bsGrupeMernihMesta = new BindingSource(components);
            bsMernaMesta = new BindingSource(components);
            dgMernaMesta = new DataGridView();
            grupaMernogMestaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tbPretraga = new TextBox();
            cbGrupeMernihMesta = new ComboBox();
            label2 = new Label();
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
            dgMernaMesta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgMernaMesta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMernaMesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMernaMesta.Columns.AddRange(new DataGridViewColumn[] { grupaMernogMestaDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgMernaMesta.DataSource = bsMernaMesta;
            dgMernaMesta.Location = new Point(12, 71);
            dgMernaMesta.MultiSelect = false;
            dgMernaMesta.Name = "dgMernaMesta";
            dgMernaMesta.RowHeadersVisible = false;
            dgMernaMesta.RowHeadersWidth = 62;
            dgMernaMesta.ScrollBars = ScrollBars.Vertical;
            dgMernaMesta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMernaMesta.Size = new Size(1682, 1174);
            dgMernaMesta.TabIndex = 0;
            // 
            // grupaMernogMestaDataGridViewTextBoxColumn
            // 
            grupaMernogMestaDataGridViewTextBoxColumn.DataPropertyName = "GrupaMernogMestaNaziv";
            grupaMernogMestaDataGridViewTextBoxColumn.HeaderText = "Grupa mernog mesta";
            grupaMernogMestaDataGridViewTextBoxColumn.MinimumWidth = 8;
            grupaMernogMestaDataGridViewTextBoxColumn.Name = "grupaMernogMestaDataGridViewTextBoxColumn";
            grupaMernogMestaDataGridViewTextBoxColumn.ReadOnly = true;
            grupaMernogMestaDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "OznakaMernogMesta";
            dataGridViewTextBoxColumn1.HeaderText = "Oznaka mernog mesta";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "OznakaKalorimetra";
            dataGridViewTextBoxColumn2.HeaderText = "Oznaka kalorimetra";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Tip";
            dataGridViewTextBoxColumn3.HeaderText = "Tip";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Oznaka:";
            // 
            // tbPretraga
            // 
            tbPretraga.BorderStyle = BorderStyle.FixedSingle;
            tbPretraga.Location = new Point(100, 26);
            tbPretraga.Name = "tbPretraga";
            tbPretraga.Size = new Size(327, 31);
            tbPretraga.TabIndex = 2;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataBindings.Add(new Binding("Text", bsGrupeMernihMesta, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(503, 23);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(321, 33);
            cbGrupeMernihMesta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 26);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Grupa:";
            // 
            // frmMernaMesta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 1257);
            Controls.Add(label2);
            Controls.Add(cbGrupeMernihMesta);
            Controls.Add(tbPretraga);
            Controls.Add(label1);
            Controls.Add(dgMernaMesta);
            Name = "frmMernaMesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uneta merna mesta";
            Load += frmMernaMesta_Load;
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
    }
}