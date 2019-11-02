namespace GEVS
{
    partial class ParliamentaryTB
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
            this.label8 = new System.Windows.Forms.Label();
            this.cboConstCode = new System.Windows.Forms.ComboBox();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtVoteCount = new System.Windows.Forms.TextBox();
            this.btnPRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCandName = new System.Windows.Forms.TextBox();
            this.btnPLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCandNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFindCandNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btnCandLoad = new System.Windows.Forms.Button();
            this.btnCandRemove = new System.Windows.Forms.Button();
            this.picPartyLogo = new System.Windows.Forms.PictureBox();
            this.picCandPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPartyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCandPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Constutuency";
            // 
            // cboConstCode
            // 
            this.cboConstCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConstCode.FormattingEnabled = true;
            this.cboConstCode.Location = new System.Drawing.Point(170, 102);
            this.cboConstCode.Name = "cboConstCode";
            this.cboConstCode.Size = new System.Drawing.Size(121, 21);
            this.cboConstCode.TabIndex = 26;
            this.cboConstCode.SelectedIndexChanged += new System.EventHandler(this.cboConstCode_SelectedIndexChanged);
            // 
            // txtPartyName
            // 
            this.txtPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.ForeColor = System.Drawing.Color.Green;
            this.txtPartyName.Location = new System.Drawing.Point(170, 74);
            this.txtPartyName.MaxLength = 30;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(276, 22);
            this.txtPartyName.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(326, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 101;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(245, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtVoteCount
            // 
            this.txtVoteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoteCount.ForeColor = System.Drawing.Color.Green;
            this.txtVoteCount.Location = new System.Drawing.Point(170, 164);
            this.txtVoteCount.MaxLength = 30;
            this.txtVoteCount.Name = "txtVoteCount";
            this.txtVoteCount.ReadOnly = true;
            this.txtVoteCount.Size = new System.Drawing.Size(69, 22);
            this.txtVoteCount.TabIndex = 29;
            // 
            // btnPRemove
            // 
            this.btnPRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPRemove.Location = new System.Drawing.Point(585, 471);
            this.btnPRemove.Name = "btnPRemove";
            this.btnPRemove.Size = new System.Drawing.Size(75, 26);
            this.btnPRemove.TabIndex = 92;
            this.btnPRemove.Text = "Remove";
            this.btnPRemove.UseVisualStyleBackColor = true;
            this.btnPRemove.Click += new System.EventHandler(this.btnPRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(343, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 83;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(4, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vote Count";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(164, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 99;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(86, 336);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 26);
            this.btnModify.TabIndex = 97;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Party Name";
            // 
            // btnCreate
            // 
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(10, 336);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 26);
            this.btnCreate.TabIndex = 95;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCandName
            // 
            this.txtCandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandName.ForeColor = System.Drawing.Color.Green;
            this.txtCandName.Location = new System.Drawing.Point(170, 47);
            this.txtCandName.MaxLength = 30;
            this.txtCandName.Name = "txtCandName";
            this.txtCandName.Size = new System.Drawing.Size(276, 22);
            this.txtCandName.TabIndex = 23;
            // 
            // btnPLoad
            // 
            this.btnPLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPLoad.Location = new System.Drawing.Point(491, 470);
            this.btnPLoad.Name = "btnPLoad";
            this.btnPLoad.Size = new System.Drawing.Size(77, 26);
            this.btnPLoad.TabIndex = 93;
            this.btnPLoad.Text = "Load";
            this.btnPLoad.UseVisualStyleBackColor = true;
            this.btnPLoad.Click += new System.EventHandler(this.btnPLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Candidate Name";
            // 
            // txtCandNum
            // 
            this.txtCandNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandNum.ForeColor = System.Drawing.Color.Green;
            this.txtCandNum.Location = new System.Drawing.Point(170, 19);
            this.txtCandNum.MaxLength = 10;
            this.txtCandNum.Name = "txtCandNum";
            this.txtCandNum.Size = new System.Drawing.Size(150, 22);
            this.txtCandNum.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(500, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 94;
            this.label9.Text = "Party Logo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConstName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboConstCode);
            this.groupBox1.Controls.Add(this.txtPartyName);
            this.groupBox1.Controls.Add(this.txtVoteCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCandName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCandNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 228);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parliementary Information";
            // 
            // lblConstName
            // 
            this.lblConstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstName.ForeColor = System.Drawing.Color.Green;
            this.lblConstName.Location = new System.Drawing.Point(170, 129);
            this.lblConstName.MaxLength = 30;
            this.lblConstName.Name = "lblConstName";
            this.lblConstName.ReadOnly = true;
            this.lblConstName.Size = new System.Drawing.Size(276, 22);
            this.lblConstName.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(4, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Candidate Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Candidate Number";
            // 
            // txtFindCandNum
            // 
            this.txtFindCandNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCandNum.ForeColor = System.Drawing.Color.Green;
            this.txtFindCandNum.Location = new System.Drawing.Point(187, 56);
            this.txtFindCandNum.MaxLength = 10;
            this.txtFindCandNum.Name = "txtFindCandNum";
            this.txtFindCandNum.Size = new System.Drawing.Size(150, 22);
            this.txtFindCandNum.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 39);
            this.label1.TabIndex = 82;
            this.label1.Text = "Parliamentary Candidates  Maintenance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(86, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 98;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(500, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 20);
            this.label26.TabIndex = 90;
            this.label26.Text = "Candidate Photo";
            // 
            // btnCandLoad
            // 
            this.btnCandLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandLoad.Location = new System.Drawing.Point(491, 238);
            this.btnCandLoad.Name = "btnCandLoad";
            this.btnCandLoad.Size = new System.Drawing.Size(77, 26);
            this.btnCandLoad.TabIndex = 89;
            this.btnCandLoad.Text = "Load";
            this.btnCandLoad.UseVisualStyleBackColor = true;
            this.btnCandLoad.Click += new System.EventHandler(this.btnCandLoad_Click);
            // 
            // btnCandRemove
            // 
            this.btnCandRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandRemove.Location = new System.Drawing.Point(585, 239);
            this.btnCandRemove.Name = "btnCandRemove";
            this.btnCandRemove.Size = new System.Drawing.Size(75, 26);
            this.btnCandRemove.TabIndex = 88;
            this.btnCandRemove.Text = "Remove";
            this.btnCandRemove.UseVisualStyleBackColor = true;
            this.btnCandRemove.Click += new System.EventHandler(this.btnCandRemove_Click);
            // 
            // picPartyLogo
            // 
            this.picPartyLogo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.picPartyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPartyLogo.Location = new System.Drawing.Point(491, 307);
            this.picPartyLogo.Name = "picPartyLogo";
            this.picPartyLogo.Size = new System.Drawing.Size(169, 158);
            this.picPartyLogo.TabIndex = 91;
            this.picPartyLogo.TabStop = false;
            // 
            // picCandPhoto
            // 
            this.picCandPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCandPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCandPhoto.Location = new System.Drawing.Point(491, 75);
            this.picCandPhoto.Name = "picCandPhoto";
            this.picCandPhoto.Size = new System.Drawing.Size(169, 158);
            this.picCandPhoto.TabIndex = 87;
            this.picCandPhoto.TabStop = false;
            // 
            // ParliamentaryTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 508);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPRemove);
            this.Controls.Add(this.picPartyLogo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPLoad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picCandPhoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFindCandNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnCandLoad);
            this.Controls.Add(this.btnCandRemove);
            this.MaximizeBox = false;
            this.Name = "ParliamentaryTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parliamentary Candidates";
            this.Load += new System.EventHandler(this.ParliamentaryTB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPartyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCandPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboConstCode;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtVoteCount;
        private System.Windows.Forms.Button btnPRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCandName;
        private System.Windows.Forms.Button btnPLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCandNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picCandPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFindCandNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnCandLoad;
        private System.Windows.Forms.Button btnCandRemove;
        private System.Windows.Forms.TextBox lblConstName;
        private System.Windows.Forms.PictureBox picPartyLogo;
    }
}