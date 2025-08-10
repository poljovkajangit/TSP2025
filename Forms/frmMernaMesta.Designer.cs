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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMernaMesta));
            bsGrupeMernihMesta = new BindingSource(components);
            bsMernaMesta = new BindingSource(components);
            dgMernaMesta = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            grupaMernogMestaNazivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            colStanje = new DataGridViewButtonColumn();
            cmMernoMestoGridMenu = new ContextMenuStrip(components);
            izmeniToolStripMenuItem = new ToolStripMenuItem();
            obrišiToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tbPretraga = new TextBox();
            cbGrupeMernihMesta = new ComboBox();
            btnPretrazi = new Button();
            statusStrip1 = new StatusStrip();
            label2 = new Label();
            panel1 = new Panel();
            btnRefresh = new Button();
            toolStrip1 = new ToolStrip();
            btnIzmeni = new ToolStripButton();
            btnObrisi = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).BeginInit();
            cmMernoMestoGridMenu.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgMernaMesta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMernaMesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMernaMesta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, grupaMernogMestaNazivDataGridViewTextBoxColumn, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, colStanje });
            dgMernaMesta.ContextMenuStrip = cmMernoMestoGridMenu;
            dgMernaMesta.DataSource = bsMernaMesta;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgMernaMesta.DefaultCellStyle = dataGridViewCellStyle2;
            dgMernaMesta.Dock = DockStyle.Fill;
            dgMernaMesta.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgMernaMesta.EnableHeadersVisualStyles = false;
            dgMernaMesta.Location = new Point(0, 63);
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
            dgMernaMesta.Size = new Size(1291, 552);
            dgMernaMesta.TabIndex = 0;
            dgMernaMesta.CellContentClick += dgMernaMesta_CellContentClick;
            dgMernaMesta.CellMouseDown += dgMernaMesta_CellMouseDown;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "OznakaMernogMesta";
            dataGridViewTextBoxColumn5.HeaderText = "Merno mesto";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // grupaMernogMestaNazivDataGridViewTextBoxColumn
            // 
            grupaMernogMestaNazivDataGridViewTextBoxColumn.DataPropertyName = "GrupaMernogMestaNaziv";
            grupaMernogMestaNazivDataGridViewTextBoxColumn.HeaderText = "U grupi";
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
            dataGridViewTextBoxColumn7.DataPropertyName = "TipMernoMesta";
            dataGridViewTextBoxColumn7.HeaderText = "Tip";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 320;
            // 
            // colStanje
            // 
            colStanje.HeaderText = "";
            colStanje.MinimumWidth = 8;
            colStanje.Name = "colStanje";
            colStanje.ReadOnly = true;
            colStanje.Text = "Stanje ...";
            colStanje.UseColumnTextForButtonValue = true;
            colStanje.Width = 150;
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
            izmeniToolStripMenuItem.Click += izmeniToolStripMenuItem_Click;
            // 
            // obrišiToolStripMenuItem
            // 
            obrišiToolStripMenuItem.Image = (Image)resources.GetObject("obrišiToolStripMenuItem.Image");
            obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            obrišiToolStripMenuItem.Size = new Size(117, 30);
            obrišiToolStripMenuItem.Text = "Obriši";
            obrišiToolStripMenuItem.Click += obrišiToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Oznaka:";
            // 
            // tbPretraga
            // 
            tbPretraga.BorderStyle = BorderStyle.FixedSingle;
            tbPretraga.Location = new Point(340, 6);
            tbPretraga.Margin = new Padding(2);
            tbPretraga.Name = "tbPretraga";
            tbPretraga.Size = new Size(230, 23);
            tbPretraga.TabIndex = 2;
            // 
            // cbGrupeMernihMesta
            // 
            cbGrupeMernihMesta.DataSource = bsGrupeMernihMesta;
            cbGrupeMernihMesta.DisplayMember = "Naziv";
            cbGrupeMernihMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupeMernihMesta.FormattingEnabled = true;
            cbGrupeMernihMesta.Location = new Point(57, 6);
            cbGrupeMernihMesta.Margin = new Padding(2);
            cbGrupeMernihMesta.Name = "cbGrupeMernihMesta";
            cbGrupeMernihMesta.Size = new Size(226, 23);
            cbGrupeMernihMesta.TabIndex = 3;
            cbGrupeMernihMesta.SelectionChangeCommitted += cbGrupeMernihMesta_SelectionChangeCommitted;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(574, 3);
            btnPretrazi.Margin = new Padding(2);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(78, 29);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 615);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1291, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Grupa:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(cbGrupeMernihMesta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPretrazi);
            panel1.Controls.Add(tbPretraga);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 38);
            panel1.TabIndex = 7;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Location = new Point(1252, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 32);
            btnRefresh.TabIndex = 6;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnIzmeni, btnObrisi });
            toolStrip1.Location = new Point(0, 38);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1291, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnIzmeni
            // 
            btnIzmeni.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnIzmeni.Image = (Image)resources.GetObject("btnIzmeni.Image");
            btnIzmeni.ImageTransparentColor = Color.Magenta;
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(23, 22);
            btnIzmeni.Text = "toolStripButton1";
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnObrisi.Image = (Image)resources.GetObject("btnObrisi.Image");
            btnObrisi.ImageTransparentColor = Color.Magenta;
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(23, 22);
            btnObrisi.Text = "toolStripButton2";
            btnObrisi.Click += btnObrisi_Click;
            // 
            // frmMernaMesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 637);
            Controls.Add(dgMernaMesta);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMernaMesta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Merna mesta";
            ((System.ComponentModel.ISupportInitialize)bsGrupeMernihMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMernaMesta).EndInit();
            cmMernoMestoGridMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private DataGridViewButtonColumn colStanje;
        private ContextMenuStrip cmMernoMestoGridMenu;
        private ToolStripMenuItem izmeniToolStripMenuItem;
        private ToolStripMenuItem obrišiToolStripMenuItem;
        private StatusStrip statusStrip1;
        private Label label2;
        private Panel panel1;
        private Button btnRefresh;
        private ToolStrip toolStrip1;
        private ToolStripButton btnIzmeni;
        private ToolStripButton btnObrisi;
    }
}