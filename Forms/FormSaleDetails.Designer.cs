namespace Forms
{
    partial class FormSaleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaleDetails));
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            lblMethod = new Label();
            panel3 = new Panel();
            label7 = new Label();
            lblSalesBy = new Label();
            panel6 = new Panel();
            panel8 = new Panel();
            lblChange = new Label();
            label11 = new Label();
            panel7 = new Panel();
            label8 = new Label();
            lblGiven = new Label();
            panel5 = new Panel();
            lblGrand = new Label();
            label5 = new Label();
            dgvSaleDetail = new DataGridView();
            SaleDetailId = new DataGridViewTextBoxColumn();
            InventoryName = new DataGridViewTextBoxColumn();
            PricePerLitre = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblTime = new Label();
            label4 = new Label();
            lblSaleId = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblSaleId);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label9);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 592);
            panel2.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblMethod);
            panel4.Location = new Point(488, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 26);
            panel4.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Right;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(227, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 21);
            label10.TabIndex = 49;
            label10.Text = "Payment Method:";
            label10.Click += label10_Click;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Dock = DockStyle.Right;
            lblMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMethod.ForeColor = Color.Black;
            lblMethod.Location = new Point(373, 0);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(52, 21);
            lblMethod.TabIndex = 50;
            lblMethod.Text = "BKash";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblSalesBy);
            panel3.Location = new Point(488, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 26);
            panel3.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(136, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 47;
            label7.Text = "Sales By:";
            // 
            // lblSalesBy
            // 
            lblSalesBy.AutoSize = true;
            lblSalesBy.Dock = DockStyle.Right;
            lblSalesBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesBy.ForeColor = Color.Black;
            lblSalesBy.Location = new Point(212, 0);
            lblSalesBy.Name = "lblSalesBy";
            lblSalesBy.Size = new Size(213, 21);
            lblSalesBy.TabIndex = 48;
            lblSalesBy.Text = "Faysal Ahammed Chowdhury";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(dgvSaleDetail);
            panel6.Location = new Point(14, 138);
            panel6.Name = "panel6";
            panel6.Size = new Size(902, 451);
            panel6.TabIndex = 46;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblChange);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(478, 365);
            panel8.Name = "panel8";
            panel8.Size = new Size(425, 26);
            panel8.TabIndex = 55;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Dock = DockStyle.Right;
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(355, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(70, 21);
            lblChange.TabIndex = 56;
            lblChange.Text = "00.00 TK";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(172, 5);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 55;
            label11.Text = "Change:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label8);
            panel7.Controls.Add(lblGiven);
            panel7.Location = new Point(477, 333);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 26);
            panel7.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(173, 2);
            label8.Name = "label8";
            label8.Size = new Size(124, 21);
            label8.TabIndex = 53;
            label8.Text = "Given Amount:";
            // 
            // lblGiven
            // 
            lblGiven.AutoSize = true;
            lblGiven.Dock = DockStyle.Right;
            lblGiven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiven.ForeColor = Color.Black;
            lblGiven.Location = new Point(355, 0);
            lblGiven.Name = "lblGiven";
            lblGiven.Size = new Size(70, 21);
            lblGiven.TabIndex = 54;
            lblGiven.Text = "00.00 TK";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblGrand);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(474, 301);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 26);
            panel5.TabIndex = 53;
            // 
            // lblGrand
            // 
            lblGrand.AutoSize = true;
            lblGrand.Dock = DockStyle.Right;
            lblGrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrand.ForeColor = Color.Black;
            lblGrand.Location = new Point(355, 0);
            lblGrand.Name = "lblGrand";
            lblGrand.Size = new Size(70, 21);
            lblGrand.TabIndex = 52;
            lblGrand.Text = "00.00 TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(176, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 51;
            label5.Text = "Grand Total:";
            // 
            // dgvSaleDetail
            // 
            dgvSaleDetail.AllowUserToAddRows = false;
            dgvSaleDetail.AllowUserToDeleteRows = false;
            dgvSaleDetail.AllowUserToOrderColumns = true;
            dgvSaleDetail.BackgroundColor = SystemColors.HighlightText;
            dgvSaleDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetail.Columns.AddRange(new DataGridViewColumn[] { SaleDetailId, InventoryName, PricePerLitre, Quantity, Total });
            dgvSaleDetail.Location = new Point(0, 3);
            dgvSaleDetail.Name = "dgvSaleDetail";
            dgvSaleDetail.ReadOnly = true;
            dgvSaleDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetail.Size = new Size(899, 281);
            dgvSaleDetail.TabIndex = 0;
            // 
            // SaleDetailId
            // 
            SaleDetailId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SaleDetailId.DataPropertyName = "SaleDetailId";
            SaleDetailId.HeaderText = "Sale Details ID";
            SaleDetailId.Name = "SaleDetailId";
            SaleDetailId.ReadOnly = true;
            // 
            // InventoryName
            // 
            InventoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InventoryName.DataPropertyName = "InventoryName";
            InventoryName.HeaderText = "Inventory";
            InventoryName.Name = "InventoryName";
            InventoryName.ReadOnly = true;
            // 
            // PricePerLitre
            // 
            PricePerLitre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PricePerLitre.DataPropertyName = "PricePerLitre";
            PricePerLitre.HeaderText = "Price Per Litre";
            PricePerLitre.Name = "PricePerLitre";
            PricePerLitre.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity (In Litre)";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(62, 98);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(99, 21);
            lblTime.TabIndex = 7;
            lblTime.Text = "23-Jan-2025";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 98);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 6;
            label4.Text = "Time:";
            // 
            // lblSaleId
            // 
            lblSaleId.AutoSize = true;
            lblSaleId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaleId.ForeColor = Color.Black;
            lblSaleId.Location = new Point(51, 72);
            lblSaleId.Name = "lblSaleId";
            lblSaleId.Size = new Size(89, 21);
            lblSaleId.TabIndex = 5;
            lblSaleId.Text = "#SALE-001";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(22, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 2);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 3;
            label2.Text = "NO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(442, 14);
            label1.Name = "label1";
            label1.Size = new Size(485, 38);
            label1.TabIndex = 2;
            label1.Text = "CHOWDHURY FILLING STATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(14, 14);
            label9.Name = "label9";
            label9.Size = new Size(144, 38);
            label9.TabIndex = 1;
            label9.Text = "INVOICE";
            // 
            // FormSaleDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 616);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormSaleDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Details";
            Load += FormSaleDetails_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label9;
        private Label label2;
        private Label lblSaleId;
        private Label lblTime;
        private Label label4;
        private Panel panel6;
        private DataGridView dgvSaleDetail;
        private Panel panel1;
        private Label label1;
        private Label lblMethod;
        private Label label10;
        private Label lblSalesBy;
        private Label label7;
        private Label lblGrand;
        private Label label5;
        private Label lblChange;
        private Label label11;
        private Label lblGiven;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel7;
        private DataGridViewTextBoxColumn SaleDetailId;
        private DataGridViewTextBoxColumn InventoryName;
        private DataGridViewTextBoxColumn PricePerLitre;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
    }
}