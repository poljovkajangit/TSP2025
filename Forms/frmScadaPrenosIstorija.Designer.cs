namespace TSP2025
{
    partial class frmScadaPrenosIstorija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScadaPrenosIstorija));
            bsScadaPrenosIstorija = new BindingSource(components);
            dgScadaPrenosIstorija = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnObrisiSvePreneto = new Button();
            ((System.ComponentModel.ISupportInitialize)bsScadaPrenosIstorija).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgScadaPrenosIstorija).BeginInit();
            SuspendLayout();
            // 
            // bsScadaPrenosIstorija
            // 
            bsScadaPrenosIstorija.DataSource = typeof(Data.Model.PullHistory);
            // 
            // dgScadaPrenosIstorija
            // 
            dgScadaPrenosIstorija.AllowUserToAddRows = false;
            dgScadaPrenosIstorija.AllowUserToDeleteRows = false;
            dgScadaPrenosIstorija.AllowUserToResizeColumns = false;
            dgScadaPrenosIstorija.AllowUserToResizeRows = false;
            dgScadaPrenosIstorija.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgScadaPrenosIstorija.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgScadaPrenosIstorija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgScadaPrenosIstorija.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgScadaPrenosIstorija.DataSource = bsScadaPrenosIstorija;
            dgScadaPrenosIstorija.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgScadaPrenosIstorija.EnableHeadersVisualStyles = false;
            dgScadaPrenosIstorija.Location = new Point(0, 0);
            dgScadaPrenosIstorija.Margin = new Padding(2);
            dgScadaPrenosIstorija.MultiSelect = false;
            dgScadaPrenosIstorija.Name = "dgScadaPrenosIstorija";
            dgScadaPrenosIstorija.RowHeadersVisible = false;
            dgScadaPrenosIstorija.RowHeadersWidth = 20;
            dgScadaPrenosIstorija.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgScadaPrenosIstorija.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgScadaPrenosIstorija.ScrollBars = ScrollBars.Vertical;
            dgScadaPrenosIstorija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgScadaPrenosIstorija.Size = new Size(1121, 539);
            dgScadaPrenosIstorija.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Vreme";
            dataGridViewTextBoxColumn1.HeaderText = "Vreme";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "MernoMesto";
            dataGridViewTextBoxColumn2.HeaderText = "Merno mesto";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PrenetoZapisa";
            dataGridViewTextBoxColumn3.HeaderText = "Preneto";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "Poruka";
            dataGridViewTextBoxColumn5.HeaderText = "Poruka";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnObrisiSvePreneto
            // 
            btnObrisiSvePreneto.Location = new Point(4, 544);
            btnObrisiSvePreneto.Name = "btnObrisiSvePreneto";
            btnObrisiSvePreneto.Size = new Size(180, 32);
            btnObrisiSvePreneto.TabIndex = 1;
            btnObrisiSvePreneto.Text = "Obriši sve prenete podatke";
            btnObrisiSvePreneto.UseVisualStyleBackColor = true;
            btnObrisiSvePreneto.Click += btnObrisiSvePreneto_Click;
            // 
            // frmScadaPrenos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 579);
            Controls.Add(btnObrisiSvePreneto);
            Controls.Add(dgScadaPrenosIstorija);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmScadaPrenos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scada prenos";
            ((System.ComponentModel.ISupportInitialize)bsScadaPrenosIstorija).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgScadaPrenosIstorija).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsScadaPrenosIstorija;
        private DataGridView dgScadaPrenosIstorija;
        private DataGridViewTextBoxColumn vremeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mernoMestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenetoZapisaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn porukaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btnObrisiSvePreneto;
    }
}