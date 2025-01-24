namespace Forms
{
    partial class FormAddSale
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
            components = new System.ComponentModel.Container();
            label9 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvInventory = new DataGridView();
            InventoryID = new DataGridViewTextBoxColumn();
            FuelName = new DataGridViewTextBoxColumn();
            PricePerLitre = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            SelectQuantity = new DataGridViewTextBoxColumn();
            AddAction = new DataGridViewButtonColumn();
            RemoveAction = new DataGridViewButtonColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            chkBkash = new RadioButton();
            chkCash = new RadioButton();
            lblSaleId = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtChange = new TextBox();
            txtGiven = new TextBox();
            btnClear = new Button();
            btnCancel = new Button();
            bntConfirm = new Button();
            dgvAddedProducts = new DataGridView();
            CFuelName = new DataGridViewTextBoxColumn();
            CPricePerLitre = new DataGridViewTextBoxColumn();
            CQuantity = new DataGridViewTextBoxColumn();
            CTotal = new DataGridViewTextBoxColumn();
            lblGrand = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(222, 38);
            label9.TabIndex = 1;
            label9.Text = "Add New Sale";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label9);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(12, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 56);
            panel2.TabIndex = 52;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(dgvInventory);
            panel6.Location = new Point(12, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(717, 605);
            panel6.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 17F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(277, 16);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 4;
            label1.Text = "List of Fuels";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(13, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Fuel Name";
            txtSearch.Size = new Size(687, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.HighlightText;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { InventoryID, FuelName, PricePerLitre, StockQuantity, SelectQuantity, AddAction, RemoveAction });
            dgvInventory.Location = new Point(13, 116);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(687, 477);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // InventoryID
            // 
            InventoryID.DataPropertyName = "InventoryId";
            InventoryID.HeaderText = "Inventory ID";
            InventoryID.Name = "InventoryID";
            InventoryID.ReadOnly = true;
            // 
            // FuelName
            // 
            FuelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FuelName.DataPropertyName = "FuelName";
            FuelName.HeaderText = "Fuel Name";
            FuelName.Name = "FuelName";
            FuelName.ReadOnly = true;
            // 
            // PricePerLitre
            // 
            PricePerLitre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PricePerLitre.DataPropertyName = "PricePerLitre";
            PricePerLitre.HeaderText = "Price (Per Litre)";
            PricePerLitre.Name = "PricePerLitre";
            PricePerLitre.ReadOnly = true;
            // 
            // StockQuantity
            // 
            StockQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockQuantity.DataPropertyName = "StockQuantity";
            StockQuantity.HeaderText = "Stock (In Litre)";
            StockQuantity.Name = "StockQuantity";
            StockQuantity.ReadOnly = true;
            // 
            // SelectQuantity
            // 
            SelectQuantity.HeaderText = "Quantity (In Litre)";
            SelectQuantity.Name = "SelectQuantity";
            SelectQuantity.Resizable = DataGridViewTriState.True;
            // 
            // AddAction
            // 
            AddAction.HeaderText = "";
            AddAction.Name = "AddAction";
            AddAction.ReadOnly = true;
            AddAction.Resizable = DataGridViewTriState.True;
            AddAction.SortMode = DataGridViewColumnSortMode.Automatic;
            AddAction.Text = "Add";
            AddAction.UseColumnTextForButtonValue = true;
            // 
            // RemoveAction
            // 
            RemoveAction.HeaderText = "";
            RemoveAction.Name = "RemoveAction";
            RemoveAction.ReadOnly = true;
            RemoveAction.Text = "Remove";
            RemoveAction.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblSaleId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtChange);
            panel1.Controls.Add(txtGiven);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(bntConfirm);
            panel1.Controls.Add(dgvAddedProducts);
            panel1.Controls.Add(lblGrand);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(735, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 605);
            panel1.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(chkBkash);
            panel3.Controls.Add(chkCash);
            panel3.Location = new Point(12, 389);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 90);
            panel3.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(-2, 3);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 65;
            label6.Text = "Payment Method:";
            // 
            // chkBkash
            // 
            chkBkash.AutoSize = true;
            chkBkash.Font = new Font("Segoe UI", 10F);
            chkBkash.Location = new Point(0, 50);
            chkBkash.Name = "chkBkash";
            chkBkash.Size = new Size(63, 23);
            chkBkash.TabIndex = 1;
            chkBkash.TabStop = true;
            chkBkash.Text = "Bkash";
            chkBkash.UseVisualStyleBackColor = true;
            // 
            // chkCash
            // 
            chkCash.AutoSize = true;
            chkCash.Font = new Font("Segoe UI", 10F);
            chkCash.Location = new Point(0, 25);
            chkCash.Name = "chkCash";
            chkCash.Size = new Size(57, 23);
            chkCash.TabIndex = 0;
            chkCash.TabStop = true;
            chkCash.Text = "Cash";
            chkCash.UseVisualStyleBackColor = true;
            // 
            // lblSaleId
            // 
            lblSaleId.AutoSize = true;
            lblSaleId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaleId.ForeColor = Color.Black;
            lblSaleId.Location = new Point(85, 16);
            lblSaleId.Name = "lblSaleId";
            lblSaleId.Size = new Size(80, 21);
            lblSaleId.TabIndex = 63;
            lblSaleId.Text = "SALE-001";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 62;
            label4.Text = "Sale ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(161, 452);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 61;
            label3.Text = "Change:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(161, 420);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 60;
            label2.Text = "Given Amount:";
            // 
            // txtChange
            // 
            txtChange.BackColor = SystemColors.Info;
            txtChange.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChange.Location = new Point(292, 452);
            txtChange.Name = "txtChange";
            txtChange.PlaceholderText = "Change";
            txtChange.Size = new Size(127, 27);
            txtChange.TabIndex = 59;
            // 
            // txtGiven
            // 
            txtGiven.BackColor = SystemColors.Info;
            txtGiven.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiven.Location = new Point(293, 420);
            txtGiven.Name = "txtGiven";
            txtGiven.PlaceholderText = "Given Amount";
            txtGiven.Size = new Size(128, 27);
            txtGiven.TabIndex = 5;
            txtGiven.TextChanged += txtGiven_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(166, 530);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 42);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 50, 49);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(35, 530);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // bntConfirm
            // 
            bntConfirm.BackColor = Color.Green;
            bntConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntConfirm.ForeColor = Color.White;
            bntConfirm.Location = new Point(297, 530);
            bntConfirm.Name = "bntConfirm";
            bntConfirm.Size = new Size(114, 42);
            bntConfirm.TabIndex = 11;
            bntConfirm.Text = "Confirm";
            bntConfirm.UseVisualStyleBackColor = false;
            bntConfirm.Click += bntConfirm_Click;
            // 
            // dgvAddedProducts
            // 
            dgvAddedProducts.AllowUserToAddRows = false;
            dgvAddedProducts.AllowUserToDeleteRows = false;
            dgvAddedProducts.AllowUserToOrderColumns = true;
            dgvAddedProducts.BackgroundColor = SystemColors.HighlightText;
            dgvAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedProducts.Columns.AddRange(new DataGridViewColumn[] { CFuelName, CPricePerLitre, CQuantity, CTotal });
            dgvAddedProducts.Location = new Point(12, 59);
            dgvAddedProducts.Name = "dgvAddedProducts";
            dgvAddedProducts.ReadOnly = true;
            dgvAddedProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddedProducts.Size = new Size(412, 318);
            dgvAddedProducts.TabIndex = 0;
            // 
            // CFuelName
            // 
            CFuelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CFuelName.DataPropertyName = "CFuelName";
            CFuelName.HeaderText = "Fuel Name";
            CFuelName.Name = "CFuelName";
            CFuelName.ReadOnly = true;
            // 
            // CPricePerLitre
            // 
            CPricePerLitre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CPricePerLitre.DataPropertyName = "CPricePerLitre";
            CPricePerLitre.HeaderText = "Price (Per Litre)";
            CPricePerLitre.Name = "CPricePerLitre";
            CPricePerLitre.ReadOnly = true;
            // 
            // CQuantity
            // 
            CQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CQuantity.DataPropertyName = "CQuantity";
            CQuantity.HeaderText = "Quantity (In Litre)";
            CQuantity.Name = "CQuantity";
            CQuantity.ReadOnly = true;
            // 
            // CTotal
            // 
            CTotal.DataPropertyName = "CTotal";
            CTotal.HeaderText = "Total";
            CTotal.Name = "CTotal";
            CTotal.ReadOnly = true;
            // 
            // lblGrand
            // 
            lblGrand.AutoSize = true;
            lblGrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrand.ForeColor = Color.Black;
            lblGrand.Location = new Point(291, 389);
            lblGrand.Name = "lblGrand";
            lblGrand.Size = new Size(27, 21);
            lblGrand.TabIndex = 58;
            lblGrand.Text = "TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(161, 389);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 57;
            label5.Text = "Grand Total:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormAddSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 701);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Name = "FormAddSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Sale";
            Load += FormAddSale_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private Panel panel2;
        private Panel panel6;
        private DataGridView dgvInventory;
        private Panel panel1;
        private DataGridView dgvAddedProducts;
        private Label label1;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn CFuelName;
        private DataGridViewTextBoxColumn CPricePerLitre;
        private DataGridViewTextBoxColumn CQuantity;
        private DataGridViewTextBoxColumn CTotal;
        private Button btnClear;
        private Button btnCancel;
        private Button bntConfirm;
        private TextBox txtChange;
        private TextBox txtGiven;
        private Label lblGrand;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridViewTextBoxColumn InventoryID;
        private DataGridViewTextBoxColumn FuelName;
        private DataGridViewTextBoxColumn PricePerLitre;
        private DataGridViewTextBoxColumn StockQuantity;
        private DataGridViewTextBoxColumn SelectQuantity;
        private DataGridViewButtonColumn AddAction;
        private DataGridViewButtonColumn RemoveAction;
        private Label label3;
        private Label label2;
        private Label lblSaleId;
        private Label label4;
        private Panel panel3;
        private RadioButton chkBkash;
        private RadioButton chkCash;
        private Label label6;
    }
}