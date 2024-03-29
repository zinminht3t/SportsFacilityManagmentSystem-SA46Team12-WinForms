﻿namespace SportsFacilityManagementSystem
{
    partial class ucFacilities
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchby = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.lblWarningRate = new System.Windows.Forms.Label();
            this.pbWarningRate = new System.Windows.Forms.PictureBox();
            this.lblWarningFac = new System.Windows.Forms.Label();
            this.lblWarningID = new System.Windows.Forms.Label();
            this.pbWarningFac = new System.Windows.Forms.PictureBox();
            this.pbWarningID = new System.Windows.Forms.PictureBox();
            this.txtFacilityID = new System.Windows.Forms.TextBox();
            this.lblFacilityID = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFacilitiesNo = new System.Windows.Forms.TextBox();
            this.lblFacilitiesno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRates = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.gbSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 96);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchby
            // 
            this.lblSearchby.AutoSize = true;
            this.lblSearchby.Location = new System.Drawing.Point(172, 60);
            this.lblSearchby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchby.Name = "lblSearchby";
            this.lblSearchby.Size = new System.Drawing.Size(64, 13);
            this.lblSearchby.TabIndex = 26;
            this.lblSearchby.Text = "Search by : ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Crimson;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(92, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 32);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Search Facilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.gbSearchResults.Controls.Add(this.cmbRates);
            this.gbSearchResults.Controls.Add(this.lblWarningRate);
            this.gbSearchResults.Controls.Add(this.pbWarningRate);
            this.gbSearchResults.Controls.Add(this.lblWarningFac);
            this.gbSearchResults.Controls.Add(this.lblWarningID);
            this.gbSearchResults.Controls.Add(this.pbWarningFac);
            this.gbSearchResults.Controls.Add(this.pbWarningID);
            this.gbSearchResults.Controls.Add(this.txtFacilityID);
            this.gbSearchResults.Controls.Add(this.lblFacilityID);
            this.gbSearchResults.Controls.Add(this.btnEdit);
            this.gbSearchResults.Controls.Add(this.btnSave);
            this.gbSearchResults.Controls.Add(this.btnCancel);
            this.gbSearchResults.Controls.Add(this.txtFacilitiesNo);
            this.gbSearchResults.Controls.Add(this.lblFacilitiesno);
            this.gbSearchResults.Controls.Add(this.txtName);
            this.gbSearchResults.Controls.Add(this.lblRates);
            this.gbSearchResults.Controls.Add(this.lblName);
            this.gbSearchResults.Location = new System.Drawing.Point(134, 136);
            this.gbSearchResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearchResults.Size = new System.Drawing.Size(314, 266);
            this.gbSearchResults.TabIndex = 63;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "Search Results";
            this.gbSearchResults.Visible = false;
            // 
            // cmbRates
            // 
            this.cmbRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRates.Enabled = false;
            this.cmbRates.FormattingEnabled = true;
            this.cmbRates.Items.AddRange(new object[] {
            "$ 3.00",
            "$ 4.00",
            "$ 5.00",
            "$ 6.00",
            "$ 7.00",
            "$ 8.00",
            "$ 9.00",
            "$ 10.00"});
            this.cmbRates.Location = new System.Drawing.Point(130, 106);
            this.cmbRates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(90, 21);
            this.cmbRates.TabIndex = 72;
            // 
            // lblWarningRate
            // 
            this.lblWarningRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarningRate.Location = new System.Drawing.Point(243, 102);
            this.lblWarningRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningRate.Name = "lblWarningRate";
            this.lblWarningRate.Size = new System.Drawing.Size(63, 30);
            this.lblWarningRate.TabIndex = 71;
            this.lblWarningRate.Text = "Rates / 2 hours";
            this.lblWarningRate.Visible = false;
            // 
            // pbWarningRate
            // 
            this.pbWarningRate.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbWarningRate.Location = new System.Drawing.Point(220, 106);
            this.pbWarningRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbWarningRate.Name = "pbWarningRate";
            this.pbWarningRate.Size = new System.Drawing.Size(18, 18);
            this.pbWarningRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningRate.TabIndex = 70;
            this.pbWarningRate.TabStop = false;
            this.pbWarningRate.Visible = false;
            this.pbWarningRate.MouseEnter += new System.EventHandler(this.pbWarningRate_MouseEnter);
            this.pbWarningRate.MouseLeave += new System.EventHandler(this.pbWarningRate_MouseLeave);
            // 
            // lblWarningFac
            // 
            this.lblWarningFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarningFac.Location = new System.Drawing.Point(242, 136);
            this.lblWarningFac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningFac.Name = "lblWarningFac";
            this.lblWarningFac.Size = new System.Drawing.Size(67, 46);
            this.lblWarningFac.TabIndex = 69;
            this.lblWarningFac.Text = "This field cannot be edited";
            this.lblWarningFac.Visible = false;
            // 
            // lblWarningID
            // 
            this.lblWarningID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarningID.Location = new System.Drawing.Point(243, 43);
            this.lblWarningID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningID.Name = "lblWarningID";
            this.lblWarningID.Size = new System.Drawing.Size(63, 49);
            this.lblWarningID.TabIndex = 68;
            this.lblWarningID.Text = "This field cannot be edited";
            this.lblWarningID.Visible = false;
            // 
            // pbWarningFac
            // 
            this.pbWarningFac.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbWarningFac.Location = new System.Drawing.Point(220, 136);
            this.pbWarningFac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbWarningFac.Name = "pbWarningFac";
            this.pbWarningFac.Size = new System.Drawing.Size(18, 18);
            this.pbWarningFac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningFac.TabIndex = 67;
            this.pbWarningFac.TabStop = false;
            this.pbWarningFac.Visible = false;
            this.pbWarningFac.MouseEnter += new System.EventHandler(this.pbWarningFac_MouseEnter);
            this.pbWarningFac.MouseLeave += new System.EventHandler(this.pbWarningFac_MouseLeave);
            // 
            // pbWarningID
            // 
            this.pbWarningID.Image = global::SportsFacilityManagementSystem.Properties.Resources.Info;
            this.pbWarningID.Location = new System.Drawing.Point(220, 43);
            this.pbWarningID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbWarningID.Name = "pbWarningID";
            this.pbWarningID.Size = new System.Drawing.Size(18, 18);
            this.pbWarningID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningID.TabIndex = 66;
            this.pbWarningID.TabStop = false;
            this.pbWarningID.Visible = false;
            this.pbWarningID.MouseEnter += new System.EventHandler(this.pbWarningID_MouseEnter);
            this.pbWarningID.MouseLeave += new System.EventHandler(this.pbWarningID_MouseLeave);
            // 
            // txtFacilityID
            // 
            this.txtFacilityID.Location = new System.Drawing.Point(130, 43);
            this.txtFacilityID.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacilityID.Name = "txtFacilityID";
            this.txtFacilityID.ReadOnly = true;
            this.txtFacilityID.Size = new System.Drawing.Size(90, 20);
            this.txtFacilityID.TabIndex = 58;
            // 
            // lblFacilityID
            // 
            this.lblFacilityID.AutoSize = true;
            this.lblFacilityID.Location = new System.Drawing.Point(38, 46);
            this.lblFacilityID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacilityID.Name = "lblFacilityID";
            this.lblFacilityID.Size = new System.Drawing.Size(59, 13);
            this.lblFacilityID.TabIndex = 64;
            this.lblFacilityID.Text = "Facility ID :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(193, 213);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 30);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 213);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 30);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(60, 213);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 30);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFacilitiesNo
            // 
            this.txtFacilitiesNo.Location = new System.Drawing.Point(130, 136);
            this.txtFacilitiesNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacilitiesNo.Name = "txtFacilitiesNo";
            this.txtFacilitiesNo.ReadOnly = true;
            this.txtFacilitiesNo.Size = new System.Drawing.Size(90, 20);
            this.txtFacilitiesNo.TabIndex = 61;
            // 
            // lblFacilitiesno
            // 
            this.lblFacilitiesno.AutoSize = true;
            this.lblFacilitiesno.Location = new System.Drawing.Point(38, 139);
            this.lblFacilitiesno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacilitiesno.Name = "lblFacilitiesno";
            this.lblFacilitiesno.Size = new System.Drawing.Size(85, 13);
            this.lblFacilitiesno.TabIndex = 41;
            this.lblFacilitiesno.Text = "No of Facilities : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(90, 20);
            this.txtName.TabIndex = 59;
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(38, 109);
            this.lblRates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(44, 13);
            this.lblRates.TabIndex = 38;
            this.lblRates.Text = "Rates : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 76);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Facility Name : ";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "- default -"});
            this.cmbSearchBy.Location = new System.Drawing.Point(251, 58);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(144, 21);
            this.cmbSearchBy.TabIndex = 56;
            // 
            // ucFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.gbSearchResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.lblSearchby);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucFacilities";
            this.Size = new System.Drawing.Size(564, 413);
            this.Load += new System.EventHandler(this.ucFacilities_Load);
            this.VisibleChanged += new System.EventHandler(this.ucFacilities_VisibleChanged);
            this.gbSearchResults.ResumeLayout(false);
            this.gbSearchResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchby;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.TextBox txtFacilitiesNo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblFacilitiesno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFacilityID;
        private System.Windows.Forms.Label lblFacilityID;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblWarningFac;
        private System.Windows.Forms.Label lblWarningID;
        private System.Windows.Forms.PictureBox pbWarningFac;
        private System.Windows.Forms.PictureBox pbWarningID;
        private System.Windows.Forms.Label lblWarningRate;
        private System.Windows.Forms.PictureBox pbWarningRate;
        private System.Windows.Forms.ComboBox cmbRates;
    }
}
