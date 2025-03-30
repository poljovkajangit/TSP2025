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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaticniPodaci));
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            tabPage1 = new TabPage();
            btnPodstaniceKotlarnice = new Button();
            btnPostaniceIndividualni = new Button();
            gbPodstanice = new GroupBox();
            tbPodstanicaNaziv = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            btnUndoPodstanice = new Button();
            textBox2 = new TextBox();
            btnSavePodstanice = new Button();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            btnMernoMestoPodstanica = new Button();
            btnKPodstaniceObrisi = new Button();
            btnKPodstaniceDodaj = new Button();
            tpToplane = new TabPage();
            btnKotlarnice = new Button();
            gbToplane = new GroupBox();
            tbToplanaNaziv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnUndoToplane = new Button();
            tbToplanaNapomena = new TextBox();
            btnSaveToplane = new Button();
            btnObrisiToplanu = new Button();
            btnDodajToplanu = new Button();
            tabPage2 = new TabPage();
            btnToplane = new Button();
            btnPodstanice = new Button();
            gbKotlarnice = new GroupBox();
            tbKotlarnicaNaziv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbKotlarnicaAdresa = new TextBox();
            btnUndoKotlarnice = new Button();
            label5 = new Label();
            btnSaveKotlarnice = new Button();
            tbKotlarnicaTelefon = new TextBox();
            label6 = new Label();
            tbKotlarnicaOdgovornoLice = new TextBox();
            label7 = new Label();
            tbKotlarnicaNapomena = new TextBox();
            btnKotlarniceObrisi = new Button();
            btnKotlarniceDodaj = new Button();
            tabIndividaulniPotrosaci = new TabPage();
            btnIndividualniPodstanice = new Button();
            gbIndividualniPotrosaci = new GroupBox();
            tbIndividualniPotrosacNaziv = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tbIndividualniPotrosacAdresa = new TextBox();
            btnUndoPotrosaci = new Button();
            label14 = new Label();
            btnSavePotrosaci = new Button();
            tbIndividualniPotrosacEmail = new TextBox();
            label15 = new Label();
            tbIndividualniPotrosacTelefon = new TextBox();
            btnMernoMestoIndividualniPotrosac = new Button();
            btnObrisiIndividualni = new Button();
            btnDodajIndividualni = new Button();
            label23 = new Label();
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
            tabPage1.SuspendLayout();
            gbPodstanice.SuspendLayout();
            tpToplane.SuspendLayout();
            gbToplane.SuspendLayout();
            tabPage2.SuspendLayout();
            gbKotlarnice.SuspendLayout();
            tabIndividaulniPotrosaci.SuspendLayout();
            gbIndividualniPotrosaci.SuspendLayout();
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
            cbToplane.Location = new Point(101, 14);
            cbToplane.Margin = new Padding(2);
            cbToplane.Name = "cbToplane";
            cbToplane.Size = new Size(181, 29);
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
            dgToplane.EnableHeadersVisualStyles = false;
            dgToplane.Location = new Point(2, 46);
            dgToplane.Margin = new Padding(2);
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
            dgToplane.Size = new Size(280, 443);
            dgToplane.TabIndex = 8;
            dgToplane.CellMouseDoubleClick += dgToplane_CellMouseDoubleClick;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            nazivDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn.HeaderText = "Toplana";
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
            cbKotlarnice.Location = new Point(99, 12);
            cbKotlarnice.Margin = new Padding(2);
            cbKotlarnice.Name = "cbKotlarnice";
            cbKotlarnice.Size = new Size(183, 29);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgKotlarnice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgKotlarnice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKotlarnice.Columns.AddRange(new DataGridViewColumn[] { nazivDataGridViewTextBoxColumn1 });
            dgKotlarnice.DataSource = _BsKotlarnice;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgKotlarnice.DefaultCellStyle = dataGridViewCellStyle5;
            dgKotlarnice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgKotlarnice.EnableHeadersVisualStyles = false;
            dgKotlarnice.Location = new Point(2, 46);
            dgKotlarnice.Margin = new Padding(2);
            dgKotlarnice.MultiSelect = false;
            dgKotlarnice.Name = "dgKotlarnice";
            dgKotlarnice.RowHeadersWidth = 32;
            dgKotlarnice.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Control;
            dgKotlarnice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgKotlarnice.ScrollBars = ScrollBars.Vertical;
            dgKotlarnice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKotlarnice.Size = new Size(280, 443);
            dgKotlarnice.TabIndex = 7;
            dgKotlarnice.CellDoubleClick += dgKotlarnice_CellDoubleClick;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            nazivDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn1.HeaderText = "Kotlarnice";
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
            cbPodstanice.Location = new Point(102, 17);
            cbPodstanice.Margin = new Padding(2);
            cbPodstanice.Name = "cbPodstanice";
            cbPodstanice.Size = new Size(182, 29);
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgPodstanice.DefaultCellStyle = dataGridViewCellStyle6;
            dgPodstanice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgPodstanice.EnableHeadersVisualStyles = false;
            dgPodstanice.Location = new Point(2, 46);
            dgPodstanice.Margin = new Padding(2);
            dgPodstanice.MultiSelect = false;
            dgPodstanice.Name = "dgPodstanice";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgPodstanice.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgPodstanice.RowHeadersWidth = 32;
            dgPodstanice.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgPodstanice.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgPodstanice.ScrollBars = ScrollBars.Vertical;
            dgPodstanice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPodstanice.Size = new Size(280, 443);
            dgPodstanice.TabIndex = 6;
            // 
            // nazivDataGridViewTextBoxColumn2
            // 
            nazivDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn2.HeaderText = "Podstanice";
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
            tabMaticniPodaci.Margin = new Padding(2);
            tabMaticniPodaci.Name = "tabMaticniPodaci";
            tabMaticniPodaci.SelectedIndex = 0;
            tabMaticniPodaci.Size = new Size(752, 515);
            tabMaticniPodaci.TabIndex = 8;
            tabMaticniPodaci.Selecting += tabMaticniPodaci_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnPodstaniceKotlarnice);
            tabPage1.Controls.Add(btnPostaniceIndividualni);
            tabPage1.Controls.Add(gbPodstanice);
            tabPage1.Controls.Add(btnKPodstaniceObrisi);
            tabPage1.Controls.Add(btnKPodstaniceDodaj);
            tabPage1.Controls.Add(cbKotlarnice);
            tabPage1.Controls.Add(dgPodstanice);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(744, 487);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Podstanice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPodstaniceKotlarnice
            // 
            btnPodstaniceKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPodstaniceKotlarnice.Location = new Point(338, 6);
            btnPodstaniceKotlarnice.Margin = new Padding(2);
            btnPodstaniceKotlarnice.Name = "btnPodstaniceKotlarnice";
            btnPodstaniceKotlarnice.Size = new Size(146, 35);
            btnPodstaniceKotlarnice.TabIndex = 23;
            btnPodstaniceKotlarnice.Text = "<<< Kotlarnice";
            btnPodstaniceKotlarnice.UseVisualStyleBackColor = true;
            btnPodstaniceKotlarnice.Click += btnPodstaniceKotlarnice_Click;
            // 
            // btnPostaniceIndividualni
            // 
            btnPostaniceIndividualni.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPostaniceIndividualni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPostaniceIndividualni.Location = new Point(488, 6);
            btnPostaniceIndividualni.Margin = new Padding(2);
            btnPostaniceIndividualni.Name = "btnPostaniceIndividualni";
            btnPostaniceIndividualni.Size = new Size(245, 35);
            btnPostaniceIndividualni.TabIndex = 22;
            btnPostaniceIndividualni.Text = "Individualni potrošači >>>";
            btnPostaniceIndividualni.UseVisualStyleBackColor = true;
            btnPostaniceIndividualni.Click += btnPostaniceIndividualni_Click;
            // 
            // gbPodstanice
            // 
            gbPodstanice.Controls.Add(tbPodstanicaNaziv);
            gbPodstanice.Controls.Add(label8);
            gbPodstanice.Controls.Add(textBox1);
            gbPodstanice.Controls.Add(label9);
            gbPodstanice.Controls.Add(btnUndoPodstanice);
            gbPodstanice.Controls.Add(textBox2);
            gbPodstanice.Controls.Add(btnSavePodstanice);
            gbPodstanice.Controls.Add(label10);
            gbPodstanice.Controls.Add(textBox3);
            gbPodstanice.Controls.Add(label11);
            gbPodstanice.Controls.Add(btnMernoMestoPodstanica);
            gbPodstanice.Enabled = false;
            gbPodstanice.Location = new Point(286, 39);
            gbPodstanice.Margin = new Padding(2);
            gbPodstanice.Name = "gbPodstanice";
            gbPodstanice.Padding = new Padding(2);
            gbPodstanice.Size = new Size(447, 334);
            gbPodstanice.TabIndex = 34;
            gbPodstanice.TabStop = false;
            // 
            // tbPodstanicaNaziv
            // 
            tbPodstanicaNaziv.BackColor = Color.White;
            tbPodstanicaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbPodstanicaNaziv.DataBindings.Add(new Binding("Text", _BsPodstanice, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbPodstanicaNaziv.Location = new Point(25, 45);
            tbPodstanicaNaziv.Margin = new Padding(2);
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
            textBox1.Margin = new Padding(2);
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
            // btnUndoPodstanice
            // 
            btnUndoPodstanice.BackgroundImage = (Image)resources.GetObject("btnUndoPodstanice.BackgroundImage");
            btnUndoPodstanice.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndoPodstanice.Location = new Point(326, 285);
            btnUndoPodstanice.Margin = new Padding(2);
            btnUndoPodstanice.Name = "btnUndoPodstanice";
            btnUndoPodstanice.Size = new Size(45, 38);
            btnUndoPodstanice.TabIndex = 25;
            btnUndoPodstanice.UseVisualStyleBackColor = true;
            btnUndoPodstanice.Visible = false;
            btnUndoPodstanice.Click += btnUndoPodstanice_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.DataBindings.Add(new Binding("Text", _BsPodstanice, "OdgovornoLice", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(25, 137);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 23);
            textBox2.TabIndex = 3;
            // 
            // btnSavePodstanice
            // 
            btnSavePodstanice.BackgroundImage = (Image)resources.GetObject("btnSavePodstanice.BackgroundImage");
            btnSavePodstanice.BackgroundImageLayout = ImageLayout.Stretch;
            btnSavePodstanice.Location = new Point(374, 285);
            btnSavePodstanice.Margin = new Padding(2);
            btnSavePodstanice.Name = "btnSavePodstanice";
            btnSavePodstanice.Size = new Size(45, 38);
            btnSavePodstanice.TabIndex = 24;
            btnSavePodstanice.UseVisualStyleBackColor = true;
            btnSavePodstanice.Visible = false;
            btnSavePodstanice.Click += btnSavePodstanice_Click;
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
            textBox3.Margin = new Padding(2);
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
            btnMernoMestoPodstanica.Margin = new Padding(2);
            btnMernoMestoPodstanica.Name = "btnMernoMestoPodstanica";
            btnMernoMestoPodstanica.Size = new Size(160, 35);
            btnMernoMestoPodstanica.TabIndex = 19;
            btnMernoMestoPodstanica.Text = "Dodaj merno mesto ...";
            btnMernoMestoPodstanica.UseVisualStyleBackColor = true;
            btnMernoMestoPodstanica.Click += btnPodstaniceDodajMernoMesto_Click;
            // 
            // btnKPodstaniceObrisi
            // 
            btnKPodstaniceObrisi.BackgroundImage = (Image)resources.GetObject("btnKPodstaniceObrisi.BackgroundImage");
            btnKPodstaniceObrisi.BackgroundImageLayout = ImageLayout.Stretch;
            btnKPodstaniceObrisi.Location = new Point(51, 4);
            btnKPodstaniceObrisi.Margin = new Padding(2);
            btnKPodstaniceObrisi.Name = "btnKPodstaniceObrisi";
            btnKPodstaniceObrisi.Size = new Size(45, 38);
            btnKPodstaniceObrisi.TabIndex = 32;
            btnKPodstaniceObrisi.UseVisualStyleBackColor = true;
            btnKPodstaniceObrisi.Click += btnKPodstaniceObrisi_Click;
            // 
            // btnKPodstaniceDodaj
            // 
            btnKPodstaniceDodaj.BackgroundImage = (Image)resources.GetObject("btnKPodstaniceDodaj.BackgroundImage");
            btnKPodstaniceDodaj.BackgroundImageLayout = ImageLayout.Stretch;
            btnKPodstaniceDodaj.Location = new Point(2, 4);
            btnKPodstaniceDodaj.Margin = new Padding(2);
            btnKPodstaniceDodaj.Name = "btnKPodstaniceDodaj";
            btnKPodstaniceDodaj.Size = new Size(45, 38);
            btnKPodstaniceDodaj.TabIndex = 31;
            btnKPodstaniceDodaj.UseVisualStyleBackColor = true;
            btnKPodstaniceDodaj.Click += btnKPodstaniceDodaj_Click;
            // 
            // tpToplane
            // 
            tpToplane.Controls.Add(btnKotlarnice);
            tpToplane.Controls.Add(gbToplane);
            tpToplane.Controls.Add(btnObrisiToplanu);
            tpToplane.Controls.Add(btnDodajToplanu);
            tpToplane.Controls.Add(dgToplane);
            tpToplane.Location = new Point(4, 24);
            tpToplane.Margin = new Padding(2);
            tpToplane.Name = "tpToplane";
            tpToplane.Padding = new Padding(2);
            tpToplane.Size = new Size(744, 487);
            tpToplane.TabIndex = 0;
            tpToplane.Text = "Toplane";
            tpToplane.UseVisualStyleBackColor = true;
            // 
            // btnKotlarnice
            // 
            btnKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKotlarnice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnKotlarnice.Location = new Point(565, 4);
            btnKotlarnice.Margin = new Padding(2);
            btnKotlarnice.Name = "btnKotlarnice";
            btnKotlarnice.Size = new Size(169, 38);
            btnKotlarnice.TabIndex = 9;
            btnKotlarnice.Text = "Kotlarnice >>>";
            btnKotlarnice.UseVisualStyleBackColor = true;
            btnKotlarnice.Click += btnKotlarnice_Click;
            // 
            // gbToplane
            // 
            gbToplane.Controls.Add(tbToplanaNaziv);
            gbToplane.Controls.Add(label1);
            gbToplane.Controls.Add(label2);
            gbToplane.Controls.Add(btnUndoToplane);
            gbToplane.Controls.Add(tbToplanaNapomena);
            gbToplane.Controls.Add(btnSaveToplane);
            gbToplane.Enabled = false;
            gbToplane.Location = new Point(286, 38);
            gbToplane.Margin = new Padding(2);
            gbToplane.Name = "gbToplane";
            gbToplane.Padding = new Padding(2);
            gbToplane.Size = new Size(448, 228);
            gbToplane.TabIndex = 25;
            gbToplane.TabStop = false;
            // 
            // tbToplanaNaziv
            // 
            tbToplanaNaziv.BackColor = Color.White;
            tbToplanaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbToplanaNaziv.DataBindings.Add(new Binding("Text", _BsToplane, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbToplanaNaziv.Location = new Point(24, 45);
            tbToplanaNaziv.Margin = new Padding(2);
            tbToplanaNaziv.Name = "tbToplanaNaziv";
            tbToplanaNaziv.Size = new Size(398, 23);
            tbToplanaNaziv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Napomena:";
            // 
            // btnUndoToplane
            // 
            btnUndoToplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUndoToplane.BackgroundImage = (Image)resources.GetObject("btnUndoToplane.BackgroundImage");
            btnUndoToplane.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndoToplane.Location = new Point(328, 184);
            btnUndoToplane.Margin = new Padding(2);
            btnUndoToplane.Name = "btnUndoToplane";
            btnUndoToplane.Size = new Size(45, 38);
            btnUndoToplane.TabIndex = 10;
            btnUndoToplane.UseVisualStyleBackColor = true;
            btnUndoToplane.Click += btnUndoIzmena_Click;
            // 
            // tbToplanaNapomena
            // 
            tbToplanaNapomena.BackColor = Color.White;
            tbToplanaNapomena.BorderStyle = BorderStyle.FixedSingle;
            tbToplanaNapomena.DataBindings.Add(new Binding("Text", _BsToplane, "Napomena", true, DataSourceUpdateMode.OnPropertyChanged));
            tbToplanaNapomena.Location = new Point(24, 88);
            tbToplanaNapomena.Margin = new Padding(2);
            tbToplanaNapomena.Multiline = true;
            tbToplanaNapomena.Name = "tbToplanaNapomena";
            tbToplanaNapomena.Size = new Size(398, 93);
            tbToplanaNapomena.TabIndex = 2;
            // 
            // btnSaveToplane
            // 
            btnSaveToplane.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveToplane.BackgroundImage = (Image)resources.GetObject("btnSaveToplane.BackgroundImage");
            btnSaveToplane.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveToplane.Location = new Point(377, 184);
            btnSaveToplane.Margin = new Padding(2);
            btnSaveToplane.Name = "btnSaveToplane";
            btnSaveToplane.Size = new Size(45, 38);
            btnSaveToplane.TabIndex = 9;
            btnSaveToplane.UseVisualStyleBackColor = true;
            btnSaveToplane.Click += btnSaveEnabled_Click;
            // 
            // btnObrisiToplanu
            // 
            btnObrisiToplanu.BackgroundImage = (Image)resources.GetObject("btnObrisiToplanu.BackgroundImage");
            btnObrisiToplanu.BackgroundImageLayout = ImageLayout.Stretch;
            btnObrisiToplanu.Location = new Point(51, 4);
            btnObrisiToplanu.Margin = new Padding(2);
            btnObrisiToplanu.Name = "btnObrisiToplanu";
            btnObrisiToplanu.Size = new Size(45, 38);
            btnObrisiToplanu.TabIndex = 23;
            btnObrisiToplanu.UseVisualStyleBackColor = true;
            btnObrisiToplanu.Click += btnObrisiToplanu_Click;
            // 
            // btnDodajToplanu
            // 
            btnDodajToplanu.BackgroundImage = (Image)resources.GetObject("btnDodajToplanu.BackgroundImage");
            btnDodajToplanu.BackgroundImageLayout = ImageLayout.Zoom;
            btnDodajToplanu.Location = new Point(2, 4);
            btnDodajToplanu.Margin = new Padding(2);
            btnDodajToplanu.Name = "btnDodajToplanu";
            btnDodajToplanu.Size = new Size(45, 38);
            btnDodajToplanu.TabIndex = 22;
            btnDodajToplanu.UseVisualStyleBackColor = true;
            btnDodajToplanu.Click += btnDodajToplanu_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnToplane);
            tabPage2.Controls.Add(btnPodstanice);
            tabPage2.Controls.Add(gbKotlarnice);
            tabPage2.Controls.Add(btnKotlarniceObrisi);
            tabPage2.Controls.Add(btnKotlarniceDodaj);
            tabPage2.Controls.Add(dgKotlarnice);
            tabPage2.Controls.Add(cbToplane);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(744, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kotlarnice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnToplane
            // 
            btnToplane.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnToplane.Location = new Point(460, 4);
            btnToplane.Margin = new Padding(2);
            btnToplane.Name = "btnToplane";
            btnToplane.Size = new Size(135, 40);
            btnToplane.TabIndex = 19;
            btnToplane.Text = "<<< Toplane";
            btnToplane.UseVisualStyleBackColor = true;
            btnToplane.Click += btnToplane_Click;
            // 
            // btnPodstanice
            // 
            btnPodstanice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPodstanice.Location = new Point(599, 4);
            btnPodstanice.Margin = new Padding(2);
            btnPodstanice.Name = "btnPodstanice";
            btnPodstanice.Size = new Size(135, 40);
            btnPodstanice.TabIndex = 18;
            btnPodstanice.Text = "Podstanice >>>";
            btnPodstanice.UseVisualStyleBackColor = true;
            btnPodstanice.Click += btnPodstanice_Click;
            // 
            // gbKotlarnice
            // 
            gbKotlarnice.Controls.Add(tbKotlarnicaNaziv);
            gbKotlarnice.Controls.Add(label3);
            gbKotlarnice.Controls.Add(label4);
            gbKotlarnice.Controls.Add(tbKotlarnicaAdresa);
            gbKotlarnice.Controls.Add(btnUndoKotlarnice);
            gbKotlarnice.Controls.Add(label5);
            gbKotlarnice.Controls.Add(btnSaveKotlarnice);
            gbKotlarnice.Controls.Add(tbKotlarnicaTelefon);
            gbKotlarnice.Controls.Add(label6);
            gbKotlarnice.Controls.Add(tbKotlarnicaOdgovornoLice);
            gbKotlarnice.Controls.Add(label7);
            gbKotlarnice.Controls.Add(tbKotlarnicaNapomena);
            gbKotlarnice.Enabled = false;
            gbKotlarnice.Location = new Point(286, 39);
            gbKotlarnice.Margin = new Padding(2);
            gbKotlarnice.Name = "gbKotlarnice";
            gbKotlarnice.Padding = new Padding(2);
            gbKotlarnice.Size = new Size(448, 356);
            gbKotlarnice.TabIndex = 30;
            gbKotlarnice.TabStop = false;
            // 
            // tbKotlarnicaNaziv
            // 
            tbKotlarnicaNaziv.BackColor = Color.White;
            tbKotlarnicaNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaNaziv.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaNaziv.Location = new Point(24, 45);
            tbKotlarnicaNaziv.Margin = new Padding(2);
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
            tbKotlarnicaAdresa.Margin = new Padding(2);
            tbKotlarnicaAdresa.Name = "tbKotlarnicaAdresa";
            tbKotlarnicaAdresa.Size = new Size(398, 23);
            tbKotlarnicaAdresa.TabIndex = 11;
            // 
            // btnUndoKotlarnice
            // 
            btnUndoKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUndoKotlarnice.BackgroundImage = (Image)resources.GetObject("btnUndoKotlarnice.BackgroundImage");
            btnUndoKotlarnice.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndoKotlarnice.Location = new Point(328, 311);
            btnUndoKotlarnice.Margin = new Padding(2);
            btnUndoKotlarnice.Name = "btnUndoKotlarnice";
            btnUndoKotlarnice.Size = new Size(45, 38);
            btnUndoKotlarnice.TabIndex = 25;
            btnUndoKotlarnice.UseVisualStyleBackColor = true;
            btnUndoKotlarnice.Click += btnUndoKotlarnice_Click;
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
            // btnSaveKotlarnice
            // 
            btnSaveKotlarnice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveKotlarnice.BackgroundImage = (Image)resources.GetObject("btnSaveKotlarnice.BackgroundImage");
            btnSaveKotlarnice.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveKotlarnice.Location = new Point(377, 311);
            btnSaveKotlarnice.Margin = new Padding(2);
            btnSaveKotlarnice.Name = "btnSaveKotlarnice";
            btnSaveKotlarnice.Size = new Size(45, 38);
            btnSaveKotlarnice.TabIndex = 24;
            btnSaveKotlarnice.UseVisualStyleBackColor = true;
            btnSaveKotlarnice.Click += btnSaveKotlarnice_Click;
            // 
            // tbKotlarnicaTelefon
            // 
            tbKotlarnicaTelefon.BackColor = Color.White;
            tbKotlarnicaTelefon.BorderStyle = BorderStyle.FixedSingle;
            tbKotlarnicaTelefon.DataBindings.Add(new Binding("Text", _BsKotlarnice, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged));
            tbKotlarnicaTelefon.Location = new Point(24, 137);
            tbKotlarnicaTelefon.Margin = new Padding(2);
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
            tbKotlarnicaOdgovornoLice.Margin = new Padding(2);
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
            tbKotlarnicaNapomena.Margin = new Padding(2);
            tbKotlarnicaNapomena.Multiline = true;
            tbKotlarnicaNapomena.Name = "tbKotlarnicaNapomena";
            tbKotlarnicaNapomena.Size = new Size(398, 75);
            tbKotlarnicaNapomena.TabIndex = 17;
            // 
            // btnKotlarniceObrisi
            // 
            btnKotlarniceObrisi.BackgroundImage = (Image)resources.GetObject("btnKotlarniceObrisi.BackgroundImage");
            btnKotlarniceObrisi.BackgroundImageLayout = ImageLayout.Stretch;
            btnKotlarniceObrisi.Location = new Point(51, 4);
            btnKotlarniceObrisi.Margin = new Padding(2);
            btnKotlarniceObrisi.Name = "btnKotlarniceObrisi";
            btnKotlarniceObrisi.Size = new Size(45, 38);
            btnKotlarniceObrisi.TabIndex = 27;
            btnKotlarniceObrisi.UseVisualStyleBackColor = true;
            btnKotlarniceObrisi.Click += btnKotlarniceObrisi_Click;
            // 
            // btnKotlarniceDodaj
            // 
            btnKotlarniceDodaj.BackgroundImage = (Image)resources.GetObject("btnKotlarniceDodaj.BackgroundImage");
            btnKotlarniceDodaj.BackgroundImageLayout = ImageLayout.Stretch;
            btnKotlarniceDodaj.Location = new Point(2, 4);
            btnKotlarniceDodaj.Margin = new Padding(2);
            btnKotlarniceDodaj.Name = "btnKotlarniceDodaj";
            btnKotlarniceDodaj.Size = new Size(45, 38);
            btnKotlarniceDodaj.TabIndex = 26;
            btnKotlarniceDodaj.UseVisualStyleBackColor = true;
            btnKotlarniceDodaj.Click += btnKotlarniceDodaj_Click;
            // 
            // tabIndividaulniPotrosaci
            // 
            tabIndividaulniPotrosaci.Controls.Add(btnIndividualniPodstanice);
            tabIndividaulniPotrosaci.Controls.Add(gbIndividualniPotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(btnObrisiIndividualni);
            tabIndividaulniPotrosaci.Controls.Add(btnDodajIndividualni);
            tabIndividaulniPotrosaci.Controls.Add(label23);
            tabIndividaulniPotrosaci.Controls.Add(dgIndividualniPotrosaci);
            tabIndividaulniPotrosaci.Controls.Add(cbPodstanice);
            tabIndividaulniPotrosaci.Location = new Point(4, 24);
            tabIndividaulniPotrosaci.Margin = new Padding(2);
            tabIndividaulniPotrosaci.Name = "tabIndividaulniPotrosaci";
            tabIndividaulniPotrosaci.Padding = new Padding(2);
            tabIndividaulniPotrosaci.Size = new Size(744, 487);
            tabIndividaulniPotrosaci.TabIndex = 3;
            tabIndividaulniPotrosaci.Text = "Individualni potrošači";
            tabIndividaulniPotrosaci.UseVisualStyleBackColor = true;
            // 
            // btnIndividualniPodstanice
            // 
            btnIndividualniPodstanice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnIndividualniPodstanice.Location = new Point(590, 5);
            btnIndividualniPodstanice.Margin = new Padding(2);
            btnIndividualniPodstanice.Name = "btnIndividualniPodstanice";
            btnIndividualniPodstanice.Size = new Size(143, 39);
            btnIndividualniPodstanice.TabIndex = 27;
            btnIndividualniPodstanice.Text = "<<< Podstanice";
            btnIndividualniPodstanice.UseVisualStyleBackColor = true;
            btnIndividualniPodstanice.Click += btnIndividualniPodstanice_Click;
            // 
            // gbIndividualniPotrosaci
            // 
            gbIndividualniPotrosaci.Controls.Add(tbIndividualniPotrosacNaziv);
            gbIndividualniPotrosaci.Controls.Add(label12);
            gbIndividualniPotrosaci.Controls.Add(label13);
            gbIndividualniPotrosaci.Controls.Add(tbIndividualniPotrosacAdresa);
            gbIndividualniPotrosaci.Controls.Add(btnUndoPotrosaci);
            gbIndividualniPotrosaci.Controls.Add(label14);
            gbIndividualniPotrosaci.Controls.Add(btnSavePotrosaci);
            gbIndividualniPotrosaci.Controls.Add(tbIndividualniPotrosacEmail);
            gbIndividualniPotrosaci.Controls.Add(label15);
            gbIndividualniPotrosaci.Controls.Add(tbIndividualniPotrosacTelefon);
            gbIndividualniPotrosaci.Controls.Add(btnMernoMestoIndividualniPotrosac);
            gbIndividualniPotrosaci.Enabled = false;
            gbIndividualniPotrosaci.Location = new Point(286, 39);
            gbIndividualniPotrosaci.Margin = new Padding(2);
            gbIndividualniPotrosaci.Name = "gbIndividualniPotrosaci";
            gbIndividualniPotrosaci.Padding = new Padding(2);
            gbIndividualniPotrosaci.Size = new Size(447, 269);
            gbIndividualniPotrosaci.TabIndex = 37;
            gbIndividualniPotrosaci.TabStop = false;
            // 
            // tbIndividualniPotrosacNaziv
            // 
            tbIndividualniPotrosacNaziv.BackColor = Color.White;
            tbIndividualniPotrosacNaziv.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacNaziv.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Naziv", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacNaziv.Location = new Point(23, 46);
            tbIndividualniPotrosacNaziv.Margin = new Padding(2);
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
            tbIndividualniPotrosacAdresa.Margin = new Padding(2);
            tbIndividualniPotrosacAdresa.Name = "tbIndividualniPotrosacAdresa";
            tbIndividualniPotrosacAdresa.Size = new Size(399, 23);
            tbIndividualniPotrosacAdresa.TabIndex = 2;
            // 
            // btnUndoPotrosaci
            // 
            btnUndoPotrosaci.BackgroundImage = (Image)resources.GetObject("btnUndoPotrosaci.BackgroundImage");
            btnUndoPotrosaci.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndoPotrosaci.Location = new Point(328, 212);
            btnUndoPotrosaci.Margin = new Padding(2);
            btnUndoPotrosaci.Name = "btnUndoPotrosaci";
            btnUndoPotrosaci.Size = new Size(45, 38);
            btnUndoPotrosaci.TabIndex = 29;
            btnUndoPotrosaci.UseVisualStyleBackColor = true;
            btnUndoPotrosaci.Visible = false;
            btnUndoPotrosaci.Click += btnUndoPotrosaci_Click;
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
            // btnSavePotrosaci
            // 
            btnSavePotrosaci.BackgroundImage = (Image)resources.GetObject("btnSavePotrosaci.BackgroundImage");
            btnSavePotrosaci.BackgroundImageLayout = ImageLayout.Stretch;
            btnSavePotrosaci.Location = new Point(377, 212);
            btnSavePotrosaci.Margin = new Padding(2);
            btnSavePotrosaci.Name = "btnSavePotrosaci";
            btnSavePotrosaci.Size = new Size(45, 38);
            btnSavePotrosaci.TabIndex = 28;
            btnSavePotrosaci.UseVisualStyleBackColor = true;
            btnSavePotrosaci.Visible = false;
            btnSavePotrosaci.Click += btnSavePotrosaci_Click;
            // 
            // tbIndividualniPotrosacEmail
            // 
            tbIndividualniPotrosacEmail.BackColor = Color.White;
            tbIndividualniPotrosacEmail.BorderStyle = BorderStyle.FixedSingle;
            tbIndividualniPotrosacEmail.DataBindings.Add(new Binding("Text", _BsIndividualniPotrosaci, "Email", true, DataSourceUpdateMode.OnPropertyChanged));
            tbIndividualniPotrosacEmail.Location = new Point(23, 138);
            tbIndividualniPotrosacEmail.Margin = new Padding(2);
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
            tbIndividualniPotrosacTelefon.Margin = new Padding(2);
            tbIndividualniPotrosacTelefon.Name = "tbIndividualniPotrosacTelefon";
            tbIndividualniPotrosacTelefon.Size = new Size(399, 23);
            tbIndividualniPotrosacTelefon.TabIndex = 4;
            // 
            // btnMernoMestoIndividualniPotrosac
            // 
            btnMernoMestoIndividualniPotrosac.Location = new Point(23, 214);
            btnMernoMestoIndividualniPotrosac.Margin = new Padding(2);
            btnMernoMestoIndividualniPotrosac.Name = "btnMernoMestoIndividualniPotrosac";
            btnMernoMestoIndividualniPotrosac.Size = new Size(160, 35);
            btnMernoMestoIndividualniPotrosac.TabIndex = 20;
            btnMernoMestoIndividualniPotrosac.Text = "Dodaj merno mesto ...";
            btnMernoMestoIndividualniPotrosac.UseVisualStyleBackColor = true;
            btnMernoMestoIndividualniPotrosac.Visible = false;
            btnMernoMestoIndividualniPotrosac.Click += btnMernoMestoIndividualniPotrosac_Click;
            // 
            // btnObrisiIndividualni
            // 
            btnObrisiIndividualni.BackgroundImage = (Image)resources.GetObject("btnObrisiIndividualni.BackgroundImage");
            btnObrisiIndividualni.BackgroundImageLayout = ImageLayout.Stretch;
            btnObrisiIndividualni.Location = new Point(51, 4);
            btnObrisiIndividualni.Margin = new Padding(2);
            btnObrisiIndividualni.Name = "btnObrisiIndividualni";
            btnObrisiIndividualni.Size = new Size(45, 38);
            btnObrisiIndividualni.TabIndex = 36;
            btnObrisiIndividualni.UseVisualStyleBackColor = true;
            btnObrisiIndividualni.Click += btnObrisiIndividualni_Click;
            // 
            // btnDodajIndividualni
            // 
            btnDodajIndividualni.BackgroundImage = (Image)resources.GetObject("btnDodajIndividualni.BackgroundImage");
            btnDodajIndividualni.BackgroundImageLayout = ImageLayout.Stretch;
            btnDodajIndividualni.Location = new Point(2, 4);
            btnDodajIndividualni.Margin = new Padding(2);
            btnDodajIndividualni.Name = "btnDodajIndividualni";
            btnDodajIndividualni.Size = new Size(45, 38);
            btnDodajIndividualni.TabIndex = 35;
            btnDodajIndividualni.UseVisualStyleBackColor = true;
            btnDodajIndividualni.Click += btnDodajIndividualni_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(102, 2);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(68, 15);
            label23.TabIndex = 31;
            label23.Text = "Podstanica:";
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgIndividualniPotrosaci.DefaultCellStyle = dataGridViewCellStyle8;
            dgIndividualniPotrosaci.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgIndividualniPotrosaci.EnableHeadersVisualStyles = false;
            dgIndividualniPotrosaci.Location = new Point(2, 46);
            dgIndividualniPotrosaci.Margin = new Padding(2);
            dgIndividualniPotrosaci.MultiSelect = false;
            dgIndividualniPotrosaci.Name = "dgIndividualniPotrosaci";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgIndividualniPotrosaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgIndividualniPotrosaci.RowHeadersWidth = 32;
            dgIndividualniPotrosaci.ScrollBars = ScrollBars.Vertical;
            dgIndividualniPotrosaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgIndividualniPotrosaci.Size = new Size(280, 438);
            dgIndividualniPotrosaci.TabIndex = 7;
            // 
            // nazivDataGridViewTextBoxColumn3
            // 
            nazivDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivDataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn3.HeaderText = "Individualni potrošači";
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
            ClientSize = new Size(769, 533);
            Controls.Add(tabMaticniPodaci);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
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
            tabPage1.ResumeLayout(false);
            gbPodstanice.ResumeLayout(false);
            gbPodstanice.PerformLayout();
            tpToplane.ResumeLayout(false);
            gbToplane.ResumeLayout(false);
            gbToplane.PerformLayout();
            tabPage2.ResumeLayout(false);
            gbKotlarnice.ResumeLayout(false);
            gbKotlarnice.PerformLayout();
            tabIndividaulniPotrosaci.ResumeLayout(false);
            tabIndividaulniPotrosaci.PerformLayout();
            gbIndividualniPotrosaci.ResumeLayout(false);
            gbIndividualniPotrosaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgIndividualniPotrosaci).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbToplane;
        private BindingSource _BsToplane;
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
        private Button btnKPodstaniceObrisi;
        private Button btnKPodstaniceDodaj;
        private Label label23;
        private Button btnObrisiIndividualni;
        private Button btnDodajIndividualni;
        private GroupBox gbToplane;
        private GroupBox gbKotlarnice;
        private GroupBox gbPodstanice;
        private GroupBox gbIndividualniPotrosaci;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn3;
    }
}
