namespace GEVS
{
    partial class PresSummaryRepCont
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
            this.crvPreSummary = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPreSummary
            // 
            this.crvPreSummary.ActiveViewIndex = -1;
            this.crvPreSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPreSummary.DisplayGroupTree = false;
            this.crvPreSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPreSummary.Location = new System.Drawing.Point(0, 0);
            this.crvPreSummary.Name = "crvPreSummary";
            this.crvPreSummary.SelectionFormula = "";
            this.crvPreSummary.Size = new System.Drawing.Size(292, 266);
            this.crvPreSummary.TabIndex = 0;
            this.crvPreSummary.ViewTimeSelectionFormula = "";
            this.crvPreSummary.Load += new System.EventHandler(this.crvPreSummary_Load);
            // 
            // PresSummaryRepCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvPreSummary);
            this.MaximizeBox = false;
            this.Name = "PresSummaryRepCont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Summary Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPreSummary;
    }
}