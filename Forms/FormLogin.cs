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
                MessageBox.Show("Please fill the Phone and Password fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string query = $"SELECT * FROM Users WHERE Phone = '{phone}' and Password = '{pass}'";
                DataSet ds = this.Da.ExecuteQuery(query);
                bool isFound = Convert.ToBoolean(ds.Tables[0].Rows.Count);
                if (isFound)
                {
                    // will back later
                    if (ds.Tables[0].Rows[0]["Role"].ToString() == "Admin")
                    {
                        this.Visible = false;
                        new FormAdminDashboard(ds.Tables[0].Rows[0]).Show();
                    }
                    else if (ds.Tables[0].Rows[0]["Role"].ToString() == "Employee")
                    {
                        this.Visible = false;
                        //new FormEmpDashboard(ds.Tables[0].Rows[0]).Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User. Neither Admin nor Employee", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("User not found, Please contact an Admin", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
