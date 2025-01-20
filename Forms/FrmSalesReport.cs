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
    public partial class FrmSalesReport : Form
    {
        private FrmLogin frmLogin;
        private FrmDashboard FrmDashboard { get; set; }

        private FrmInventory FrmInventory { get; set; }
        public FrmSalesReport()
        {
            InitializeComponent();
        }
        public FrmSalesReport(FrmLogin frmLogin) : this()
        {

            this.frmLogin = frmLogin;
        }
        public FrmSalesReport(FrmDashboard frmDashboard, FrmLogin frmLogin) : this(frmLogin)
        {
            this.FrmDashboard = frmDashboard;

        }
        public FrmSalesReport(FrmInventory frmInventory, FrmLogin frmLogin) : this(frmLogin)
        {
            this.FrmInventory = frmInventory;
        }




        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.frmLogin.Show();
            this.Hide();
        }

       

        private void btnOverView_Click(object sender, EventArgs e)
        {
            new FrmDashboard(this, frmLogin).Show();
            this.Hide();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            new FrmInventory(this, frmLogin).Show();
            this.Hide();
        }
    }
}
