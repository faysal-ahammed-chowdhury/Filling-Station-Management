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
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormInventory FrmInv { get; set; }
        public FormEditInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            isOpen = true;
        }
        public FormEditInventory(string inventoryId, FormInventory FrmInv) : this()
        {
            this.FrmInv = FrmInv;
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pricePerLitre;
            bool isNumeric = decimal.TryParse(this.txtPricePerLitre.Text, out pricePerLitre);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical value for the price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal stockQuantity;
            isNumeric = decimal.TryParse(this.txtStockQuantity.Text, out stockQuantity);
            if (!isNumeric)
            {
                MessageBox.Show("Stock quantity must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pricePerLitre <= 0)
            {
                MessageBox.Show("Price must be a positive value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stockQuantity <= 0)
            {
                MessageBox.Show("Stock quantity must be a positive value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                {
                    MessageBox.Show($"{fuelName} has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    this.ClearAll();
                    this.FrmInv.ClearAll();
                    this.FrmInv.Visible = true;
                    isOpen = false;
                }
                else
                {
                    MessageBox.Show($"{fuelName} could not be updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.FrmInv.PopulateGridViewOnAction();
            this.FrmInv.Visible = true;
            isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
