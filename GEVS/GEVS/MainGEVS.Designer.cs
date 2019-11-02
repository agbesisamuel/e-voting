namespace GEVS
{
    partial class MainGEVS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGEVS));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetupConstutuency = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetupPollingStation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSetupPresidential = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetupParliamentary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCodeGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrintSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventVoting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCountVotes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTransmitResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransferPresident = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransferParliamentary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEventOpenVoting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventCloseVoting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepPresidential = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepParliamentary = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportDetailReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepDetailPresidential = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepDetailsParliamentary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRepWasteVotes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepTotalVoters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepCodeNotUsed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuVoterReg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.tlsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEvent,
            this.mnuReports,
            this.mnuUtilities});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(575, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSetup,
            this.mnuCodeGeneration,
            this.toolStripMenuItem2,
            this.mnuFilePrintSetup,
            this.mnuFileLogOff,
            this.toolStripMenuItem3,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileSetup
            // 
            this.mnuFileSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetupConstutuency,
            this.mnuSetupPollingStation,
            this.toolStripMenuItem1,
            this.mnuSetupPresidential,
            this.mnuSetupParliamentary});
            this.mnuFileSetup.Name = "mnuFileSetup";
            this.mnuFileSetup.Size = new System.Drawing.Size(163, 22);
            this.mnuFileSetup.Text = "&Setups";
            // 
            // mnuSetupConstutuency
            // 
            this.mnuSetupConstutuency.Name = "mnuSetupConstutuency";
            this.mnuSetupConstutuency.Size = new System.Drawing.Size(156, 22);
            this.mnuSetupConstutuency.Text = "Constituency";
            this.mnuSetupConstutuency.Click += new System.EventHandler(this.mnuSetupConstutuency_Click);
            // 
            // mnuSetupPollingStation
            // 
            this.mnuSetupPollingStation.Name = "mnuSetupPollingStation";
            this.mnuSetupPollingStation.Size = new System.Drawing.Size(156, 22);
            this.mnuSetupPollingStation.Text = "Polling Stations";
            this.mnuSetupPollingStation.Click += new System.EventHandler(this.mnuSetupPollingStation_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // mnuSetupPresidential
            // 
            this.mnuSetupPresidential.Name = "mnuSetupPresidential";
            this.mnuSetupPresidential.Size = new System.Drawing.Size(156, 22);
            this.mnuSetupPresidential.Text = "Presidential";
            this.mnuSetupPresidential.Click += new System.EventHandler(this.mnuSetupPresidential_Click);
            // 
            // mnuSetupParliamentary
            // 
            this.mnuSetupParliamentary.Name = "mnuSetupParliamentary";
            this.mnuSetupParliamentary.Size = new System.Drawing.Size(156, 22);
            this.mnuSetupParliamentary.Text = "Parliamentary";
            this.mnuSetupParliamentary.Click += new System.EventHandler(this.mnuSetupParliamentary_Click);
            // 
            // mnuCodeGeneration
            // 
            this.mnuCodeGeneration.Name = "mnuCodeGeneration";
            this.mnuCodeGeneration.Size = new System.Drawing.Size(163, 22);
            this.mnuCodeGeneration.Text = "&Code Generation";
            this.mnuCodeGeneration.Click += new System.EventHandler(this.mnuCodeGeneration_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuFilePrintSetup
            // 
            this.mnuFilePrintSetup.Name = "mnuFilePrintSetup";
            this.mnuFilePrintSetup.Size = new System.Drawing.Size(163, 22);
            this.mnuFilePrintSetup.Text = "&Print Setup";
            this.mnuFilePrintSetup.Click += new System.EventHandler(this.mnuFilePrintSetup_Click);
            // 
            // mnuFileLogOff
            // 
            this.mnuFileLogOff.Name = "mnuFileLogOff";
            this.mnuFileLogOff.Size = new System.Drawing.Size(163, 22);
            this.mnuFileLogOff.Text = "&Log Off";
            this.mnuFileLogOff.Click += new System.EventHandler(this.mnuFileLogOff_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(163, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEvent
            // 
            this.mnuEvent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEventVoting,
            this.mnuCountVotes,
            this.toolStripMenuItem5,
            this.mnuTransmitResults,
            this.toolStripMenuItem9,
            this.mnuEventOpenVoting,
            this.mnuEventCloseVoting});
            this.mnuEvent.Name = "mnuEvent";
            this.mnuEvent.Size = new System.Drawing.Size(48, 20);
            this.mnuEvent.Text = "&Event";
            // 
            // mnuEventVoting
            // 
            this.mnuEventVoting.Name = "mnuEventVoting";
            this.mnuEventVoting.Size = new System.Drawing.Size(161, 22);
            this.mnuEventVoting.Text = "&Voting";
            this.mnuEventVoting.Click += new System.EventHandler(this.mnuEventVoting_Click);
            // 
            // mnuCountVotes
            // 
            this.mnuCountVotes.Name = "mnuCountVotes";
            this.mnuCountVotes.Size = new System.Drawing.Size(161, 22);
            this.mnuCountVotes.Text = "C&ount Votes";
            this.mnuCountVotes.Visible = false;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(158, 6);
            this.toolStripMenuItem5.Visible = false;
            // 
            // mnuTransmitResults
            // 
            this.mnuTransmitResults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransferPresident,
            this.mnuTransferParliamentary});
            this.mnuTransmitResults.Name = "mnuTransmitResults";
            this.mnuTransmitResults.Size = new System.Drawing.Size(161, 22);
            this.mnuTransmitResults.Text = "Transmit Results";
            // 
            // mnuTransferPresident
            // 
            this.mnuTransferPresident.Name = "mnuTransferPresident";
            this.mnuTransferPresident.Size = new System.Drawing.Size(147, 22);
            this.mnuTransferPresident.Text = "Presidetial";
            this.mnuTransferPresident.Click += new System.EventHandler(this.mnuTransferPresident_Click);
            // 
            // mnuTransferParliamentary
            // 
            this.mnuTransferParliamentary.Name = "mnuTransferParliamentary";
            this.mnuTransferParliamentary.Size = new System.Drawing.Size(147, 22);
            this.mnuTransferParliamentary.Text = "Parliamentary";
            this.mnuTransferParliamentary.Click += new System.EventHandler(this.mnuTransferParliamentary_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuEventOpenVoting
            // 
            this.mnuEventOpenVoting.Name = "mnuEventOpenVoting";
            this.mnuEventOpenVoting.Size = new System.Drawing.Size(161, 22);
            this.mnuEventOpenVoting.Text = "Open Voting";
            this.mnuEventOpenVoting.Click += new System.EventHandler(this.mnuEventOpenVoting_Click);
            // 
            // mnuEventCloseVoting
            // 
            this.mnuEventCloseVoting.Name = "mnuEventCloseVoting";
            this.mnuEventCloseVoting.Size = new System.Drawing.Size(161, 22);
            this.mnuEventCloseVoting.Text = "Close Voting";
            this.mnuEventCloseVoting.Click += new System.EventHandler(this.mnuEventCloseVoting_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepPresidential,
            this.mnuRepParliamentary,
            this.ReportDetailReports,
            this.toolStripMenuItem6,
            this.mnuRepWasteVotes,
            this.mnuRepTotalVoters,
            this.mnuRepCodeNotUsed,
            this.toolStripMenuItem4});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "&Reports";
            // 
            // mnuRepPresidential
            // 
            this.mnuRepPresidential.Name = "mnuRepPresidential";
            this.mnuRepPresidential.Size = new System.Drawing.Size(201, 22);
            this.mnuRepPresidential.Text = "&Presidential";
            this.mnuRepPresidential.Click += new System.EventHandler(this.mnuRepPresidential_Click);
            // 
            // mnuRepParliamentary
            // 
            this.mnuRepParliamentary.Name = "mnuRepParliamentary";
            this.mnuRepParliamentary.Size = new System.Drawing.Size(201, 22);
            this.mnuRepParliamentary.Text = "P&arliamntary";
            this.mnuRepParliamentary.Click += new System.EventHandler(this.mnuRepParliamentary_Click);
            // 
            // ReportDetailReports
            // 
            this.ReportDetailReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepDetailPresidential,
            this.mnuRepDetailsParliamentary});
            this.ReportDetailReports.Name = "ReportDetailReports";
            this.ReportDetailReports.Size = new System.Drawing.Size(201, 22);
            this.ReportDetailReports.Text = "&Details Reports";
            // 
            // mnuRepDetailPresidential
            // 
            this.mnuRepDetailPresidential.Name = "mnuRepDetailPresidential";
            this.mnuRepDetailPresidential.Size = new System.Drawing.Size(147, 22);
            this.mnuRepDetailPresidential.Text = "&Presidential";
            this.mnuRepDetailPresidential.Click += new System.EventHandler(this.mnuRepDetailPresidential_Click);
            // 
            // mnuRepDetailsParliamentary
            // 
            this.mnuRepDetailsParliamentary.Name = "mnuRepDetailsParliamentary";
            this.mnuRepDetailsParliamentary.Size = new System.Drawing.Size(147, 22);
            this.mnuRepDetailsParliamentary.Text = "P&arliamnetary";
            this.mnuRepDetailsParliamentary.Click += new System.EventHandler(this.mnuRepDetailsParliamentary_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(198, 6);
            // 
            // mnuRepWasteVotes
            // 
            this.mnuRepWasteVotes.Name = "mnuRepWasteVotes";
            this.mnuRepWasteVotes.Size = new System.Drawing.Size(201, 22);
            this.mnuRepWasteVotes.Text = "&Waste Votes";
            this.mnuRepWasteVotes.Visible = false;
            // 
            // mnuRepTotalVoters
            // 
            this.mnuRepTotalVoters.Name = "mnuRepTotalVoters";
            this.mnuRepTotalVoters.Size = new System.Drawing.Size(201, 22);
            this.mnuRepTotalVoters.Text = "&Total Voters";
            this.mnuRepTotalVoters.Visible = false;
            // 
            // mnuRepCodeNotUsed
            // 
            this.mnuRepCodeNotUsed.Name = "mnuRepCodeNotUsed";
            this.mnuRepCodeNotUsed.Size = new System.Drawing.Size(201, 22);
            this.mnuRepCodeNotUsed.Text = "Code &Number Not Used";
            this.mnuRepCodeNotUsed.Click += new System.EventHandler(this.mnuRepCodeNotUsed_Click);
            // 
            // mnuUtilities
            // 
            this.mnuUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserAccounts,
            this.toolStripMenuItem7,
            this.mnuVoterReg,
            this.toolStripMenuItem8});
            this.mnuUtilities.Name = "mnuUtilities";
            this.mnuUtilities.Size = new System.Drawing.Size(58, 20);
            this.mnuUtilities.Text = "&Utilities";
            // 
            // mnuUserAccounts
            // 
            this.mnuUserAccounts.Name = "mnuUserAccounts";
            this.mnuUserAccounts.Size = new System.Drawing.Size(173, 22);
            this.mnuUserAccounts.Text = "&User Accounts";
            this.mnuUserAccounts.Click += new System.EventHandler(this.mnuUserAccounts_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuVoterReg
            // 
            this.mnuVoterReg.Name = "mnuVoterReg";
            this.mnuVoterReg.Size = new System.Drawing.Size(173, 22);
            this.mnuVoterReg.Text = "Voters Registration";
            this.mnuVoterReg.Click += new System.EventHandler(this.mnuVoterReg_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(170, 6);
            // 
            // ToolBar
            // 
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(575, 25);
            this.ToolBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GHANA ELECTRONIC VOTING SYSTEM (GEVS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsUser,
            this.lblUser,
            this.toolStripStatusLabel1,
            this.lblDate});
            this.StatusBar.Location = new System.Drawing.Point(0, 306);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(575, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // tlsUser
            // 
            this.tlsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsUser.Name = "tlsUser";
            this.tlsUser.Size = new System.Drawing.Size(88, 17);
            this.tlsUser.Text = "Current User";
            // 
            // lblUser
            // 
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.Text = "User";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel1.Text = "                         Current Date";
            // 
            // lblDate
            // 
            this.lblDate.Image = ((System.Drawing.Image)(resources.GetObject("lblDate.Image")));
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 17);
            this.lblDate.Text = "Date";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 6);
            // 
            // MainGEVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GEVS.Properties.Resources.ec_1logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(575, 328);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGEVS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghana Electronic Voting System (GEVS)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainGEVS_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuSetupConstutuency;
        private System.Windows.Forms.ToolStripMenuItem mnuSetupPollingStation;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSetupPresidential;
        private System.Windows.Forms.ToolStripMenuItem mnuSetupParliamentary;
        private System.Windows.Forms.ToolStripMenuItem mnuCodeGeneration;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLogOff;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuEventVoting;
        private System.Windows.Forms.ToolStripMenuItem mnuCountVotes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuTransmitResults;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuRepPresidential;
        private System.Windows.Forms.ToolStripMenuItem mnuRepParliamentary;
        private System.Windows.Forms.ToolStripMenuItem ReportDetailReports;
        private System.Windows.Forms.ToolStripMenuItem mnuRepDetailPresidential;
        private System.Windows.Forms.ToolStripMenuItem mnuRepDetailsParliamentary;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnuRepWasteVotes;
        private System.Windows.Forms.ToolStripMenuItem mnuRepTotalVoters;
        private System.Windows.Forms.ToolStripMenuItem mnuRepCodeNotUsed;
        private System.Windows.Forms.ToolStripMenuItem mnuUtilities;
        private System.Windows.Forms.ToolStripMenuItem mnuUserAccounts;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tlsUser;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnuVoterReg;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem mnuEventOpenVoting;
        private System.Windows.Forms.ToolStripMenuItem mnuEventCloseVoting;
        private System.Windows.Forms.ToolStripMenuItem mnuTransferPresident;
        private System.Windows.Forms.ToolStripMenuItem mnuTransferParliamentary;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}

