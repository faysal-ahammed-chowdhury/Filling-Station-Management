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
    public partial class FormEditExpense : Form
    {
        private DataAccess Da { get; set; }
        private FormExpense FrmExp { get; set; }
        public FormEditExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormEditExpense(string expenseId, FormExpense frmExp) : this()
        {
            this.FrmExp = frmExp;
            this.ShowExpense(expenseId);
        }

        public void ClearAll()
        {
            this.txtAmount.Clear();
            this.txtDescription.Clear();
            this.cboCategory.SelectedIndex = -1;
            this.dtpDate.Text = DateTime.Today.ToString();
            this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ShowExpense(string expenseId)
        {
            try
            {
                string query = $"SELECT * FROM Expenses WHERE ExpenseId = '{expenseId}'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count > 0)
                {
                    // done
                    this.txtExpenseId.Text = dt.Rows[0][0].ToString();
                    this.txtAmount.Text = dt.Rows[0][1].ToString();
                    this.cboCategory.Text = dt.Rows[0][2].ToString();
                    this.txtDescription.Text = dt.Rows[0][4].ToString();
                    DateTime fullDateTime = Convert.ToDateTime(dt.Rows[0]["DateTime"]);
                    this.dtpDate.Text = fullDateTime.ToString("dd-MM-yyyy");
                    this.dtpTime.Text = fullDateTime.ToString("hh:mm tt");
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

        private void bntSave_Click(object sender, EventArgs e)
        {
            string id = this.txtExpenseId.Text;
            string description = this.txtDescription.Text;

            if (this.cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string category = this.cboCategory.SelectedItem.ToString();

            if (description.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill all the fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal amount;
            bool isNumeric = decimal.TryParse(this.txtAmount.Text, out amount);
            if (!isNumeric)
            {
                MessageBox.Show("Amount should be a numerical value", "Huh!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount should be a positive value", "Huh!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = dtpTime.Value.ToString("HH:mm:ss");
            string dateTime = $"{date} {time}";


            try
            {
                string sql = $@"UPDATE Expenses 
                                SET ExpenseId = '{id}',
                                Amount = '{amount}',
                                Category = '{category}',
                                DateTime = '{dateTime}',
                                Description = '{description}'
                                WHERE ExpenseId = '{id}'";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"{id} updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.Visible = false;
                    this.ClearAll();
                    this.FrmExp.ClearAll();
                    this.FrmExp.Visible = true;
                }
                else
                {
                    MessageBox.Show($"{id} did not updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.FrmExp.PopulateGridViewOnAction();
            this.FrmExp.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
