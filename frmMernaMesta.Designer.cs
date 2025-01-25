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
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            grupaMernogMestaNazivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tbPretraga = new TextBox();
            cbGrupeMernihMesta = new ComboBox();
            label2 = new Label();
            btnPretrazi = new Button();
            btnGodisnjiIzvestaj = new Button();
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
            dgMernaMesta.Size = new Size(1704, 1184);
            dgMernaMesta.TabIndex = 0;
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
            // btnGodisnjiIzvestaj
            // 
            btnGodisnjiIzvestaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGodisnjiIzvestaj.Image = (Image)resources.GetObject("btnGodisnjiIzvestaj.Image");
            btnGodisnjiIzvestaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnGodisnjiIzvestaj.Location = new Point(17, 1276);
            btnGodisnjiIzvestaj.Name = "btnGodisnjiIzvestaj";
            btnGodisnjiIzvestaj.Size = new Size(222, 64);
            btnGodisnjiIzvestaj.TabIndex = 8;
            btnGodisnjiIzvestaj.Text = "Stanja ...";
            btnGodisnjiIzvestaj.UseVisualStyleBackColor = true;
            btnGodisnjiIzvestaj.Click += btnGodisnjiIzvestaj_Click;
            // 
            // frmMernaMesta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 1352);
            Controls.Add(btnGodisnjiIzvestaj);
            Controls.Add(btnPretrazi);
            Controls.Add(label2);
            Controls.Add(cbGrupeMernihMesta);
            Controls.Add(tbPretraga);
            Controls.Add(label1);
            Controls.Add(dgMernaMesta);
            Name = "frmMernaMesta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Merna mesta";
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn grupaMernogMestaNazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button btnGodisnjiIzvestaj;
    }
}