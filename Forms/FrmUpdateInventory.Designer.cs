namespace Forms
{
    partial class FrmUpdateInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateInventory));
            pnlViewStock = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            InventoryId = new DataGridViewTextBoxColumn();
            InventoryName = new DataGridViewTextBoxColumn();
            DateOfAdd = new DataGridViewTextBoxColumn();
            InventoryPrices = new DataGridViewTextBoxColumn();
            inventoryStatus = new DataGridViewTextBoxColumn();
            label4 = new Label();
            pnlSliding = new Panel();
            button3 = new Button();
            label7 = new Label();
            btnClear = new Button();
            txtPrices = new TextBox();
            button2 = new Button();
            btnUpdate = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            pnlViewStock.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlSliding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlViewStock
            // 
            pnlViewStock.BackColor = SystemColors.InactiveCaption;
            pnlViewStock.Controls.Add(panel1);
            pnlViewStock.Location = new Point(228, -1);
            pnlViewStock.Name = "pnlViewStock";
            pnlViewStock.Size = new Size(571, 500);
            pnlViewStock.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(15, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 463);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { InventoryId, InventoryName, DateOfAdd, InventoryPrices, inventoryStatus });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(545, 424);
            dataGridView1.TabIndex = 1;
            // 
            // InventoryId
            // 
            InventoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InventoryId.HeaderText = "Inventory Id";
            InventoryId.Name = "InventoryId";
            InventoryId.ReadOnly = true;
            // 
            // InventoryName
            // 
            InventoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InventoryName.HeaderText = "Inventory Name ";
            InventoryName.Name = "InventoryName";
            InventoryName.ReadOnly = true;
            // 
            // DateOfAdd
            // 
            DateOfAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateOfAdd.HeaderText = "Date Of Add";
            DateOfAdd.Name = "DateOfAdd";
            DateOfAdd.ReadOnly = true;
            // 
            // InventoryPrices
            // 
            InventoryPrices.HeaderText = "Inventory Prices";
            InventoryPrices.Name = "InventoryPrices";
            InventoryPrices.ReadOnly = true;
            // 
            // inventoryStatus
            // 
            inventoryStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inventoryStatus.HeaderText = "Inventory Status";
            inventoryStatus.Name = "inventoryStatus";
            inventoryStatus.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 0;
            label4.Text = "View All the Stocks  ";
            // 
            // pnlSliding
            // 
            pnlSliding.BackColor = Color.Black;
            pnlSliding.Controls.Add(dateTimePicker2);
            pnlSliding.Controls.Add(button3);
            pnlSliding.Controls.Add(label7);
            pnlSliding.Controls.Add(btnClear);
            pnlSliding.Controls.Add(txtPrices);
            pnlSliding.Controls.Add(button2);
            pnlSliding.Controls.Add(btnUpdate);
            pnlSliding.Controls.Add(button1);
            pnlSliding.Controls.Add(comboBox1);
            pnlSliding.Controls.Add(label6);
            pnlSliding.Controls.Add(label3);
            pnlSliding.Controls.Add(txtName);
            pnlSliding.Controls.Add(label2);
            pnlSliding.Controls.Add(label5);
            pnlSliding.Controls.Add(pictureBox2);
            pnlSliding.Controls.Add(label1);
            pnlSliding.ForeColor = Color.DimGray;
            pnlSliding.Location = new Point(2, -1);
            pnlSliding.Name = "pnlSliding";
            pnlSliding.Size = new Size(228, 503);
            pnlSliding.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(13, 457);
            button3.Name = "button3";
            button3.Size = new Size(185, 36);
            button3.TabIndex = 25;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(13, 256);
            label7.Name = "label7";
            label7.Size = new Size(71, 13);
            label7.TabIndex = 24;
            label7.Text = "Date of stock\r\n";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkCyan;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(113, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 36);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtPrices
            // 
            txtPrices.Location = new Point(11, 165);
            txtPrices.Name = "txtPrices";
            txtPrices.Size = new Size(154, 23);
            txtPrices.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 400);
            button2.Name = "button2";
            button2.Size = new Size(85, 36);
            button2.TabIndex = 20;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Brown;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(113, 351);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 34);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(9, 351);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(13, 201);
            label6.Name = "label6";
            label6.Size = new Size(37, 13);
            label6.TabIndex = 15;
            label6.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(67, 13);
            label3.TabIndex = 13;
            label3.Text = "Stock Prices";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 13);
            label2.TabIndex = 11;
            label2.Text = "Stock Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(84, 29);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Update ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.stock_125131221;
            pictureBox2.Location = new Point(9, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 44);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 2;
            label1.Text = "Inventory\r\n";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(9, 272);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(156, 23);
            dateTimePicker2.TabIndex = 27;
            // 
            // FrmUpdateInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(pnlViewStock);
            Controls.Add(pnlSliding);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmUpdateInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Inventory";
            pnlViewStock.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlSliding.ResumeLayout(false);
            pnlSliding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewStock;
        private Panel panel1;
        private Label label4;
        private Panel pnlSliding;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private ComboBox comboBox1;
        private Button button2;
        private Button btnUpdate;
        private Button button1;
        private TextBox txtPrices;
        private Button btnClear;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn InventoryId;
        private DataGridViewTextBoxColumn InventoryName;
        private DataGridViewTextBoxColumn DateOfAdd;
        private DataGridViewTextBoxColumn InventoryPrices;
        private DataGridViewTextBoxColumn inventoryStatus;
        private Button button3;
        private DateTimePicker dateTimePicker2;
    }
}