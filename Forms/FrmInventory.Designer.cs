namespace Forms
{
    partial class FrmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
            panel2 = new Panel();
            lblUserName = new Label();
            label1 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            StockId = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            lbltotalUser = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
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
            panel3 = new Panel();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            label9 = new Label();
            panel9 = new Panel();
            lblPriceOfPatrol = new Label();
            label11 = new Label();
            pictureBox9 = new PictureBox();
            label10 = new Label();
            panel10 = new Panel();
            label18 = new Label();
            label19 = new Label();
            pictureBox12 = new PictureBox();
            label20 = new Label();
            panel8 = new Panel();
            label12 = new Label();
            label13 = new Label();
            pictureBox10 = new PictureBox();
            label14 = new Label();
            panel11 = new Panel();
            label15 = new Label();
            label16 = new Label();
            pictureBox11 = new PictureBox();
            label17 = new Label();
            panel12 = new Panel();
            cmbFilter = new ComboBox();
            btnAddNewStock = new Button();
            txtSearch = new TextBox();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel12.SuspendLayout();
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
            panel6.Controls.Add(label8);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(206, 349);
            panel6.Name = "panel6";
            panel6.Size = new Size(653, 298);
            panel6.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 7);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 1;
            label8.Text = "Stocks view ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StockId });
            dataGridView1.Location = new Point(15, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(619, 249);
            dataGridView1.TabIndex = 0;
            // 
            // StockId
            // 
            StockId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockId.HeaderText = "Stock Id ";
            StockId.Name = "StockId";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(lbltotalUser);
            panel4.Location = new Point(208, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 77);
            panel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(73, 14);
            label3.Name = "label3";
            label3.Size = new Size(115, 17);
            label3.TabIndex = 4;
            label3.Text = "Total Fual Stock \r\n";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.money_box_10920568;
            pictureBox6.Location = new Point(13, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // lbltotalUser
            // 
            lbltotalUser.AutoSize = true;
            lbltotalUser.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalUser.ForeColor = Color.Black;
            lbltotalUser.Location = new Point(82, 31);
            lbltotalUser.Name = "lbltotalUser";
            lbltotalUser.Size = new Size(105, 32);
            lbltotalUser.TabIndex = 1;
            lbltotalUser.Text = "00.00 L";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(206, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 56);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(546, 25);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 1;
            label5.Text = "User Name ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 14);
            label6.Name = "label6";
            label6.Size = new Size(263, 29);
            label6.TabIndex = 0;
            label6.Text = "Welcome to Inventory\r\n";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(18, 53, 36);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(btnOverView);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(btnInventory);
            panel5.Controls.Add(btnLogOut);
            panel5.Controls.Add(btnEmpolyeeList);
            panel5.Controls.Add(btnSalesrep);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(7, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 639);
            panel5.TabIndex = 10;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.analysis_17612956;
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
            btnOverView.Location = new Point(47, 117);
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
            btnInventory.BackColor = Color.FromArgb(133, 169, 71);
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
            btnSalesrep.BackColor = Color.FromArgb(18, 53, 36);
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
            btnSalesrep.Click += btnSalesrep_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(421, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 77);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(87, 14);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 4;
            label2.Text = "Low Stock\n";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.shopping_13559495;
            pictureBox5.Location = new Point(16, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(85, 31);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 1;
            label4.Text = "00.00 L";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(639, 70);
            panel7.Name = "panel7";
            panel7.Size = new Size(218, 77);
            panel7.TabIndex = 15;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.remove_11695444;
            pictureBox7.Location = new Point(12, 19);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 36);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(84, 14);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 4;
            label7.Text = "Out Stock\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(84, 31);
            label9.Name = "label9";
            label9.Size = new Size(105, 32);
            label9.TabIndex = 1;
            label9.Text = "00.00 L";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(18, 53, 36);
            panel9.Controls.Add(lblPriceOfPatrol);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(pictureBox9);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(208, 154);
            panel9.Name = "panel9";
            panel9.Size = new Size(151, 106);
            panel9.TabIndex = 17;
            // 
            // lblPriceOfPatrol
            // 
            lblPriceOfPatrol.AutoSize = true;
            lblPriceOfPatrol.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriceOfPatrol.ForeColor = Color.White;
            lblPriceOfPatrol.Location = new Point(13, 69);
            lblPriceOfPatrol.Name = "lblPriceOfPatrol";
            lblPriceOfPatrol.Size = new Size(98, 24);
            lblPriceOfPatrol.TabIndex = 5;
            lblPriceOfPatrol.Text = "00.00  Tk";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(16, 50);
            label11.Name = "label11";
            label11.Size = new Size(71, 16);
            label11.TabIndex = 6;
            label11.Text = "Prices Par litter";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.oil_price_66076684;
            pictureBox9.Location = new Point(108, 39);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 27);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(16, 30);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 0;
            label10.Text = "Patrol ";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(label18);
            panel10.Controls.Add(label19);
            panel10.Controls.Add(pictureBox12);
            panel10.Controls.Add(label20);
            panel10.Location = new Point(698, 153);
            panel10.Name = "panel10";
            panel10.Size = new Size(160, 107);
            panel10.TabIndex = 18;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(7, 61);
            label18.Name = "label18";
            label18.Size = new Size(98, 24);
            label18.TabIndex = 16;
            label18.Text = "00.00  Tk";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(10, 42);
            label19.Name = "label19";
            label19.Size = new Size(71, 16);
            label19.TabIndex = 18;
            label19.Text = "Prices Par litter";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.gas_station_18136878;
            pictureBox12.Location = new Point(110, 31);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(43, 27);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 17;
            pictureBox12.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(10, 22);
            label20.Name = "label20";
            label20.Size = new Size(37, 20);
            label20.TabIndex = 15;
            label20.Text = "CNG";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(pictureBox10);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(368, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(159, 107);
            panel8.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(10, 72);
            label12.Name = "label12";
            label12.Size = new Size(98, 24);
            label12.TabIndex = 8;
            label12.Text = "00.00  Tk";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(13, 53);
            label13.Name = "label13";
            label13.Size = new Size(71, 16);
            label13.TabIndex = 10;
            label13.Text = "Prices Par litter";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.flame_6630258;
            pictureBox10.Location = new Point(113, 42);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 27);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(13, 33);
            label14.Name = "label14";
            label14.Size = new Size(44, 20);
            label14.TabIndex = 7;
            label14.Text = "Diesel";
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(label15);
            panel11.Controls.Add(label16);
            panel11.Controls.Add(pictureBox11);
            panel11.Controls.Add(label17);
            panel11.Location = new Point(533, 153);
            panel11.Name = "panel11";
            panel11.Size = new Size(159, 107);
            panel11.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(6, 67);
            label15.Name = "label15";
            label15.Size = new Size(98, 24);
            label15.TabIndex = 12;
            label15.Text = "00.00  Tk";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(9, 48);
            label16.Name = "label16";
            label16.Size = new Size(71, 16);
            label16.TabIndex = 14;
            label16.Text = "Prices Par litter";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.oil_price_16073717;
            pictureBox11.Location = new Point(109, 37);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(43, 27);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 13;
            pictureBox11.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(9, 28);
            label17.Name = "label17";
            label17.Size = new Size(50, 20);
            label17.TabIndex = 11;
            label17.Text = "Octane";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(cmbFilter);
            panel12.Controls.Add(btnAddNewStock);
            panel12.Controls.Add(txtSearch);
            panel12.Location = new Point(208, 273);
            panel12.Name = "panel12";
            panel12.Size = new Size(650, 65);
            panel12.TabIndex = 21;
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
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(870, 659);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel8);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblUserName;
        private Label label1;
        private Panel panel6;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StockId;
        private Panel panel4;
        private Label label3;
        private Label lbltotalUser;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Panel panel5;
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
        private PictureBox pictureBox6;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox5;
        private Label label4;
        private Panel panel7;
        private Label label7;
        private Label label9;
        private PictureBox pictureBox7;
        private Panel panel9;
        private Panel panel10;
        private Panel panel8;
        private Panel panel11;
        private Label label10;
        private PictureBox pictureBox9;
        private Label lblPriceOfPatrol;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox10;
        private Label label14;
        private Label label18;
        private Label label19;
        private PictureBox pictureBox12;
        private Label label20;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox11;
        private Label label17;
        private Panel panel12;
        private Button btnAddNewStock;
        private TextBox txtSearch;
        private ComboBox cmbFilter;
    }
}