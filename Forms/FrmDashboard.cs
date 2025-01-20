using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmDashboard : Form
    {
        private FrmLogin frmLogin;
        private FrmSalesReport FrmSalesReport {  get; set; }
        private FrmInventory FrmInventory { get; set; }
        public FrmDashboard()
        {
            InitializeComponent();
            
        }

        public FrmDashboard(FrmLogin frmLogin) : this()
        {
            this.frmLogin = frmLogin;
        }

        public FrmDashboard(FrmInventory frmInventory,FrmLogin frmLogin):this(frmLogin)
        {
            FrmInventory= frmInventory;
        }

        public FrmDashboard(FrmSalesReport frmSalesReport, FrmLogin frmLogin) : this(frmLogin)
        {
            FrmSalesReport= frmSalesReport;
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin.Visible = true;
            this.Visible = false;
        }
        
        

        private void btnInventory_Click(object sender, EventArgs e)
        {
            new FrmInventory(this,frmLogin).Show();
            this.Hide();
        }

        private void btnSalesrep_Click(object sender, EventArgs e)
        {
            new FrmSalesReport(this,frmLogin).Visible = true;
            this.Visible = false;
        }

        private void btnEmpolyeeList_Click(object sender, EventArgs e)
        {
            new FrmUserList(this).Show();
            this.Hide();
        }
    }
}
