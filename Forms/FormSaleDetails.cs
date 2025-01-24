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
    public partial class FormSaleDetails : Form
    {
        private DataAccess Da { get; set; }
        public FormSaleDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormSaleDetails(string saleId) : this()
        {
            string query = $"SELECT * FROM SaleDetails WHERE SaleId = '{saleId}'";
            this.PopulateGridView(query);
            this.ShowInitialInfo(saleId);
        }
        public void PopulateGridView(string query = "SELECT * FROM SaleDetails")
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable(query);
                dt.Columns.Add("InventoryName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT FuelName FROM Inventories WHERE InventoryId = '{row["InventoryId"]}'");
                    string name = "Null";
                    if (dt2.Rows.Count > 0)
                        name = dt2.Rows[0][0].ToString();
                    row["InventoryName"] = name;
                }
                this.dgvSaleDetail.AutoGenerateColumns = false;
                this.dgvSaleDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ShowInitialInfo(string saleId)
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable($"SELECT * FROM Sales WHERE SaleId = '{saleId}'");
                DateTime fullDateTime = Convert.ToDateTime(dt.Rows[0]["SaleDateTime"]);
                string time = fullDateTime.ToString("hh:mm tt") + " " + fullDateTime.ToString("dd-MM-yyyy");
                DataTable dt2 = this.Da.ExecuteQueryTable($"SELECT Name FROM Users WHERE UserId = '{dt.Rows[0]["CreatedBy"]}'");
                string createdBy = dt2.Rows[0][0].ToString();
                string paymentMethod = dt.Rows[0]["PaymentMethod"].ToString();
                decimal grandTotal = Convert.ToDecimal(dt.Rows[0]["GrandTotal"]);
                decimal givemAmount = Convert.ToDecimal(dt.Rows[0]["GivenAmount"]);
                decimal change = Convert.ToDecimal(dt.Rows[0]["Change"]);

                this.lblSaleId.Text = saleId;
                this.lblTime.Text = time;
                this.lblMethod.Text = paymentMethod;
                this.lblSalesBy.Text = createdBy;

                this.lblGrand.Text = grandTotal.ToString("F2") + " TK";
                this.lblGiven.Text = givemAmount.ToString("F2") + " TK";
                this.lblChange.Text = change.ToString("F2") + " TK";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormSaleDetails_Load(object sender, EventArgs e)
        {
            this.dgvSaleDetail.ClearSelection();
        }
    }
}
