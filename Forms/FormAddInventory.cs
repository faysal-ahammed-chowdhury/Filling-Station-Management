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
    public partial class FormAddInventory : Form
    {
        private DataAccess Da { get; set; }
        private FormAdminInventory FrmAdminInv { get; set; }
        public FormAddInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateId();
        }
        public FormAddInventory(FormAdminInventory frmAdminInv) : this()
        {
            this.FrmAdminInv = frmAdminInv;
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt =  this.Da.ExecuteQueryTable("SELECT MAX(InventoryId) FROM Inventories");
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtInventoryId.Text = $"INV-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            this.GenerateId();
            this.txtFuelName.Clear();
            this.txtPricePerLitre.Clear();
            this.txtStockQuantity.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = this.txtInventoryId.Text;
            string fuelName = this.txtFuelName.Text;

            if (id.IsNullOrEmpty() || fuelName.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill all the fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pricePerLitre;
            bool isNumeric = decimal.TryParse(this.txtPricePerLitre.Text, out pricePerLitre);
            if (!isNumeric)
            {
                MessageBox.Show("Price should be a numerical value", "Huh!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal stockQuantity;
            isNumeric = decimal.TryParse(this.txtStockQuantity.Text, out stockQuantity);
            if (!isNumeric)
            {
                MessageBox.Show("Stock Quantity should be a numerical value", "Huh!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string sql = $"INSERT INTO Inventories VALUES ('{id}', '{fuelName}', '{pricePerLitre}', '{stockQuantity}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"{fuelName} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                    this.Visible = false;
                    this.ClearAll();
                    this.FrmAdminInv.ClearAll();
                    this.FrmAdminInv.Visible = true;
                }
                else
                {
                    MessageBox.Show($"{fuelName} did not added", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.FrmAdminInv.PopulateGridViewOnAction();
            this.FrmAdminInv.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
