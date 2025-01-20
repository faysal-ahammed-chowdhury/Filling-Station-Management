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
    public partial class FrmInventory : Form
    {
        private FrmDashboard FrmDashboard { get; set; }
        private FrmLogin FrmLogin { get; set; }

        private FrmSalesReport FrmSalesReport { get; set; }


        public FrmInventory()
        {
            InitializeComponent();


        }
        public FrmInventory(FrmLogin frmLogin) : this()
        {

            this.FrmLogin = frmLogin;

        }
        public FrmInventory(FrmSalesReport frmSalesReport, FrmLogin frmLogin) : this(frmLogin)
        {
            this.FrmSalesReport = frmSalesReport;

        }
        public FrmInventory(FrmDashboard frmDashboard, FrmLogin frmLogin) : this(frmLogin)
        {
            this.FrmDashboard = frmDashboard;
        }


        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            new FrmUpdateInventory(this).Visible = true;
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.FrmLogin.Show();
            this.Hide();
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            new FrmDashboard(this, this.FrmLogin).Show();
            this.Hide();
        }

        private void btnSalesrep_Click(object sender, EventArgs e)
        {
            new FrmSalesReport(this,FrmLogin).Visible = true;
            this.Hide();    
        }
    }
}
