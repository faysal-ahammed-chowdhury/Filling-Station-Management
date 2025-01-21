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
                bool isFound =  Convert.ToBoolean(ds.Tables[0].Rows.Count);
                if (isFound)
                {
                    // will back later
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
    }
}
