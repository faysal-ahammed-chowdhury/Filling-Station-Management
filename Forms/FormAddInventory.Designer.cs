﻿namespace Forms
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
            pictureBox6 = new PictureBox();
            btnOrder = new Button();
            pictureBox5 = new PictureBox();
            btnExpense = new Button();
            pictureBox8 = new PictureBox();
            btnOverview = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInventory = new Button();
            btnLogOut = new Button();
            btnEmpolyeeList = new Button();
            btnSalesrep = new Button();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(211, 10);
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
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.order_now_9226478;
            pictureBox6.Location = new Point(13, 294);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(196, 232, 255);
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatStyle = FlatStyle.Popup;
            btnOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(55, 294);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(124, 33);
            btnOrder.TabIndex = 22;
            btnOrder.Text = "Orders";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.increase2;
            pictureBox5.Location = new Point(13, 246);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // btnExpense
            // 
            btnExpense.Cursor = Cursors.Hand;
            btnExpense.FlatStyle = FlatStyle.Popup;
            btnExpense.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.Black;
            btnExpense.Location = new Point(55, 244);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(124, 33);
            btnExpense.TabIndex = 20;
            btnExpense.Text = "Expense list";
            btnExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnExpense.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.analysis_176129561;
            pictureBox8.Location = new Point(13, 10);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.FromArgb(196, 232, 255);
            btnOverview.BackgroundImageLayout = ImageLayout.Zoom;
            btnOverview.Cursor = Cursors.Hand;
            btnOverview.FlatStyle = FlatStyle.Popup;
            btnOverview.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOverview.ForeColor = Color.Black;
            btnOverview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverview.ImageKey = "(none)";
            btnOverview.Location = new Point(55, 10);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(124, 33);
            btnOverview.TabIndex = 14;
            btnOverview.Text = "Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(196, 232, 255);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(btnOrder);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btnExpense);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(btnOverview);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnInventory);
            panel3.Controls.Add(btnLogOut);
            panel3.Controls.Add(btnEmpolyeeList);
            panel3.Controls.Add(btnSalesrep);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(12, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 602);
            panel3.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout_165852551;
            pictureBox2.Location = new Point(13, 557);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.marketing_128622382;
            pictureBox4.Location = new Point(13, 186);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.increase2;
            pictureBox3.Location = new Point(13, 130);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventory_121486803;
            pictureBox1.Location = new Point(13, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(49, 108, 181);
            btnInventory.BackgroundImageLayout = ImageLayout.Zoom;
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatStyle = FlatStyle.Popup;
            btnInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.ImageKey = "(none)";
            btnInventory.Location = new Point(55, 69);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(124, 33);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(196, 232, 255);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(55, 557);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 31);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log-Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnEmpolyeeList
            // 
            btnEmpolyeeList.BackColor = Color.FromArgb(196, 232, 255);
            btnEmpolyeeList.Cursor = Cursors.Hand;
            btnEmpolyeeList.FlatStyle = FlatStyle.Popup;
            btnEmpolyeeList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpolyeeList.ForeColor = Color.Black;
            btnEmpolyeeList.Location = new Point(55, 186);
            btnEmpolyeeList.Name = "btnEmpolyeeList";
            btnEmpolyeeList.Size = new Size(124, 33);
            btnEmpolyeeList.TabIndex = 5;
            btnEmpolyeeList.Text = "Empolyee List";
            btnEmpolyeeList.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpolyeeList.UseVisualStyleBackColor = false;
            // 
            // btnSalesrep
            // 
            btnSalesrep.BackColor = Color.FromArgb(196, 232, 255);
            btnSalesrep.Cursor = Cursors.Hand;
            btnSalesrep.FlatStyle = FlatStyle.Popup;
            btnSalesrep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesrep.ForeColor = Color.Black;
            btnSalesrep.Location = new Point(55, 128);
            btnSalesrep.Name = "btnSalesrep";
            btnSalesrep.Size = new Size(124, 33);
            btnSalesrep.TabIndex = 4;
            btnSalesrep.Text = "Sales Report";
            btnSalesrep.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesrep.UseVisualStyleBackColor = false;
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
            panel6.Location = new Point(211, 79);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 533);
            panel6.TabIndex = 29;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(443, 245);
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
            btnCancel.Location = new Point(309, 245);
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
            txtStockQuantity.Location = new Point(398, 146);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(287, 29);
            txtStockQuantity.TabIndex = 8;
            // 
            // asrer
            // 
            asrer.AutoSize = true;
            asrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asrer.Location = new Point(396, 117);
            asrer.Name = "asrer";
            asrer.Size = new Size(114, 21);
            asrer.TabIndex = 7;
            asrer.Text = "Stock Quantity:";
            // 
            // txtPricePerLitre
            // 
            txtPricePerLitre.BackColor = SystemColors.ScrollBar;
            txtPricePerLitre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPricePerLitre.Location = new Point(31, 146);
            txtPricePerLitre.Name = "txtPricePerLitre";
            txtPricePerLitre.Size = new Size(287, 29);
            txtPricePerLitre.TabIndex = 6;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd.Location = new Point(29, 117);
            sd.Name = "sd";
            sd.Size = new Size(105, 21);
            sd.TabIndex = 5;
            sd.Text = "Price Per Litre";
            // 
            // txtFuelName
            // 
            txtFuelName.BackColor = SystemColors.ScrollBar;
            txtFuelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuelName.Location = new Point(398, 65);
            txtFuelName.Name = "txtFuelName";
            txtFuelName.Size = new Size(287, 29);
            txtFuelName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 36);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 3;
            label5.Text = "Fuel Name:";
            // 
            // txtInventoryId
            // 
            txtInventoryId.BackColor = SystemColors.ScrollBar;
            txtInventoryId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventoryId.Location = new Point(31, 65);
            txtInventoryId.Name = "txtInventoryId";
            txtInventoryId.Size = new Size(287, 29);
            txtInventoryId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 36);
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
            bntAdd.Location = new Point(179, 245);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(114, 42);
            bntAdd.TabIndex = 0;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += btnAdd_Click;
            // 
            // FormAddInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 616);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormAddInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox6;
        private Button btnOrder;
        private PictureBox pictureBox5;
        private Button btnExpense;
        private PictureBox pictureBox8;
        protected Button btnOverview;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        protected Button btnInventory;
        private Button btnLogOut;
        private Button btnEmpolyeeList;
        private Button btnSalesrep;
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
    }
}