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
    public partial class FormUsers : Form
    {
        private DataAccess Da { get; set; }
        public FormUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.cboUserType.SelectedIndex = 0;
            this.ShowInitialInfo();
        }

        public void PopulateGridView(string query = "SELECT * FROM Users")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(query);
                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PopulateGridViewOnAction()
        {
            string part = "";
            if (!this.txtSearch.Text.IsNullOrEmpty())
                part = $"WHERE Name LIKE '%{this.txtSearch.Text}%'";
            if (!this.txtSearch.Text.IsNullOrEmpty() && this.cboUserType.SelectedIndex != 0)
                part += " AND ";
            if (this.cboUserType.SelectedIndex != 0 && this.txtSearch.Text.IsNullOrEmpty())
                part = "WHERE ";
            if (this.cboUserType.SelectedIndex != 0)
                part += $"Role = '{this.cboUserType.SelectedItem.ToString()}'";
            string query = $"SELECT * FROM Users {part}";
            this.PopulateGridView(query);
        }

        public void ShowInitialInfo()
        {
            try
            {
                DataTable dt = this.Da.ExecuteQueryTable("SELECT * FROM Users");
                int adminCnt = 0, empCnt = 0;
                foreach (DataRow dr in dt.Rows) {
                    if (dr["Role"].ToString() == "Admin") adminCnt++;
                    else if (dr["Role"].ToString() == "Employee") empCnt++;
                }
                //MessageBox.Show(adminCnt.ToString() + " " + empCnt.ToString());
                this.lblTotal.Text = (adminCnt + empCnt).ToString();
                this.lblAdmin.Text = adminCnt.ToString("D2");
                this.lblEmp.Text = empCnt.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            this.txtSearch.Clear();
            this.cboUserType.SelectedIndex = 0;
            this.PopulateGridView();
            this.ShowInitialInfo();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            this.dgvUser.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewOnAction();
        }
    }
}
