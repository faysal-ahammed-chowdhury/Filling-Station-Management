using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Forms
{
    public partial class FormSales : Form
    {
        private DataAccess Da { get; set; }
        public FormSales()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ShowInitialInfo();
            this.PopulateGridView();
            this.dtpStartDate.Text = (new DateTime(2015, 1, 1)).ToString();
            this.dtpEndDate.Text = DateTime.Now.ToString();
        }

        public void PopulateGridView(string query = "SELECT * FROM Sales")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("SaleTimeDate", typeof(string));
                dt.Columns.Add("CreatedByName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fullDateTime = Convert.ToDateTime(row["SaleDateTime"]);
                    row["SaleTimeDate"] = fullDateTime.ToString("hh:mm tt") + " " + fullDateTime.ToString("dd-MM-yyyy");
                    DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT Name FROM Users WHERE UserId = '{row["CreatedBy"]}'");
                    string name = "null";
                    if (dt2.Rows.Count > 0)
                        name = dt2.Rows[0][0].ToString();
                    row["CreatedByName"] = name;
                }
                this.dgvSale.AutoGenerateColumns = false;
                this.dgvSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PopulateGridViewOnAction()
        {
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
            string part = "";
            if (!this.txtSearch.Text.IsNullOrEmpty())
            {
                part = $"SaleId LIKE '%{this.txtSearch.Text}%' AND ";
            }
            string query = $"SELECT * FROM Sales WHERE {part} SaleDateTime BETWEEN '{startDate}' AND '{endDate}';";
            this.PopulateGridView(query);
        }

        public void ClearAll()
        {
            this.dtpStartDate.Text = (new DateTime(2015, 1, 1)).ToString();
            this.dtpEndDate.Text = DateTime.Now.ToString();
            this.txtSearch.Clear();
            this.ShowInitialInfo();
            this.PopulateGridView();
        }

        public DataTable GetSales(string startDate, string endDate)
        {
            string query = $"SELECT * FROM Sales WHERE SaleDateTime BETWEEN '{startDate}' AND '{endDate}';";
            return this.Da.ExecuteQueryTable(query);
        }

        public DataTable GetTodaysSales()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate = today + " 00:00:00";
            string endDate = today + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetSales(startDate, endDate);
        }

        public DataTable GetThisWeeksSales()
        {
            DateTime today = DateTime.Now;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek - 1);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            string startDate = startOfWeek.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfWeek.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetSales(startDate, endDate);
        }

        public DataTable GetThisMonthsSales()
        {
            DateTime today = DateTime.Now;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            string startDate = startOfMonth.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfMonth.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetSales(startDate, endDate);
        }

        public DataTable GetThisYearsSales()
        {
            DateTime today = DateTime.Now;
            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            DateTime endOfYear = new DateTime(today.Year, 12, 31);
            string startDate = startOfYear.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfYear.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetSales(startDate, endDate);
        }

        public void ShowInitialInfo()
        {
            try
            {
                // today
                DataTable dt = this.GetTodaysSales();
                decimal tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["GrandTotal"]);
                this.lblThisDay.Text = $"{tot.ToString("F2")} TK";

                // this week
                dt = this.GetThisWeeksSales();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["GrandTotal"]);
                this.lblThisWeeK.Text = $"{tot.ToString("F2")} TK";

                // this month
                dt = this.GetThisMonthsSales();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["GrandTotal"]);
                this.lblThisMonth.Text = $"{tot.ToString("F2")} TK";

                // between selected dates
                string startDate = this.dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
                string endDate = this.dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
                dt = this.GetSales(startDate, endDate);
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr["GrandTotal"]);
                this.lblBetweenDates.Text = $"{tot.ToString("F2")} TK";
                this.lblStartDate.Text = this.dtpStartDate.Value.ToString("dd-MM-yyyy");
                this.lblEndDate.Text = this.dtpEndDate.Value.ToString("dd-MM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeleteSale(string saleId)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + saleId + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // update stock first
                Dictionary<string, decimal> currentStock = new Dictionary<string, decimal>(); // id->stockquantity
                string query = $"SELECT * FROM Inventories";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                foreach (DataRow dr in dt.Rows)
                {
                    currentStock[dr["InventoryId"].ToString()] = Convert.ToDecimal(dr["StockQuantity"]);
                }

                query = $"SELECT * FROM SaleDetails WHERE SaleId = '{saleId}'";
                DataTable dt2 = this.Da.ExecuteQueryTable(query);
                foreach (DataRow dr in dt2.Rows)
                {
                    if (currentStock.ContainsKey(dr["InventoryId"].ToString()))
                    {
                        currentStock[dr["InventoryId"].ToString()] += Convert.ToDecimal(dr["Quantity"]);
                    }
                }

                int cnt = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    string sqll = $@"UPDATE Inventories
                                SET StockQuantity = '{currentStock[dr["InventoryId"].ToString()]}'
                                WHERE InventoryId = '{dr["InventoryId"].ToString()}'";
                    cnt = Math.Min(cnt, this.Da.ExecuteDMLQuery(sqll));
                    if (cnt == 0)
                    {
                        MessageBox.Show($"{saleId} has not been removed properly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string sql = $"DELETE FROM Sales WHERE SaleId = '{saleId}'";
                cnt = Math.Min(cnt, this.Da.ExecuteDMLQuery(sql));
                sql = $"DELETE FROM SaleDetails WHERE SaleId = '{saleId}'";
                cnt = Math.Min(cnt, this.Da.ExecuteDMLQuery(sql));
                if (cnt == 1)
                {
                    MessageBox.Show($"{saleId} has been removed properly", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"{saleId} has not been removed properly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.ShowInitialInfo();
            this.PopulateGridViewOnAction();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.ShowInitialInfo();
            this.PopulateGridViewOnAction();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            this.dgvSale.ClearSelection();
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // details
            if (e.RowIndex >= 0 && dgvSale.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvSale.Columns[e.ColumnIndex].Name == "Details")
            {
                //MessageBox.Show("Details");
                if (this.dgvSale.SelectedRows.Count > 0)
                {
                    string saleId = this.dgvSale.CurrentRow.Cells[0].Value.ToString();
                    //this.Visible = false;
                    new FormSaleDetails(saleId).Show();
                }
            }

            // delete
            if (e.RowIndex >= 0 && dgvSale.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvSale.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                //MessageBox.Show("Delete");
                if (this.dgvSale.SelectedRows.Count > 0)
                {
                    string saleId = this.dgvSale.CurrentRow.Cells[0].Value.ToString();
                    this.DeleteSale(saleId);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new FormAddSale(this).Show();
        }
    }
}
