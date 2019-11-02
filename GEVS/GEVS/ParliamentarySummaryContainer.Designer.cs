namespace GEVS
{
    partial class ParliamentarySummaryContainer
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
            this.crvParliamentarySummar = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvParliamentarySummar
            // 
            this.crvParliamentarySummar.ActiveViewIndex = -1;
            this.crvParliamentarySummar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvParliamentarySummar.DisplayGroupTree = false;
            this.crvParliamentarySummar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvParliamentarySummar.Location = new System.Drawing.Point(0, 0);
            this.crvParliamentarySummar.Name = "crvParliamentarySummar";
            this.crvParliamentarySummar.SelectionFormula = "";
            this.crvParliamentarySummar.Size = new System.Drawing.Size(292, 266);
            this.crvParliamentarySummar.TabIndex = 0;
            this.crvParliamentarySummar.ViewTimeSelectionFormula = "";
            this.crvParliamentarySummar.Load += new System.EventHandler(this.crvParliamentarySummar_Load);
            // 
            // ParliamentarySummaryContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvParliamentarySummar);
            this.MaximizeBox = false;
            this.Name = "ParliamentarySummaryContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parliamentary Summary Results";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvParliamentarySummar;
    }
}