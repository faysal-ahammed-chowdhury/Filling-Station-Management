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
        public FormUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.cboUserType.SelectedIndex = 0;
            this.ShowInitialInfo();
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
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.lblTotal.Text = (adminCnt + empCnt).ToString();
                this.lblAdmin.Text = adminCnt.ToString("D2");
                this.lblEmp.Text = empCnt.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.Visible = false;
            new FormAddUser(this).Show();
        }

        public void DeleteUser(string userId)
        {
            string name = this.dgvUser.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + name + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    MessageBox.Show($"{name} has been removed properly", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"{name} has not been removed properly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
