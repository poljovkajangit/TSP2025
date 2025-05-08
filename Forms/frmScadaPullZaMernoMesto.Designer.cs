namespace TSP2025.Forms
{
    partial class frmScadaPullZaMernoMesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScadaPullZaMernoMesto));
            btnPullMernaMestaRefresh = new Button();
            tbSourceColumn = new TextBox();
            label4 = new Label();
            tbSourceTable = new TextBox();
            label3 = new Label();
            tbSourceDatabase = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbMernaMesta = new ComboBox();
            bsMernaMesta = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            SuspendLayout();
            // 
            // btnPullMernaMestaRefresh
            // 
            btnPullMernaMestaRefresh.BackColor = SystemColors.Control;
            btnPullMernaMestaRefresh.BackgroundImage = (Image)resources.GetObject("btnPullMernaMestaRefresh.BackgroundImage");
            btnPullMernaMestaRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnPullMernaMestaRefresh.FlatStyle = FlatStyle.Flat;
            btnPullMernaMestaRefresh.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 200);
            btnPullMernaMestaRefresh.ForeColor = Color.White;
            btnPullMernaMestaRefresh.Location = new Point(316, 23);
            btnPullMernaMestaRefresh.Margin = new Padding(2);
            btnPullMernaMestaRefresh.Name = "btnPullMernaMestaRefresh";
            btnPullMernaMestaRefresh.Size = new Size(32, 29);
            btnPullMernaMestaRefresh.TabIndex = 19;
            btnPullMernaMestaRefresh.UseVisualStyleBackColor = false;
            btnPullMernaMestaRefresh.Click += btnPullMernaMestaRefresh_Click;
            // 
            // tbSourceColumn
            // 
            tbSourceColumn.BorderStyle = BorderStyle.FixedSingle;
            tbSourceColumn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceColumn.Location = new Point(109, 111);
            tbSourceColumn.Margin = new Padding(2);
            tbSourceColumn.Name = "tbSourceColumn";
            tbSourceColumn.ReadOnly = true;
            tbSourceColumn.Size = new Size(235, 23);
            tbSourceColumn.TabIndex = 18;
            tbSourceColumn.Text = "TP1_1_KUM_SNAGA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(11, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 17;
            label4.Text = "Source kolona:";
            // 
            // tbSourceTable
            // 
            tbSourceTable.BorderStyle = BorderStyle.FixedSingle;
            tbSourceTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbSourceTable.Location = new Point(109, 84);
            tbSourceTable.Margin = new Padding(2);
            tbSourceTable.Name = "tbSourceTable";
            tbSourceTable.ReadOnly = true;
            tbSourceTable.Size = new Size(235, 23);
            tbSourceTable.TabIndex = 16;
            tbSourceTable.Text = "TREND_TSTP1_TP1_1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 15;
            label3.Text = "Source tabela:";
            // 
            // tbSourceDatabase
            // 
            tbSourceDatabase.BorderStyle = BorderStyle.FixedSingle;
            tbSourceDatabase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbSourceDatabase.Location = new Point(109, 57);
            tbSourceDatabase.Margin = new Padding(2);
            tbSourceDatabase.Name = "tbSourceDatabase";
            tbSourceDatabase.ReadOnly = true;
            tbSourceDatabase.Size = new Size(235, 23);
            tbSourceDatabase.TabIndex = 14;
            tbSourceDatabase.Text = "TSP2025SCADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "Source baza:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 12;
            label1.Text = "Merno mesto:";
            // 
            // cbMernaMesta
            // 
            cbMernaMesta.DisplayMember = "OznakaMernogMesta";
            cbMernaMesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernaMesta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbMernaMesta.FormattingEnabled = true;
            cbMernaMesta.Location = new Point(11, 26);
            cbMernaMesta.Margin = new Padding(2);
            cbMernaMesta.Name = "cbMernaMesta";
            cbMernaMesta.Size = new Size(304, 23);
            cbMernaMesta.TabIndex = 11;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.CurrentChanged += bsMernaMesta_CurrentChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 144);
            button1.Name = "button1";
            button1.Size = new Size(166, 31);
            button1.TabIndex = 20;
            button1.Text = "Test connection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTestConnection_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 144);
            button2.Name = "button2";
            button2.Size = new Size(166, 31);
            button2.TabIndex = 21;
            button2.Text = "Pull SCADA data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmScadaPullZaMernoMesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 187);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPullMernaMestaRefresh);
            Controls.Add(tbSourceColumn);
            Controls.Add(label4);
            Controls.Add(tbSourceTable);
            Controls.Add(label3);
            Controls.Add(tbSourceDatabase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbMernaMesta);
            Name = "frmScadaPullZaMernoMesto";
            Text = "frmScadaPullZaMernoMesto";
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPullMernaMestaRefresh;
        private TextBox tbSourceColumn;
        private Label label4;
        private TextBox tbSourceTable;
        private Label label3;
        private TextBox tbSourceDatabase;
        private Label label2;
        private Label label1;
        private ComboBox cbMernaMesta;
        private BindingSource bsMernaMesta;
        private Button button1;
        private Button button2;
    }
}