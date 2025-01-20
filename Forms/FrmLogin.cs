namespace Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FrmDashboard(this).Visible = true;
            this.Hide();
        }
    }
}
