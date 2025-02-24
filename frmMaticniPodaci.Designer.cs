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
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaticniPodaci));
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
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
            gbUnosToplane = new GroupBox();
            tbToplanaNaziv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbToplanaNapomena = new TextBox();
            label18 = new Label();
            btnObrisiToplanu = new Button();
            btnDodajToplanu = new Button();
            btnUndoToplane = new Button();
            btnKotlarnice = new Button();
            btnSaveToplane = new Button();
            tabPage2 = new TabPage();
            gbKotlarnice = new GroupBox();
            tbKotlarnicaNaziv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbKotlarnicaAdresa = new TextBox();
            label5 = new Label();
            tbKotlarnicaTelefon = new TextBox();
            label6 = new Label();
            tbKotlarnicaOdgovornoLice = new TextBox();
            label7 = new Label();
            tbKotlarnicaNapomena = new TextBox();
            label20 = new Label();
            label19 = new Label();
            btnKotlarniceObrisi = new Button();
            btnKotlarniceDodaj = new Button();
            btnUndoKotlarnice = new Button();
            btnSaveKotlarnice = new Button();
            btnToplane = new Button();
            btnPodstanice = new Button();
            tabPage1 = new TabPage();
            gbUnosPodstanica = new GroupBox();
            tbPodstanicaNaziv = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            btnMernoMestoPodstanica = new Button();
            label22 = new Label();
            btnKPodstaniceObrisi = new Button();
            btnKPodstaniceDodaj = new Button();
            label21 = new Label();
            btnUndoPodstanice = new Button();
            btnSavePodstanice = new Button();
            btnPodstaniceKotlarnice = new Button();
            btnPostaniceIndividualni = new Button();
            tabIndividaulniPotrosaci = new TabPage();
            gUnosbIndividualniPotrosac = new GroupBox();
            tbIndividualniPotrosacNaziv = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tbIndividualniPotrosacAdresa = new TextBox();
            label14 = new Label();
            tbIndividualniPotrosacEmail = new TextBox();
            label15 = new Label();
            tbIndividualniPotrosacTelefon = new TextBox();
            btnMernoMestoIndividualniPotrosac = new Button();
            btnObrisiIndividualni = new Button();
            btnDodajIndividualni = new Button();
            label24 = new Label();
            label23 = new Label();
            btnUndoPotrosaci = new Button();
            btnSavePotrosaci = new Button();
            btnIndividualniPodstanice = new Button();
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
            gbUnosToplane.SuspendLayout();
            tabPage2.SuspendLayout();
            gbKotlarnice.SuspendLayout();
            tabPage1.SuspendLayout();
            gbUnosPodstanica.SuspendLayout();
            tabIndividaulniPotrosaci.SuspendLayout();
            gUnosbIndividualniPotrosac.SuspendLayout();
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
            cbToplane.Location = new Point(64, 6);
            cbToplane.Margin = new Padding(2, 2, 2, 2);
            cbToplane.Name = "cbToplane";
            cbToplane.Size = new Size(420, 29);
            cbToplane.TabIndex = 1;
            cbToplane.ValueMember = "Id";
            // 
            // _BsToplane
            // 
            _BsToplane.DataMember = "MojeToplane";
            _BsToplane.DataSource = _BsPoslovniSistem;
            _BsToplane.PositionChanged += _BsToplane_PositionChanged;
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
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = SystemColors.Control;
            dataGridViewCellStyle37.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle37.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle37.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            dgToplane.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            dgToplane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgToplane.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn });
            dgToplane.DataSource = _BsToplane;
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = SystemColors.Window;
            dataGridViewCellStyle38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle38.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle38.SelectionForeColor = Color.Black;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.False;
            dgToplane.DefaultCellStyle = dataGridViewCellStyle38;
            dgToplane.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgToplane.EnableHeadersVisualStyles = false;
            dgToplane.Location = new Point(2, 100);
            dgToplane.Margin = new Padding(2, 2, 2, 2);
            dgToplane.MultiSelect = false;
            dgToplane.Name = "dgToplane";
            dgToplane.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = SystemColors.Control;
            dataGridViewCellStyle39.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle39.SelectionForeColor = Color.Black;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            dgToplane.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            dgToplane.RowHeadersWidth = 32;
            dgToplane.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgToplane.ScrollBars = ScrollBars.Vertical;
            dgToplane.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgToplane.Size = new Size(679, 615);
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
            _BsIndividualniPotrosaci.PositionChanged += _BsIndividualniPotrosaci_PositionChanged;
            // 
            // _BsPodstanice
            // 
            _BsPodstanice.DataMember = "Podstanice";
            _BsPodstanice.DataSource = _BsKotlarnice;
            _BsPodstanice.PositionChanged += _BsPodstanice_PositionChanged;
            // 
            // _BsKotlarnice
            // 
            _BsKotlarnice.DataMember = "Kotlarnice";
            _BsKotlarnice.DataSource = _BsToplane;
            _BsKotlarnice.PositionChanged += _BsKotlarnice_PositionChanged;
            // 
            // cbKotlarnice
            // 
            cbKotlarnice.DataSource = _BsKotlarnice;
            cbKotlarnice.DisplayMember = "Naziv";
            cbKotlarnice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbKotlarnice.FormattingEnabled = true;
            cbKotlarnice.Location = new Point(81, 7);
            cbKotlarnice.Margin = new Padding(2, 2, 2, 2);
            cbKotlarnice.Name = "cbKotlarnice";
            cbKotlarnice.Size = new Size(420, 29);
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
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = SystemColors.Control;
            dataGridViewCellStyle40.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle40.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle40.SelectionForeColor = Color.Black;
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
            dgKotlarnice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            dgKotlarnice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKotlarnice.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn1 });
            dgKotlarnice.DataSource = _BsKotlarnice;
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = SystemColors.Window;
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle41.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle41.SelectionForeColor = Color.Black;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.False;
            dgKotlarnice.DefaultCellStyle = dataGridViewCellStyle41;
            dgKotlarnice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgKotlarnice.EnableHeadersVisualStyles = false;
            dgKotlarnice.Location = new Point(4, 110);
            dgKotlarnice.Margin = new Padding(2, 2, 2, 2);
            dgKotlarnice.MultiSelect = false;
            dgKotlarnice.Name = "dgKotlarnice";
            dgKotlarnice.RowHeadersWidth = 32;
            dgKotlarnice.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Control;
            dgKotlarnice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgKotlarnice.ScrollBars = ScrollBars.Vertical;
            dgKotlarnice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKotlarnice.Size = new Size(679, 601);
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
            cbPodstanice.Location = new Point(90, 7);
            cbPodstanice.Margin = new Padding(2, 2, 2, 2);
            cbPodstanice.Name = "cbPodstanice";
            cbPodstanice.Size = new Size(420, 29);
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
            dgPodstanice.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn2 });
            dgPodstanice.DataSource = _BsPodstanice;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = SystemColors.Window;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle42.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle42.SelectionForeColor = Color.Black;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.False;
            dgPodstanice.DefaultCellStyle = dataGridViewCellStyle42;
            dgPodstanice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgPodstanice.EnableHeadersVisualStyles = false;
            dgPodstanice.Location = new Point(4, 110);
            dgPodstanice.Margin = new Padding(2, 2, 2, 2);
            dgPodstanice.MultiSelect = false;
            dgPodstanice.Name = "dgPodstanice";
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = SystemColors.Control;
            dataGridViewCellStyle43.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle43.SelectionForeColor = Color.Black;
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
            dgPodstanice.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            dgPodstanice.RowHeadersWidth = 32;
            dgPodstanice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgPodstanice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgPodstanice.ScrollBars = ScrollBars.Vertical;
            dgPodstanice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPodstanice.Size = new Size(679, 607);
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
            tabMaticniPodaci.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabMaticniPodaci.Controls.Add(tpToplane);
            tabMaticniPodaci.Controls.Add(tabPage2);
            tabMaticniPodaci.Controls.Add(tabPage1);
            tabMaticniPodaci.Controls.Add(tabIndividaulniPotrosaci);
            tabMaticniPodaci.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tabMaticniPodaci.Location = new Point(8, 7);
            tabMaticniPodaci.Margin = new Padding(2, 2, 2, 2);
            tabMaticniPodaci.Name = "tabMaticniPodaci";
            tabMaticniPodaci.SelectedIndex = 0;
            tabMaticniPodaci.Size = new Size(1446, 749);
            tabMaticniPodaci.TabIndex = 8;
            tabMaticniPodaci.Selecting += tabMaticniPodaci_Selecting;
            // 
            // tpToplane
            // 
            tpToplane.Controls.Add(gbUnosToplane);
            tpToplane.Controls.Add(label18);
            tpToplane.Controls.Add(btnObrisiToplanu);
            tpToplane.Controls.Add(btnDodajToplanu);
            tpToplane.Controls.Add(btnUndoToplane);
            tpToplane.Controls.Add(btnKotlarnice);
            tpToplane.Controls.Add(btnSaveToplane);
            tpToplane.Controls.Add(dgToplane);
            tpToplane.Location = new Point(4, 24);
            tpToplane.Margin = new Padding(2, 2, 2, 2);
            tpToplane.Name = "tpToplane";
            tpToplane.Padding = new Padding(2, 2, 2, 2);
            tpToplane.Size = new Size(1438, 721);
            tpToplane.TabIndex = 0;
            tpToplane.Text = "Toplane";
            tpToplane.UseVisualStyleBackColor = true;
            // 
            // gbUnosToplane
            // 
            gbUnosToplane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbUnosToplane.Controls.Add(tbToplanaNaziv);
            gbUnosToplane.Controls.Add(label1);
            gbUnosToplane.Controls.Add(label2);
            gbUnosToplane.Controls.Add(tbToplanaNapomena);
            gbUnosToplane.Enabled = false;
            gbUnosToplane.Location = new Point(685, 100);
            gbUnosToplane.Margin = new Padding(2, 2, 2, 2);
            gbUnosToplane.Name = "gbUnosToplane";
            gbUnosToplane.Padding = new Padding(2, 2, 2, 2);
            gbUnosToplane.Size = new Size(447, 615);
            gbUnosToplane.TabIndex = 25;
            gbUnosToplane.TabStop = false;
            gbUnosToplane.Text = "Toplana";
            // 
            // tbToplanaNaziv
            // 
            tbToplanaNaziv.BackColor = Color.White;
            tbToplanaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbToplanaNaziv.DataBindings.Add(new Binding("Text", _BsToplane, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbToplanaNaziv.Location = new Point(19, 52);
            tbToplanaNaziv.Margin = new Padding(2, 2, 2, 2);
            tbToplanaNaziv.Name = "tbToplanaNaziv";
            tbToplanaNaziv.Size = new Size(408, 23);
            tbToplanaNaziv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Napomena:";
            // 
            // tbToplanaNapomena
            // 
            tbToplanaNapomena.BackColor = Color.White;
            tbToplanaNapomena.BorderStyle = BorderStyle.FixedSingle;
            tbToplanaNapomena.DataBindings.Add(new Binding("Text", _BsToplane, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            tbToplanaNapomena.Location = new Point(19, 98);
            tbToplanaNapomena.Margin = new Padding(2, 2, 2, 2);
            tbToplanaNapomena.Multiline = true;
            tbToplanaNapomena.Name = "tbToplanaNapomena";
            tbToplanaNapomena.Size = new Size(408, 105);
            tbToplanaNapomena.TabIndex = 2;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label18.AutoSize = true;
            label18.BackColor = Color.LightGray;
            label18.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(4, 679);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(107, 32);
            label18.TabIndex = 24;
            label18.Text = "Toplane";
            // 
            // btnObrisiToplanu
            // 
            btnObrisiToplanu.Image = (Image)resources.GetObject("btnObrisiToplanu.Image");
            btnObrisiToplanu.Location = new Point(87, 33);
            btnObrisiToplanu.Margin = new Padding(2, 2, 2, 2);
            btnObrisiToplanu.Name = "btnObrisiToplanu";
            btnObrisiToplanu.Size = new Size(78, 64);
            btnObrisiToplanu.TabIndex = 23;
            btnObrisiToplanu.UseVisualStyleBackColor = true;
            btnObrisiToplanu.Click += btnObrisiToplanu_Click;
            // 
            // btnDodajToplanu
            // 
            btnDodajToplanu.Image = (Image)resources.GetObject("btnDodajToplanu.Image");
            btnDodajToplanu.Location = new Point(4, 33);
            btnDodajToplanu.Margin = new Padding(2, 2, 2, 2);
            btnDodajToplanu.Name = "btnDodajToplanu";
            btnDodajToplanu.Size = new Size(78, 64);
            btnDodajToplanu.TabIndex = 22;
            btnDodajToplanu.UseVisualStyleBackColor = true;
            btnDodajToplanu.Click += btnDodajToplanu_Click;
            // 
            // btnUndoToplane
            // 
            btnUndoToplane.Image = (Image)resources.GetObject("btnUndoToplane.Image");
            btnUndoToplane.Location = new Point(372, 32);
            btnUndoToplane.Margin = new Padding(2, 2, 2, 2);
            btnUndoToplane.Name = "btnUndoToplane";
            btnUndoToplane.Padding = new Padding(14, 0, 0, 0);
            btnUndoToplane.Size = new Size(153, 65);
            btnUndoToplane.TabIndex = 10;
            btnUndoToplane.UseVisualStyleBackColor = true;
            btnUndoToplane.Visible = false;
            btnUndoToplane.Click += btnUndoIzmena_Click;
            // 
            // btnKotlarnice
            // 
            btnKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnKotlarnice.Location = new Point(1299, 679);
            btnKotlarnice.Margin = new Padding(2, 2, 2, 2);
            btnKotlarnice.Name = "btnKotlarnice";
            btnKotlarnice.Size = new Size(135, 38);
            btnKotlarnice.TabIndex = 9;
            btnKotlarnice.Text = "Kotlarnice >>>";
            btnKotlarnice.UseVisualStyleBackColor = true;
            btnKotlarnice.Click += btnKotlarnice_Click;
            // 
            // btnSaveToplane
            // 
            btnSaveToplane.Image = (Image)resources.GetObject("btnSaveToplane.Image");
            btnSaveToplane.Location = new Point(528, 32);
            btnSaveToplane.Margin = new Padding(2, 2, 2, 2);
            btnSaveToplane.Name = "btnSaveToplane";
            btnSaveToplane.Padding = new Padding(14, 0, 0, 0);
            btnSaveToplane.Size = new Size(153, 65);
            btnSaveToplane.TabIndex = 9;
            btnSaveToplane.UseVisualStyleBackColor = true;
            btnSaveToplane.Visible = false;
            btnSaveToplane.Click += btnSaveEnabled_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gbKotlarnice);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(btnKotlarniceObrisi);
            tabPage2.Controls.Add(btnKotlarniceDodaj);
            tabPage2.Controls.Add(btnUndoKotlarnice);
            tabPage2.Controls.Add(btnSaveKotlarnice);
            tabPage2.Controls.Add(btnToplane);
            tabPage2.Controls.Add(btnPodstanice);
            tabPage2.Controls.Add(dgKotlarnice);
            tabPage2.Controls.Add(cbToplane);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(1438, 721);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kotlarnice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbKotlarnice
            // 
            gbKotlarnice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbKotlarnice.Controls.Add(tbKotlarnicaNaziv);
            gbKotlarnice.Controls.Add(label3);
            gbKotlarnice.Controls.Add(label4);
            gbKotlarnice.Controls.Add(tbKotlarnicaAdresa);
            gbKotlarnice.Controls.Add(label5);
            gbKotlarnice.Controls.Add(tbKotlarnicaTelefon);
            gbKotlarnice.Controls.Add(label6);
            gbKotlarnice.Controls.Add(tbKotlarnicaOdgovornoLice);
            gbKotlarnice.Controls.Add(label7);
            gbKotlarnice.Controls.Add(tbKotlarnicaNapomena);
            gbKotlarnice.Enabled = false;
            gbKotlarnice.Location = new Point(687, 100);
            gbKotlarnice.Margin = new Padding(2, 2, 2, 2);
            gbKotlarnice.Name = "gbKotlarnice";
            gbKotlarnice.Padding = new Padding(2, 2, 2, 2);
            gbKotlarnice.Size = new Size(447, 611);
            gbKotlarnice.TabIndex = 30;
            gbKotlarnice.TabStop = false;
            gbKotlarnice.Text = "Kotlarnica";
            // 
            // tbKotlarnicaNaziv
            // 
            tbKotlarnicaNaziv.BackColor = Color.White;
            tbKotlarnicaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaNaziv.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaNaziv.Location = new Point(24, 45);
            tbKotlarnicaNaziv.Margin = new Padding(2, 2, 2, 2);
            tbKotlarnicaNaziv.Name = "tbKotlarnicaNaziv";
            tbKotlarnicaNaziv.Size = new Size(398, 23);
            tbKotlarnicaNaziv.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Naziv:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 72);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "Adresa:";
            // 
            // tbKotlarnicaAdresa
            // 
            tbKotlarnicaAdresa.BackColor = Color.White;
            tbKotlarnicaAdresa.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaAdresa.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Adresa", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaAdresa.Location = new Point(24, 91);
            tbKotlarnicaAdresa.Margin = new Padding(2, 2, 2, 2);
            tbKotlarnicaAdresa.Name = "tbKotlarnicaAdresa";
            tbKotlarnicaAdresa.Size = new Size(398, 23);
            tbKotlarnicaAdresa.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 118);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefon:";
            // 
            // tbKotlarnicaTelefon
            // 
            tbKotlarnicaTelefon.BackColor = Color.White;
            tbKotlarnicaTelefon.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaTelefon.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaTelefon.Location = new Point(24, 137);
            tbKotlarnicaTelefon.Margin = new Padding(2, 2, 2, 2);
            tbKotlarnicaTelefon.Name = "tbKotlarnicaTelefon";
            tbKotlarnicaTelefon.Size = new Size(398, 23);
            tbKotlarnicaTelefon.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 164);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 14;
            label6.Text = "Odgovorno lice:";
            // 
            // tbKotlarnicaOdgovornoLice
            // 
            tbKotlarnicaOdgovornoLice.BackColor = Color.White;
            tbKotlarnicaOdgovornoLice.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaOdgovornoLice.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Sef", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaOdgovornoLice.Location = new Point(24, 183);
            tbKotlarnicaOdgovornoLice.Margin = new Padding(2, 2, 2, 2);
            tbKotlarnicaOdgovornoLice.Name = "tbKotlarnicaOdgovornoLice";
            tbKotlarnicaOdgovornoLice.Size = new Size(398, 23);
            tbKotlarnicaOdgovornoLice.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 210);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 16;
            label7.Text = "Napomena:";
            // 
            // tbKotlarnicaNapomena
            // 
            tbKotlarnicaNapomena.BackColor = Color.White;
            tbKotlarnicaNapomena.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaNapomena.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaNapomena.Location = new Point(24, 229);
            tbKotlarnicaNapomena.Margin = new Padding(2, 2, 2, 2);
            tbKotlarnicaNapomena.Multiline = true;
            tbKotlarnicaNapomena.Name = "tbKotlarnicaNapomena";
            tbKotlarnicaNapomena.Size = new Size(398, 75);
            tbKotlarnicaNapomena.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 14);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(52, 15);
            label20.TabIndex = 29;
            label20.Text = "Toplana:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.LightGray;
            label19.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(8, 670);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(133, 32);
            label19.TabIndex = 28;
            label19.Text = "Kotlarnice";
            // 
            // btnKotlarniceObrisi
            // 
            btnKotlarniceObrisi.Image = (Image)resources.GetObject("btnKotlarniceObrisi.Image");
            btnKotlarniceObrisi.Location = new Point(88, 43);
            btnKotlarniceObrisi.Margin = new Padding(2, 2, 2, 2);
            btnKotlarniceObrisi.Name = "btnKotlarniceObrisi";
            btnKotlarniceObrisi.Size = new Size(78, 63);
            btnKotlarniceObrisi.TabIndex = 27;
            btnKotlarniceObrisi.UseVisualStyleBackColor = true;
            btnKotlarniceObrisi.Click += btnKotlarniceObrisi_Click;
            // 
            // btnKotlarniceDodaj
            // 
            btnKotlarniceDodaj.Image = (Image)resources.GetObject("btnKotlarniceDodaj.Image");
            btnKotlarniceDodaj.Location = new Point(6, 41);
            btnKotlarniceDodaj.Margin = new Padding(2, 2, 2, 2);
            btnKotlarniceDodaj.Name = "btnKotlarniceDodaj";
            btnKotlarniceDodaj.Size = new Size(78, 63);
            btnKotlarniceDodaj.TabIndex = 26;
            btnKotlarniceDodaj.UseVisualStyleBackColor = true;
            btnKotlarniceDodaj.Click += btnKotlarniceDodaj_Click;
            // 
            // btnUndoKotlarnice
            // 
            btnUndoKotlarnice.Image = (Image)resources.GetObject("btnUndoKotlarnice.Image");
            btnUndoKotlarnice.Location = new Point(381, 39);
            btnUndoKotlarnice.Margin = new Padding(2, 2, 2, 2);
            btnUndoKotlarnice.Name = "btnUndoKotlarnice";
            btnUndoKotlarnice.Padding = new Padding(14, 0, 0, 0);
            btnUndoKotlarnice.Size = new Size(146, 65);
            btnUndoKotlarnice.TabIndex = 25;
            btnUndoKotlarnice.UseVisualStyleBackColor = true;
            btnUndoKotlarnice.Visible = false;
            btnUndoKotlarnice.Click += btnUndoKotlarnice_Click;
            // 
            // btnSaveKotlarnice
            // 
            btnSaveKotlarnice.Image = (Image)resources.GetObject("btnSaveKotlarnice.Image");
            btnSaveKotlarnice.Location = new Point(531, 39);
            btnSaveKotlarnice.Margin = new Padding(2, 2, 2, 2);
            btnSaveKotlarnice.Name = "btnSaveKotlarnice";
            btnSaveKotlarnice.Padding = new Padding(14, 0, 0, 0);
            btnSaveKotlarnice.Size = new Size(153, 65);
            btnSaveKotlarnice.TabIndex = 24;
            btnSaveKotlarnice.UseVisualStyleBackColor = true;
            btnSaveKotlarnice.Visible = false;
            btnSaveKotlarnice.Click += btnSaveKotlarnice_Click;
            // 
            // btnToplane
            // 
            btnToplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnToplane.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnToplane.Location = new Point(1299, 619);
            btnToplane.Margin = new Padding(2, 2, 2, 2);
            btnToplane.Name = "btnToplane";
            btnToplane.Size = new Size(135, 44);
            btnToplane.TabIndex = 19;
            btnToplane.Text = "<<< Toplane";
            btnToplane.UseVisualStyleBackColor = true;
            btnToplane.Click += btnToplane_Click;
            // 
            // btnPodstanice
            // 
            btnPodstanice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPodstanice.Location = new Point(1299, 667);
            btnPodstanice.Margin = new Padding(2, 2, 2, 2);
            btnPodstanice.Name = "btnPodstanice";
            btnPodstanice.Size = new Size(135, 44);
            btnPodstanice.TabIndex = 18;
            btnPodstanice.Text = "Podstanice >>>";
            btnPodstanice.UseVisualStyleBackColor = true;
            btnPodstanice.Click += btnPodstanice_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gbUnosPodstanica);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(btnKPodstaniceObrisi);
            tabPage1.Controls.Add(btnKPodstaniceDodaj);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(btnUndoPodstanice);
            tabPage1.Controls.Add(btnSavePodstanice);
            tabPage1.Controls.Add(btnPodstaniceKotlarnice);
            tabPage1.Controls.Add(btnPostaniceIndividualni);
            tabPage1.Controls.Add(cbKotlarnice);
            tabPage1.Controls.Add(dgPodstanice);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(1438, 721);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Podstanice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbUnosPodstanica
            // 
            gbUnosPodstanica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbUnosPodstanica.Controls.Add(tbPodstanicaNaziv);
            gbUnosPodstanica.Controls.Add(label8);
            gbUnosPodstanica.Controls.Add(textBox1);
            gbUnosPodstanica.Controls.Add(label9);
            gbUnosPodstanica.Controls.Add(textBox2);
            gbUnosPodstanica.Controls.Add(label10);
            gbUnosPodstanica.Controls.Add(textBox3);
            gbUnosPodstanica.Controls.Add(label11);
            gbUnosPodstanica.Controls.Add(btnMernoMestoPodstanica);
            gbUnosPodstanica.Enabled = false;
            gbUnosPodstanica.Location = new Point(687, 110);
            gbUnosPodstanica.Margin = new Padding(2, 2, 2, 2);
            gbUnosPodstanica.Name = "gbUnosPodstanica";
            gbUnosPodstanica.Padding = new Padding(2, 2, 2, 2);
            gbUnosPodstanica.Size = new Size(447, 607);
            gbUnosPodstanica.TabIndex = 34;
            gbUnosPodstanica.TabStop = false;
            gbUnosPodstanica.Text = "Podstanica";
            // 
            // tbPodstanicaNaziv
            // 
            tbPodstanicaNaziv.BackColor = Color.White;
            tbPodstanicaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbPodstanicaNaziv.DataBindings.Add(new Binding("Text", _BsPodstanice, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbPodstanicaNaziv.Location = new Point(25, 45);
            tbPodstanicaNaziv.Margin = new Padding(2, 2, 2, 2);
            tbPodstanicaNaziv.Name = "tbPodstanicaNaziv";
            tbPodstanicaNaziv.Size = new Size(395, 23);
            tbPodstanicaNaziv.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 26);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 8;
            label8.Text = "Naziv:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.DataBindings.Add(new Binding("Text", _BsPodstanice, "Adresa", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(25, 91);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 23);
            textBox1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 72);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 10;
            label9.Text = "Adresa:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.DataBindings.Add(new Binding("Text", _BsPodstanice, "OdgovornoLice", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(25, 137);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 23);
            textBox2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 118);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 12;
            label10.Text = "Odgovorno lice:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.DataBindings.Add(new Binding("Text", _BsPodstanice, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.Location = new Point(25, 183);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(395, 94);
            textBox3.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 164);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 14;
            label11.Text = "Napomena:";
            // 
            // btnMernoMestoPodstanica
            // 
            btnMernoMestoPodstanica.Location = new Point(25, 283);
            btnMernoMestoPodstanica.Margin = new Padding(2, 2, 2, 2);
            btnMernoMestoPodstanica.Name = "btnMernoMestoPodstanica";
            btnMernoMestoPodstanica.Size = new Size(160, 35);
            btnMernoMestoPodstanica.TabIndex = 19;
            btnMernoMestoPodstanica.Text = "Dodaj merno mesto ...";
            btnMernoMestoPodstanica.UseVisualStyleBackColor = true;
            btnMernoMestoPodstanica.Click += btnPodstaniceDodajMernoMesto_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.LightGray;
            label22.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label22.ForeColor = Color.Gray;
            label22.Location = new Point(8, 679);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(141, 32);
            label22.TabIndex = 33;
            label22.Text = "Podstanice";
            // 
            // btnKPodstaniceObrisi
            // 
            btnKPodstaniceObrisi.Image = (Image)resources.GetObject("btnKPodstaniceObrisi.Image");
            btnKPodstaniceObrisi.Location = new Point(87, 40);
            btnKPodstaniceObrisi.Margin = new Padding(2, 2, 2, 2);
            btnKPodstaniceObrisi.Name = "btnKPodstaniceObrisi";
            btnKPodstaniceObrisi.Size = new Size(78, 66);
            btnKPodstaniceObrisi.TabIndex = 32;
            btnKPodstaniceObrisi.UseVisualStyleBackColor = true;
            btnKPodstaniceObrisi.Click += btnKPodstaniceObrisi_Click;
            // 
            // btnKPodstaniceDodaj
            // 
            btnKPodstaniceDodaj.Image = (Image)resources.GetObject("btnKPodstaniceDodaj.Image");
            btnKPodstaniceDodaj.Location = new Point(4, 40);
            btnKPodstaniceDodaj.Margin = new Padding(2, 2, 2, 2);
            btnKPodstaniceDodaj.Name = "btnKPodstaniceDodaj";
            btnKPodstaniceDodaj.Size = new Size(78, 66);
            btnKPodstaniceDodaj.TabIndex = 31;
            btnKPodstaniceDodaj.UseVisualStyleBackColor = true;
            btnKPodstaniceDodaj.Click += btnKPodstaniceDodaj_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 14);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(63, 15);
            label21.TabIndex = 30;
            label21.Text = "Kotlarnica:";
            // 
            // btnUndoPodstanice
            // 
            btnUndoPodstanice.Image = (Image)resources.GetObject("btnUndoPodstanice.Image");
            btnUndoPodstanice.Location = new Point(374, 40);
            btnUndoPodstanice.Margin = new Padding(2, 2, 2, 2);
            btnUndoPodstanice.Name = "btnUndoPodstanice";
            btnUndoPodstanice.Padding = new Padding(14, 0, 0, 0);
            btnUndoPodstanice.Size = new Size(153, 65);
            btnUndoPodstanice.TabIndex = 25;
            btnUndoPodstanice.UseVisualStyleBackColor = true;
            btnUndoPodstanice.Visible = false;
            btnUndoPodstanice.Click += btnUndoPodstanice_Click;
            // 
            // btnSavePodstanice
            // 
            btnSavePodstanice.Image = (Image)resources.GetObject("btnSavePodstanice.Image");
            btnSavePodstanice.Location = new Point(531, 41);
            btnSavePodstanice.Margin = new Padding(2, 2, 2, 2);
            btnSavePodstanice.Name = "btnSavePodstanice";
            btnSavePodstanice.Padding = new Padding(14, 0, 0, 0);
            btnSavePodstanice.Size = new Size(153, 65);
            btnSavePodstanice.TabIndex = 24;
            btnSavePodstanice.UseVisualStyleBackColor = true;
            btnSavePodstanice.Visible = false;
            btnSavePodstanice.Click += btnSavePodstanice_Click;
            // 
            // btnPodstaniceKotlarnice
            // 
            btnPodstaniceKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPodstaniceKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPodstaniceKotlarnice.Location = new Point(1189, 616);
            btnPodstaniceKotlarnice.Margin = new Padding(2, 2, 2, 2);
            btnPodstaniceKotlarnice.Name = "btnPodstaniceKotlarnice";
            btnPodstaniceKotlarnice.Size = new Size(245, 44);
            btnPodstaniceKotlarnice.TabIndex = 23;
            btnPodstaniceKotlarnice.Text = "<<< Kotlarnice";
            btnPodstaniceKotlarnice.UseVisualStyleBackColor = true;
            btnPodstaniceKotlarnice.Click += btnPodstaniceKotlarnice_Click;
            // 
            // btnPostaniceIndividualni
            // 
            btnPostaniceIndividualni.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPostaniceIndividualni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPostaniceIndividualni.Location = new Point(1189, 664);
            btnPostaniceIndividualni.Margin = new Padding(2, 2, 2, 2);
            btnPostaniceIndividualni.Name = "btnPostaniceIndividualni";
            btnPostaniceIndividualni.Size = new Size(245, 44);
            btnPostaniceIndividualni.TabIndex = 22;
            btnPostaniceIndividualni.Text = "Individualni potrošači >>>";
            btnPostaniceIndividualni.UseVisualStyleBackColor = true;
            btnPostaniceIndividualni.Click += btnPostaniceIndividualni_Click;
            // 
            // tabIndividaulniPotrosaci
            // 
            tabIndividaulniPotrosaci.Controls.Add(gUnosbIndividualniPotrosac);
            tabIndividaulniPotrosaci.Controls.Add(btnObrisiIndividualni);
            tabIndividaulniPotrosaci.Controls.Add(btnDodajIndividualni);
            tabIndividaulniPotrosaci.Controls.Add(label24);
            tabIndividaulniPotrosaci.Controls.Add(label23);
            tabIndividaulniPotrosaci.Controls.Add(btnUndoPotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(btnSavePotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(btnIndividualniPodstanice);
            tabIndividaulniPotrosaci.Controls.Add(dgIndividualniPotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(cbPodstanice);
            tabIndividaulniPotrosaci.Location = new Point(4, 24);
            tabIndividaulniPotrosaci.Margin = new Padding(2, 2, 2, 2);
            tabIndividaulniPotrosaci.Name = "tabIndividaulniPotrosaci";
            tabIndividaulniPotrosaci.Padding = new Padding(2, 2, 2, 2);
            tabIndividaulniPotrosaci.Size = new Size(1438, 721);
            tabIndividaulniPotrosaci.TabIndex = 3;
            tabIndividaulniPotrosaci.Text = "Individualni potrošači";
            tabIndividaulniPotrosaci.UseVisualStyleBackColor = true;
            // 
            // gUnosbIndividualniPotrosac
            // 
            gUnosbIndividualniPotrosac.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gUnosbIndividualniPotrosac.Controls.Add(tbIndividualniPotrosacNaziv);
            gUnosbIndividualniPotrosac.Controls.Add(label12);
            gUnosbIndividualniPotrosac.Controls.Add(label13);
            gUnosbIndividualniPotrosac.Controls.Add(tbIndividualniPotrosacAdresa);
            gUnosbIndividualniPotrosac.Controls.Add(label14);
            gUnosbIndividualniPotrosac.Controls.Add(tbIndividualniPotrosacEmail);
            gUnosbIndividualniPotrosac.Controls.Add(label15);
            gUnosbIndividualniPotrosac.Controls.Add(tbIndividualniPotrosacTelefon);
            gUnosbIndividualniPotrosac.Controls.Add(btnMernoMestoIndividualniPotrosac);
            gUnosbIndividualniPotrosac.Enabled = false;
            gUnosbIndividualniPotrosac.Location = new Point(687, 110);
            gUnosbIndividualniPotrosac.Margin = new Padding(2, 2, 2, 2);
            gUnosbIndividualniPotrosac.Name = "gUnosbIndividualniPotrosac";
            gUnosbIndividualniPotrosac.Padding = new Padding(2, 2, 2, 2);
            gUnosbIndividualniPotrosac.Size = new Size(447, 607);
            gUnosbIndividualniPotrosac.TabIndex = 37;
            gUnosbIndividualniPotrosac.TabStop = false;
            gUnosbIndividualniPotrosac.Text = "Individualni potrošač";
            // 
            // tbIndividualniPotrosacNaziv
            // 
            tbIndividualniPotrosacNaziv.BackColor = Color.White;
            tbIndividualniPotrosacNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacNaziv.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacNaziv.Location = new Point(23, 46);
            tbIndividualniPotrosacNaziv.Margin = new Padding(2, 2, 2, 2);
            tbIndividualniPotrosacNaziv.Name = "tbIndividualniPotrosacNaziv";
            tbIndividualniPotrosacNaziv.Size = new Size(399, 23);
            tbIndividualniPotrosacNaziv.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 27);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 8;
            label12.Text = "Naziv:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 73);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 10;
            label13.Text = "Adresa:";
            // 
            // tbIndividualniPotrosacAdresa
            // 
            tbIndividualniPotrosacAdresa.BackColor = Color.White;
            tbIndividualniPotrosacAdresa.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacAdresa.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Adresa", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacAdresa.Location = new Point(23, 92);
            tbIndividualniPotrosacAdresa.Margin = new Padding(2, 2, 2, 2);
            tbIndividualniPotrosacAdresa.Name = "tbIndividualniPotrosacAdresa";
            tbIndividualniPotrosacAdresa.Size = new Size(399, 23);
            tbIndividualniPotrosacAdresa.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 119);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 12;
            label14.Text = "Email:";
            // 
            // tbIndividualniPotrosacEmail
            // 
            tbIndividualniPotrosacEmail.BackColor = Color.White;
            tbIndividualniPotrosacEmail.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacEmail.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Email", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacEmail.Location = new Point(23, 138);
            tbIndividualniPotrosacEmail.Margin = new Padding(2, 2, 2, 2);
            tbIndividualniPotrosacEmail.Name = "tbIndividualniPotrosacEmail";
            tbIndividualniPotrosacEmail.Size = new Size(399, 23);
            tbIndividualniPotrosacEmail.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 165);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 14;
            label15.Text = "Telefon:";
            // 
            // tbIndividualniPotrosacTelefon
            // 
            tbIndividualniPotrosacTelefon.BackColor = Color.White;
            tbIndividualniPotrosacTelefon.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacTelefon.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacTelefon.Location = new Point(23, 184);
            tbIndividualniPotrosacTelefon.Margin = new Padding(2, 2, 2, 2);
            tbIndividualniPotrosacTelefon.Name = "tbIndividualniPotrosacTelefon";
            tbIndividualniPotrosacTelefon.Size = new Size(399, 23);
            tbIndividualniPotrosacTelefon.TabIndex = 4;
            // 
            // btnMernoMestoIndividualniPotrosac
            // 
            btnMernoMestoIndividualniPotrosac.Location = new Point(23, 219);
            btnMernoMestoIndividualniPotrosac.Margin = new Padding(2, 2, 2, 2);
            btnMernoMestoIndividualniPotrosac.Name = "btnMernoMestoIndividualniPotrosac";
            btnMernoMestoIndividualniPotrosac.Size = new Size(238, 42);
            btnMernoMestoIndividualniPotrosac.TabIndex = 20;
            btnMernoMestoIndividualniPotrosac.Text = "Formiraj merno mesto ...";
            btnMernoMestoIndividualniPotrosac.UseVisualStyleBackColor = true;
            btnMernoMestoIndividualniPotrosac.Visible = false;
            btnMernoMestoIndividualniPotrosac.Click += btnMernoMestoIndividualniPotrosac_Click;
            // 
            // btnObrisiIndividualni
            // 
            btnObrisiIndividualni.Image = (Image)resources.GetObject("btnObrisiIndividualni.Image");
            btnObrisiIndividualni.Location = new Point(87, 40);
            btnObrisiIndividualni.Margin = new Padding(2, 2, 2, 2);
            btnObrisiIndividualni.Name = "btnObrisiIndividualni";
            btnObrisiIndividualni.Size = new Size(78, 66);
            btnObrisiIndividualni.TabIndex = 36;
            btnObrisiIndividualni.UseVisualStyleBackColor = true;
            btnObrisiIndividualni.Click += btnObrisiIndividualni_Click;
            // 
            // btnDodajIndividualni
            // 
            btnDodajIndividualni.Image = (Image)resources.GetObject("btnDodajIndividualni.Image");
            btnDodajIndividualni.Location = new Point(5, 40);
            btnDodajIndividualni.Margin = new Padding(2, 2, 2, 2);
            btnDodajIndividualni.Name = "btnDodajIndividualni";
            btnDodajIndividualni.Size = new Size(78, 66);
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
            label24.Location = new Point(8, 681);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(268, 32);
            label24.TabIndex = 34;
            label24.Text = "Individualni potrošači";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(8, 14);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(68, 15);
            label23.TabIndex = 31;
            label23.Text = "Podstanica:";
            // 
            // btnUndoPotrosaci
            // 
            btnUndoPotrosaci.Image = (Image)resources.GetObject("btnUndoPotrosaci.Image");
            btnUndoPotrosaci.Location = new Point(374, 40);
            btnUndoPotrosaci.Margin = new Padding(2, 2, 2, 2);
            btnUndoPotrosaci.Name = "btnUndoPotrosaci";
            btnUndoPotrosaci.Padding = new Padding(14, 0, 0, 0);
            btnUndoPotrosaci.Size = new Size(153, 65);
            btnUndoPotrosaci.TabIndex = 29;
            btnUndoPotrosaci.UseVisualStyleBackColor = true;
            btnUndoPotrosaci.Visible = false;
            btnUndoPotrosaci.Click += btnUndoPotrosaci_Click;
            // 
            // btnSavePotrosaci
            // 
            btnSavePotrosaci.Image = (Image)resources.GetObject("btnSavePotrosaci.Image");
            btnSavePotrosaci.Location = new Point(531, 41);
            btnSavePotrosaci.Margin = new Padding(2, 2, 2, 2);
            btnSavePotrosaci.Name = "btnSavePotrosaci";
            btnSavePotrosaci.Padding = new Padding(14, 0, 0, 0);
            btnSavePotrosaci.Size = new Size(153, 65);
            btnSavePotrosaci.TabIndex = 28;
            btnSavePotrosaci.UseVisualStyleBackColor = true;
            btnSavePotrosaci.Visible = false;
            btnSavePotrosaci.Click += btnSavePotrosaci_Click;
            // 
            // btnIndividualniPodstanice
            // 
            btnIndividualniPodstanice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIndividualniPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnIndividualniPodstanice.Location = new Point(1274, 673);
            btnIndividualniPodstanice.Margin = new Padding(2, 2, 2, 2);
            btnIndividualniPodstanice.Name = "btnIndividualniPodstanice";
            btnIndividualniPodstanice.Size = new Size(160, 44);
            btnIndividualniPodstanice.TabIndex = 27;
            btnIndividualniPodstanice.Text = "<<< Podstanice";
            btnIndividualniPodstanice.UseVisualStyleBackColor = true;
            btnIndividualniPodstanice.Click += btnIndividualniPodstanice_Click;
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
            dgIndividualniPotrosaci.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn3 });
            dgIndividualniPotrosaci.DataSource = _BsIndividualniPotrosaci;
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = SystemColors.Window;
            dataGridViewCellStyle44.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle44.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle44.SelectionForeColor = Color.Black;
            dataGridViewCellStyle44.WrapMode = DataGridViewTriState.False;
            dgIndividualniPotrosaci.DefaultCellStyle = dataGridViewCellStyle44;
            dgIndividualniPotrosaci.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgIndividualniPotrosaci.EnableHeadersVisualStyles = false;
            dgIndividualniPotrosaci.Location = new Point(4, 110);
            dgIndividualniPotrosaci.Margin = new Padding(2, 2, 2, 2);
            dgIndividualniPotrosaci.MultiSelect = false;
            dgIndividualniPotrosaci.Name = "dgIndividualniPotrosaci";
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = SystemColors.Control;
            dataGridViewCellStyle45.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle45.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle45.SelectionForeColor = Color.Black;
            dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
            dgIndividualniPotrosaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            dgIndividualniPotrosaci.RowHeadersWidth = 32;
            dgIndividualniPotrosaci.ScrollBars = ScrollBars.Vertical;
            dgIndividualniPotrosaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgIndividualniPotrosaci.Size = new Size(679, 607);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1465, 767);
            Controls.Add(tabMaticniPodaci);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
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
            gbUnosToplane.ResumeLayout(false);
            gbUnosToplane.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            gbKotlarnice.ResumeLayout(false);
            gbKotlarnice.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gbUnosPodstanica.ResumeLayout(false);
            gbUnosPodstanica.PerformLayout();
            tabIndividaulniPotrosaci.ResumeLayout(false);
            tabIndividaulniPotrosaci.PerformLayout();
            gUnosbIndividualniPotrosac.ResumeLayout(false);
            gUnosbIndividualniPotrosac.PerformLayout();
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
        private GroupBox gbUnosToplane;
        private GroupBox gbKotlarnice;
        private GroupBox gbUnosPodstanica;
        private GroupBox gUnosbIndividualniPotrosac;
    }
}
