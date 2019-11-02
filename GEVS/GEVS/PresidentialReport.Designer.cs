namespace GEVS
{
    partial class PresidentialReport
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
            this.crvPresidential = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPresidential
            // 
            this.crvPresidential.ActiveViewIndex = -1;
            this.crvPresidential.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPresidential.DisplayGroupTree = false;
            this.crvPresidential.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPresidential.Location = new System.Drawing.Point(0, 0);
            this.crvPresidential.Name = "crvPresidential";
            this.crvPresidential.SelectionFormula = "";
            this.crvPresidential.Size = new System.Drawing.Size(292, 266);
            this.crvPresidential.TabIndex = 0;
            this.crvPresidential.ViewTimeSelectionFormula = "";
            this.crvPresidential.Load += new System.EventHandler(this.crvPresidential_Load);
            // 
            // PresidentialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvPresidential);
            this.MaximizeBox = false;
            this.Name = "PresidentialReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Presidential Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPresidential;
    }
}