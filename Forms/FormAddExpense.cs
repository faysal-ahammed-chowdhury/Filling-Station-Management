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
        private DataAccess Da { get; set; }
        private string UserId { get; set; }
        private FormExpense FrmExp { get; set; }
        public FormAddExpense()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateId();
        }

        public FormAddExpense(string userId, FormExpense frmExp) : this()
        {
            this.UserId = userId;
            this.FrmExp = frmExp;
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT MAX(ExpenseId) FROM Expenses");
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtExpenseId.Text = $"EXP-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            this.GenerateId();
            this.txtAmount.Clear();
            this.txtDescription.Clear();
            this.chkCurrentTime.Checked = true;
            this.dtpDate.Enabled = false;
            this.dtpTime.Enabled = false;
            this.dtpDate.Text = DateTime.Now.ToString("dd:mm:yy").ToString();
            this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt").ToString();
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
                this.dtpDate.Text = DateTime.Now.ToString("dd:mm:yy").ToString();
                this.dtpTime.Text = DateTime.Now.ToString("hh:mm:ss tt").ToString();
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
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

            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (!this.chkCurrentTime.Checked)
            {
                string date = dtpDate.Value.ToString("yyyy-MM-dd");
                string time = dtpTime.Value.ToString("HH:mm:ss");
                dateTime = $"{date} {time}";
            }


            try
            {
                string sql = $"INSERT INTO Expenses VALUES ('{id}', '{amount}', '{category}', '{dateTime}', '{description}', '{this.UserId}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"{id} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.Visible = false;
                    this.ClearAll();
                    this.FrmExp.ClearAll();
                    this.FrmExp.Visible = true;
                }
                else
                {
                    MessageBox.Show($"{id} did not added", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
