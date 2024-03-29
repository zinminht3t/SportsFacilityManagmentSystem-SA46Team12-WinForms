﻿namespace SportsFacilityManagementSystem
{
    partial class ucMembers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtICNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblWarningKeyword = new System.Windows.Forms.Label();
            this.lblWarningSearchBy = new System.Windows.Forms.Label();
            this.lblWarningSearchResult = new System.Windows.Forms.Label();
            this.gbSearchResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by : ";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Member ID",
            "Name",
            "IC Number",
            "Mobile Number",
            "Email"});
            this.cmbSearchBy.Location = new System.Drawing.Point(92, 62);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(173, 21);
            this.cmbSearchBy.TabIndex = 40;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(293, 62);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(165, 20);
            this.txtKeyword.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(364, 85);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(74, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 32);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Search Members";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.Controls.Add(this.txtStatus);
            this.gbSearchResults.Controls.Add(this.btnEdit);
            this.gbSearchResults.Controls.Add(this.groupBox1);
            this.gbSearchResults.Controls.Add(this.dtpExpiry);
            this.gbSearchResults.Controls.Add(this.dtpJoin);
            this.gbSearchResults.Controls.Add(this.dtpDOB);
            this.gbSearchResults.Controls.Add(this.btnUpdate);
            this.gbSearchResults.Controls.Add(this.txtEmail);
            this.gbSearchResults.Controls.Add(this.txtMobile);
            this.gbSearchResults.Controls.Add(this.txtAddress);
            this.gbSearchResults.Controls.Add(this.txtICNo);
            this.gbSearchResults.Controls.Add(this.txtName);
            this.gbSearchResults.Controls.Add(this.label11);
            this.gbSearchResults.Controls.Add(this.label10);
            this.gbSearchResults.Controls.Add(this.label9);
            this.gbSearchResults.Controls.Add(this.label8);
            this.gbSearchResults.Controls.Add(this.label7);
            this.gbSearchResults.Controls.Add(this.label6);
            this.gbSearchResults.Controls.Add(this.label5);
            this.gbSearchResults.Controls.Add(this.label4);
            this.gbSearchResults.Controls.Add(this.lbl);
            this.gbSearchResults.Controls.Add(this.lblName);
            this.gbSearchResults.Controls.Add(this.btnPrint);
            this.gbSearchResults.Controls.Add(this.btnReset);
            this.gbSearchResults.Location = new System.Drawing.Point(74, 110);
            this.gbSearchResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearchResults.Size = new System.Drawing.Size(404, 296);
            this.gbSearchResults.TabIndex = 58;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "Search Results";
            this.gbSearchResults.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(154, 239);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(203, 20);
            this.txtStatus.TabIndex = 56;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(262, 267);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 24);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Location = new System.Drawing.Point(154, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 27);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Enabled = false;
            this.rdbFemale.Location = new System.Drawing.Point(117, 8);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 48;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Enabled = false;
            this.rdbMale.Location = new System.Drawing.Point(32, 8);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 47;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Enabled = false;
            this.dtpExpiry.Location = new System.Drawing.Point(154, 218);
            this.dtpExpiry.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(203, 20);
            this.dtpExpiry.TabIndex = 52;
            // 
            // dtpJoin
            // 
            this.dtpJoin.Enabled = false;
            this.dtpJoin.Location = new System.Drawing.Point(154, 196);
            this.dtpJoin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(203, 20);
            this.dtpJoin.TabIndex = 51;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Location = new System.Drawing.Point(154, 174);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(203, 20);
            this.dtpDOB.TabIndex = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(262, 266);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 24);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 151);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 49;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(154, 98);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(203, 20);
            this.txtMobile.TabIndex = 46;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(154, 57);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(203, 38);
            this.txtAddress.TabIndex = 45;
            // 
            // txtICNo
            // 
            this.txtICNo.Location = new System.Drawing.Point(154, 36);
            this.txtICNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtICNo.Name = "txtICNo";
            this.txtICNo.ReadOnly = true;
            this.txtICNo.Size = new System.Drawing.Size(203, 20);
            this.txtICNo.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(203, 20);
            this.txtName.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Expiry Date : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Join Date : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Date of Birth : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Email : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gender : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mobile Number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Address : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(48, 39);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 13);
            this.lbl.TabIndex = 27;
            this.lbl.Text = "IC Number : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 18);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name : ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(52, 267);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 24);
            this.btnPrint.TabIndex = 54;
            this.btnPrint.Text = "Print Info";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(52, 266);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 24);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Cancel";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblWarningKeyword
            // 
            this.lblWarningKeyword.AutoSize = true;
            this.lblWarningKeyword.ForeColor = System.Drawing.Color.Red;
            this.lblWarningKeyword.Location = new System.Drawing.Point(291, 41);
            this.lblWarningKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningKeyword.Name = "lblWarningKeyword";
            this.lblWarningKeyword.Size = new System.Drawing.Size(116, 13);
            this.lblWarningKeyword.TabIndex = 59;
            this.lblWarningKeyword.Text = "* Field cannot be blank";
            this.lblWarningKeyword.Visible = false;
            // 
            // lblWarningSearchBy
            // 
            this.lblWarningSearchBy.AutoSize = true;
            this.lblWarningSearchBy.ForeColor = System.Drawing.Color.Red;
            this.lblWarningSearchBy.Location = new System.Drawing.Point(92, 80);
            this.lblWarningSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningSearchBy.Name = "lblWarningSearchBy";
            this.lblWarningSearchBy.Size = new System.Drawing.Size(169, 13);
            this.lblWarningSearchBy.TabIndex = 60;
            this.lblWarningSearchBy.Text = "* Select one of the search criterias";
            this.lblWarningSearchBy.Visible = false;
            // 
            // lblWarningSearchResult
            // 
            this.lblWarningSearchResult.AutoSize = true;
            this.lblWarningSearchResult.ForeColor = System.Drawing.Color.Red;
            this.lblWarningSearchResult.Location = new System.Drawing.Point(158, 94);
            this.lblWarningSearchResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningSearchResult.Name = "lblWarningSearchResult";
            this.lblWarningSearchResult.Size = new System.Drawing.Size(196, 13);
            this.lblWarningSearchResult.TabIndex = 61;
            this.lblWarningSearchResult.Text = "There is no result related to the keyword";
            this.lblWarningSearchResult.Visible = false;
            // 
            // ucMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.lblWarningSearchResult);
            this.Controls.Add(this.lblWarningSearchBy);
            this.Controls.Add(this.lblWarningKeyword);
            this.Controls.Add(this.gbSearchResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMembers";
            this.Size = new System.Drawing.Size(564, 413);
            this.Load += new System.EventHandler(this.ucMembers_Load);
            this.VisibleChanged += new System.EventHandler(this.ucMembers_VisibleChanged);
            this.gbSearchResults.ResumeLayout(false);
            this.gbSearchResults.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtICNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWarningKeyword;
        private System.Windows.Forms.Label lblWarningSearchBy;
        private System.Windows.Forms.Label lblWarningSearchResult;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtStatus;
    }
}
