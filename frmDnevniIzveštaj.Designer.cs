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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDnevniIzveštaj));
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dgOcitavanja = new DataGridView();
            vremeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mernoMestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrednostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsOcitavanja = new BindingSource(components);
            btnPrikazi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbMernoMesto = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            comboBox2 = new ComboBox();
            bsGrupaMernihMesta = new BindingSource(components);
            label4 = new Label();
            bindingSource1 = new BindingSource(components);
            rbMernoMesto = new RadioButton();
            rbGrupaMernihMesta = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(360, 54);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(264, 31);
            dateTimePicker2.TabIndex = 1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgOcitavanja.DefaultCellStyle = dataGridViewCellStyle2;
            dgOcitavanja.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgOcitavanja.Location = new Point(12, 258);
            dgOcitavanja.Name = "dgOcitavanja";
            dgOcitavanja.RowHeadersWidth = 62;
            dgOcitavanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOcitavanja.Size = new Size(2108, 980);
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
            mernoMestoDataGridViewTextBoxColumn.HeaderText = "MernoMesto";
            mernoMestoDataGridViewTextBoxColumn.MinimumWidth = 8;
            mernoMestoDataGridViewTextBoxColumn.Name = "mernoMestoDataGridViewTextBoxColumn";
            mernoMestoDataGridViewTextBoxColumn.Width = 300;
            // 
            // vrednostDataGridViewTextBoxColumn
            // 
            vrednostDataGridViewTextBoxColumn.DataPropertyName = "Vrednost";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            vrednostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            vrednostDataGridViewTextBoxColumn.HeaderText = "Vrednost";
            vrednostDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrednostDataGridViewTextBoxColumn.Name = "vrednostDataGridViewTextBoxColumn";
            vrednostDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsOcitavanja
            // 
            bsOcitavanja.DataMember = "SvaOcitavanja";
            bsOcitavanja.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(36, 204);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(112, 34);
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
            label1.Size = new Size(41, 25);
            label1.TabIndex = 4;
            label1.Text = "Od:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 26);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 5;
            label2.Text = "Do:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 6;
            label3.Text = "Merno mesto:";
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(80, 145);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(230, 33);
            cbMernoMesto.TabIndex = 7;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            // 
            // comboBox2
            // 
            comboBox2.DataSource = bsGrupaMernihMesta;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(385, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 33);
            comboBox2.TabIndex = 9;
            // 
            // bsGrupaMernihMesta
            // 
            bsGrupaMernihMesta.DataMember = "SvaGrupaMernihMesta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 112);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 8;
            label4.Text = "Grupa mernih mesta:";
            // 
            // rbMernoMesto
            // 
            rbMernoMesto.AutoSize = true;
            rbMernoMesto.Checked = true;
            rbMernoMesto.Location = new Point(42, 151);
            rbMernoMesto.Name = "rbMernoMesto";
            rbMernoMesto.Size = new Size(21, 20);
            rbMernoMesto.TabIndex = 10;
            rbMernoMesto.TabStop = true;
            rbMernoMesto.UseVisualStyleBackColor = true;
            // 
            // rbGrupaMernihMesta
            // 
            rbGrupaMernihMesta.AutoSize = true;
            rbGrupaMernihMesta.Location = new Point(359, 146);
            rbGrupaMernihMesta.Name = "rbGrupaMernihMesta";
            rbGrupaMernihMesta.Size = new Size(21, 20);
            rbGrupaMernihMesta.TabIndex = 11;
            rbGrupaMernihMesta.UseVisualStyleBackColor = true;
            // 
            // frmDnevniIzveštaj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2132, 1250);
            Controls.Add(rbGrupaMernihMesta);
            Controls.Add(rbMernoMesto);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(cbMernoMesto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPrikazi);
            Controls.Add(dgOcitavanja);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDnevniIzveštaj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dnevni izveštaj";
            Load += frmDnevniIzveštaj_Load;
            ((System.ComponentModel.ISupportInitialize)dgOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOcitavanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGrupaMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dgOcitavanja;
        private Button btnPrikazi;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbMernoMesto;
        private BindingSource bsMernaMesta;
        private ComboBox comboBox2;
        private Label label4;
        private BindingSource bindingSource1;
        private BindingSource bsGrupaMernihMesta;
        private RadioButton rbMernoMesto;
        private RadioButton rbGrupaMernihMesta;
        private BindingSource bsOcitavanja;
        private DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mernoMestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrednostDataGridViewTextBoxColumn;
    }
}