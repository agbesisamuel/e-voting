﻿namespace GEVS
{
    partial class ParliamentaryReport
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
            this.crvParliamentaryRep = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvParliamentaryRep
            // 
            this.crvParliamentaryRep.ActiveViewIndex = -1;
            this.crvParliamentaryRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvParliamentaryRep.DisplayGroupTree = false;
            this.crvParliamentaryRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvParliamentaryRep.Location = new System.Drawing.Point(0, 0);
            this.crvParliamentaryRep.Name = "crvParliamentaryRep";
            this.crvParliamentaryRep.SelectionFormula = "";
            this.crvParliamentaryRep.Size = new System.Drawing.Size(292, 266);
            this.crvParliamentaryRep.TabIndex = 0;
            this.crvParliamentaryRep.ViewTimeSelectionFormula = "";
            this.crvParliamentaryRep.Load += new System.EventHandler(this.crvParliamentaryRep_Load);
            // 
            // ParliamentaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crvParliamentaryRep);
            this.MaximizeBox = false;
            this.Name = "ParliamentaryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parliamentary Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvParliamentaryRep;
    }
}