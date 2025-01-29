namespace Forms
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            panel2 = new Panel();
            lblUserName = new Label();
            label1 = new Label();
            panel6 = new Panel();
            dgvInventory = new DataGridView();
            panel12 = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            btnLogOut = new Button();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            btnExpense = new Button();
            pictureBox8 = new PictureBox();
            btnOverview = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInventory = new Button();
            btnUserList = new Button();
            btnSalesrep = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            lblWlcName = new Label();
            label4 = new Label();
            InventoryID = new DataGridViewTextBoxColumn();
            FuelName = new DataGridViewTextBoxColumn();
            PricePerLitre = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            EditAction = new DataGridViewButtonColumn();
            DeleteAction = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(237, -118);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 56);
            panel2.TabIndex = 9;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = Color.Navy;
            lblUserName.Location = new Point(546, 25);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(68, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(361, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Dashboard\r\n";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvInventory);
            panel6.Location = new Point(209, 150);
            panel6.Name = "panel6";
            panel6.Size = new Size(963, 539);
            panel6.TabIndex = 14;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.HighlightText;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { InventoryID, FuelName, PricePerLitre, StockQuantity, EditAction, DeleteAction });
            dgvInventory.Location = new Point(11, 16);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(935, 507);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(btnAdd);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(209, 79);
            panel12.Name = "panel12";
            panel12.Size = new Size(963, 65);
            panel12.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 108, 181);
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(767, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(179, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New Inventory";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(11, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Fuel Name";
            txtSearch.Size = new Size(571, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout_165852551;
            pictureBox2.Location = new Point(13, 634);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(196, 232, 255);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(55, 634);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 31);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log-Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(196, 232, 255);
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
            panel3.Controls.Add(btnUserList);
            panel3.Controls.Add(btnSalesrep);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(10, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 681);
            panel3.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.increase2;
            pictureBox5.Location = new Point(13, 248);
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
            btnExpense.Location = new Point(55, 246);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(124, 33);
            btnExpense.TabIndex = 20;
            btnExpense.Text = "Expenses";
            btnExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.analysis_176129561;
            pictureBox8.Location = new Point(13, 12);
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
            btnOverview.Location = new Point(55, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(124, 33);
            btnOverview.TabIndex = 14;
            btnOverview.Text = "Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.marketing_128622382;
            pictureBox4.Location = new Point(13, 188);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.increase2;
            pictureBox3.Location = new Point(13, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventory_121486803;
            pictureBox1.Location = new Point(13, 71);
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
            btnInventory.Location = new Point(55, 71);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(124, 33);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventories";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnUserList
            // 
            btnUserList.BackColor = Color.FromArgb(196, 232, 255);
            btnUserList.Cursor = Cursors.Hand;
            btnUserList.FlatStyle = FlatStyle.Popup;
            btnUserList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserList.ForeColor = Color.Black;
            btnUserList.Location = new Point(55, 188);
            btnUserList.Name = "btnUserList";
            btnUserList.Size = new Size(124, 33);
            btnUserList.TabIndex = 5;
            btnUserList.Text = "Users";
            btnUserList.TextAlign = ContentAlignment.MiddleLeft;
            btnUserList.UseVisualStyleBackColor = false;
            btnUserList.Click += btnUserList_Click;
            // 
            // btnSalesrep
            // 
            btnSalesrep.BackColor = Color.FromArgb(196, 232, 255);
            btnSalesrep.Cursor = Cursors.Hand;
            btnSalesrep.FlatStyle = FlatStyle.Popup;
            btnSalesrep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesrep.ForeColor = Color.Black;
            btnSalesrep.Location = new Point(55, 130);
            btnSalesrep.Name = "btnSalesrep";
            btnSalesrep.Size = new Size(124, 33);
            btnSalesrep.TabIndex = 4;
            btnSalesrep.Text = "Sales History";
            btnSalesrep.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesrep.UseVisualStyleBackColor = false;
            btnSalesrep.Click += btnSalesrep_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(209, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 56);
            panel1.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWlcName);
            panel5.Location = new Point(544, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 35);
            panel5.TabIndex = 25;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Dock = DockStyle.Right;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.Black;
            lblWlcName.Location = new Point(180, 0);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(222, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Asef Abdullah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 9);
            label4.Name = "label4";
            label4.Size = new Size(167, 37);
            label4.TabIndex = 24;
            label4.Text = "Inventories";
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
            StockQuantity.HeaderText = "Stock Quantity (In Litre)";
            StockQuantity.Name = "StockQuantity";
            StockQuantity.ReadOnly = true;
            // 
            // EditAction
            // 
            EditAction.HeaderText = "";
            EditAction.Name = "EditAction";
            EditAction.ReadOnly = true;
            EditAction.Resizable = DataGridViewTriState.True;
            EditAction.SortMode = DataGridViewColumnSortMode.Automatic;
            EditAction.Text = "Edit";
            EditAction.UseColumnTextForButtonValue = true;
            // 
            // DeleteAction
            // 
            DeleteAction.HeaderText = "";
            DeleteAction.Name = "DeleteAction";
            DeleteAction.ReadOnly = true;
            DeleteAction.Resizable = DataGridViewTriState.True;
            DeleteAction.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteAction.Text = "Delete";
            DeleteAction.UseColumnTextForButtonValue = true;
            DeleteAction.Width = 116;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1184, 701);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel12);
            Controls.Add(panel6);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventories";
            FormClosing += FormInventory_FormClosing;
            Load += FormInventory_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblUserName;
        private Label label1;
        private Panel panel6;
        private DataGridView dgvInventory;
        private Panel panel12;
        private Button btnAdd;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private Button btnLogOut;
        private Panel panel3;
        private PictureBox pictureBox8;
        protected Button btnOverview;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        protected Button btnInventory;
        private Button btnUserList;
        private Button btnSalesrep;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Button btnExpense;
        private Label label4;
        private Panel panel5;
        private Label lblWlcName;
        private DataGridViewTextBoxColumn InventoryID;
        private DataGridViewTextBoxColumn FuelName;
        private DataGridViewTextBoxColumn PricePerLitre;
        private DataGridViewTextBoxColumn StockQuantity;
        private DataGridViewButtonColumn EditAction;
        private DataGridViewButtonColumn DeleteAction;
    }
}