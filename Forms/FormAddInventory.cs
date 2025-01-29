using Microsoft.IdentityModel.Tokens;
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
    public partial class FormAddInventory : Form
    {
        public static bool isOpen = false;
        private DataAccess Da { get; set; }
        private FormInventory FrmInv { get; set; }
        public FormAddInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GenerateId();
            isOpen = true;
        }
        public FormAddInventory(FormInventory FrmInv) : this()
        {
            this.FrmInv = FrmInv;
        }

        public void GenerateId()
        {
            try
            {
                DataTable dt =  this.Da.ExecuteQueryTable("SELECT MAX(InventoryId) FROM Inventories");
                if (dt.Rows[0][0].ToString().IsNullOrEmpty())
                {
                    this.txtInventoryId.Text = "INV-001";
                    return;
                }
                string[] temp = dt.Rows[0][0].ToString().Split("-");
                int id = Convert.ToInt32(temp[1]) + 1;
                this.txtInventoryId.Text = $"INV-{id.ToString("D3")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            this.GenerateId();
            this.txtFuelName.Clear();
            this.txtPricePerLitre.Clear();
            this.txtStockQuantity.Clear();
        }

        public bool IsValid()
        {
            string id = this.txtInventoryId.Text;
            string fuelName = this.txtFuelName.Text;

            if (id.IsNullOrEmpty() || fuelName.IsNullOrEmpty())
            {
                MessageBox.Show("All fields are required. Please complete them.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal pricePerLitre;
            bool isNumeric = decimal.TryParse(this.txtPricePerLitre.Text, out pricePerLitre);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid numerical price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            decimal stockQuantity;
            isNumeric = decimal.TryParse(this.txtStockQuantity.Text, out stockQuantity);
            if (!isNumeric)
            {
                MessageBox.Show("Stock quantity must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (pricePerLitre <= 0)
            {
                MessageBox.Show("Price must be a positive value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (stockQuantity < 0)
            {
                MessageBox.Show("Stock quantity must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fuelName.Length > 20)
            {
                MessageBox.Show("Fuel Name cannot exceed 20 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
                return;

            try
            {
                string id = this.txtInventoryId.Text;
                string fuelName = this.txtFuelName.Text;
                decimal pricePerLitre = Convert.ToDecimal(this.txtPricePerLitre.Text);
                decimal stockQuantity = Convert.ToDecimal(this.txtStockQuantity.Text);

                string sql = $"INSERT INTO Inventories VALUES ('{id}', '{fuelName}', '{stockQuantity}', '{pricePerLitre}')";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt > 0)
                {
                    MessageBox.Show($"{fuelName} has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    this.ClearAll();
                    this.FrmInv.ClearAll();
                    this.FrmInv.Visible = true;
                    isOpen = false;
                }
                else
                {
                    MessageBox.Show($"{fuelName} could not be added. Please try again.", "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.Visible = false;
            this.FrmInv.PopulateGridViewOnAction();
            this.FrmInv.Visible = true;
            isOpen = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
