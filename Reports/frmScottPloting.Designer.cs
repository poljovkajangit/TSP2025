namespace TSP2025.Reports
{
    partial class frmScottPloting
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.Black;
            formsPlot1.DisplayScale = 1.5F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.ForeColor = SystemColors.WindowText;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Margin = new Padding(2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1952, 853);
            formsPlot1.TabIndex = 0;
            // 
            // frmScottPloting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1952, 853);
            Controls.Add(formsPlot1);
            Margin = new Padding(2);
            Name = "frmScottPloting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmScottPloting";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}