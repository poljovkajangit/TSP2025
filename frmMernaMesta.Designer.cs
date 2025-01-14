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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMernaMesta));
            bsGrupeMernihMesta = new BindingSource(components);
            bsMernaMesta = new BindingSource(components);
            dgMernaMesta = new DataGridView();
            oznakaMernogMestaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oznakaKalorimetraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tbPretraga = new TextBox();
            cbGrupeMernihMesta = new ComboBox();
            label2 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).BeginInit();
            SuspendLayout();
            // 
            // bsGrupeMernihMesta
            // 
            bsGrupeMernihMesta.DataMember = "SvaGrupaMernihMesta";
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
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
            dgMernaMesta.Columns.AddRange(new DataGridViewColumn[] { oznakaMernogMestaDataGridViewTextBoxColumn, tipDataGridViewTextBoxColumn, oznakaKalorimetraDataGridViewTextBoxColumn });
            dgMernaMesta.DataSource = bsMernaMesta;
            dgMernaMesta.Location = new Point(12, 71);
            dgMernaMesta.MultiSelect = false;
            dgMernaMesta.Name = "dgMernaMesta";
            dgMernaMesta.RowHeadersVisible = false;
            dgMernaMesta.RowHeadersWidth = 62;
            dgMernaMesta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMernaMesta.Size = new Size(1743, 1084);
            dgMernaMesta.TabIndex = 0;
            // 
            // oznakaMernogMestaDataGridViewTextBoxColumn
            // 
            oznakaMernogMestaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            oznakaMernogMestaDataGridViewTextBoxColumn.DataPropertyName = "OznakaMernogMesta";
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            oznakaMernogMestaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            oznakaMernogMestaDataGridViewTextBoxColumn.HeaderText = "Oznaka mernog mesta";
            oznakaMernogMestaDataGridViewTextBoxColumn.MinimumWidth = 8;
            oznakaMernogMestaDataGridViewTextBoxColumn.Name = "oznakaMernogMestaDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            tipDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            tipDataGridViewTextBoxColumn.MinimumWidth = 8;
            tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            tipDataGridViewTextBoxColumn.Width = 150;
            // 
            // oznakaKalorimetraDataGridViewTextBoxColumn
            // 
            oznakaKalorimetraDataGridViewTextBoxColumn.DataPropertyName = "OznakaKalorimetra";
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            oznakaKalorimetraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            oznakaKalorimetraDataGridViewTextBoxColumn.HeaderText = "Oznaka Kalorimetara";
            oznakaKalorimetraDataGridViewTextBoxColumn.MinimumWidth = 8;
            oznakaKalorimetraDataGridViewTextBoxColumn.Name = "oznakaKalorimetraDataGridViewTextBoxColumn";
            oznakaKalorimetraDataGridViewTextBoxColumn.Width = 250;
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
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(503, 23);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(321, 33);
            cbGrupeMernihMesta.TabIndex = 3;
            cbGrupeMernihMesta.SelectedIndexChanged += cbGrupeMernihMesta_SelectedIndexChanged;
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
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(1707, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(48, 48);
            btnDelete.TabIndex = 7;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmMernaMesta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1767, 1167);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(cbGrupeMernihMesta);
            Controls.Add(tbPretraga);
            Controls.Add(label1);
            Controls.Add(dgMernaMesta);
            Name = "frmMernaMesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uredi merna mesta";
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
        private Button btnDelete;
    }
}