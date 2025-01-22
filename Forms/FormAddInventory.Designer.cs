namespace Forms
{
    partial class FormAddInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblUserName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            btnClear = new Button();
            btnCancel = new Button();
            txtStockQuantity = new TextBox();
            asrer = new Label();
            txtPricePerLitre = new TextBox();
            sd = new Label();
            txtFuelName = new TextBox();
            label5 = new Label();
            txtInventoryId = new TextBox();
            label4 = new Label();
            bntAdd = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(206, 29);
            label3.TabIndex = 0;
            label3.Text = "Welcome, Faysal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(120, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 56);
            panel1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(587, 18);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 1;
            label2.Text = "Change Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = Color.Navy;
            lblUserName.Location = new Point(546, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(68, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(361, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Dashboard\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(239, -116);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 56);
            panel2.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(btnClear);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(txtStockQuantity);
            panel6.Controls.Add(asrer);
            panel6.Controls.Add(txtPricePerLitre);
            panel6.Controls.Add(sd);
            panel6.Controls.Add(txtFuelName);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtInventoryId);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(bntAdd);
            panel6.Location = new Point(120, 81);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 533);
            panel6.TabIndex = 29;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(434, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 42);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 50, 49);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(300, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.BackColor = SystemColors.ScrollBar;
            txtStockQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQuantity.Location = new Point(398, 227);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(287, 29);
            txtStockQuantity.TabIndex = 8;
            // 
            // asrer
            // 
            asrer.AutoSize = true;
            asrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asrer.Location = new Point(396, 198);
            asrer.Name = "asrer";
            asrer.Size = new Size(114, 21);
            asrer.TabIndex = 7;
            asrer.Text = "Stock Quantity:";
            // 
            // txtPricePerLitre
            // 
            txtPricePerLitre.BackColor = SystemColors.ScrollBar;
            txtPricePerLitre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPricePerLitre.Location = new Point(31, 227);
            txtPricePerLitre.Name = "txtPricePerLitre";
            txtPricePerLitre.Size = new Size(287, 29);
            txtPricePerLitre.TabIndex = 6;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd.Location = new Point(29, 198);
            sd.Name = "sd";
            sd.Size = new Size(105, 21);
            sd.TabIndex = 5;
            sd.Text = "Price Per Litre";
            // 
            // txtFuelName
            // 
            txtFuelName.BackColor = SystemColors.ScrollBar;
            txtFuelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuelName.Location = new Point(398, 146);
            txtFuelName.Name = "txtFuelName";
            txtFuelName.Size = new Size(287, 29);
            txtFuelName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 117);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 3;
            label5.Text = "Fuel Name:";
            // 
            // txtInventoryId
            // 
            txtInventoryId.BackColor = SystemColors.ScrollBar;
            txtInventoryId.Enabled = false;
            txtInventoryId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventoryId.Location = new Point(31, 146);
            txtInventoryId.Name = "txtInventoryId";
            txtInventoryId.ReadOnly = true;
            txtInventoryId.Size = new Size(287, 29);
            txtInventoryId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 117);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 1;
            label4.Text = "Inventory ID:";
            // 
            // bntAdd
            // 
            bntAdd.BackColor = Color.FromArgb(49, 108, 181);
            bntAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAdd.ForeColor = Color.White;
            bntAdd.Location = new Point(170, 350);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(114, 42);
            bntAdd.TabIndex = 0;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += btnAdd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 18);
            label8.Name = "label8";
            label8.Size = new Size(347, 45);
            label8.TabIndex = 18;
            label8.Text = "Create New Inventory";
            // 
            // FormAddInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 616);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label lblUserName;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private TextBox txtInventoryId;
        private Label label4;
        private Button bntAdd;
        private TextBox txtStockQuantity;
        private Label asrer;
        private TextBox txtPricePerLitre;
        private Label sd;
        private TextBox txtFuelName;
        private Label label5;
        private Button btnClear;
        private Button btnCancel;
        private Label label8;
    }
}