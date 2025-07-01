namespace TSP2025
{
    partial class frmMernaMestaLookup
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMernaMestaLookup));
            bsGrupeMernihMesta = new BindingSource(components);
            bsMernaMesta = new BindingSource(components);
            dgMernaMesta = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            cmMernoMestoGridMenu = new ContextMenuStrip(components);
            izmeniToolStripMenuItem = new ToolStripMenuItem();
            obrišiToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tbOznakaPretraga = new TextBox();
            cbGrupeMernihMesta = new ComboBox();
            btnPretrazi = new Button();
            statusStrip1 = new StatusStrip();
            label2 = new Label();
            panel1 = new Panel();
            btnPreuzmi = new Button();
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).BeginInit();
            cmMernoMestoGridMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bsGrupeMernihMesta
            // 
            bsGrupeMernihMesta.DataMember = "SveGrupeMernihMestaSaPocetnimSve";
            bsGrupeMernihMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // dgMernaMesta
            // 
            dgMernaMesta.AllowUserToAddRows = false;
            dgMernaMesta.AllowUserToResizeRows = false;
            dgMernaMesta.AutoGenerateColumns = false;
            dgMernaMesta.BackgroundColor = Color.LightGray;
            dgMernaMesta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgMernaMesta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgMernaMesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMernaMesta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgMernaMesta.ContextMenuStrip = cmMernoMestoGridMenu;
            dgMernaMesta.DataSource = bsMernaMesta;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgMernaMesta.DefaultCellStyle = dataGridViewCellStyle4;
            dgMernaMesta.Dock = DockStyle.Fill;
            dgMernaMesta.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgMernaMesta.EnableHeadersVisualStyles = false;
            dgMernaMesta.Location = new Point(0, 60);
            dgMernaMesta.Margin = new Padding(2);
            dgMernaMesta.MultiSelect = false;
            dgMernaMesta.Name = "dgMernaMesta";
            dgMernaMesta.ReadOnly = true;
            dgMernaMesta.RowHeadersVisible = false;
            dgMernaMesta.RowHeadersWidth = 32;
            dgMernaMesta.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgMernaMesta.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgMernaMesta.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgMernaMesta.ScrollBars = ScrollBars.Vertical;
            dgMernaMesta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMernaMesta.Size = new Size(739, 802);
            dgMernaMesta.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "OznakaMernogMesta";
            dataGridViewTextBoxColumn5.HeaderText = "Jedinstvena oznaka mernog mesta";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "OznakaKalorimetra";
            dataGridViewTextBoxColumn6.HeaderText = "Jedinstvena oznaka kalorimetra";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 260;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "TipMernoMesta";
            dataGridViewTextBoxColumn7.HeaderText = "Vezano za";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 240;
            // 
            // cmMernoMestoGridMenu
            // 
            cmMernoMestoGridMenu.ImageScalingSize = new Size(24, 24);
            cmMernoMestoGridMenu.Items.AddRange(new ToolStripItem[] { izmeniToolStripMenuItem, obrišiToolStripMenuItem });
            cmMernoMestoGridMenu.Name = "cmMernoMestoGridMenu";
            cmMernoMestoGridMenu.Size = new Size(118, 64);
            // 
            // izmeniToolStripMenuItem
            // 
            izmeniToolStripMenuItem.Image = (Image)resources.GetObject("izmeniToolStripMenuItem.Image");
            izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            izmeniToolStripMenuItem.Size = new Size(117, 30);
            izmeniToolStripMenuItem.Text = "Izmeni";
            // 
            // obrišiToolStripMenuItem
            // 
            obrišiToolStripMenuItem.Image = (Image)resources.GetObject("obrišiToolStripMenuItem.Image");
            obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            obrišiToolStripMenuItem.Size = new Size(117, 30);
            obrišiToolStripMenuItem.Text = "Obriši";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 1;
            label1.Text = "Jedinstvena oznaka mernog mesta:";
            // 
            // tbOznakaPretraga
            // 
            tbOznakaPretraga.BorderStyle = BorderStyle.FixedSingle;
            tbOznakaPretraga.Location = new Point(341, 26);
            tbOznakaPretraga.Margin = new Padding(2);
            tbOznakaPretraga.Name = "tbOznakaPretraga";
            tbOznakaPretraga.Size = new Size(302, 23);
            tbOznakaPretraga.TabIndex = 2;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(111, 26);
            cbGrupeMernihMesta.Margin = new Padding(2);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(226, 23);
            cbGrupeMernihMesta.TabIndex = 3;
            cbGrupeMernihMesta.SelectionChangeCommitted += cbGrupeMernihMesta_SelectionChangeCommitted;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(646, 22);
            btnPretrazi.Margin = new Padding(2);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(86, 31);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 862);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(739, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Grupa:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnPreuzmi);
            panel1.Controls.Add(cbGrupeMernihMesta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPretrazi);
            panel1.Controls.Add(tbOznakaPretraga);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 60);
            panel1.TabIndex = 7;
            // 
            // btnPreuzmi
            // 
            btnPreuzmi.BackgroundImageLayout = ImageLayout.None;
            btnPreuzmi.DialogResult = DialogResult.OK;
            btnPreuzmi.Image = (Image)resources.GetObject("btnPreuzmi.Image");
            btnPreuzmi.ImageAlign = ContentAlignment.MiddleLeft;
            btnPreuzmi.Location = new Point(4, 5);
            btnPreuzmi.Name = "btnPreuzmi";
            btnPreuzmi.Size = new Size(102, 48);
            btnPreuzmi.TabIndex = 6;
            btnPreuzmi.Text = "Preuzmi  ";
            btnPreuzmi.TextAlign = ContentAlignment.MiddleRight;
            btnPreuzmi.UseVisualStyleBackColor = true;
            // 
            // frmMernaMestaLookup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 884);
            Controls.Add(dgMernaMesta);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMernaMestaLookup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izbor mernog mesta";
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).EndInit();
            cmMernoMestoGridMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsGrupeMernihMesta;
        private BindingSource bsMernaMesta;
        private DataGridView dgMernaMesta;
        private Label label1;
        private TextBox tbOznakaPretraga;
        private ComboBox cbGrupeMernihMesta;
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
        private ContextMenuStrip cmMernoMestoGridMenu;
        private ToolStripMenuItem izmeniToolStripMenuItem;
        private ToolStripMenuItem obrišiToolStripMenuItem;
        private StatusStrip statusStrip1;
        private Label label2;
        private Panel panel1;
        private Button btnPreuzmi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}