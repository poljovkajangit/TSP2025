namespace TSP2025.Reports
{
    partial class frmBarPlotReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarPlotReport));
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            lblMernoMesto = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(11, 60);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(2239, 1197);
            formsPlot1.TabIndex = 0;
            // 
            // lblMernoMesto
            // 
            lblMernoMesto.BackColor = Color.White;
            lblMernoMesto.BorderStyle = BorderStyle.FixedSingle;
            lblMernoMesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMernoMesto.Location = new Point(130, 11);
            lblMernoMesto.Name = "lblMernoMesto";
            lblMernoMesto.Size = new Size(571, 39);
            lblMernoMesto.TabIndex = 1;
            lblMernoMesto.Text = "<merno mesto>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 2;
            label1.Text = "Potrošnja";
            // 
            // frmGraph
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2263, 1268);
            Controls.Add(label1);
            Controls.Add(lblMernoMesto);
            Controls.Add(formsPlot1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGraph";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label lblMernoMesto;
        private Label label1;
    }
}