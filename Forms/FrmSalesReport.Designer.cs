namespace Forms
{
    partial class FrmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesReport));
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            btnOverView = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInventory = new Button();
            btnLogOut = new Button();
            btnEmpolyeeList = new Button();
            btnSalesrep = new Button();
            panel2 = new Panel();
            lblUserName = new Label();
            label1 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            label4 = new Label();
            lblPriceOfPatrol = new Label();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            SalesId = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btnViewSales = new Button();
            panel7 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel12 = new Panel();
            cmbFilter = new ComboBox();
            btnAddNewStock = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 53, 36);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(btnOverView);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnEmpolyeeList);
            panel1.Controls.Add(btnSalesrep);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(11, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 639);
            panel1.TabIndex = 9;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.analysis_176129561;
            pictureBox8.Location = new Point(13, 117);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // btnOverView
            // 
            btnOverView.BackColor = Color.FromArgb(18, 53, 36);
            btnOverView.BackgroundImageLayout = ImageLayout.Zoom;
            btnOverView.Cursor = Cursors.Hand;
            btnOverView.FlatStyle = FlatStyle.Popup;
            btnOverView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOverView.ForeColor = Color.WhiteSmoke;
            btnOverView.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverView.ImageKey = "(none)";
            btnOverView.Location = new Point(47, 115);
            btnOverView.Name = "btnOverView";
            btnOverView.Size = new Size(124, 35);
            btnOverView.TabIndex = 14;
            btnOverView.Text = "Overview";
            btnOverView.UseVisualStyleBackColor = false;
            btnOverView.Click += btnOverView_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout_165852551;
            pictureBox2.Location = new Point(13, 569);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.marketing_128622382;
            pictureBox4.Location = new Point(13, 373);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.increase2;
            pictureBox3.Location = new Point(13, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventory_121486803;
            pictureBox1.Location = new Point(13, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(18, 53, 36);
            btnInventory.BackgroundImageLayout = ImageLayout.Zoom;
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatStyle = FlatStyle.Popup;
            btnInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.WhiteSmoke;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.ImageKey = "(none)";
            btnInventory.Location = new Point(47, 197);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(124, 35);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click_1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(18, 53, 36);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.WhiteSmoke;
            btnLogOut.Location = new Point(47, 571);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 31);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log-Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnEmpolyeeList
            // 
            btnEmpolyeeList.BackColor = Color.FromArgb(18, 53, 36);
            btnEmpolyeeList.Cursor = Cursors.Hand;
            btnEmpolyeeList.FlatStyle = FlatStyle.Popup;
            btnEmpolyeeList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpolyeeList.ForeColor = Color.WhiteSmoke;
            btnEmpolyeeList.Location = new Point(47, 373);
            btnEmpolyeeList.Name = "btnEmpolyeeList";
            btnEmpolyeeList.Size = new Size(124, 35);
            btnEmpolyeeList.TabIndex = 5;
            btnEmpolyeeList.Text = "Empolyee List";
            btnEmpolyeeList.UseVisualStyleBackColor = false;
            // 
            // btnSalesrep
            // 
            btnSalesrep.BackColor = Color.FromArgb(133, 169, 71);
            btnSalesrep.Cursor = Cursors.Hand;
            btnSalesrep.FlatStyle = FlatStyle.Popup;
            btnSalesrep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesrep.ForeColor = Color.WhiteSmoke;
            btnSalesrep.Location = new Point(47, 281);
            btnSalesrep.Name = "btnSalesrep";
            btnSalesrep.Size = new Size(124, 35);
            btnSalesrep.TabIndex = 4;
            btnSalesrep.Text = "Sales Report";
            btnSalesrep.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(207, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 56);
            panel2.TabIndex = 4;
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
            label1.Size = new Size(301, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Sales Report\r\n";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(369, 79);
            panel8.Name = "panel8";
            panel8.Size = new Size(159, 120);
            panel8.TabIndex = 23;
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
            label5.Size = new Size(69, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Profit";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(18, 53, 36);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(lblPriceOfPatrol);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(209, 80);
            panel9.Name = "panel9";
            panel9.Size = new Size(151, 119);
            panel9.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 41);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 6;
            label4.Text = "Since this Month";
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
            label10.Size = new Size(90, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Revenue";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.HighlightText;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { SalesId });
            dataGridView2.Location = new Point(15, 34);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(619, 273);
            dataGridView2.TabIndex = 0;
            // 
            // SalesId
            // 
            SalesId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SalesId.HeaderText = "Sales Id ";
            SalesId.Name = "SalesId";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 7);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 1;
            label9.Text = "Sales  view ";
            // 
            // btnViewSales
            // 
            btnViewSales.Location = new Point(559, 5);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(75, 23);
            btnViewSales.TabIndex = 2;
            btnViewSales.Text = "View all";
            btnViewSales.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btnViewSales);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(dataGridView2);
            panel7.Location = new Point(210, 328);
            panel7.Name = "panel7";
            panel7.Size = new Size(650, 321);
            panel7.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(534, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(159, 120);
            panel3.TabIndex = 24;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(701, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 120);
            panel4.TabIndex = 25;
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
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(cmbFilter);
            panel12.Controls.Add(btnAddNewStock);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(210, 207);
            panel12.Name = "panel12";
            panel12.Size = new Size(650, 115);
            panel12.TabIndex = 26;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Current Day", "This Month", "This Year" });
            cmbFilter.Location = new Point(528, 17);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(104, 23);
            cmbFilter.Sorted = true;
            cmbFilter.TabIndex = 4;
            // 
            // btnAddNewStock
            // 
            btnAddNewStock.BackColor = Color.FromArgb(133, 169, 71);
            btnAddNewStock.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewStock.Cursor = Cursors.Hand;
            btnAddNewStock.FlatStyle = FlatStyle.Flat;
            btnAddNewStock.Location = new Point(381, 17);
            btnAddNewStock.Name = "btnAddNewStock";
            btnAddNewStock.Size = new Size(129, 23);
            btnAddNewStock.TabIndex = 3;
            btnAddNewStock.Text = "Add New Stock";
            btnAddNewStock.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Location = new Point(22, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Serach ";
            txtSearch.Size = new Size(207, 23);
            txtSearch.TabIndex = 0;
            // 
            // FrmSalesReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 659);
            Controls.Add(panel12);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSalesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Reports";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LbDesel;
        private Label lbPatrol;
        private Panel panel1;
        private PictureBox pictureBox8;
        protected Button btnOverView;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        protected Button btnInventory;
        private Button btnLogOut;
        private Button btnEmpolyeeList;
        private Button btnSalesrep;
        private Panel panel2;
        private Label lblUserName;
        private Label label1;
        private Panel panel8;
        private Panel panel9;
        private Label lblPriceOfPatrol;
        private Label label10;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn SalesId;
        private Label label9;
        private Button btnViewSales;
        private Panel panel7;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel12;
        private ComboBox cmbFilter;
        private Button btnAddNewStock;
        private TextBox txtSearch;
    }
}