﻿namespace SportsFacilityManagementSystem
{
    partial class ucReports
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
            this.cmbTypeofReport = new System.Windows.Forms.ComboBox();
            this.lblTypeofReport = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpDateFromReport = new System.Windows.Forms.DateTimePicker();
            this.dtpToDateReport = new System.Windows.Forms.DateTimePicker();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.labelWarningReportTodate = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.gbMemberList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdnDateRange = new System.Windows.Forms.RadioButton();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.btnPrintML = new System.Windows.Forms.Button();
            this.dtpDatetoML = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFromML = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbRevenue = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnRPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMMR = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMRMonth = new System.Windows.Forms.ComboBox();
            this.cmbMRYear = new System.Windows.Forms.ComboBox();
            this.btnMRPrint = new System.Windows.Forms.Button();
            this.lblMRYear = new System.Windows.Forms.Label();
            this.gbReport.SuspendLayout();
            this.gbMemberList.SuspendLayout();
            this.gbRevenue.SuspendLayout();
            this.gbMMR.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTypeofReport
            // 
            this.cmbTypeofReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeofReport.ForeColor = System.Drawing.Color.Black;
            this.cmbTypeofReport.FormattingEnabled = true;
            this.cmbTypeofReport.Items.AddRange(new object[] {
            "Member List",
            "Facility Occupany Report",
            "Yearly Revenue Report",
            "Monthly Revenue Report"});
            this.cmbTypeofReport.Location = new System.Drawing.Point(360, 89);
            this.cmbTypeofReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbTypeofReport.Name = "cmbTypeofReport";
            this.cmbTypeofReport.Size = new System.Drawing.Size(332, 33);
            this.cmbTypeofReport.TabIndex = 70;
            this.cmbTypeofReport.SelectedIndexChanged += new System.EventHandler(this.cmbTypeofReport_SelectedIndexChanged);
            // 
            // lblTypeofReport
            // 
            this.lblTypeofReport.AutoSize = true;
            this.lblTypeofReport.Location = new System.Drawing.Point(184, 92);
            this.lblTypeofReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeofReport.Name = "lblTypeofReport";
            this.lblTypeofReport.Size = new System.Drawing.Size(166, 25);
            this.lblTypeofReport.TabIndex = 1;
            this.lblTypeofReport.Text = "Type of Report :";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Location = new System.Drawing.Point(52, 92);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(156, 67);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Week Starting From :";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(52, 191);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 25);
            this.lblToDate.TabIndex = 3;
            this.lblToDate.Text = "To :";
            // 
            // dtpDateFromReport
            // 
            this.dtpDateFromReport.Location = new System.Drawing.Point(228, 108);
            this.dtpDateFromReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpDateFromReport.Name = "dtpDateFromReport";
            this.dtpDateFromReport.Size = new System.Drawing.Size(426, 31);
            this.dtpDateFromReport.TabIndex = 73;
            this.dtpDateFromReport.ValueChanged += new System.EventHandler(this.dtpDateFromReport_ValueChanged);
            // 
            // dtpToDateReport
            // 
            this.dtpToDateReport.Location = new System.Drawing.Point(228, 191);
            this.dtpToDateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpToDateReport.Name = "dtpToDateReport";
            this.dtpToDateReport.Size = new System.Drawing.Size(420, 31);
            this.dtpToDateReport.TabIndex = 74;
            this.dtpToDateReport.ValueChanged += new System.EventHandler(this.dtpToDateReport_ValueChanged);
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.labelWarningReportTodate);
            this.gbReport.Controls.Add(this.btnPrintReport);
            this.gbReport.Controls.Add(this.dtpToDateReport);
            this.gbReport.Controls.Add(this.dtpDateFromReport);
            this.gbReport.Controls.Add(this.lblToDate);
            this.gbReport.Controls.Add(this.lblDateFrom);
            this.gbReport.Location = new System.Drawing.Point(120, 152);
            this.gbReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbReport.Name = "gbReport";
            this.gbReport.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbReport.Size = new System.Drawing.Size(806, 528);
            this.gbReport.TabIndex = 13;
            this.gbReport.TabStop = false;
            // 
            // labelWarningReportTodate
            // 
            this.labelWarningReportTodate.ForeColor = System.Drawing.Color.Red;
            this.labelWarningReportTodate.Location = new System.Drawing.Point(594, 231);
            this.labelWarningReportTodate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarningReportTodate.Name = "labelWarningReportTodate";
            this.labelWarningReportTodate.Size = new System.Drawing.Size(196, 69);
            this.labelWarningReportTodate.TabIndex = 24;
            this.labelWarningReportTodate.Text = "* To Date cannot be less than Date From";
            this.labelWarningReportTodate.Visible = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(290, 398);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(168, 91);
            this.btnPrintReport.TabIndex = 77;
            this.btnPrintReport.Text = "Print";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // gbMemberList
            // 
            this.gbMemberList.Controls.Add(this.label1);
            this.gbMemberList.Controls.Add(this.radioButton1);
            this.gbMemberList.Controls.Add(this.rdnDateRange);
            this.gbMemberList.Controls.Add(this.lblDateRange);
            this.gbMemberList.Controls.Add(this.btnPrintML);
            this.gbMemberList.Controls.Add(this.dtpDatetoML);
            this.gbMemberList.Controls.Add(this.dtpDateFromML);
            this.gbMemberList.Controls.Add(this.cmbStatus);
            this.gbMemberList.Location = new System.Drawing.Point(154, 169);
            this.gbMemberList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbMemberList.Name = "gbMemberList";
            this.gbMemberList.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbMemberList.Size = new System.Drawing.Size(806, 528);
            this.gbMemberList.TabIndex = 14;
            this.gbMemberList.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Status : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 283);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(27, 26);
            this.radioButton1.TabIndex = 81;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdnDateRange
            // 
            this.rdnDateRange.AutoSize = true;
            this.rdnDateRange.Location = new System.Drawing.Point(44, 114);
            this.rdnDateRange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdnDateRange.Name = "rdnDateRange";
            this.rdnDateRange.Size = new System.Drawing.Size(27, 26);
            this.rdnDateRange.TabIndex = 78;
            this.rdnDateRange.TabStop = true;
            this.rdnDateRange.UseVisualStyleBackColor = true;
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Location = new System.Drawing.Point(80, 111);
            this.lblDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(210, 25);
            this.lblDateRange.TabIndex = 24;
            this.lblDateRange.Text = "Expiry Date Range : ";
            // 
            // btnPrintML
            // 
            this.btnPrintML.Location = new System.Drawing.Point(316, 402);
            this.btnPrintML.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintML.Name = "btnPrintML";
            this.btnPrintML.Size = new System.Drawing.Size(168, 91);
            this.btnPrintML.TabIndex = 83;
            this.btnPrintML.Text = "Print";
            this.btnPrintML.UseVisualStyleBackColor = true;
            this.btnPrintML.Click += new System.EventHandler(this.btnPrintML_Click);
            // 
            // dtpDatetoML
            // 
            this.dtpDatetoML.Location = new System.Drawing.Point(332, 198);
            this.dtpDatetoML.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpDatetoML.Name = "dtpDatetoML";
            this.dtpDatetoML.Size = new System.Drawing.Size(392, 31);
            this.dtpDatetoML.TabIndex = 80;
            // 
            // dtpDateFromML
            // 
            this.dtpDateFromML.Location = new System.Drawing.Point(332, 109);
            this.dtpDateFromML.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpDateFromML.Name = "dtpDateFromML";
            this.dtpDateFromML.Size = new System.Drawing.Size(392, 31);
            this.dtpDateFromML.TabIndex = 79;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(332, 277);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(184, 33);
            this.cmbStatus.TabIndex = 82;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(134, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(806, 61);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Print Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbRevenue
            // 
            this.gbRevenue.Controls.Add(this.cmbYear);
            this.gbRevenue.Controls.Add(this.btnRPrint);
            this.gbRevenue.Controls.Add(this.label4);
            this.gbRevenue.Location = new System.Drawing.Point(134, 156);
            this.gbRevenue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbRevenue.Name = "gbRevenue";
            this.gbRevenue.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbRevenue.Size = new System.Drawing.Size(806, 528);
            this.gbRevenue.TabIndex = 25;
            this.gbRevenue.TabStop = false;
            this.gbRevenue.Visible = false;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cmbYear.Location = new System.Drawing.Point(368, 94);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(168, 33);
            this.cmbYear.TabIndex = 71;
            // 
            // btnRPrint
            // 
            this.btnRPrint.Location = new System.Drawing.Point(316, 327);
            this.btnRPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRPrint.Name = "btnRPrint";
            this.btnRPrint.Size = new System.Drawing.Size(168, 91);
            this.btnRPrint.TabIndex = 72;
            this.btnRPrint.Text = "Print";
            this.btnRPrint.UseVisualStyleBackColor = true;
            this.btnRPrint.Click += new System.EventHandler(this.btnRPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Year : ";
            // 
            // gbMMR
            // 
            this.gbMMR.Controls.Add(this.label2);
            this.gbMMR.Controls.Add(this.cmbMRMonth);
            this.gbMMR.Controls.Add(this.cmbMRYear);
            this.gbMMR.Controls.Add(this.btnMRPrint);
            this.gbMMR.Controls.Add(this.lblMRYear);
            this.gbMMR.Location = new System.Drawing.Point(160, 131);
            this.gbMMR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbMMR.Name = "gbMMR";
            this.gbMMR.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbMMR.Size = new System.Drawing.Size(806, 528);
            this.gbMMR.TabIndex = 26;
            this.gbMMR.TabStop = false;
            this.gbMMR.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Month : ";
            // 
            // cmbMRMonth
            // 
            this.cmbMRMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMRMonth.FormattingEnabled = true;
            this.cmbMRMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMRMonth.Location = new System.Drawing.Point(410, 216);
            this.cmbMRMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbMRMonth.Name = "cmbMRMonth";
            this.cmbMRMonth.Size = new System.Drawing.Size(168, 33);
            this.cmbMRMonth.TabIndex = 72;
            // 
            // cmbMRYear
            // 
            this.cmbMRYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMRYear.FormattingEnabled = true;
            this.cmbMRYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cmbMRYear.Location = new System.Drawing.Point(410, 106);
            this.cmbMRYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbMRYear.Name = "cmbMRYear";
            this.cmbMRYear.Size = new System.Drawing.Size(168, 33);
            this.cmbMRYear.TabIndex = 71;
            // 
            // btnMRPrint
            // 
            this.btnMRPrint.Location = new System.Drawing.Point(290, 398);
            this.btnMRPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMRPrint.Name = "btnMRPrint";
            this.btnMRPrint.Size = new System.Drawing.Size(168, 91);
            this.btnMRPrint.TabIndex = 73;
            this.btnMRPrint.Text = "Print";
            this.btnMRPrint.UseVisualStyleBackColor = true;
            this.btnMRPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMRYear
            // 
            this.lblMRYear.AutoSize = true;
            this.lblMRYear.Location = new System.Drawing.Point(184, 109);
            this.lblMRYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRYear.Name = "lblMRYear";
            this.lblMRYear.Size = new System.Drawing.Size(142, 25);
            this.lblMRYear.TabIndex = 2;
            this.lblMRYear.Text = "Select Year : ";
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTypeofReport);
            this.Controls.Add(this.cmbTypeofReport);
            this.Controls.Add(this.gbMMR);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbMemberList);
            this.Controls.Add(this.gbRevenue);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1128, 794);
            this.Load += new System.EventHandler(this.ucReports_Load);
            this.VisibleChanged += new System.EventHandler(this.ucReports_VisibleChanged);
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.gbMemberList.ResumeLayout(false);
            this.gbMemberList.PerformLayout();
            this.gbRevenue.ResumeLayout(false);
            this.gbRevenue.PerformLayout();
            this.gbMMR.ResumeLayout(false);
            this.gbMMR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeofReport;
        private System.Windows.Forms.Label lblTypeofReport;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpDateFromReport;
        private System.Windows.Forms.DateTimePicker dtpToDateReport;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label labelWarningReportTodate;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.GroupBox gbMemberList;
        private System.Windows.Forms.Button btnPrintML;
        private System.Windows.Forms.DateTimePicker dtpDatetoML;
        private System.Windows.Forms.DateTimePicker dtpDateFromML;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdnDateRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRevenue;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnRPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbMMR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMRMonth;
        private System.Windows.Forms.ComboBox cmbMRYear;
        private System.Windows.Forms.Button btnMRPrint;
        private System.Windows.Forms.Label lblMRYear;
    }
}
