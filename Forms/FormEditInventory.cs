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
    public partial class FormEditInventory : Form
    {
        private DataAccess Da { get; set; }
        private FormAdminInventory FrmAdminInv { get; set; }
        public FormEditInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormEditInventory(string inventoryId, FormAdminInventory frmAdminInv) : this()
        {
            this.FrmAdminInv = frmAdminInv;
            this.ShowInventory(inventoryId);
        }

        private void ShowInventory(string inventoryId)
        {
            try
            {
                string query = $"SELECT * FROM Inventories WHERE InventoryId = '{inventoryId}'";
                DataSet ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // done
                    this.txtInventoryId.Text = ds.Tables[0].Rows[0][0].ToString();
                    this.txtFuelName.Text = ds.Tables[0].Rows[0][1].ToString();
                    this.txtStockQuantity.Text = ds.Tables[0].Rows[0][2].ToString();
                    this.txtPricePerLitre.Text = ds.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    // not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            this.txtFuelName.Clear();
            this.txtPricePerLitre.Clear();
            this.txtStockQuantity.Clear();
        }

        private void bntSave_Click(object sender, EventArgs e)
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
                string sql = $@"UPDATE Inventories 
                                SET FuelName = '{fuelName}',
                                StockQuantity = '{stockQuantity}',
                                PricePerLitre = '{pricePerLitre}'
                                WHERE InventoryId = '{id}'";
                //MessageBox.Show(sql);
                var count = this.Da.ExecuteDMLQuery(sql);
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"{fuelName} updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show($"{fuelName} did not updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Visible = false;
                this.ClearAll();
                FrmAdminInv.ClearAll();
                this.FrmAdminInv.Visible = true;
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
            FrmAdminInv.PopulateGridView();
            this.FrmAdminInv.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
