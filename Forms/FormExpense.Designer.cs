namespace Forms
{
    partial class FormExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpense));
            txtSearch = new TextBox();
            panel12 = new Panel();
            label7 = new Label();
            label3 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            btnAdd = new Button();
            label9 = new Label();
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
            panel6 = new Panel();
            label14 = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            btnExpense = new Button();
            btnOverview = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInventory = new Button();
            btnLogOut = new Button();
            btnEmpolyeeList = new Button();
            btnSalesrep = new Button();
            lblThisYear = new Label();
            label13 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            lblThisWeeK = new Label();
            label5 = new Label();
            panel9 = new Panel();
            label4 = new Label();
            lblThisDay = new Label();
            label10 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            lblThisMonth = new Label();
            label8 = new Label();
            lblStartDate = new Label();
            panel4 = new Panel();
            lblEndDate = new Label();
            label12 = new Label();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(11, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach by Category";
            txtSearch.Size = new Size(267, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(label7);
            panel12.Controls.Add(label3);
            panel12.Controls.Add(dtpEndDate);
            panel12.Controls.Add(dtpStartDate);
            panel12.Controls.Add(btnAdd);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(210, 204);
            panel12.Name = "panel12";
            panel12.Size = new Size(733, 85);
            panel12.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(431, 48);
            label7.Name = "label7";
            label7.Size = new Size(30, 23);
            label7.TabIndex = 7;
            label7.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(431, 12);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 6;
            label3.Text = "From:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Location = new Point(491, 48);
            dtpEndDate.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(228, 25);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(491, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(228, 25);
            dtpStartDate.TabIndex = 4;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 108, 181);
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(284, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New Stock";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(9, 9);
            label9.Name = "label9";
            label9.Size = new Size(262, 38);
            label9.TabIndex = 1;
            label9.Text = "Expense History";
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AllowUserToDeleteRows = false;
            dgvExpense.AllowUserToOrderColumns = true;
            dgvExpense.BackgroundColor = SystemColors.HighlightText;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Columns.AddRange(new DataGridViewColumn[] { ExpenseId, Amount, Category, Description, Date, TIme, CreatedBy, EditAction, DeleteAction });
            dgvExpense.Location = new Point(11, 30);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.ReadOnly = true;
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(708, 272);
            dgvExpense.TabIndex = 0;
            dgvExpense.CellContentClick += dgvExpense_CellContentClick;
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
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgvExpense);
            panel6.Location = new Point(210, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 314);
            panel6.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 13F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(560, 18);
            label14.MaximumSize = new Size(270, 30);
            label14.Name = "label14";
            label14.Size = new Size(159, 21);
            label14.TabIndex = 0;
            label14.Text = "Welcome, Faysal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label14);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(210, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 56);
            panel2.TabIndex = 36;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(196, 232, 255);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnExpense);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnEmpolyeeList);
            panel1.Controls.Add(btnSalesrep);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 602);
            panel1.TabIndex = 35;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.increase2;
            pictureBox5.Location = new Point(13, 247);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.FromArgb(49, 108, 181);
            btnExpense.Cursor = Cursors.Hand;
            btnExpense.FlatStyle = FlatStyle.Popup;
            btnExpense.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = Color.White;
            btnExpense.Location = new Point(55, 245);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(124, 33);
            btnExpense.TabIndex = 16;
            btnExpense.Text = "Expense list";
            btnExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnExpense.UseVisualStyleBackColor = false;
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
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout_165852551;
            pictureBox2.Location = new Point(13, 559);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
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
            btnLogOut.Location = new Point(55, 559);
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
            btnEmpolyeeList.Location = new Point(55, 188);
            btnEmpolyeeList.Name = "btnEmpolyeeList";
            btnEmpolyeeList.Size = new Size(124, 33);
            btnEmpolyeeList.TabIndex = 5;
            btnEmpolyeeList.Text = "Empolyee List";
            btnEmpolyeeList.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpolyeeList.UseVisualStyleBackColor = false;
            // 
            // btnSalesrep
            // 
            btnSalesrep.Cursor = Cursors.Hand;
            btnSalesrep.FlatStyle = FlatStyle.Popup;
            btnSalesrep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesrep.ForeColor = Color.Black;
            btnSalesrep.Location = new Point(55, 130);
            btnSalesrep.Name = "btnSalesrep";
            btnSalesrep.Size = new Size(124, 33);
            btnSalesrep.TabIndex = 4;
            btnSalesrep.Text = "Sales Report";
            btnSalesrep.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesrep.UseVisualStyleBackColor = false;
            // 
            // lblThisYear
            // 
            lblThisYear.AutoSize = true;
            lblThisYear.BackColor = Color.White;
            lblThisYear.Font = new Font("Arial", 19F);
            lblThisYear.ForeColor = Color.Black;
            lblThisYear.Location = new Point(9, 66);
            lblThisYear.Name = "lblThisYear";
            lblThisYear.Size = new Size(124, 31);
            lblThisYear.TabIndex = 8;
            lblThisYear.Text = "00.00  TK";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(9, 6);
            label13.Name = "label13";
            label13.Size = new Size(89, 20);
            label13.TabIndex = 7;
            label13.Text = "Total Expense";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label2);
            panel8.Controls.Add(lblThisWeeK);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(397, 74);
            panel8.Name = "panel8";
            panel8.Size = new Size(172, 120);
            panel8.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 9;
            label2.Text = "Since this Week";
            // 
            // lblThisWeeK
            // 
            lblThisWeeK.AutoSize = true;
            lblThisWeeK.BackColor = Color.White;
            lblThisWeeK.Font = new Font("Arial", 19F);
            lblThisWeeK.ForeColor = Color.Black;
            lblThisWeeK.Location = new Point(9, 66);
            lblThisWeeK.Name = "lblThisWeeK";
            lblThisWeeK.Size = new Size(124, 31);
            lblThisWeeK.TabIndex = 8;
            lblThisWeeK.Text = "00.00  TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 21);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Expence ";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(49, 108, 181);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(lblThisDay);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(211, 75);
            panel9.Name = "panel9";
            panel9.Size = new Size(172, 119);
            panel9.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 41);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 6;
            label4.Text = "Since Today";
            // 
            // lblThisDay
            // 
            lblThisDay.AutoSize = true;
            lblThisDay.Font = new Font("Arial", 19F);
            lblThisDay.ForeColor = Color.White;
            lblThisDay.Location = new Point(10, 66);
            lblThisDay.Name = "lblThisDay";
            lblThisDay.Size = new Size(124, 31);
            lblThisDay.TabIndex = 5;
            lblThisDay.Text = "00.00  TK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(11, 21);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Expense";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblThisMonth);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(583, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 120);
            panel3.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 41);
            label6.Name = "label6";
            label6.Size = new Size(115, 17);
            label6.TabIndex = 9;
            label6.Text = "Since this Month";
            // 
            // lblThisMonth
            // 
            lblThisMonth.AutoSize = true;
            lblThisMonth.BackColor = Color.White;
            lblThisMonth.Font = new Font("Arial", 19F);
            lblThisMonth.ForeColor = Color.Black;
            lblThisMonth.Location = new Point(9, 66);
            lblThisMonth.Name = "lblThisMonth";
            lblThisMonth.Size = new Size(124, 31);
            lblThisMonth.TabIndex = 8;
            lblThisMonth.Text = "00.00  TK";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(10, 21);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 7;
            label8.Text = "Total Expense";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.White;
            lblStartDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.Black;
            lblStartDate.Location = new Point(14, 31);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(82, 17);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "29-01-2020";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblEndDate);
            panel4.Controls.Add(lblStartDate);
            panel4.Controls.Add(lblThisYear);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(769, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 120);
            panel4.TabIndex = 34;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.BackColor = Color.White;
            lblEndDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.Black;
            lblEndDate.Location = new Point(36, 49);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(82, 17);
            lblEndDate.TabIndex = 10;
            lblEndDate.Text = "29-01-2020";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(16, 48);
            label12.Name = "label12";
            label12.Size = new Size(20, 17);
            label12.TabIndex = 11;
            label12.Text = "to";
            // 
            // FormExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 616);
            Controls.Add(panel12);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormExpense";
            Text = "Expense History";
            Load += FormExpense_Load;
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private Panel panel12;
        private Button btnAdd;
        private Label label9;
        private DataGridView dgvExpense;
        private Panel panel6;
        private Label label14;
        private Panel panel2;
        private PictureBox pictureBox8;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Button btnExpense;
        protected Button btnOverview;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        protected Button btnInventory;
        private Button btnLogOut;
        private Button btnEmpolyeeList;
        private Button btnSalesrep;
        private Label lblThisYear;
        private Label label13;
        private Panel panel8;
        private Label label2;
        private Label lblThisWeeK;
        private Label label5;
        private Panel panel9;
        private Label label4;
        private Label lblThisDay;
        private Label label10;
        private Panel panel3;
        private Label label6;
        private Label lblThisMonth;
        private Label label8;
        private Label lblStartDate;
        private Panel panel4;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label7;
        private Label label3;
        private DataGridViewTextBoxColumn ExpenseId;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TIme;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewButtonColumn EditAction;
        private DataGridViewButtonColumn DeleteAction;
        private Label label12;
        private Label lblEndDate;
    }
}