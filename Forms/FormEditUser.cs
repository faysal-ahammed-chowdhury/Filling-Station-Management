using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormEditUser : Form
    {
        private DataAccess Da { get; set; }
        private FormUsers FrmUsers { get; set; }
        private string userId; 
        public FormEditUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormEditUser(string userId, FormUsers frmUsers) : this()
        {
            this.FrmUsers = frmUsers;
            this.ShowUser(userId);
            this.userId = userId;
        }

        private void ShowUser(string userId)
        {
            try
            {
                string query = $"SELECT * FROM Users WHERE UserId = '{userId}'";
                DataSet ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // done
                    this.txtUserId.Text = ds.Tables[0].Rows[0][0].ToString();
                    this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    this.txtPhone.Text = ds.Tables[0].Rows[0][2].ToString();
                    this.txtPassword.Text = ds.Tables[0].Rows[0][3].ToString();
                    string role = ds.Tables[0].Rows[0][4].ToString();
                    if (role == "Admin") this.chkAdmin.Checked = true;
                    else if (role == "Employee") this.chkEmp.Checked = true;
                }
                else
                {
                    // not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.txtName.Clear();
            this.txtPhone.Clear();
            this.txtPassword.Clear();
            this.chkAdmin.Checked = false;
            this.chkEmp.Checked = false;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            string id = this.txtUserId.Text;
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            string password = this.txtPassword.Text;
            bool typeChecked = chkEmp.Checked || chkAdmin.Checked;
            string role = "";
            if (chkAdmin.Checked)
                role = "Admin";
            else if (chkEmp.Checked)
                role = "Employee";

            if (name.IsNullOrEmpty() || phone.IsNullOrEmpty() || password.IsNullOrEmpty() || !typeChecked)
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = $@"UPDATE Users 
                                SET Name = '{name}',
                                Phone = '{phone}',
                                Password = '{password}',
                                Role = '{role}'
                                WHERE UserId = '{id}'";
                //MessageBox.Show(sql);
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"{name} has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    this.ClearAll();
                    this.FrmUsers.ClearAll();
                    this.FrmUsers.Visible = true;
                    this.FrmUsers.AfterEdit(this.userId);
                }
                else
                {
                    MessageBox.Show($"Failed to update {name}. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.Visible = false;
            this.FrmUsers.PopulateGridViewOnAction();
            this.FrmUsers.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
