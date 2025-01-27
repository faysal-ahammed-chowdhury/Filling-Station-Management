using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Forms
{
    public partial class FormLogin : Form
    {

        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phone = this.txtPhone.Text;
            string pass = this.txtPassword.Text;

            if (phone.IsNullOrEmpty() || pass.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in both the Phone and Password fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = $"SELECT * FROM Users WHERE Phone = '{phone}' and Password = '{pass}'";
                DataSet ds = this.Da.ExecuteQuery(query);
                bool isFound = Convert.ToBoolean(ds.Tables[0].Rows.Count);
                if (isFound)
                {
                    if (ds.Tables[0].Rows[0]["Role"].ToString() == "Admin")
                    {
                        this.Visible = false;
                        new FormAdminDashboard(ds.Tables[0].Rows[0]).Show();
                    }
                    else if (ds.Tables[0].Rows[0]["Role"].ToString() == "Employee")
                    {
                        this.Visible = false;
                        new FormEmployeeDashboard(ds.Tables[0].Rows[0]).Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user. Please ensure the credentials match either Admin or Employee.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("User not found. Please contact an Admin for assistance.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkShowPass.Checked)
                this.txtPassword.UseSystemPasswordChar = false;
            else
                this.txtPassword.UseSystemPasswordChar = true;
        }
    }
}
