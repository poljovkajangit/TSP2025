namespace TSP2025
{
    partial class frmMaticniPodaci
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaticniPodaci));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            cbToplane = new ComboBox();
            _BsToplane = new BindingSource(components);
            _BsPoslovniSistem = new BindingSource(components);
            dgToplane = new DataGridView();
            nazivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _BsIndividualniPotrosaci = new BindingSource(components);
            _BsPodstanice = new BindingSource(components);
            _BsKotlarnice = new BindingSource(components);
            cbKotlarnice = new ComboBox();
            dgKotlarnice = new DataGridView();
            nazivDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cbPodstanice = new ComboBox();
            dgPodstanice = new DataGridView();
            nazivDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            tabMaticniPodaci = new TabControl();
            tpToplane = new TabPage();
            label18 = new Label();
            btnObrisiToplanu = new Button();
            btnDodajToplanu = new Button();
            btnUndoToplane = new Button();
            btnKotlarnice = new Button();
            btnSaveToplane = new Button();
            tbToplanaNapomena = new TextBox();
            tbToplanaNaziv = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label20 = new Label();
            label19 = new Label();
            btnKotlarniceObrisi = new Button();
            btnKotlarniceDodaj = new Button();
            btnUndoKotlarnice = new Button();
            btnSaveKotlarnice = new Button();
            btnToplane = new Button();
            btnPodstanice = new Button();
            tbKotlarnicaNapomena = new TextBox();
            label7 = new Label();
            tbKotlarnicaOdgovornoLice = new TextBox();
            label6 = new Label();
            tbKotlarnicaTelefon = new TextBox();
            label5 = new Label();
            tbKotlarnicaAdresa = new TextBox();
            label4 = new Label();
            tbKotlarnicaNaziv = new TextBox();
            label3 = new Label();
            tabPage1 = new TabPage();
            label22 = new Label();
            btnKPodstaniceObrisi = new Button();
            btnKPodstaniceDodaj = new Button();
            label21 = new Label();
            btnUndoPodstanice = new Button();
            btnSavePodstanice = new Button();
            btnPodstaniceKotlarnice = new Button();
            btnPostaniceIndividualni = new Button();
            btnMernoMestoPodstanica = new Button();
            label17 = new Label();
            textBox5 = new TextBox();
            label16 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            tbPodstanicaNaziv = new TextBox();
            tabIndividaulniPotrosaci = new TabPage();
            btnObrisiIndividualni = new Button();
            btnDodajIndividualni = new Button();
            label24 = new Label();
            label23 = new Label();
            btnUndoPotrosaci = new Button();
            btnSavePotrosaci = new Button();
            btnIndividualniPodstanice = new Button();
            btnMernoMestoIndividualniPotrosac = new Button();
            tbIndividualniPotrosacTelefon = new TextBox();
            label15 = new Label();
            tbIndividualniPotrosacEmail = new TextBox();
            label14 = new Label();
            tbIndividualniPotrosacAdresa = new TextBox();
            label13 = new Label();
            tbIndividualniPotrosacNaziv = new TextBox();
            label12 = new Label();
            dgIndividualniPotrosaci = new DataGridView();
            nazivDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)_BsToplane).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_BsPoslovniSistem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgToplane).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_BsIndividualniPotrosaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_BsPodstanice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_BsKotlarnice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgKotlarnice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPodstanice).BeginInit();
            tabMaticniPodaci.SuspendLayout();
            tpToplane.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabIndividaulniPotrosaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgIndividualniPotrosaci).BeginInit();
            SuspendLayout();
            // 
            // cbToplane
            // 
            cbToplane.BackColor = Color.White;
            cbToplane.DataSource = _BsToplane;
            cbToplane.DisplayMember = "Naziv";
            cbToplane.DropDownStyle = ComboBoxStyle.DropDownList;
            cbToplane.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbToplane.FormattingEnabled = true;
            cbToplane.Location = new Point(92, 9);
            cbToplane.Name = "cbToplane";
            cbToplane.Size = new Size(600, 40);
            cbToplane.TabIndex = 1;
            cbToplane.ValueMember = "Id";
            // 
            // _BsToplane
            // 
            _BsToplane.DataMember = "MojeToplane";
            _BsToplane.DataSource = _BsPoslovniSistem;
            // 
            // _BsPoslovniSistem
            // 
            _BsPoslovniSistem.DataSource = typeof(Data.PoslovniSistemDataContext);
            // 
            // dgToplane
            // 
            dgToplane.AllowUserToAddRows = false;
            dgToplane.AllowUserToDeleteRows = false;
            dgToplane.AllowUserToResizeColumns = false;
            dgToplane.AllowUserToResizeRows = false;
            dgToplane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgToplane.AutoGenerateColumns = false;
            dgToplane.BackgroundColor = Color.LightGray;
            dgToplane.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgToplane.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgToplane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgToplane.ColumnHeadersVisible = false;
            dgToplane.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn });
            dgToplane.DataSource = _BsToplane;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgToplane.DefaultCellStyle = dataGridViewCellStyle2;
            dgToplane.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgToplane.Location = new Point(3, 107);
            dgToplane.MultiSelect = false;
            dgToplane.Name = "dgToplane";
            dgToplane.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgToplane.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgToplane.RowHeadersWidth = 32;
            dgToplane.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgToplane.ScrollBars = ScrollBars.Vertical;
            dgToplane.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgToplane.Size = new Size(970, 1090);
            dgToplane.TabIndex = 8;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            nazivDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            nazivDataGridViewTextBoxColumn.MinimumWidth = 8;
            nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // _BsIndividualniPotrosaci
            // 
            _BsIndividualniPotrosaci.DataMember = "IndividualniPotrosaci";
            _BsIndividualniPotrosaci.DataSource = _BsPodstanice;
            // 
            // _BsPodstanice
            // 
            _BsPodstanice.DataMember = "Podstanice";
            _BsPodstanice.DataSource = _BsKotlarnice;
            // 
            // _BsKotlarnice
            // 
            _BsKotlarnice.DataMember = "Kotlarnice";
            _BsKotlarnice.DataSource = _BsToplane;
            // 
            // cbKotlarnice
            // 
            cbKotlarnice.DataSource = _BsKotlarnice;
            cbKotlarnice.DisplayMember = "Naziv";
            cbKotlarnice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbKotlarnice.FormattingEnabled = true;
            cbKotlarnice.Location = new Point(116, 6);
            cbKotlarnice.Name = "cbKotlarnice";
            cbKotlarnice.Size = new Size(600, 40);
            cbKotlarnice.TabIndex = 1;
            cbKotlarnice.ValueMember = "Id";
            // 
            // dgKotlarnice
            // 
            dgKotlarnice.AllowUserToAddRows = false;
            dgKotlarnice.AllowUserToDeleteRows = false;
            dgKotlarnice.AllowUserToResizeRows = false;
            dgKotlarnice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgKotlarnice.AutoGenerateColumns = false;
            dgKotlarnice.BackgroundColor = Color.LightGray;
            dgKotlarnice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKotlarnice.ColumnHeadersVisible = false;
            dgKotlarnice.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn1 });
            dgKotlarnice.DataSource = _BsKotlarnice;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgKotlarnice.DefaultCellStyle = dataGridViewCellStyle4;
            dgKotlarnice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgKotlarnice.Location = new Point(6, 135);
            dgKotlarnice.MultiSelect = false;
            dgKotlarnice.Name = "dgKotlarnice";
            dgKotlarnice.RowHeadersWidth = 32;
            dgKotlarnice.ScrollBars = ScrollBars.Vertical;
            dgKotlarnice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKotlarnice.Size = new Size(970, 1058);
            dgKotlarnice.TabIndex = 7;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            nazivDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            nazivDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // cbPodstanice
            // 
            cbPodstanice.DataSource = _BsPodstanice;
            cbPodstanice.DisplayMember = "Naziv";
            cbPodstanice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbPodstanice.FormattingEnabled = true;
            cbPodstanice.Location = new Point(113, 8);
            cbPodstanice.Name = "cbPodstanice";
            cbPodstanice.Size = new Size(592, 40);
            cbPodstanice.TabIndex = 1;
            cbPodstanice.ValueMember = "Id";
            // 
            // dgPodstanice
            // 
            dgPodstanice.AllowUserToAddRows = false;
            dgPodstanice.AllowUserToDeleteRows = false;
            dgPodstanice.AllowUserToResizeRows = false;
            dgPodstanice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgPodstanice.AutoGenerateColumns = false;
            dgPodstanice.BackgroundColor = Color.LightGray;
            dgPodstanice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPodstanice.ColumnHeadersVisible = false;
            dgPodstanice.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn2 });
            dgPodstanice.DataSource = _BsPodstanice;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgPodstanice.DefaultCellStyle = dataGridViewCellStyle5;
            dgPodstanice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgPodstanice.Location = new Point(6, 119);
            dgPodstanice.MultiSelect = false;
            dgPodstanice.Name = "dgPodstanice";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgPodstanice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgPodstanice.RowHeadersWidth = 32;
            dgPodstanice.ScrollBars = ScrollBars.Vertical;
            dgPodstanice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPodstanice.Size = new Size(970, 1078);
            dgPodstanice.TabIndex = 6;
            // 
            // nazivDataGridViewTextBoxColumn2
            // 
            nazivDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn2.HeaderText = "Naziv";
            nazivDataGridViewTextBoxColumn2.MinimumWidth = 8;
            nazivDataGridViewTextBoxColumn2.Name = "nazivDataGridViewTextBoxColumn2";
            // 
            // tabMaticniPodaci
            // 
            tabMaticniPodaci.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabMaticniPodaci.Controls.Add(tpToplane);
            tabMaticniPodaci.Controls.Add(tabPage2);
            tabMaticniPodaci.Controls.Add(tabPage1);
            tabMaticniPodaci.Controls.Add(tabIndividaulniPotrosaci);
            tabMaticniPodaci.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tabMaticniPodaci.Location = new Point(12, 12);
            tabMaticniPodaci.Name = "tabMaticniPodaci";
            tabMaticniPodaci.SelectedIndex = 0;
            tabMaticniPodaci.Size = new Size(2767, 1241);
            tabMaticniPodaci.TabIndex = 8;
            tabMaticniPodaci.Selecting += tabMaticniPodaci_Selecting;
            // 
            // tpToplane
            // 
            tpToplane.Controls.Add(label18);
            tpToplane.Controls.Add(btnObrisiToplanu);
            tpToplane.Controls.Add(btnDodajToplanu);
            tpToplane.Controls.Add(btnUndoToplane);
            tpToplane.Controls.Add(btnKotlarnice);
            tpToplane.Controls.Add(btnSaveToplane);
            tpToplane.Controls.Add(tbToplanaNapomena);
            tpToplane.Controls.Add(tbToplanaNaziv);
            tpToplane.Controls.Add(dgToplane);
            tpToplane.Controls.Add(label2);
            tpToplane.Controls.Add(label1);
            tpToplane.Location = new Point(4, 34);
            tpToplane.Name = "tpToplane";
            tpToplane.Padding = new Padding(3);
            tpToplane.Size = new Size(2759, 1203);
            tpToplane.TabIndex = 0;
            tpToplane.Text = "Toplane";
            tpToplane.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.LightGray;
            label18.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(800, 1139);
            label18.Name = "label18";
            label18.Size = new Size(163, 48);
            label18.TabIndex = 24;
            label18.Text = "Toplane";
            // 
            // btnObrisiToplanu
            // 
            btnObrisiToplanu.Image = (Image)resources.GetObject("btnObrisiToplanu.Image");
            btnObrisiToplanu.Location = new Point(124, 37);
            btnObrisiToplanu.Name = "btnObrisiToplanu";
            btnObrisiToplanu.Size = new Size(112, 64);
            btnObrisiToplanu.TabIndex = 23;
            btnObrisiToplanu.UseVisualStyleBackColor = true;
            btnObrisiToplanu.Click += btnObrisiToplanu_Click;
            // 
            // btnDodajToplanu
            // 
            btnDodajToplanu.Image = (Image)resources.GetObject("btnDodajToplanu.Image");
            btnDodajToplanu.Location = new Point(6, 37);
            btnDodajToplanu.Name = "btnDodajToplanu";
            btnDodajToplanu.Size = new Size(112, 64);
            btnDodajToplanu.TabIndex = 22;
            btnDodajToplanu.UseVisualStyleBackColor = true;
            btnDodajToplanu.Click += btnDodajToplanu_Click;
            // 
            // btnUndoToplane
            // 
            btnUndoToplane.Image = (Image)resources.GetObject("btnUndoToplane.Image");
            btnUndoToplane.ImageAlign = ContentAlignment.MiddleLeft;
            btnUndoToplane.Location = new Point(775, 37);
            btnUndoToplane.Name = "btnUndoToplane";
            btnUndoToplane.Padding = new Padding(20, 0, 0, 0);
            btnUndoToplane.Size = new Size(96, 64);
            btnUndoToplane.TabIndex = 10;
            btnUndoToplane.UseVisualStyleBackColor = true;
            btnUndoToplane.Visible = false;
            btnUndoToplane.Click += btnUndoIzmena_Click;
            // 
            // btnKotlarnice
            // 
            btnKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnKotlarnice.Location = new Point(2508, 1133);
            btnKotlarnice.Name = "btnKotlarnice";
            btnKotlarnice.Size = new Size(248, 64);
            btnKotlarnice.TabIndex = 9;
            btnKotlarnice.Text = "Kotlarnice >>>";
            btnKotlarnice.UseVisualStyleBackColor = true;
            btnKotlarnice.Click += btnKotlarnice_Click;
            // 
            // btnSaveToplane
            // 
            btnSaveToplane.Image = (Image)resources.GetObject("btnSaveToplane.Image");
            btnSaveToplane.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveToplane.Location = new Point(877, 37);
            btnSaveToplane.Name = "btnSaveToplane";
            btnSaveToplane.Padding = new Padding(20, 0, 0, 0);
            btnSaveToplane.Size = new Size(96, 64);
            btnSaveToplane.TabIndex = 9;
            btnSaveToplane.UseVisualStyleBackColor = true;
            btnSaveToplane.Visible = false;
            btnSaveToplane.Click += btnSaveEnabled_Click;
            // 
            // tbToplanaNapomena
            // 
            tbToplanaNapomena.BackColor = Color.White;
            tbToplanaNapomena.BorderStyle = BorderStyle.FixedSingle;
            tbToplanaNapomena.DataBindings.Add(new Binding("Text", _BsToplane, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            tbToplanaNapomena.Location = new Point(1014, 197);
            tbToplanaNapomena.Multiline = true;
            tbToplanaNapomena.Name = "tbToplanaNapomena";
            tbToplanaNapomena.Size = new Size(450, 174);
            tbToplanaNapomena.TabIndex = 2;
            // 
            // tbToplanaNaziv
            // 
            tbToplanaNaziv.BackColor = Color.White;
            tbToplanaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbToplanaNaziv.DataBindings.Add(new Binding("Text", _BsToplane, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbToplanaNaziv.Location = new Point(1014, 135);
            tbToplanaNaziv.Name = "tbToplanaNaziv";
            tbToplanaNaziv.Size = new Size(450, 31);
            tbToplanaNaziv.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1014, 169);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Napomena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1014, 107);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Naziv:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(btnKotlarniceObrisi);
            tabPage2.Controls.Add(btnKotlarniceDodaj);
            tabPage2.Controls.Add(btnUndoKotlarnice);
            tabPage2.Controls.Add(btnSaveKotlarnice);
            tabPage2.Controls.Add(btnToplane);
            tabPage2.Controls.Add(btnPodstanice);
            tabPage2.Controls.Add(tbKotlarnicaNapomena);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tbKotlarnicaOdgovornoLice);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tbKotlarnicaTelefon);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbKotlarnicaAdresa);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(tbKotlarnicaNaziv);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dgKotlarnice);
            tabPage2.Controls.Add(cbToplane);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2759, 1203);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kotlarnice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(9, 18);
            label20.Name = "label20";
            label20.Size = new Size(77, 25);
            label20.TabIndex = 29;
            label20.Text = "Toplana:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.LightGray;
            label19.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(758, 1125);
            label19.Name = "label19";
            label19.Size = new Size(203, 48);
            label19.TabIndex = 28;
            label19.Text = "Kotlarnice";
            // 
            // btnKotlarniceObrisi
            // 
            btnKotlarniceObrisi.Image = (Image)resources.GetObject("btnKotlarniceObrisi.Image");
            btnKotlarniceObrisi.Location = new Point(127, 55);
            btnKotlarniceObrisi.Name = "btnKotlarniceObrisi";
            btnKotlarniceObrisi.Size = new Size(112, 64);
            btnKotlarniceObrisi.TabIndex = 27;
            btnKotlarniceObrisi.UseVisualStyleBackColor = true;
            btnKotlarniceObrisi.Click += btnKotlarniceObrisi_Click;
            // 
            // btnKotlarniceDodaj
            // 
            btnKotlarniceDodaj.Image = (Image)resources.GetObject("btnKotlarniceDodaj.Image");
            btnKotlarniceDodaj.Location = new Point(9, 55);
            btnKotlarniceDodaj.Name = "btnKotlarniceDodaj";
            btnKotlarniceDodaj.Size = new Size(112, 64);
            btnKotlarniceDodaj.TabIndex = 26;
            btnKotlarniceDodaj.UseVisualStyleBackColor = true;
            btnKotlarniceDodaj.Click += btnKotlarniceDodaj_Click;
            // 
            // btnUndoKotlarnice
            // 
            btnUndoKotlarnice.Image = (Image)resources.GetObject("btnUndoKotlarnice.Image");
            btnUndoKotlarnice.ImageAlign = ContentAlignment.MiddleLeft;
            btnUndoKotlarnice.Location = new Point(778, 55);
            btnUndoKotlarnice.Name = "btnUndoKotlarnice";
            btnUndoKotlarnice.Padding = new Padding(20, 0, 0, 0);
            btnUndoKotlarnice.Size = new Size(96, 64);
            btnUndoKotlarnice.TabIndex = 25;
            btnUndoKotlarnice.UseVisualStyleBackColor = true;
            btnUndoKotlarnice.Visible = false;
            btnUndoKotlarnice.Click += btnUndoKotlarnice_Click;
            // 
            // btnSaveKotlarnice
            // 
            btnSaveKotlarnice.Image = (Image)resources.GetObject("btnSaveKotlarnice.Image");
            btnSaveKotlarnice.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveKotlarnice.Location = new Point(880, 55);
            btnSaveKotlarnice.Name = "btnSaveKotlarnice";
            btnSaveKotlarnice.Padding = new Padding(20, 0, 0, 0);
            btnSaveKotlarnice.Size = new Size(96, 64);
            btnSaveKotlarnice.TabIndex = 24;
            btnSaveKotlarnice.UseVisualStyleBackColor = true;
            btnSaveKotlarnice.Visible = false;
            btnSaveKotlarnice.Click += btnSaveKotlarnice_Click;
            // 
            // btnToplane
            // 
            btnToplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnToplane.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnToplane.Location = new Point(2292, 1118);
            btnToplane.Name = "btnToplane";
            btnToplane.Size = new Size(229, 73);
            btnToplane.TabIndex = 19;
            btnToplane.Text = "<<< Toplane";
            btnToplane.UseVisualStyleBackColor = true;
            btnToplane.Click += btnToplane_Click;
            // 
            // btnPodstanice
            // 
            btnPodstanice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPodstanice.Location = new Point(2527, 1118);
            btnPodstanice.Name = "btnPodstanice";
            btnPodstanice.Size = new Size(229, 73);
            btnPodstanice.TabIndex = 18;
            btnPodstanice.Text = "Podstanice >>>";
            btnPodstanice.UseVisualStyleBackColor = true;
            btnPodstanice.Click += btnPodstanice_Click;
            // 
            // tbKotlarnicaNapomena
            // 
            tbKotlarnicaNapomena.BackColor = Color.White;
            tbKotlarnicaNapomena.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaNapomena.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaNapomena.Location = new Point(1020, 411);
            tbKotlarnicaNapomena.Multiline = true;
            tbKotlarnicaNapomena.Name = "tbKotlarnicaNapomena";
            tbKotlarnicaNapomena.Size = new Size(450, 124);
            tbKotlarnicaNapomena.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1021, 383);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 16;
            label7.Text = "Napomena:";
            // 
            // tbKotlarnicaOdgovornoLice
            // 
            tbKotlarnicaOdgovornoLice.BackColor = Color.White;
            tbKotlarnicaOdgovornoLice.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaOdgovornoLice.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Sef", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaOdgovornoLice.Location = new Point(1020, 349);
            tbKotlarnicaOdgovornoLice.Name = "tbKotlarnicaOdgovornoLice";
            tbKotlarnicaOdgovornoLice.Size = new Size(450, 31);
            tbKotlarnicaOdgovornoLice.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1021, 321);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 14;
            label6.Text = "Odgovorno lice:";
            // 
            // tbKotlarnicaTelefon
            // 
            tbKotlarnicaTelefon.BackColor = Color.White;
            tbKotlarnicaTelefon.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaTelefon.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaTelefon.Location = new Point(1020, 287);
            tbKotlarnicaTelefon.Name = "tbKotlarnicaTelefon";
            tbKotlarnicaTelefon.Size = new Size(450, 31);
            tbKotlarnicaTelefon.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1021, 259);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 12;
            label5.Text = "Telefon:";
            // 
            // tbKotlarnicaAdresa
            // 
            tbKotlarnicaAdresa.BackColor = Color.White;
            tbKotlarnicaAdresa.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaAdresa.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Adresa", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaAdresa.Location = new Point(1020, 225);
            tbKotlarnicaAdresa.Name = "tbKotlarnicaAdresa";
            tbKotlarnicaAdresa.Size = new Size(450, 31);
            tbKotlarnicaAdresa.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1021, 197);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 10;
            label4.Text = "Adresa:";
            // 
            // tbKotlarnicaNaziv
            // 
            tbKotlarnicaNaziv.BackColor = Color.White;
            tbKotlarnicaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaNaziv.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaNaziv.Location = new Point(1020, 163);
            tbKotlarnicaNaziv.Name = "tbKotlarnicaNaziv";
            tbKotlarnicaNaziv.Size = new Size(450, 31);
            tbKotlarnicaNaziv.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1020, 135);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 8;
            label3.Text = "Naziv:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(btnKPodstaniceObrisi);
            tabPage1.Controls.Add(btnKPodstaniceDodaj);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(btnUndoPodstanice);
            tabPage1.Controls.Add(btnSavePodstanice);
            tabPage1.Controls.Add(btnPodstaniceKotlarnice);
            tabPage1.Controls.Add(btnPostaniceIndividualni);
            tabPage1.Controls.Add(btnMernoMestoPodstanica);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(tbPodstanicaNaziv);
            tabPage1.Controls.Add(cbKotlarnice);
            tabPage1.Controls.Add(dgPodstanice);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2759, 1203);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Podstanice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.LightGray;
            label22.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label22.ForeColor = Color.Gray;
            label22.Location = new Point(752, 1139);
            label22.Name = "label22";
            label22.Size = new Size(214, 48);
            label22.TabIndex = 33;
            label22.Text = "Podstanice";
            // 
            // btnKPodstaniceObrisi
            // 
            btnKPodstaniceObrisi.Image = (Image)resources.GetObject("btnKPodstaniceObrisi.Image");
            btnKPodstaniceObrisi.Location = new Point(124, 49);
            btnKPodstaniceObrisi.Name = "btnKPodstaniceObrisi";
            btnKPodstaniceObrisi.Size = new Size(112, 64);
            btnKPodstaniceObrisi.TabIndex = 32;
            btnKPodstaniceObrisi.UseVisualStyleBackColor = true;
            btnKPodstaniceObrisi.Click += btnKPodstaniceObrisi_Click;
            // 
            // btnKPodstaniceDodaj
            // 
            btnKPodstaniceDodaj.Image = (Image)resources.GetObject("btnKPodstaniceDodaj.Image");
            btnKPodstaniceDodaj.Location = new Point(6, 49);
            btnKPodstaniceDodaj.Name = "btnKPodstaniceDodaj";
            btnKPodstaniceDodaj.Size = new Size(112, 64);
            btnKPodstaniceDodaj.TabIndex = 31;
            btnKPodstaniceDodaj.UseVisualStyleBackColor = true;
            btnKPodstaniceDodaj.Click += btnKPodstaniceDodaj_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 12);
            label21.Name = "label21";
            label21.Size = new Size(93, 25);
            label21.TabIndex = 30;
            label21.Text = "Kotlarnica:";
            // 
            // btnUndoPodstanice
            // 
            btnUndoPodstanice.Image = (Image)resources.GetObject("btnUndoPodstanice.Image");
            btnUndoPodstanice.ImageAlign = ContentAlignment.MiddleLeft;
            btnUndoPodstanice.Location = new Point(777, 49);
            btnUndoPodstanice.Name = "btnUndoPodstanice";
            btnUndoPodstanice.Padding = new Padding(20, 0, 0, 0);
            btnUndoPodstanice.Size = new Size(96, 64);
            btnUndoPodstanice.TabIndex = 25;
            btnUndoPodstanice.UseVisualStyleBackColor = true;
            btnUndoPodstanice.Visible = false;
            btnUndoPodstanice.Click += btnUndoPodstanice_Click;
            // 
            // btnSavePodstanice
            // 
            btnSavePodstanice.Image = (Image)resources.GetObject("btnSavePodstanice.Image");
            btnSavePodstanice.ImageAlign = ContentAlignment.MiddleLeft;
            btnSavePodstanice.Location = new Point(880, 49);
            btnSavePodstanice.Name = "btnSavePodstanice";
            btnSavePodstanice.Padding = new Padding(20, 0, 0, 0);
            btnSavePodstanice.Size = new Size(96, 64);
            btnSavePodstanice.TabIndex = 24;
            btnSavePodstanice.UseVisualStyleBackColor = true;
            btnSavePodstanice.Visible = false;
            btnSavePodstanice.Click += btnSavePodstanice_Click;
            // 
            // btnPodstaniceKotlarnice
            // 
            btnPodstaniceKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPodstaniceKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPodstaniceKotlarnice.Location = new Point(2168, 1121);
            btnPodstaniceKotlarnice.Name = "btnPodstaniceKotlarnice";
            btnPodstaniceKotlarnice.Size = new Size(229, 73);
            btnPodstaniceKotlarnice.TabIndex = 23;
            btnPodstaniceKotlarnice.Text = "<<< Kotlarnice";
            btnPodstaniceKotlarnice.UseVisualStyleBackColor = true;
            btnPodstaniceKotlarnice.Click += btnPodstaniceKotlarnice_Click;
            // 
            // btnPostaniceIndividualni
            // 
            btnPostaniceIndividualni.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPostaniceIndividualni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPostaniceIndividualni.Location = new Point(2403, 1121);
            btnPostaniceIndividualni.Name = "btnPostaniceIndividualni";
            btnPostaniceIndividualni.Size = new Size(350, 73);
            btnPostaniceIndividualni.TabIndex = 22;
            btnPostaniceIndividualni.Text = "Individualni potrošači >>>";
            btnPostaniceIndividualni.UseVisualStyleBackColor = true;
            btnPostaniceIndividualni.Click += btnPostaniceIndividualni_Click;
            // 
            // btnMernoMestoPodstanica
            // 
            btnMernoMestoPodstanica.Location = new Point(982, 1124);
            btnMernoMestoPodstanica.Name = "btnMernoMestoPodstanica";
            btnMernoMestoPodstanica.Size = new Size(340, 70);
            btnMernoMestoPodstanica.TabIndex = 19;
            btnMernoMestoPodstanica.Text = "Formiraj merno mesto ...";
            btnMernoMestoPodstanica.UseVisualStyleBackColor = true;
            btnMernoMestoPodstanica.Click += btnPodstaniceDodajMernoMesto_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1025, 426);
            label17.Name = "label17";
            label17.Size = new Size(294, 25);
            label17.TabIndex = 18;
            label17.Text = "KOLONA_NAPLANTONG_REGISTRA:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.DataBindings.Add(new Binding("Text", _BsPodstanice, "KOLONA_NAPLANTONG_REGISTRA", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.Location = new Point(1025, 454);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(450, 31);
            textBox5.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1025, 364);
            label16.Name = "label16";
            label16.Size = new Size(272, 25);
            label16.TabIndex = 16;
            label16.Text = "TABELA_NAPLATNOG_REGISTRA:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.DataBindings.Add(new Binding("Text", _BsPodstanice, "TABELA_NAPLATNOG_REGISTRA", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.Location = new Point(1025, 392);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 31);
            textBox4.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1025, 499);
            label11.Name = "label11";
            label11.Size = new Size(104, 25);
            label11.TabIndex = 14;
            label11.Text = "Napomena:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.DataBindings.Add(new Binding("Text", _BsPodstanice, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.Location = new Point(1025, 527);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(450, 155);
            textBox3.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1025, 293);
            label10.Name = "label10";
            label10.Size = new Size(140, 25);
            label10.TabIndex = 12;
            label10.Text = "Odgovorno lice:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.DataBindings.Add(new Binding("Text", _BsPodstanice, "OdgovornoLice", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(1025, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 31);
            textBox2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1025, 231);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 10;
            label9.Text = "Adresa:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.DataBindings.Add(new Binding("Text", _BsPodstanice, "Adresa", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(1025, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 31);
            textBox1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1025, 169);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 8;
            label8.Text = "Naziv:";
            // 
            // tbPodstanicaNaziv
            // 
            tbPodstanicaNaziv.BackColor = Color.White;
            tbPodstanicaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbPodstanicaNaziv.DataBindings.Add(new Binding("Text", _BsPodstanice, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbPodstanicaNaziv.Location = new Point(1025, 197);
            tbPodstanicaNaziv.Name = "tbPodstanicaNaziv";
            tbPodstanicaNaziv.Size = new Size(450, 31);
            tbPodstanicaNaziv.TabIndex = 1;
            // 
            // tabIndividaulniPotrosaci
            // 
            tabIndividaulniPotrosaci.Controls.Add(btnObrisiIndividualni);
            tabIndividaulniPotrosaci.Controls.Add(btnDodajIndividualni);
            tabIndividaulniPotrosaci.Controls.Add(label24);
            tabIndividaulniPotrosaci.Controls.Add(label23);
            tabIndividaulniPotrosaci.Controls.Add(btnUndoPotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(btnSavePotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(btnIndividualniPodstanice);
            tabIndividaulniPotrosaci.Controls.Add(btnMernoMestoIndividualniPotrosac);
            tabIndividaulniPotrosaci.Controls.Add(tbIndividualniPotrosacTelefon);
            tabIndividaulniPotrosaci.Controls.Add(label15);
            tabIndividaulniPotrosaci.Controls.Add(tbIndividualniPotrosacEmail);
            tabIndividaulniPotrosaci.Controls.Add(label14);
            tabIndividaulniPotrosaci.Controls.Add(tbIndividualniPotrosacAdresa);
            tabIndividaulniPotrosaci.Controls.Add(label13);
            tabIndividaulniPotrosaci.Controls.Add(tbIndividualniPotrosacNaziv);
            tabIndividaulniPotrosaci.Controls.Add(label12);
            tabIndividaulniPotrosaci.Controls.Add(dgIndividualniPotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(cbPodstanice);
            tabIndividaulniPotrosaci.Location = new Point(4, 34);
            tabIndividaulniPotrosaci.Name = "tabIndividaulniPotrosaci";
            tabIndividaulniPotrosaci.Padding = new Padding(3);
            tabIndividaulniPotrosaci.Size = new Size(2759, 1203);
            tabIndividaulniPotrosaci.TabIndex = 3;
            tabIndividaulniPotrosaci.Text = "Individualni potrošači";
            tabIndividaulniPotrosaci.UseVisualStyleBackColor = true;
            // 
            // btnObrisiIndividualni
            // 
            btnObrisiIndividualni.Image = (Image)resources.GetObject("btnObrisiIndividualni.Image");
            btnObrisiIndividualni.Location = new Point(124, 83);
            btnObrisiIndividualni.Name = "btnObrisiIndividualni";
            btnObrisiIndividualni.Size = new Size(112, 64);
            btnObrisiIndividualni.TabIndex = 36;
            btnObrisiIndividualni.UseVisualStyleBackColor = true;
            btnObrisiIndividualni.Click += btnObrisiIndividualni_Click;
            // 
            // btnDodajIndividualni
            // 
            btnDodajIndividualni.Image = (Image)resources.GetObject("btnDodajIndividualni.Image");
            btnDodajIndividualni.Location = new Point(6, 83);
            btnDodajIndividualni.Name = "btnDodajIndividualni";
            btnDodajIndividualni.Size = new Size(112, 64);
            btnDodajIndividualni.TabIndex = 35;
            btnDodajIndividualni.UseVisualStyleBackColor = true;
            btnDodajIndividualni.Click += btnDodajIndividualni_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.LightGray;
            label24.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label24.ForeColor = Color.Gray;
            label24.Location = new Point(553, 1137);
            label24.Name = "label24";
            label24.Size = new Size(412, 48);
            label24.TabIndex = 34;
            label24.Text = "Individualni potrošači";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 17);
            label23.Name = "label23";
            label23.Size = new Size(101, 25);
            label23.TabIndex = 31;
            label23.Text = "Podstanica:";
            // 
            // btnUndoPotrosaci
            // 
            btnUndoPotrosaci.Image = (Image)resources.GetObject("btnUndoPotrosaci.Image");
            btnUndoPotrosaci.ImageAlign = ContentAlignment.MiddleLeft;
            btnUndoPotrosaci.Location = new Point(775, 83);
            btnUndoPotrosaci.Name = "btnUndoPotrosaci";
            btnUndoPotrosaci.Padding = new Padding(20, 0, 0, 0);
            btnUndoPotrosaci.Size = new Size(96, 64);
            btnUndoPotrosaci.TabIndex = 29;
            btnUndoPotrosaci.UseVisualStyleBackColor = true;
            btnUndoPotrosaci.Visible = false;
            btnUndoPotrosaci.Click += btnUndoPotrosaci_Click;
            // 
            // btnSavePotrosaci
            // 
            btnSavePotrosaci.Image = (Image)resources.GetObject("btnSavePotrosaci.Image");
            btnSavePotrosaci.ImageAlign = ContentAlignment.MiddleLeft;
            btnSavePotrosaci.Location = new Point(877, 83);
            btnSavePotrosaci.Name = "btnSavePotrosaci";
            btnSavePotrosaci.Padding = new Padding(20, 0, 0, 0);
            btnSavePotrosaci.Size = new Size(96, 64);
            btnSavePotrosaci.TabIndex = 28;
            btnSavePotrosaci.UseVisualStyleBackColor = true;
            btnSavePotrosaci.Visible = false;
            btnSavePotrosaci.Click += btnSavePotrosaci_Click;
            // 
            // btnIndividualniPodstanice
            // 
            btnIndividualniPodstanice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIndividualniPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnIndividualniPodstanice.Location = new Point(2524, 1124);
            btnIndividualniPodstanice.Name = "btnIndividualniPodstanice";
            btnIndividualniPodstanice.Size = new Size(229, 73);
            btnIndividualniPodstanice.TabIndex = 27;
            btnIndividualniPodstanice.Text = "<<< Podstanice";
            btnIndividualniPodstanice.UseVisualStyleBackColor = true;
            btnIndividualniPodstanice.Click += btnIndividualniPodstanice_Click;
            // 
            // btnMernoMestoIndividualniPotrosac
            // 
            btnMernoMestoIndividualniPotrosac.Location = new Point(982, 1124);
            btnMernoMestoIndividualniPotrosac.Name = "btnMernoMestoIndividualniPotrosac";
            btnMernoMestoIndividualniPotrosac.Size = new Size(340, 70);
            btnMernoMestoIndividualniPotrosac.TabIndex = 20;
            btnMernoMestoIndividualniPotrosac.Text = "Formiraj merno mesto ...";
            btnMernoMestoIndividualniPotrosac.UseVisualStyleBackColor = true;
            btnMernoMestoIndividualniPotrosac.Click += btnMernoMestoIndividualniPotrosac_Click;
            // 
            // tbIndividualniPotrosacTelefon
            // 
            tbIndividualniPotrosacTelefon.BackColor = Color.White;
            tbIndividualniPotrosacTelefon.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacTelefon.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacTelefon.Location = new Point(1012, 367);
            tbIndividualniPotrosacTelefon.Name = "tbIndividualniPotrosacTelefon";
            tbIndividualniPotrosacTelefon.Size = new Size(450, 31);
            tbIndividualniPotrosacTelefon.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1012, 339);
            label15.Name = "label15";
            label15.Size = new Size(72, 25);
            label15.TabIndex = 14;
            label15.Text = "Telefon:";
            // 
            // tbIndividualniPotrosacEmail
            // 
            tbIndividualniPotrosacEmail.BackColor = Color.White;
            tbIndividualniPotrosacEmail.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacEmail.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Email", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacEmail.Location = new Point(1012, 305);
            tbIndividualniPotrosacEmail.Name = "tbIndividualniPotrosacEmail";
            tbIndividualniPotrosacEmail.Size = new Size(450, 31);
            tbIndividualniPotrosacEmail.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1012, 277);
            label14.Name = "label14";
            label14.Size = new Size(58, 25);
            label14.TabIndex = 12;
            label14.Text = "Email:";
            // 
            // tbIndividualniPotrosacAdresa
            // 
            tbIndividualniPotrosacAdresa.BackColor = Color.White;
            tbIndividualniPotrosacAdresa.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacAdresa.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Adresa", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacAdresa.Location = new Point(1012, 243);
            tbIndividualniPotrosacAdresa.Name = "tbIndividualniPotrosacAdresa";
            tbIndividualniPotrosacAdresa.Size = new Size(450, 31);
            tbIndividualniPotrosacAdresa.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1012, 215);
            label13.Name = "label13";
            label13.Size = new Size(71, 25);
            label13.TabIndex = 10;
            label13.Text = "Adresa:";
            // 
            // tbIndividualniPotrosacNaziv
            // 
            tbIndividualniPotrosacNaziv.BackColor = Color.White;
            tbIndividualniPotrosacNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacNaziv.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacNaziv.Location = new Point(1012, 181);
            tbIndividualniPotrosacNaziv.Name = "tbIndividualniPotrosacNaziv";
            tbIndividualniPotrosacNaziv.Size = new Size(450, 31);
            tbIndividualniPotrosacNaziv.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1012, 153);
            label12.Name = "label12";
            label12.Size = new Size(59, 25);
            label12.TabIndex = 8;
            label12.Text = "Naziv:";
            // 
            // dgIndividualniPotrosaci
            // 
            dgIndividualniPotrosaci.AllowUserToAddRows = false;
            dgIndividualniPotrosaci.AllowUserToDeleteRows = false;
            dgIndividualniPotrosaci.AllowUserToResizeRows = false;
            dgIndividualniPotrosaci.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgIndividualniPotrosaci.AutoGenerateColumns = false;
            dgIndividualniPotrosaci.BackgroundColor = Color.LightGray;
            dgIndividualniPotrosaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIndividualniPotrosaci.ColumnHeadersVisible = false;
            dgIndividualniPotrosaci.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn3 });
            dgIndividualniPotrosaci.DataSource = _BsIndividualniPotrosaci;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgIndividualniPotrosaci.DefaultCellStyle = dataGridViewCellStyle7;
            dgIndividualniPotrosaci.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgIndividualniPotrosaci.Location = new Point(6, 153);
            dgIndividualniPotrosaci.MultiSelect = false;
            dgIndividualniPotrosaci.Name = "dgIndividualniPotrosaci";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgIndividualniPotrosaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgIndividualniPotrosaci.RowHeadersWidth = 32;
            dgIndividualniPotrosaci.ScrollBars = ScrollBars.Vertical;
            dgIndividualniPotrosaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgIndividualniPotrosaci.Size = new Size(970, 1044);
            dgIndividualniPotrosaci.TabIndex = 7;
            // 
            // nazivDataGridViewTextBoxColumn3
            // 
            nazivDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn3.HeaderText = "Naziv";
            nazivDataGridViewTextBoxColumn3.MinimumWidth = 8;
            nazivDataGridViewTextBoxColumn3.Name = "nazivDataGridViewTextBoxColumn3";
            // 
            // frmMaticniPodaci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(2791, 1258);
            Controls.Add(tabMaticniPodaci);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMaticniPodaci";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matični podaci";
            FormClosing += frmMaticniPodaci_FormClosing;
            ((System.ComponentModel.ISupportInitialize)_BsToplane).EndInit();
            ((System.ComponentModel.ISupportInitialize)_BsPoslovniSistem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgToplane).EndInit();
            ((System.ComponentModel.ISupportInitialize)_BsIndividualniPotrosaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)_BsPodstanice).EndInit();
            ((System.ComponentModel.ISupportInitialize)_BsKotlarnice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgKotlarnice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPodstanice).EndInit();
            tabMaticniPodaci.ResumeLayout(false);
            tpToplane.ResumeLayout(false);
            tpToplane.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabIndividaulniPotrosaci.ResumeLayout(false);
            tabIndividaulniPotrosaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgIndividualniPotrosaci).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbToplane;
        private BindingSource _BsToplane;
        private GroupBox gbToplane;
        private BindingSource _BsKotlarnice;
        private BindingSource _BsPodstanice;
        private ComboBox cbKotlarnice;
        private ComboBox cbPodstanice;
        private DataGridView dgToplane;
        private DataGridView dgKotlarnice;
        private DataGridView dgPodstanice;
        private DataGridViewCheckBoxColumn isDirtyDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn sefDataGridViewTextBoxColumn;
        private TabControl tabMaticniPodaci;
        private TabPage tpToplane;
        private TabPage tabPage2;
        private TextBox tbToplanaNapomena;
        private TextBox tbToplanaNaziv;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tbKotlarnicaNapomena;
        private Label label7;
        private TextBox tbKotlarnicaOdgovornoLice;
        private Label label6;
        private TextBox tbKotlarnicaTelefon;
        private Label label5;
        private TextBox tbKotlarnicaAdresa;
        private Label label4;
        private TextBox tbKotlarnicaNaziv;
        private TabPage tabPage1;
        private Label label8;
        private TextBox tbPodstanicaNaziv;
        private Label label11;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private TabPage tabIndividaulniPotrosaci;
        private DataGridView dgIndividualniPotrosaci;
        private BindingSource _BsIndividualniPotrosaci;
        private TextBox tbIndividualniPotrosacNaziv;
        private Label label12;
        private TextBox tbIndividualniPotrosacTelefon;
        private Label label15;
        private TextBox tbIndividualniPotrosacEmail;
        private Label label14;
        private TextBox tbIndividualniPotrosacAdresa;
        private Label label13;
        private Button btnSaveToplane;
        private Label label17;
        private TextBox textBox5;
        private Label label16;
        private TextBox textBox4;
        private Button btnUndoToplane;
        private Button btnMernoMestoPodstanica;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnMernoMestoIndividualniPotrosac;
        private Button btnKotlarnice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btnToplane;
        private Button btnPodstanice;
        private Button btnUndoPodstanice;
        private Button btnSavePodstanice;
        private Button btnPodstaniceKotlarnice;
        private Button btnPostaniceIndividualni;
        private Button btnUndoPotrosaci;
        private Button btnSavePotrosaci;
        private Button btnIndividualniPodstanice;
        private Button btnObrisiToplanu;
        private Button btnDodajToplanu;
        private Label label18;
        private BindingSource _BsPoslovniSistem;
        private DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn poslovniSistemDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn isChangedDataGridViewCheckBoxColumn3;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn3;
        private DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn2;
        private Button btnKotlarniceObrisi;
        private Button btnKotlarniceDodaj;
        private Button btnUndoKotlarnice;
        private Button btnSaveKotlarnice;
        private Label label19;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private Label label20;
        private Label label21;
        private Button btnKPodstaniceObrisi;
        private Button btnKPodstaniceDodaj;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button btnObrisiIndividualni;
        private Button btnDodajIndividualni;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn3;
    }
}
