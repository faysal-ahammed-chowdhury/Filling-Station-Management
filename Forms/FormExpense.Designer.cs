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
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            panel12 = new Panel();
            btnAddNewStock = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            label1 = new Label();
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
            label12 = new Label();
            label13 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            label4 = new Label();
            lblPriceOfPatrol = new Label();
            label10 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            btnOrder = new Button();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // cmbFilter
            // 
            cmbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Current Day", "This Month", "This Year" });
            cmbFilter.Location = new Point(605, 21);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(114, 29);
            cmbFilter.Sorted = true;
            cmbFilter.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(11, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach ";
            txtSearch.Size = new Size(417, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(cmbFilter);
            panel12.Controls.Add(btnAddNewStock);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(210, 209);
            panel12.Name = "panel12";
            panel12.Size = new Size(733, 65);
            panel12.TabIndex = 38;
            // 
            // btnAddNewStock
            // 
            btnAddNewStock.BackColor = Color.FromArgb(49, 108, 181);
            btnAddNewStock.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewStock.Cursor = Cursors.Hand;
            btnAddNewStock.FlatStyle = FlatStyle.Flat;
            btnAddNewStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewStock.ForeColor = Color.White;
            btnAddNewStock.Location = new Point(470, 21);
            btnAddNewStock.Name = "btnAddNewStock";
            btnAddNewStock.Size = new Size(129, 29);
            btnAddNewStock.TabIndex = 3;
            btnAddNewStock.Text = "Add New Stock";
            btnAddNewStock.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 7);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 1;
            label9.Text = "Expense History";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 272);
            dataGridView1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(210, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 314);
            panel6.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(587, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 1;
            label1.Text = "Change Password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 16);
            label14.Name = "label14";
            label14.Size = new Size(206, 29);
            label14.TabIndex = 0;
            label14.Text = "Welcome, Faysal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
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
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnOrder);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 66);
            label12.Name = "label12";
            label12.Size = new Size(135, 33);
            label12.TabIndex = 8;
            label12.Text = "00.00  Tk";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 21);
            label13.Name = "label13";
            label13.Size = new Size(40, 20);
            label13.TabIndex = 7;
            label13.Text = "Sales";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label3);
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
            label2.Size = new Size(115, 17);
            label2.TabIndex = 9;
            label2.Text = "Since this Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 8;
            label3.Text = "00.00  Tk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 21);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Expence ";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(49, 108, 181);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(lblPriceOfPatrol);
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
            label4.Size = new Size(105, 17);
            label4.TabIndex = 6;
            label4.Text = "Since this Year";
            // 
            // lblPriceOfPatrol
            // 
            lblPriceOfPatrol.AutoSize = true;
            lblPriceOfPatrol.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriceOfPatrol.ForeColor = Color.White;
            lblPriceOfPatrol.Location = new Point(13, 66);
            lblPriceOfPatrol.Name = "lblPriceOfPatrol";
            lblPriceOfPatrol.Size = new Size(135, 33);
            lblPriceOfPatrol.TabIndex = 5;
            lblPriceOfPatrol.Text = "00.00  Tk";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(13, 21);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Expense";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 66);
            label7.Name = "label7";
            label7.Size = new Size(135, 33);
            label7.TabIndex = 8;
            label7.Text = "00.00  Tk";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 21);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 7;
            label8.Text = "Total Cost";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 41);
            label11.Name = "label11";
            label11.Size = new Size(102, 17);
            label11.TabIndex = 9;
            label11.Text = "Since this Day";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(769, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 120);
            panel4.TabIndex = 34;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.order_now_9226478;
            pictureBox6.Location = new Point(13, 304);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(196, 232, 255);
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatStyle = FlatStyle.Popup;
            btnOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(55, 304);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(124, 33);
            btnOrder.TabIndex = 18;
            btnOrder.Text = "Orders";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.UseVisualStyleBackColor = false;
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
            Text = "List of Expense";
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbFilter;
        private TextBox txtSearch;
        private Panel panel12;
        private Button btnAddNewStock;
        private Label label9;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Label label1;
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
        private Label label12;
        private Label label13;
        private Panel panel8;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel9;
        private Label label4;
        private Label lblPriceOfPatrol;
        private Label label10;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Panel panel4;
        private PictureBox pictureBox6;
        private Button btnOrder;
    }
}