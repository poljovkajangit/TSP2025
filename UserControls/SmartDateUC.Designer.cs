namespace TSP2025.UserControls
{
    partial class SmartDateUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            SuspendLayout();
            // 
            // cbDay
            // 
            cbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(3, 3);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(75, 33);
            cbDay.TabIndex = 0;
            // 
            // cbMonth
            // 
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "Jan", "Feb", "Mar", "Apr", "Maj", "Jun", "Jul", "Avg", "Sep", "Okt", "Nov", "Dec" });
            cbMonth.Location = new Point(82, 3);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(75, 33);
            cbMonth.TabIndex = 1;
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            cbYear.Location = new Point(158, 3);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(90, 33);
            cbYear.TabIndex = 2;
            // 
            // SmartDateUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Name = "SmartDateUC";
            Size = new Size(252, 40);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbDay;
        private ComboBox cbMonth;
        private ComboBox cbYear;
    }
}
