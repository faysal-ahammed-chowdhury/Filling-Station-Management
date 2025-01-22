namespace Forms
{
    partial class FormEditInventory
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
            panel6 = new Panel();
            label8 = new Label();
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
            bntSave = new Button();
            lblUserName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel6.Controls.Add(bntSave);
            panel6.Location = new Point(118, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 533);
            panel6.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 30);
            label8.Name = "label8";
            label8.Size = new Size(232, 45);
            label8.TabIndex = 36;
            label8.Text = "Edit Inventory";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(434, 345);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 42);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 50, 49);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(300, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.BackColor = SystemColors.ScrollBar;
            txtStockQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQuantity.Location = new Point(403, 236);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(287, 29);
            txtStockQuantity.TabIndex = 8;
            // 
            // asrer
            // 
            asrer.AutoSize = true;
            asrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asrer.Location = new Point(401, 207);
            asrer.Name = "asrer";
            asrer.Size = new Size(114, 21);
            asrer.TabIndex = 7;
            asrer.Text = "Stock Quantity:";
            // 
            // txtPricePerLitre
            // 
            txtPricePerLitre.BackColor = SystemColors.ScrollBar;
            txtPricePerLitre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPricePerLitre.Location = new Point(36, 236);
            txtPricePerLitre.Name = "txtPricePerLitre";
            txtPricePerLitre.Size = new Size(287, 29);
            txtPricePerLitre.TabIndex = 6;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd.Location = new Point(34, 207);
            sd.Name = "sd";
            sd.Size = new Size(105, 21);
            sd.TabIndex = 5;
            sd.Text = "Price Per Litre";
            // 
            // txtFuelName
            // 
            txtFuelName.BackColor = SystemColors.ScrollBar;
            txtFuelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuelName.Location = new Point(403, 155);
            txtFuelName.Name = "txtFuelName";
            txtFuelName.Size = new Size(287, 29);
            txtFuelName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(401, 126);
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
            txtInventoryId.Location = new Point(36, 155);
            txtInventoryId.Name = "txtInventoryId";
            txtInventoryId.ReadOnly = true;
            txtInventoryId.Size = new Size(287, 29);
            txtInventoryId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 126);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 1;
            label4.Text = "Inventory ID:";
            // 
            // bntSave
            // 
            bntSave.BackColor = Color.FromArgb(49, 108, 181);
            bntSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSave.ForeColor = Color.White;
            bntSave.Location = new Point(162, 345);
            bntSave.Name = "bntSave";
            bntSave.Size = new Size(114, 42);
            bntSave.TabIndex = 0;
            bntSave.Text = "Save";
            bntSave.UseVisualStyleBackColor = false;
            bntSave.Click += bntSave_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = Color.Navy;
            lblUserName.Location = new Point(545, 21);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(68, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 10);
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
            panel2.Location = new Point(238, -116);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 56);
            panel2.TabIndex = 30;
            // 
            // FormEditInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 616);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Name = "FormEditInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Inventory";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private TextBox txtStockQuantity;
        private Label asrer;
        private TextBox txtPricePerLitre;
        private Label sd;
        private TextBox txtFuelName;
        private Label label5;
        private TextBox txtInventoryId;
        private Label label4;
        private Button bntSave;
        private Label lblUserName;
        private Label label1;
        private Panel panel2;
        private Button btnClear;
        private Button btnCancel;
        private Label label8;
    }
}