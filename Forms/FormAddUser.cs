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
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormUsers FrmUsers { get; set; }
        public FormAddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateId();
            isOpen = true;
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
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.txtUserId.Text = "USER-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtUserId.Text = $"USER-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool IsValid()
        {
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            string password = this.txtPassword.Text;
            bool typeChecked = this.chkEmp.Checked || this.chkAdmin.Checked;
            if (name.IsNullOrEmpty() || phone.IsNullOrEmpty() || password.IsNullOrEmpty() || !typeChecked)
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            try
            {
                string id = this.txtUserId.Text;
                string name = this.txtName.Text;
                string phone = this.txtPhone.Text;
                string password = this.txtPassword.Text;
                string role = "";
                if (this.chkAdmin.Checked)
                    role = "Admin";
                else if (this.chkEmp.Checked)
                    role = "Employee";


                string sql = $"SELECT * FROM Users WHERE Phone = '{phone}'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count > 0)
                    MessageBox.Show("A user with this phone number already exists. Please use a different number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                sql = $"INSERT INTO Users VALUES ('{id}', '{name}', '{phone}', '{password}', '{role}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"{name} has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    this.ClearAll();
                    this.FrmUsers.ClearAll();
                    this.FrmUsers.Visible = true;
                    isOpen = false;
                }
                else
                    MessageBox.Show($"Failed to add {name}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
