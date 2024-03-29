﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SportsFacilityManagementSystem
{
    public partial class ucAddMember : UserControl
    {
        Member newmember;
        public ucAddMember()
        {
            InitializeComponent();
        }

        private void InsertData()
        {
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            newmember = new Member();
            newmember.name = txtName.Text;
            newmember.icno = txtICNo.Text;
            if(rdbMale.Checked == true)
            {
                newmember.gender = rdbMale.Text;
            }
            else
            {
                newmember.gender = rdbFemale.Text;
            }
            newmember.address = txtAddress.Text;
            newmember.mobileno = Convert.ToInt32(txtMobile.Text);
            newmember.email = txtEmail.Text;
            newmember.dateofbirth = dtpDOB.Value;
            newmember.joindate = dtpJoindate.Value;
            newmember.expirydate = dtpJoindate.Value.AddYears(2);
            newmember.status = "Active";
            ctx.Members.Add(newmember);
            ctx.SaveChanges();
        }
        
        public bool CheckEmail(string email)
        {
            string pattern;
            pattern = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, pattern))
            {
                if (Regex.Replace(email, pattern, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ResetAllFields()
        {
            txtName.Text = "";
            txtICNo.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            rdbFemale.Checked = false;
            rdbMale.Checked = true;
            dtpDOB.Value = dtpDOB.MaxDate = DateTime.Today.AddYears(-13);
            dtpJoindate.Value = DateTime.Now;
        }

        private void ResetAllWarningLabels()
        {
            lblWarningName.Visible = false;
            lblWarningIC.Visible = false;
            lblWarningAddress.Visible = false;
            lblWarningGender.Visible = false;
            lblWarningMobile.Text = "Field cannot be blank";
            lblWarningMobile.Visible = false;
            lblWarningEmail.Text = "Field cannot be blank";
            lblWarningEmail.Visible = false;
        }

        #region Event Handlers
        private void ucAddMember_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today.AddYears(-13); // the member must be at least 13 years old.
            rdbMale.Checked = true;
        }
        private void ucAddMember_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ResetAllFields();
                ResetAllWarningLabels();
            }
        }
        private void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(this.ucAddMember_VisibleChanged);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllFields();
            ResetAllWarningLabels();
        }
        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMobile.Text, "[^0-9]"))
            {
                lblWarningMobile.Text = "Please enter only numbers.";
                lblWarningMobile.Visible = true;

            }
            else
            {
                lblWarningMobile.Text = "";
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ResetAllWarningLabels();
            SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
            if (txtName.Text == "" || txtICNo.Text == "" || txtMobile.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                if (txtName.Text == "")
                {
                    lblWarningName.Visible = true;
                }
                else
                {
                    lblWarningName.Visible = false;
                }

                if (txtICNo.Text == "")
                {
                    lblWarningIC.Visible = true;
                }
                else
                {
                    lblWarningIC.Visible = false;
                }

                if (txtMobile.Text == "")
                {
                    lblWarningMobile.Visible = true;
                }
                else
                {
                    lblWarningMobile.Visible = false;
                }

                if (txtEmail.Text == "")
                {
                    lblWarningEmail.Visible = true;
                }
                else
                {
                    lblWarningEmail.Visible = false;
                }
                if (txtAddress.Text == "")
                {
                    lblWarningAddress.Visible = true;
                }
                else
                {
                    lblWarningAddress.Visible = false;
                }
            }
            else
            {
                if (!CheckEmail(txtEmail.Text))
                {
                    lblWarningEmail.Text = "Please enter the valid email address";
                    lblWarningEmail.Visible = true;
                }
                else
                {
                    try
                    {
                        InsertData();
                        ResetAllFields();
                        ResetAllWarningLabels();
                        MessageBox.Show("Add Member Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult d = MessageBox.Show("Do you want to print the membership form?", "Print Membership Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (d == DialogResult.OK)
                        {
                            ucMembers.memberid = newmember.memberid;
                            frmMemberInfoReport frmMemberInfo = new frmMemberInfoReport();
                            frmMemberInfo.ShowDialog();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error Occurred. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        #endregion

    }
}
