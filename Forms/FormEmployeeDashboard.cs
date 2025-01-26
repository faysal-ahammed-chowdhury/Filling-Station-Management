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
    public partial class FormEmployeeDashboard : Form
    {
        private DataAccess Da { get; set; }
        private DataRow currentUser;
        public FormEmployeeDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormEmployeeDashboard(DataRow currentUser) : this()
        {
            this.currentUser = currentUser;
            this.lblWlcName.Text = "Welcome, " + currentUser["Name"];
            this.PopulateGridView();
        }

        public void PopulateGridView()
        {
            try
            {
                // my sales
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                string startDate = today + " 00:00:00";
                string endDate = today + " 23:59:59";
                string query = $@"SELECT * FROM Sales 
                                WHERE CreatedBy = '{this.currentUser["UserId"].ToString()}' AND SaleDateTime BETWEEN '{startDate}' AND '{endDate}'
                                ORDER BY SaleDateTime DESC";
                //MessageBox.Show(query);
                //return;
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("SaleTimeDate", typeof(string));
                decimal totalSale = 0;
                foreach (DataRow row in dt.Rows)
                {
                    DateTime fullDateTime = Convert.ToDateTime(row["SaleDateTime"]);
                    row["SaleTimeDate"] = fullDateTime.ToString("hh:mm tt") + " " + fullDateTime.ToString("dd-MM-yyyy");
                    totalSale += Convert.ToDecimal(row["GrandTotal"]);
                }
                this.dgvMySale.AutoGenerateColumns = false;
                this.dgvMySale.DataSource = dt;
                this.lblAmount.Text = totalSale.ToString("F2") + " TK";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.PopulateGridView();
        }

        private void FormEmployeeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void FormEmployeeDashboard_Load(object sender, EventArgs e)
        {
            this.dgvMySale.ClearSelection();
        }

        private void dgvMySale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // details
            if (e.RowIndex >= 0 && dgvMySale.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvMySale.Columns[e.ColumnIndex].Name == "Details")
            {
                //MessageBox.Show("Details");
                if (this.dgvMySale.SelectedRows.Count > 0)
                {
                    string saleId = this.dgvMySale.CurrentRow.Cells[0].Value.ToString();
                    //this.Visible = false;
                    new FormSaleDetails(saleId).Show();
                }
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            if (FormAddSale.isOpen)
                return;

            new FormAddSale(this.currentUser, this).Show();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (FormAddExpense.isOpen)
                return;

            new FormAddExpense(this.currentUser, this).Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormLogin().Show();
        }
    }
}
