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
    public partial class FrmInventoryAdd : Form
    {
        FrmInventory FrmInventory { get; set; }

        public FrmInventoryAdd()
        {
            InitializeComponent();
        }


        public FrmInventoryAdd(FrmInventory fminventory) : this()
        {
            FrmInventory = fminventory;
        }

        private void InventoryAdd_Load(object sender, EventArgs e)
        {
            FrmInventory.Visible = true;
            this.Visible = false;
        }

       
    }
}
