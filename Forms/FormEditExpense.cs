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
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormExpense FrmExp { get; set; }
        public FormEditExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            isOpen = true;
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsValid()
        {
            string description = this.txtDescription.Text;
            if (this.cboCategory.SelectedIndex == -1 || description.IsNullOrEmpty())
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal amount;
            bool isNumeric = decimal.TryParse(this.txtAmount.Text, out amount);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be a positive value.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (description.Length > 100)
            {
                MessageBox.Show("Description cannot exceed 100 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            string id = this.txtExpenseId.Text;
            string description = this.txtDescription.Text;
            decimal amount = Convert.ToDecimal(this.txtAmount.Text);
            string category = this.cboCategory.SelectedItem.ToString();
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
                    MessageBox.Show($"Expense ID {id} has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    this.ClearAll();
                    this.FrmExp.ClearAll();
                    this.FrmExp.Visible = true;
                    isOpen = false;
                }
                else
                    MessageBox.Show($"Failed to update Expense ID {id}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.FrmExp.PopulateGridViewOnAction();
            this.FrmExp.Visible = true;
            isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
