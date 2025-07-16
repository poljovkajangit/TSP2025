namespace TSP2025.Reports
{
    partial class frmMedjugodisnja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedjugodisnja));
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button1 = new Button();
            bsMernaMesta = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            lblUkupno = new ToolStripStatusLabel();
            cbMernoMesto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(12, 45);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(984, 491);
            formsPlot1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(284, 3);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 1;
            button1.Text = "Prikaži";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bsMernaMesta
            // 
            bsMernaMesta.DataMember = "SvaMernaMesta";
            bsMernaMesta.DataSource = typeof(Data.TSP2025DataContext);
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUkupno });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(10, 0, 1, 0);
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1008, 22);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUkupno
            // 
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(0, 17);
            // 
            // cbMernoMesto
            // 
            cbMernoMesto.BackColor = Color.White;
            cbMernoMesto.DataSource = bsMernaMesta;
            cbMernoMesto.DisplayMember = "OznakaMernogMesta";
            cbMernoMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMernoMesto.FormattingEnabled = true;
            cbMernoMesto.Location = new Point(11, 11);
            cbMernoMesto.Margin = new Padding(2);
            cbMernoMesto.Name = "cbMernoMesto";
            cbMernoMesto.Size = new Size(268, 23);
            cbMernoMesto.TabIndex = 22;
            // 
            // frmMedjugodisnja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(cbMernoMesto);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(formsPlot1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMedjugodisnja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Međugodišnja potrošnja po mesecima";
            ((System.ComponentModel.ISupportInitialize)bsMernaMesta).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button1;
        private BindingSource bsMernaMesta;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUkupno;
        private ComboBox cbMernoMesto;
    }
}