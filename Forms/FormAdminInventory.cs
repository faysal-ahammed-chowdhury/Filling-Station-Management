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
    public partial class FormAdminInventory : Form
    {
        private DataAccess Da { get; set; }
        public FormAdminInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public void PopulateGridView()
        {
            try
            {
                string query = "SELECT * FROM Inventories";
                DataSet ds = this.Da.ExecuteQuery(query);
                this.dgvInventory.AutoGenerateColumns = false;
                this.dgvInventory.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string fuelName = this.dgvInventory.CurrentRow.Cells[1].Value.ToString();

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
                        this.PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show($"{fuelName} has not been removed properly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FormAdminInventory_Load(object sender, EventArgs e)
        {
            this.dgvInventory.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormAddInventory(this).Show();
        }
    }
}
