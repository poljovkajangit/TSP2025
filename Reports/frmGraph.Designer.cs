namespace TSP2025.Reports
{
    partial class frmGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraph));
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            lblMernoMesto = new Label();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(8, 36);
            formsPlot1.Margin = new Padding(2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1567, 718);
            formsPlot1.TabIndex = 0;
            // 
            // lblMernoMesto
            // 
            lblMernoMesto.AutoSize = true;
            lblMernoMesto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMernoMesto.Location = new Point(8, 5);
            lblMernoMesto.Margin = new Padding(2, 0, 2, 0);
            lblMernoMesto.Name = "lblMernoMesto";
            lblMernoMesto.Size = new Size(189, 32);
            lblMernoMesto.TabIndex = 1;
            lblMernoMesto.Text = "<merno mesto>";
            // 
            // frmGraph
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 761);
            Controls.Add(lblMernoMesto);
            Controls.Add(formsPlot1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmGraph";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label lblMernoMesto;
    }
}