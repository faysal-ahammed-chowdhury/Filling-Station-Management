namespace Forms
{
    partial class FormAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDashboard));
            panel1 = new Panel();
            pictureBox10 = new PictureBox();
            btnExpense = new Button();
            pictureBox8 = new PictureBox();
            btnOverview = new Button();
            iconLogOut = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInventory = new Button();
            btnLogOut = new Button();
            btnUserList = new Button();
            btnSalesrep = new Button();
            panel2 = new Panel();
            label10 = new Label();
            lblWlcName = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            lblSale = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            lblExpense = new Label();
            panel7 = new Panel();
            dgvSale = new DataGridView();
            SaleId = new DataGridViewTextBoxColumn();
            SaleTimeDate = new DataGridViewTextBoxColumn();
            GrandTotal = new DataGridViewTextBoxColumn();
            GivenAmount = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            btnViewSales = new Button();
            label9 = new Label();
            panel8 = new Panel();
            dgvExpense = new DataGridView();
            ExpenseId = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TIme = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            EditAction = new DataGridViewButtonColumn();
            DeleteAction = new DataGridViewButtonColumn();
            btnViewExpense = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(196, 232, 255);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(btnExpense);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(iconLogOut);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnUserList);
            panel1.Controls.Add(btnSalesrep);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 686);
            panel1.TabIndex = 0;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.increase2;
            pictureBox10.Location = new Point(13, 247);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 33);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 21;
            pictureBox10.TabStop = false;
            // 
            // btnExpense
            // 
            btnExpense.Cursor = Cursors.Hand;
            btnExpense.FlatStyle = FlatStyle.Popup;
            btnExpense.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.Black;
            btnExpense.Location = new Point(55, 245);
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
            btnOverview.BackColor = Color.FromArgb(49, 108, 181);
            btnOverview.BackgroundImageLayout = ImageLayout.Zoom;
            btnOverview.Cursor = Cursors.Hand;
            btnOverview.FlatStyle = FlatStyle.Popup;
            btnOverview.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOverview.ForeColor = Color.White;
            btnOverview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverview.ImageKey = "(none)";
            btnOverview.Location = new Point(55, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(124, 33);
            btnOverview.TabIndex = 14;
            btnOverview.Text = "Overview";
            btnOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnOverview.UseVisualStyleBackColor = false;
            // 
            // iconLogOut
            // 
            iconLogOut.Image = Properties.Resources.logout_165852551;
            iconLogOut.Location = new Point(13, 640);
            iconLogOut.Name = "iconLogOut";
            iconLogOut.Size = new Size(36, 33);
            iconLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            iconLogOut.TabIndex = 13;
            iconLogOut.TabStop = false;
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
            btnInventory.BackColor = Color.FromArgb(196, 232, 255);
            btnInventory.BackgroundImageLayout = ImageLayout.Zoom;
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatStyle = FlatStyle.Popup;
            btnInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.Black;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.ImageKey = "(none)";
            btnInventory.Location = new Point(55, 71);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(124, 33);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventories";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(196, 232, 255);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(55, 640);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 31);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log-Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblWlcName);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(208, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 56);
            panel2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(10, 8);
            label10.Name = "label10";
            label10.Size = new Size(278, 38);
            label10.TabIndex = 2;
            label10.Text = "Admin Dashboard";
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.Black;
            lblWlcName.Location = new Point(589, 20);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(359, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Faysal Ahammed Chowdhury";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(49, 108, 181);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(lblSale);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(209, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 103);
            panel3.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.report_1211564;
            pictureBox5.Location = new Point(395, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // lblSale
            // 
            lblSale.AutoSize = true;
            lblSale.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSale.ForeColor = Color.White;
            lblSale.Location = new Point(9, 42);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(124, 32);
            lblSale.TabIndex = 1;
            lblSale.Text = "00.00 TK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 0;
            label2.Text = "Total Sale";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(lblExpense);
            panel4.Location = new Point(689, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(482, 105);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 19);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 4;
            label3.Text = "Total Expense";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user_11129587;
            pictureBox6.Location = new Point(419, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpense.ForeColor = SystemColors.ActiveCaptionText;
            lblExpense.Location = new Point(13, 42);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(124, 32);
            lblExpense.TabIndex = 1;
            lblExpense.Text = "00.00 TK";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dgvSale);
            panel7.Controls.Add(btnViewSales);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(208, 200);
            panel7.Name = "panel7";
            panel7.Size = new Size(963, 241);
            panel7.TabIndex = 8;
            // 
            // dgvSale
            // 
            dgvSale.AllowUserToAddRows = false;
            dgvSale.AllowUserToDeleteRows = false;
            dgvSale.AllowUserToOrderColumns = true;
            dgvSale.BackgroundColor = SystemColors.HighlightText;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Columns.AddRange(new DataGridViewColumn[] { SaleId, SaleTimeDate, GrandTotal, GivenAmount, Change, PaymentMethod, dataGridViewTextBoxColumn1, Details, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            dgvSale.Location = new Point(13, 32);
            dgvSale.Name = "dgvSale";
            dgvSale.ReadOnly = true;
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSale.Size = new Size(936, 193);
            dgvSale.TabIndex = 3;
            // 
            // SaleId
            // 
            SaleId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SaleId.DataPropertyName = "SaleId";
            SaleId.HeaderText = "Sale ID";
            SaleId.Name = "SaleId";
            SaleId.ReadOnly = true;
            // 
            // SaleTimeDate
            // 
            SaleTimeDate.DataPropertyName = "SaleTimeDate";
            SaleTimeDate.HeaderText = "Time";
            SaleTimeDate.Name = "SaleTimeDate";
            SaleTimeDate.ReadOnly = true;
            // 
            // GrandTotal
            // 
            GrandTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrandTotal.DataPropertyName = "GrandTotal";
            GrandTotal.HeaderText = "Grand Total";
            GrandTotal.Name = "GrandTotal";
            GrandTotal.ReadOnly = true;
            // 
            // GivenAmount
            // 
            GivenAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GivenAmount.DataPropertyName = "GivenAmount";
            GivenAmount.HeaderText = "Given Amount";
            GivenAmount.Name = "GivenAmount";
            GivenAmount.ReadOnly = true;
            // 
            // Change
            // 
            Change.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Change.DataPropertyName = "Change";
            Change.HeaderText = "Change";
            Change.Name = "Change";
            Change.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PaymentMethod.DataPropertyName = "PaymentMethod";
            PaymentMethod.HeaderText = "Method";
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "CreatedByName";
            dataGridViewTextBoxColumn1.HeaderText = "Created By";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Details
            // 
            Details.HeaderText = "";
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Text = "Details";
            Details.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Edit";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn2.HeaderText = "";
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.ReadOnly = true;
            dataGridViewButtonColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn2.Text = "Delete";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // btnViewSales
            // 
            btnViewSales.Location = new Point(873, 3);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(75, 23);
            btnViewSales.TabIndex = 2;
            btnViewSales.Text = "View all";
            btnViewSales.UseVisualStyleBackColor = true;
            btnViewSales.Click += btnViewSales_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 7);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 1;
            label9.Text = "Sales History";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(dgvExpense);
            panel8.Controls.Add(btnViewExpense);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(209, 447);
            panel8.Name = "panel8";
            panel8.Size = new Size(964, 251);
            panel8.TabIndex = 9;
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AllowUserToDeleteRows = false;
            dgvExpense.AllowUserToOrderColumns = true;
            dgvExpense.BackgroundColor = SystemColors.HighlightText;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Columns.AddRange(new DataGridViewColumn[] { ExpenseId, Amount, Category, Description, Date, TIme, CreatedBy, EditAction, DeleteAction });
            dgvExpense.Location = new Point(14, 32);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.ReadOnly = true;
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(932, 204);
            dgvExpense.TabIndex = 3;
            // 
            // ExpenseId
            // 
            ExpenseId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExpenseId.DataPropertyName = "ExpenseId";
            ExpenseId.HeaderText = "Expense ID";
            ExpenseId.Name = "ExpenseId";
            ExpenseId.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // TIme
            // 
            TIme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TIme.DataPropertyName = "TIme";
            TIme.HeaderText = "TIme";
            TIme.Name = "TIme";
            TIme.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedBy.DataPropertyName = "CreatedByName";
            CreatedBy.HeaderText = "Created By";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // EditAction
            // 
            EditAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EditAction.HeaderText = "";
            EditAction.Name = "EditAction";
            EditAction.ReadOnly = true;
            EditAction.Text = "Edit";
            EditAction.UseColumnTextForButtonValue = true;
            // 
            // DeleteAction
            // 
            DeleteAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeleteAction.HeaderText = "";
            DeleteAction.Name = "DeleteAction";
            DeleteAction.ReadOnly = true;
            DeleteAction.Resizable = DataGridViewTriState.True;
            DeleteAction.Text = "Delete";
            DeleteAction.UseColumnTextForButtonValue = true;
            // 
            // btnViewExpense
            // 
            btnViewExpense.Location = new Point(873, 3);
            btnViewExpense.Name = "btnViewExpense";
            btnViewExpense.Size = new Size(75, 23);
            btnViewExpense.TabIndex = 2;
            btnViewExpense.Text = "View all";
            btnViewExpense.UseVisualStyleBackColor = true;
            btnViewExpense.Click += btnViewExpense_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 7);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 1;
            label4.Text = "Expense History";
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnLogOut;
            ClientSize = new Size(1184, 701);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(59, 28, 50);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAdminDashboard";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            FormClosed += FormAdminDashboard_FormClosed;
            Load += FormAdminDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalesrep;
        private Button btnUserList;
        private Button btnLogOut;
        private PictureBox pictureBox1;
        protected Button btnInventory;
        private PictureBox iconLogOut;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label lblWlcName;
        private Panel panel3;
        private Label lblSale;
        private Label label2;
        private PictureBox pictureBox5;
        private Panel panel4;
        private PictureBox pictureBox6;
        private Label lblExpense;
        private Label label3;
        private Panel panel7;
        private Button btnViewSales;
        private Label label9;
        private PictureBox pictureBox8;
        protected Button btnOverview;
        private PictureBox pictureBox10;
        private Button btnExpense;
        private Label label10;
        private Panel panel8;
        private Button btnViewExpense;
        private Label label4;
        private DataGridView dgvExpense;
        private DataGridViewTextBoxColumn ExpenseId;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TIme;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewButtonColumn EditAction;
        private DataGridViewButtonColumn DeleteAction;
        private DataGridView dgvSale;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewTextBoxColumn SaleTimeDate;
        private DataGridViewTextBoxColumn GrandTotal;
        private DataGridViewTextBoxColumn GivenAmount;
        private DataGridViewTextBoxColumn Change;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}