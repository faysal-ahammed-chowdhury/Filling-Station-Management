namespace Forms
{
    partial class FormEmployeeDashboard
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            btnAddSale = new Button();
            label10 = new Label();
            btnAddExpense = new Button();
            iconLogOut = new PictureBox();
            btnLogOut = new Button();
            label1 = new Label();
            lblTime = new Label();
            panel2 = new Panel();
            lblWlcName = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel7 = new Panel();
            lblAmount = new Label();
            label2 = new Label();
            dgvMySale = new DataGridView();
            SaleId = new DataGridViewTextBoxColumn();
            SaleTimeDate = new DataGridViewTextBoxColumn();
            GrandTotal = new DataGridViewTextBoxColumn();
            GivenAmount = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            btnViewSales = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconLogOut).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMySale).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(196, 232, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAddSale);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnAddExpense);
            panel1.Controls.Add(iconLogOut);
            panel1.Controls.Add(btnLogOut);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(10, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 686);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(120, 73);
            label4.Name = "label4";
            label4.Size = new Size(145, 29);
            label4.TabIndex = 6;
            label4.Text = "Important!!!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(364, 20);
            label3.TabIndex = 6;
            label3.Text = "If incorrect data was entered, please inform an Admin";
            // 
            // btnAddSale
            // 
            btnAddSale.BackColor = Color.Green;
            btnAddSale.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSale.ForeColor = Color.White;
            btnAddSale.Location = new Point(56, 189);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(256, 68);
            btnAddSale.TabIndex = 12;
            btnAddSale.Text = "Add New Sale";
            btnAddSale.UseVisualStyleBackColor = false;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(23, 18);
            label10.Name = "label10";
            label10.Size = new Size(330, 38);
            label10.TabIndex = 3;
            label10.Text = "Employee Dashboard";
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.Red;
            btnAddExpense.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExpense.ForeColor = Color.White;
            btnAddExpense.Location = new Point(56, 289);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(256, 68);
            btnAddExpense.TabIndex = 13;
            btnAddExpense.Text = "Add New Expense";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // iconLogOut
            // 
            iconLogOut.Image = Properties.Resources.logout_165852551;
            iconLogOut.Location = new Point(108, 635);
            iconLogOut.Name = "iconLogOut";
            iconLogOut.Size = new Size(36, 33);
            iconLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            iconLogOut.TabIndex = 13;
            iconLogOut.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(196, 232, 255);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(150, 635);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 31);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log-Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(558, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 15;
            label1.Text = "Time:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(627, 14);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(136, 30);
            lblTime.TabIndex = 14;
            lblTime.Text = "09:20:53 PM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblWlcName);
            panel2.Controls.Add(lblTime);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(394, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 64);
            panel2.TabIndex = 11;
            // 
            // lblWlcName
            // 
            lblWlcName.AutoSize = true;
            lblWlcName.Font = new Font("Arial", 13F, FontStyle.Bold);
            lblWlcName.ForeColor = Color.Black;
            lblWlcName.Location = new Point(19, 23);
            lblWlcName.Name = "lblWlcName";
            lblWlcName.Size = new Size(208, 21);
            lblWlcName.TabIndex = 0;
            lblWlcName.Text = "Welcome, Alam Pranto";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblAmount);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(dgvMySale);
            panel7.Controls.Add(btnViewSales);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(394, 77);
            panel7.Name = "panel7";
            panel7.Size = new Size(779, 616);
            panel7.TabIndex = 12;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(613, 17);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(150, 29);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "14000.00 TK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(506, 17);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 4;
            label2.Text = "Amount:";
            // 
            // dgvMySale
            // 
            dgvMySale.AllowUserToAddRows = false;
            dgvMySale.AllowUserToDeleteRows = false;
            dgvMySale.AllowUserToOrderColumns = true;
            dgvMySale.BackgroundColor = SystemColors.HighlightText;
            dgvMySale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMySale.Columns.AddRange(new DataGridViewColumn[] { SaleId, SaleTimeDate, GrandTotal, GivenAmount, Change, PaymentMethod, Details });
            dgvMySale.Location = new Point(13, 69);
            dgvMySale.Name = "dgvMySale";
            dgvMySale.ReadOnly = true;
            dgvMySale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMySale.Size = new Size(750, 529);
            dgvMySale.TabIndex = 3;
            dgvMySale.CellContentClick += dgvMySale_CellContentClick;
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
            // Details
            // 
            Details.HeaderText = "";
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Text = "Details";
            Details.UseColumnTextForButtonValue = true;
            // 
            // btnViewSales
            // 
            btnViewSales.Location = new Point(873, 3);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(75, 23);
            btnViewSales.TabIndex = 2;
            btnViewSales.Text = "View all";
            btnViewSales.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 17);
            label9.Name = "label9";
            label9.Size = new Size(312, 29);
            label9.TabIndex = 1;
            label9.Text = "Your Total Sales for Today";
            // 
            // FormEmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 701);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormEmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Dashboard";
            FormClosing += FormEmployeeDashboard_FormClosing;
            Load += FormEmployeeDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconLogOut).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMySale).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox iconLogOut;
        private Button btnLogOut;
        private Panel panel2;
        private Label lblWlcName;
        private Label label10;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button btnAddSale;
        private Button btnAddExpense;
        private Panel panel7;
        private DataGridView dgvMySale;
        private Button btnViewSales;
        private Label label9;
        private Label lblAmount;
        private Label label2;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewTextBoxColumn SaleTimeDate;
        private DataGridViewTextBoxColumn GrandTotal;
        private DataGridViewTextBoxColumn GivenAmount;
        private DataGridViewTextBoxColumn Change;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewButtonColumn Details;
        private Label label3;
        private Label label4;
    }
}