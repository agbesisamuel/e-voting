namespace GEVS
{
    partial class VVPATContainer
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
            this.crvVVPAT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVVPAT
            // 
            this.crvVVPAT.ActiveViewIndex = -1;
            this.crvVVPAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVVPAT.DisplayGroupTree = false;
            this.crvVVPAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVVPAT.Location = new System.Drawing.Point(0, 0);
            this.crvVVPAT.Name = "crvVVPAT";
            this.crvVVPAT.SelectionFormula = "";
            this.crvVVPAT.Size = new System.Drawing.Size(292, 266);
            this.crvVVPAT.TabIndex = 0;
            this.crvVVPAT.ViewTimeSelectionFormula = "";
            this.crvVVPAT.Load += new System.EventHandler(this.crvVVPAT_Load);
            // 
            // VVPATContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvVVPAT);
            this.Name = "VVPATContainer";
            this.Text = "VVPAT Printouts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVVPAT;
    }
}