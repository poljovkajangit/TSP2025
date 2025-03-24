namespace TSP2025
{
    partial class frmMaticniPodaciTreeEditor
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
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(416, 966);
            treeView1.TabIndex = 0;
            // 
            // frmMaticniPodaciTreeEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1745, 990);
            Controls.Add(treeView1);
            Name = "frmMaticniPodaciTreeEditor";
            Text = "frmMaticniPodaciTreeEditor";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}