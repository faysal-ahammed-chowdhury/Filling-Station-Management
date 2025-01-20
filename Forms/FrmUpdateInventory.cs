﻿using System;
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

    public partial class FrmUpdateInventory : Form
    {


        private FrmInventory inventory;
        public FrmUpdateInventory()
        {
            InitializeComponent();
        }
        public FrmUpdateInventory(FrmInventory fmupdate) : this()
        {
            inventory = fmupdate;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventory.Show();
            this.Hide();
        }
    }
}
