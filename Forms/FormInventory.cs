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
    public partial class FormInventory : Form
    {
        private DataAccess Da { get; set; }
        private DataRow currentUser;
        public FormInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public FormInventory(DataRow currentUser) : this()
        {
            this.currentUser = currentUser;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"];
        }

        public void PopulateGridView(string query = "SELECT * FROM Inventories")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(query);
                this.dgvInventory.AutoGenerateColumns = false;
                this.dgvInventory.DataSource = ds.Tables[0];
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
            {
                part = $"WHERE FuelName LIKE '%{this.txtSearch.Text}%'";
            }
            string query = $"SELECT * FROM Inventories {part}";
            this.PopulateGridView(query);
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.PopulateGridView();
        }

        public void DeleteInventory(string inventoryId)
        {
            string fuelName = this.dgvInventory.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + fuelName + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string sql = $"DELETE FROM Inventories WHERE InventoryId = '{inventoryId}'";
            int cnt = this.Da.ExecuteDMLQuery(sql);
            if (cnt == 1)
            {
                MessageBox.Show($"{fuelName} has been removed properly", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.PopulateGridViewOnAction();
            }
            else
            {
                MessageBox.Show($"{fuelName} has not been removed properly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.RowIndex >= 0 && dgvInventory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvInventory.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // edit operations
                //MessageBox.Show("Edit Form");
                if (this.dgvInventory.SelectedRows.Count > 0)
                {
                    string inventoryId = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                    this.Visible = false;
                    new FormEditInventory(inventoryId, this).Show();
                }
            }

            // delete
            if (e.RowIndex >= 0 && dgvInventory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvInventory.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // delete operations
                //MessageBox.Show(this.dgvInventory.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvInventory.SelectedRows.Count > 0)
                {
                    string inventoryId = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                    this.DeleteInventory(inventoryId);
                }
            }
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            this.dgvInventory.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormAddInventory(this).Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormAdminDashboard(currentUser).Show();
        }

        private void btnSalesrep_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormSales(currentUser).Show();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormUsers(currentUser).Show();
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
    }
}
