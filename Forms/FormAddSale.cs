﻿using Microsoft.IdentityModel.Tokens;
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
        private FormEmployeeDashboard frmEmpDashboard { get; set; }
        private string who;
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
            this.who = "Admin";
        }

        public FormAddSale(DataRow currentUser, FormEmployeeDashboard frmEmpDashboard) : this()
        {
            this.currentUser = currentUser;
            this.frmEmpDashboard = frmEmpDashboard;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"].ToString();
            this.who = "Employee";
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(SaleId) FROM Sales");
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.lblSaleId.Text = "SALE-001";
                    return;
                }
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

        public bool IsValidToAddCart()
        {
            string productName = this.dgvInventory.CurrentRow.Cells[1].Value.ToString();
            decimal avaiableQuantity = Convert.ToDecimal(this.dgvInventory.CurrentRow.Cells[3].Value.ToString());
            string selectedQuantityStr = "";
            if (this.dgvInventory.CurrentRow.Cells[4].Value != null)
                selectedQuantityStr = this.dgvInventory.CurrentRow.Cells[4].Value.ToString();
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
                    return false;
                }
            }

            if (avaiableQuantity < addedQuantity)
            {
                MessageBox.Show($"Not enough {productName} in stock.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (addedQuantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
                        if (!this.IsValidToAddCart())
                            return;


                        string inventoryId = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                        string productName = this.dgvInventory.CurrentRow.Cells[1].Value.ToString();
                        decimal productPrice = Convert.ToDecimal(this.dgvInventory.CurrentRow.Cells[2].Value.ToString());
                        decimal avaiableQuantity = Convert.ToDecimal(this.dgvInventory.CurrentRow.Cells[3].Value.ToString());
                        string selectedQuantityStr = "";
                        if (this.dgvInventory.CurrentRow.Cells[4].Value != null)
                            selectedQuantityStr = this.dgvInventory.CurrentRow.Cells[4].Value.ToString();
                        decimal addedQuantity = 0;
                        if (selectedQuantityStr.IsNullOrEmpty())
                        {
                            this.dgvInventory.CurrentRow.Cells[4].Value = "1";
                            addedQuantity = 1;
                        }
                        else
                        {
                            addedQuantity = Convert.ToDecimal(selectedQuantityStr);
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
                            this.addedProductsTable.Rows.Add(inventoryId, productName, productPrice, addedQuantity, productTotal);
                        }

                        this.dgvAddedProducts.AutoGenerateColumns = false;
                        this.dgvAddedProducts.DataSource = this.addedProductsTable;
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
                            this.addedProductsTable.Rows.Remove(row);
                            isDeleted = true;
                            break;
                        }
                    }

                    if (!isDeleted)
                        return;

                    this.dgvAddedProducts.AutoGenerateColumns = false;
                    this.dgvAddedProducts.DataSource = this.addedProductsTable;
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

        public bool IsValid()
        {
            if (this.addedProductsTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add items to the cart before confirming the sale.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal givenAmount, changeAmount;
            bool isNumeric = decimal.TryParse(this.txtGiven.Text, out givenAmount);
            isNumeric &= decimal.TryParse(this.txtChange.Text, out changeAmount);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (givenAmount < grandTotal)
            {
                MessageBox.Show("The given amount should be greater than or equal to the Grand Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (givenAmount < 0 || changeAmount < 0)
            {
                MessageBox.Show("Amount must be a positive value.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool methodChecked = this.chkCash.Checked || this.chkBkash.Checked;

            if (!methodChecked)
            {
                MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public int InsertIntoSaleDetails(DataRow sale)
        {
            DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(SaleDetailId) FROM SaleDetails");
            string[] temp = dt.Rows[0][0].ToString().Split("-");
            string saleDetailId = $"SD-{(Convert.ToInt32(temp[1]) + 1).ToString("D3")}";
            string inventoryId = sale["CInventoryId"].ToString();
            string pricePerLitre = sale["CPricePerLitre"].ToString();
            string quantity = sale["CQuantity"].ToString();
            string total = sale["CTotal"].ToString();

            string sql = $@"INSERT INTO SaleDetails VALUES ('{saleDetailId}', '{this.lblSaleId.Text}', 
                            '{inventoryId}', '{pricePerLitre}', '{quantity}', '{total}')";
            return this.Da.ExecuteDMLQuery(sql);
        }

        public int UpdateStock(DataRow sale)
        {
            string inventoryId = sale["CInventoryId"].ToString();
            string pricePerLitre = sale["CPricePerLitre"].ToString();
            string quantity = sale["CQuantity"].ToString();
            string total = sale["CTotal"].ToString();

            DataTable dt = this.Da.ExecuteQueryTable($"SELECT StockQuantity FROM Inventories WHERE InventoryId = '{inventoryId}'");
            decimal newStockQuantity = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(quantity);
            string sql = $@"UPDATE Inventories 
                            SET StockQuantity = '{newStockQuantity}'
                            WHERE InventoryId = '{inventoryId}'";
            return this.Da.ExecuteDMLQuery(sql);
        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to confirm the sale?", "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            // validation done, now insert into db and rest
            string id = this.lblSaleId.Text;
            string saleDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            decimal givenAmount = Convert.ToDecimal(this.txtGiven.Text);
            decimal changeAmount = Convert.ToDecimal(this.txtChange.Text);
            string method = "";
            if (this.chkCash.Checked)
                method = "Cash";
            else if (this.chkBkash.Checked)
                method = "Bkash";

            try
            {

                // insert into sales 
                string sql = $@"INSERT INTO Sales VALUES ('{id}', '{saleDateTime}', '{currentUser["UserId"].ToString()}',
                            '{grandTotal.ToString()}', '{givenAmount.ToString()}', 
                            '{changeAmount.ToString()}', '{method}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                foreach (DataRow row in this.addedProductsTable.Rows)
                {
                    // insert into sale details
                    cnt = Math.Min(cnt, this.InsertIntoSaleDetails(row));
                    // update stock
                    cnt = Math.Min(cnt, this.UpdateStock(row));
                }
                if (cnt > 0)
                {
                    MessageBox.Show("Sale has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ClearAll();
                    this.Visible = false;
                    new FormSaleDetails(id).Show();
                    if (this.who == "Admin")
                        this.FrmSls.ClearAll();
                    else if (this.who == "Employee")
                        this.frmEmpDashboard.ClearAll();
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
            isOpen = false;
            if (this.who == "Admin")
            {
                this.FrmSls.ClearAll();
                this.FrmSls.Visible = true;
            }
            else if (this.who == "Employee")
            {
                this.frmEmpDashboard.ClearAll();
                this.frmEmpDashboard.Visible = true;
            }
        }
    }
}
