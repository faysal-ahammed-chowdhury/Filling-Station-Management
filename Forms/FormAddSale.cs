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
    public partial class FormAddSale : Form
    {
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private DataTable addedProductsTable;
        private decimal grandTotal;
        private DataRow currentUser;

        private FormSales FrmSls { get; set; }
        public FormAddSale()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.addedProductsTable = new DataTable();
            this.addedProductsTable.Columns.Add("CInventoryId", typeof(string));
            this.addedProductsTable.Columns.Add("CFuelName", typeof(string));
            this.addedProductsTable.Columns.Add("CPricePerLitre", typeof(decimal));
            this.addedProductsTable.Columns.Add("CQuantity", typeof(decimal));
            this.addedProductsTable.Columns.Add("CTotal", typeof(decimal));
            this.ShowGrandTotal();
            this.GenerateId();
            isOpen = true;
        }

        public FormAddSale(DataRow currentUser, FormSales frmSls) : this()
        {
            this.currentUser = currentUser;
            this.FrmSls = frmSls;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"].ToString();
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(SaleId) FROM Sales");
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.lblSaleId.Text = $"SALE-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void ShowGrandTotal()
        {
            decimal total = 0;
            foreach (DataRow row in this.addedProductsTable.Rows)
            {
                total += Convert.ToDecimal(row["CTotal"]);
            }
            this.lblGrand.Text = total.ToString("F2") + " TK";
            this.grandTotal = total;
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.PopulateGridView();
            this.addedProductsTable.Clear();
            this.dgvAddedProducts.AutoGenerateColumns = false;
            this.dgvAddedProducts.DataSource = addedProductsTable;
            this.ShowGrandTotal();
            this.txtGiven.Text = string.Empty;
            this.txtChange.Text = string.Empty;
            this.GenerateId();
            this.chkCash.Checked = false;
            this.chkBkash.Checked = false;
        }

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            this.dgvInventory.ClearSelection();
            this.dgvAddedProducts.ClearSelection();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // add
            if (e.RowIndex >= 0 && dgvInventory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvInventory.Columns[e.ColumnIndex].Name == "AddAction")
            {
                if (this.dgvInventory.SelectedRows.Count > 0)
                {
                    try
                    {
                        string inventoryId = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                        string productName = this.dgvInventory.CurrentRow.Cells[1].Value.ToString();
                        decimal productPrice = Convert.ToDecimal(this.dgvInventory.CurrentRow.Cells[2].Value.ToString());
                        decimal avaiableQuantity = Convert.ToDecimal(this.dgvInventory.CurrentRow.Cells[3].Value.ToString());
                        string selectedQuantityStr = "";
                        if (this.dgvInventory.CurrentRow.Cells[4].Value != null)
                        {
                            selectedQuantityStr = this.dgvInventory.CurrentRow.Cells[4].Value.ToString();
                            //MessageBox.Show(selectedQuantityStr);
                        }

                        decimal addedQuantity = 0;

                        if (selectedQuantityStr.IsNullOrEmpty())
                        {
                            this.dgvInventory.CurrentRow.Cells[4].Value = "1";
                            addedQuantity = 1;
                        }
                        else
                        {
                            bool isNumeric = decimal.TryParse(selectedQuantityStr, out addedQuantity);
                            if (!isNumeric)
                            {
                                MessageBox.Show("Quantity must be a valid numerical value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        if (avaiableQuantity < addedQuantity)
                        {
                            MessageBox.Show($"Not enough {productName} in stock.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (addedQuantity <= 0)
                        {
                            MessageBox.Show("Quantity must be a positive value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        decimal productTotal = addedQuantity * productPrice;

                        DataRow existingRow = null;
                        foreach (DataRow row in addedProductsTable.Rows)
                        {
                            if (row["CInventoryId"].ToString() == inventoryId)
                            {
                                existingRow = row;
                                break;
                            }
                        }
                        if (existingRow != null)
                        {
                            existingRow["CQuantity"] = addedQuantity;
                            existingRow["CTotal"] = productTotal;
                        }
                        else
                        {
                            addedProductsTable.Rows.Add(inventoryId, productName, productPrice, addedQuantity, productTotal);
                        }

                        this.dgvAddedProducts.AutoGenerateColumns = false;
                        this.dgvAddedProducts.DataSource = addedProductsTable;
                        this.ShowGrandTotal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // remove
            if (e.RowIndex >= 0 && dgvInventory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvInventory.Columns[e.ColumnIndex].Name == "RemoveAction")
            {
                try
                {
                    string inventoryId = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                    bool isDeleted = false;
                    foreach (DataRow row in addedProductsTable.Rows)
                    {
                        if (row["CInventoryId"].ToString() == inventoryId)
                        {
                            addedProductsTable.Rows.Remove(row);
                            isDeleted = true;
                            break;
                        }
                    }

                    if (!isDeleted)
                        return;

                    this.dgvAddedProducts.AutoGenerateColumns = false;
                    this.dgvAddedProducts.DataSource = addedProductsTable;
                    this.dgvInventory.CurrentRow.Cells[4].Value = null;
                    this.ShowGrandTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void txtGiven_TextChanged(object sender, EventArgs e)
        {
            decimal amount;
            bool isNumeric = decimal.TryParse(this.txtGiven.Text, out amount);
            if (!isNumeric)
            {
                this.txtChange.Text = string.Empty;
                return;
            }
            if (amount <= 0)
            {
                this.txtChange.Text = string.Empty;
                return;
            }

            this.txtChange.Text = (amount - grandTotal).ToString();
        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            if (this.addedProductsTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add items to the cart before confirming the sale.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal givenAmount, changeAmount;
            bool isNumeric = decimal.TryParse(this.txtGiven.Text, out givenAmount);
            isNumeric &= decimal.TryParse(this.txtChange.Text, out changeAmount);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (givenAmount < grandTotal)
            {
                MessageBox.Show("The given amount should be greater than or equal to the Grand Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (givenAmount < 0 || changeAmount < 0)
            {
                MessageBox.Show("Amount must be a positive value.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool methodChecked = this.chkCash.Checked || this.chkBkash.Checked;
            string method = "";
            if (this.chkCash.Checked)
                method = "Cash";
            else if (this.chkBkash.Checked)
                method = "Bkash";

            if (!methodChecked)
            {
                MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to confirm the sale?", "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            // validation done, now insert into db and rest
            string id = this.lblSaleId.Text;
            string saleDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {

                // update stock, add to sales and saledetails
                string sql = $@"INSERT INTO Sales VALUES ('{id}', '{saleDateTime}', '{currentUser["UserId"].ToString()}',
                            '{grandTotal.ToString()}', '{givenAmount.ToString()}', 
                            '{changeAmount.ToString()}', '{method}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                foreach (DataRow row in this.addedProductsTable.Rows)
                {
                    DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(SaleDetailId) FROM SaleDetails");
                    string[] temp = dt.Rows[0][0].ToString().Split("-");
                    string saleDetailId = $"SD-{(Convert.ToInt32(temp[1]) + 1).ToString("D3")}";
                    string inventoryId = row["CInventoryId"].ToString();
                    string pricePerLitre = row["CPricePerLitre"].ToString();
                    string quantity = row["CQuantity"].ToString();
                    string total = row["CTotal"].ToString();
                    sql = $@"INSERT INTO SaleDetails VALUES ('{saleDetailId}', '{this.lblSaleId.Text}', 
                            '{inventoryId}', '{pricePerLitre}', '{quantity}', '{total}')";
                    Math.Min(cnt, this.Da.ExecuteDMLQuery(sql));

                    // update stock
                    dt = this.Da.ExecuteQueryTable($"SELECT StockQuantity FROM Inventories WHERE InventoryId = '{inventoryId}'");
                    decimal newStockQuantity = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(quantity);
                    sql = $@"UPDATE Inventories 
                            SET StockQuantity = '{newStockQuantity}'
                            WHERE InventoryId = '{inventoryId}'";
                    Math.Min(cnt, this.Da.ExecuteDMLQuery(sql));
                }
                if (cnt > 0)
                {
                    MessageBox.Show("Sale has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ClearAll();
                    new FormSaleDetails(id).Show();
                    isOpen = false;
                }
                else
                {
                    MessageBox.Show("Sale could not be added. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.FrmSls.ClearAll();
            this.FrmSls.Visible = true;
            isOpen = false;
        }
    }
}
