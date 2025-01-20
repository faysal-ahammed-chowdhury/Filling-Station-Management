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
    public partial class FrmUserList : Form
    {
        private FrmDashboard FrmDashboard { get; set; }
        public FrmUserList()
        {
            InitializeComponent();
        }

        public FrmUserList(FrmDashboard frmDeshboard) : this()
        {
            FrmDashboard = frmDeshboard;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDashboard.Show();
            this.Hide();
        }

        
    }
}
