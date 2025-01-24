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
    public partial class FormUsers : Form
    {
        private DataAccess Da { get; set; }
        private DataRow currentUser;
        public FormUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.cboUserType.SelectedIndex = 0;
            this.ShowInitialInfo();
        }

        public FormUsers(DataRow currentUser) : this()
        {
            this.currentUser = currentUser;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"];
        }

        public void PopulateGridView(string query = "SELECT * FROM Users")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(query);
                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateGridViewOnAction()
        {
            string part = "";
            if (!this.txtSearch.Text.IsNullOrEmpty())
                part = $"WHERE Name LIKE '%{this.txtSearch.Text}%'";
            if (!this.txtSearch.Text.IsNullOrEmpty() && this.cboUserType.SelectedIndex != 0)
                part += " AND ";
            if (this.cboUserType.SelectedIndex != 0 && this.txtSearch.Text.IsNullOrEmpty())
                part = "WHERE ";
            if (this.cboUserType.SelectedIndex != 0)
                part += $"Role = '{this.cboUserType.SelectedItem.ToString()}'";
            string query = $"SELECT * FROM Users {part}";
            this.PopulateGridView(query);
        }

        public void ShowInitialInfo()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT * FROM Users");
                int adminCnt = 0, empCnt = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Role"].ToString() == "Admin") adminCnt++;
                    else if (dr["Role"].ToString() == "Employee") empCnt++;
                }
                //MessageBox.Show(adminCnt.ToString() + " " + empCnt.ToString());
                this.lblTotal.Text = (adminCnt + empCnt).ToString("D2");
                this.lblAdmin.Text = adminCnt.ToString("D2");
                this.lblEmp.Text = empCnt.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.cboUserType.SelectedIndex = 0;
            this.PopulateGridView();
            this.ShowInitialInfo();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            this.dgvUser.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FormAddUser.isOpen)
                return;
            //this.Visible = false;
            new FormAddUser(this).Show();
        }

        public void DeleteUser(string userId)
        {
            string name = this.dgvUser.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = $"DELETE FROM Users WHERE UserId = '{userId}'";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"{name} has been successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"Failed to remove {name}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvUser.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // edit operations
                //MessageBox.Show("Edit Form");
                if (this.dgvUser.SelectedRows.Count > 0)
                {
                    if (FormEditUser.isOpen)
                        return;
                    string userId = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                    //this.Visible = false;
                    new FormEditUser(userId, this).Show();
                }
            }

            // delete
            if (e.RowIndex >= 0 && dgvUser.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvUser.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // delete operations
                //MessageBox.Show(this.dgvInventory.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvUser.SelectedRows.Count > 0)
                {
                    string userId = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                    this.DeleteUser(userId);
                }
            }
        }

        public void AfterEdit(string userId)
        {
            if (userId != currentUser["UserId"].ToString())
                return;

            try
            {
                string query = $"SELECT * FROM Users WHERE UserId = '{userId}'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                currentUser = dt.Rows[0];
                this.lblWlcName.Text = "Welcome, " + currentUser["Name"];

                if (currentUser["Role"].ToString() != "Admin")
                {
                    MessageBox.Show("Your status has been changed to 'Employee'. Please log in again with your new role.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    new FormLogin().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormAdminDashboard(currentUser).Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormInventory(currentUser).Show();
        }

        private void btnSalesrep_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormSales(currentUser).Show();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormExpense(currentUser).Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormLogin().Show();
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
