using Microsoft.IdentityModel.Tokens;
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
    public partial class FormAddUser : Form
    {
        private DataAccess Da { get; set; }
        private FormUsers FrmUsers { get; set; }
        public FormAddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateId();
        }
        public FormAddUser(FormUsers frmUsers) : this()
        {
            this.FrmUsers = frmUsers;
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(UserId) FROM Users");
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtUserId.Text = $"USER-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            this.GenerateId();
            this.txtName.Clear();
            this.txtPhone.Clear();
            this.txtPassword.Clear();
            this.chkAdmin.Checked = false;
            this.chkEmp.Checked = false;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            string id = this.txtUserId.Text;
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            string password = this.txtPassword.Text;
            bool typeChecked = this.chkEmp.Checked || this.chkAdmin.Checked;
            string role = "";
            if (this.chkAdmin.Checked)
                role = "Admin";
            else if (this.chkEmp.Checked)
                role = "Employee";

            if (name.IsNullOrEmpty() || phone.IsNullOrEmpty() || password.IsNullOrEmpty() || !typeChecked)
            {
                MessageBox.Show("Please fill all the fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                string sql = $"SELECT * FROM Users WHERE Phone = '{phone}'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("There is an user with this phone number, please change the phone number", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                sql = $"INSERT INTO Users VALUES ('{id}', '{name}', '{phone}', '{password}', '{role}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"{name} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.Visible = false;
                    this.ClearAll();
                    this.FrmUsers.ClearAll();
                    this.FrmUsers.Visible = true;
                }
                else
                {
                    MessageBox.Show($"{name} did not added", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
