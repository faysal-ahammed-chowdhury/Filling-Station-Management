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
    public partial class FormAddExpense : Form
    {
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormExpense FrmExp { get; set; }
        private FormEmployeeDashboard frmEmpDashboard { get; set; }
        private DataRow currentUser;
        private string who;
        public FormAddExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateId();
            this.dtpDate.MaxDate = DateTime.Today;
            this.dtpTime.MaxDate = DateTime.Now;
            isOpen = true;
        }

        public FormAddExpense(DataRow currentUser, FormExpense frmExp) : this()
        {
            this.currentUser = currentUser;
            this.FrmExp = frmExp;
            this.who = "Admin";
        }

        public FormAddExpense(DataRow currentUser, FormEmployeeDashboard frmEmpDashboard) : this()
        {
            this.currentUser = currentUser;
            this.frmEmpDashboard = frmEmpDashboard;
            this.who = "Employee";
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(ExpenseId) FROM Expenses");
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.txtExpenseId.Text = "EXP-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtExpenseId.Text = $"EXP-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.GenerateId();
            this.txtAmount.Clear();
            this.cboCategory.SelectedIndex = -1;
            this.txtDescription.Clear();
            this.chkCurrentTime.Checked = true;
            this.dtpDate.Enabled = false;
            this.dtpTime.Enabled = false;
            this.dtpDate.MaxDate = DateTime.Today;
            this.dtpTime.MaxDate = DateTime.Now;
            this.dtpDate.Text = DateTime.Today.ToString();
            this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void chkCurrentTime_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCurrentTime.Checked == true)
            {
                this.dtpDate.Enabled = false;
                this.dtpTime.Enabled = false;
            }
            else
            {
                this.dtpDate.Enabled = true;
                this.dtpTime.Enabled = true;
                this.dtpDate.MaxDate = DateTime.Today;
                this.dtpTime.MaxDate = DateTime.Now;
                this.dtpDate.Text = DateTime.Today.ToString();
                this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
        }

        public bool IsValid()
        {
            string id = this.txtExpenseId.Text;
            string description = this.txtDescription.Text;

            if (this.cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category to proceed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string category = this.cboCategory.SelectedItem.ToString();

            if (description.IsNullOrEmpty())
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

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            try
            {
                string id = this.txtExpenseId.Text;
                string description = this.txtDescription.Text;
                string category = this.cboCategory.SelectedItem.ToString();
                decimal amount = Convert.ToDecimal(this.txtAmount.Text);
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (!this.chkCurrentTime.Checked)
                {
                    string date = dtpDate.Value.ToString("yyyy-MM-dd");
                    string time = dtpTime.Value.ToString("HH:mm:ss");
                    dateTime = $"{date} {time}";
                }

                string sql = $"INSERT INTO Expenses VALUES ('{id}', '{amount}', '{category}', '{dateTime}', '{description}', '{currentUser["UserId"].ToString()}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"Expense #{id} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    this.ClearAll();
                    isOpen = false;
                    if (this.who == "Admin")
                    {
                        this.FrmExp.PopulateGridViewOnAction();
                        this.FrmExp.Visible = true;
                    }
                    else if (this.who == "Employee")
                    {
                        this.frmEmpDashboard.ClearAll();
                        this.frmEmpDashboard.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to add Expense #{id}. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (this.who == "Admin")
            {
                this.FrmExp.PopulateGridViewOnAction();
                this.FrmExp.Visible = true;
            }
            else if (this.who == "Employee")
            {
                this.frmEmpDashboard.ClearAll();
                this.frmEmpDashboard.Visible = true;
            }
            isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
