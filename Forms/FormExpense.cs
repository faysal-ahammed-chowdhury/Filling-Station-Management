using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Forms
{
    public partial class FormExpense : Form
    {
        private DataAccess Da { get; set; }
        public FormExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ShowInitialInfo();
            this.PopulateGridView();
        }

        public void PopulateGridView(string query = "SELECT * FROM Expenses")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Time", typeof(string));
                dt.Columns.Add("CreatedByName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fullDateTime = Convert.ToDateTime(row["DateTime"]);
                    row["Date"] = fullDateTime.ToString("dd-MM-yyyy");
                    row["Time"] = fullDateTime.ToString("hh:mm tt");
                    DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT Name FROM Users WHERE UserId = '{row["CreatedBy"]}'");
                    string name = dt2.Rows[0][0].ToString();
                    row["CreatedByName"] = name;
                }
                this.dgvExpense.AutoGenerateColumns = false;
                this.dgvExpense.DataSource = dt;
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
                part = $"Category LIKE '%{this.txtSearch.Text}%' AND ";
            }
            string query = $"SELECT * FROM Expenses WHERE {part} DateTime BETWEEN '{startDate}' AND '{endDate}';";
            this.PopulateGridView(query);
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.ShowInitialInfo();
            this.PopulateGridView();
        }

        public DataTable GetExpenses(string startDate, string endDate)
        {
            string query = $"SELECT * FROM Expenses WHERE DateTime BETWEEN '{startDate}' AND '{endDate}';";
            return this.Da.ExecuteQueryTable(query);
        }

        public DataTable GetTodaysExpenses()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate = today + " 00:00:00";
            string endDate = today + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetExpenses(startDate, endDate);
        }

        public DataTable GetThisWeeksExpenses()
        {
            DateTime today = DateTime.Now;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek - 1);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            string startDate = startOfWeek.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfWeek.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetExpenses(startDate, endDate);
        }

        public DataTable GetThisMonthsExpenses()
        {
            DateTime today = DateTime.Now;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            string startDate = startOfMonth.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfMonth.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetExpenses(startDate, endDate);
        }

        public DataTable GetThisYearsExpenses()
        {
            DateTime today = DateTime.Now;
            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            DateTime endOfYear = new DateTime(today.Year, 12, 31);
            string startDate = startOfYear.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = endOfYear.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(startDate + " " + endDate);
            return GetExpenses(startDate, endDate);
        }


        public void ShowInitialInfo()
        {
            this.dtpStartDate.Text = (new DateTime(2015, 1, 1)).ToString();
            this.dtpEndDate.Text = DateTime.Now.ToString();

            try
            {
                // today
                DataTable dt = this.GetTodaysExpenses();
                decimal tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr[1]);
                this.lblThisDay.Text = $"{tot.ToString("F2")} TK";

                // this week
                dt = this.GetThisWeeksExpenses();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr[1]);
                this.lblThisWeeK.Text = $"{tot.ToString("F2")} TK";

                // this month
                dt = this.GetThisMonthsExpenses();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr[1]);
                this.lblThisMonth.Text = $"{tot.ToString("F2")} TK";

                // this year
                dt = this.GetThisYearsExpenses();
                tot = 0;
                foreach (DataRow dr in dt.Rows)
                    tot += Convert.ToDecimal(dr[1]);
                this.lblThisYear.Text = $"{tot.ToString("F2")} TK";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.RowIndex >= 0 && dgvExpense.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvExpense.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // edit operations
                MessageBox.Show("Edit Form");
                //if (this.dgvInventory.SelectedRows.Count > 0)
                //{
                //    string inventoryId = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                //    this.Visible = false;
                //    new FormEditInventory(inventoryId, this).Show();
                //}
            }

            // delete
            if (e.RowIndex >= 0 && dgvExpense.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvExpense.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // delete operations
                MessageBox.Show(this.dgvExpense.CurrentRow.Cells[0].Value.ToString());
                //if (this.dgvExpense.SelectedRows.Count > 0)
                //{
                //    string inventoryId = this.dgvExpense.CurrentRow.Cells[0].Value.ToString();
                //    this.DeleteInventory(inventoryId);
                //}
            }
        }

        private void FormExpense_Load(object sender, EventArgs e)
        {
            this.dgvExpense.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormAddExpense("U-001", this).Show(); // change here later
        }
    }
}
