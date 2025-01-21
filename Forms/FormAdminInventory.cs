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
            PopulateGridView();
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
                MessageBox.Show("Edit Form");
            }

            // delete
            if (e.RowIndex >= 0 && dgvInventory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvInventory.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // delete operations
                MessageBox.Show("Delete Form");
            }
        }
    }
}
