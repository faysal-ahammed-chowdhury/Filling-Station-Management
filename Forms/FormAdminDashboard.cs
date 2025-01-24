using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormAdminDashboard : Form
    {
        private DataAccess Da { get; set; }
        private DataRow currentUser;
        public FormAdminDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public FormAdminDashboard(DataRow currentUser) : this()
        {
            this.currentUser = currentUser;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"];
        }

        public void PopulateGridView()
        {
            try
            {
                // sales
                string query = $"SELECT * FROM Sales";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("SaleTimeDate", typeof(string));
                dt.Columns.Add("CreatedByName", typeof(string));
                decimal totalSale = 0;
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fullDateTime = Convert.ToDateTime(row["SaleDateTime"]);
                    row["SaleTimeDate"] = fullDateTime.ToString("hh:mm tt") + " " + fullDateTime.ToString("dd-MM-yyyy");
                    DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT Name FROM Users WHERE UserId = '{row["CreatedBy"]}'");
                    string name = "null";
                    if (dt2.Rows.Count > 0)
                        name = dt2.Rows[0][0].ToString();
                    row["CreatedByName"] = name;
                    totalSale += Convert.ToDecimal(row["GrandTotal"]);
                }
                this.dgvSale.AutoGenerateColumns = false;
                this.dgvSale.DataSource = dt;
                this.lblSale.Text = totalSale.ToString("F2") + " TK";

                // expenses
                query = $"SELECT * FROM Expenses";
                dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Time", typeof(string));
                dt.Columns.Add("CreatedByName", typeof(string));
                decimal totalExpense = 0;
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fullDateTime = Convert.ToDateTime(row["DateTime"]);
                    row["Date"] = fullDateTime.ToString("dd-MM-yyyy");
                    row["Time"] = fullDateTime.ToString("hh:mm tt");
                    DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT Name FROM Users WHERE UserId = '{row["CreatedBy"]}'");
                    string name = "null";
                    if (dt2.Rows.Count > 0)
                        name = dt2.Rows[0][0].ToString();
                    row["CreatedByName"] = name;
                    totalExpense += Convert.ToDecimal(row["Amount"]);
                }
                this.dgvExpense.AutoGenerateColumns = false;
                this.dgvExpense.DataSource = dt;
                this.lblExpense.Text = totalExpense.ToString("F2") + " TK";
                //MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            this.dgvSale.ClearSelection();
            this.dgvExpense.ClearSelection();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormLogin().Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormInventory(currentUser).Show();
        }

        public void GotoSalesHistory()
        {
            this.Visible = false;
            new FormSales(currentUser).Show();
        }

        public void GotoExpenseHistory()
        {
            this.Visible = false;
            new FormExpense(currentUser).Show();
        }

        private void btnSalesrep_Click(object sender, EventArgs e)
        {
            this.GotoSalesHistory();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            this.GotoSalesHistory();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormUsers(currentUser).Show();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.GotoExpenseHistory();
        }

        private void btnViewExpense_Click(object sender, EventArgs e)
        {
            this.GotoExpenseHistory();
        }

        private void FormAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
