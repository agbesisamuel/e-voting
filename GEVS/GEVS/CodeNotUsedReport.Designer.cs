namespace GEVS
{
    partial class CodeNotUsedReport
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
            this.crvCodeNotUsed = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCodeNotUsed
            // 
            this.crvCodeNotUsed.ActiveViewIndex = -1;
            this.crvCodeNotUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCodeNotUsed.DisplayGroupTree = false;
            this.crvCodeNotUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCodeNotUsed.Location = new System.Drawing.Point(0, 0);
            this.crvCodeNotUsed.Name = "crvCodeNotUsed";
            this.crvCodeNotUsed.SelectionFormula = "";
            this.crvCodeNotUsed.Size = new System.Drawing.Size(292, 266);
            this.crvCodeNotUsed.TabIndex = 0;
            this.crvCodeNotUsed.ViewTimeSelectionFormula = "";
            this.crvCodeNotUsed.Load += new System.EventHandler(this.crvCodeNotUsed_Load);
            // 
            // CodeNotUsedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvCodeNotUsed);
            this.MaximizeBox = false;
            this.Name = "CodeNotUsedReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code Not Used Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCodeNotUsed;
    }
}