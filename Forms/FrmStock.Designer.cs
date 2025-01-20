namespace Forms
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            panel4 = new Panel();
            btnBack = new Button();
            textSearch = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbStockStatus = new ComboBox();
            btnSearch = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            dataGridviewStockmangement = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnAddInventory = new Button();
            label1 = new Label();
            StockId = new DataGridViewTextBoxColumn();
            StockQuentity = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            StockPrices = new DataGridViewTextBoxColumn();
            StockStatus = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridviewStockmangement).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(btnBack);
            panel4.Controls.Add(textSearch);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cmbStockStatus);
            panel4.Controls.Add(btnSearch);
            panel4.Location = new Point(12, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 342);
            panel4.TabIndex = 15;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.MenuHighlight;
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(13, 297);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(165, 30);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(13, 41);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(159, 23);
            textSearch.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 87);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 8;
            label3.Text = "Search";
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(13, 105);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(165, 23);
            cmbStockStatus.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.MenuHighlight;
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(18, 144);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(154, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(224, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 28);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 9;
            label2.Text = "Table of Inventorys";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridviewStockmangement);
            panel2.Location = new Point(224, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 316);
            panel2.TabIndex = 13;
            // 
            // dataGridviewStockmangement
            // 
            dataGridviewStockmangement.AllowUserToAddRows = false;
            dataGridviewStockmangement.AllowUserToDeleteRows = false;
            dataGridviewStockmangement.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridviewStockmangement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridviewStockmangement.Columns.AddRange(new DataGridViewColumn[] { StockId, StockQuentity, StockName, StockPrices, StockStatus });
            dataGridviewStockmangement.Dock = DockStyle.Fill;
            dataGridviewStockmangement.Location = new Point(0, 0);
            dataGridviewStockmangement.Name = "dataGridviewStockmangement";
            dataGridviewStockmangement.ReadOnly = true;
            dataGridviewStockmangement.Size = new Size(564, 316);
            dataGridviewStockmangement.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnAddInventory);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.increase1;
            pictureBox2.Location = new Point(3, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnAddInventory
            // 
            btnAddInventory.BackColor = SystemColors.MenuHighlight;
            btnAddInventory.ForeColor = SystemColors.Control;
            btnAddInventory.Location = new Point(718, 16);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(70, 30);
            btnAddInventory.TabIndex = 7;
            btnAddInventory.Text = "Add ";
            btnAddInventory.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 16);
            label1.Name = "label1";
            label1.Size = new Size(245, 90);
            label1.TabIndex = 2;
            label1.Text = "Fual Stock Management\r\n\r\n\r\n";
            // 
            // StockId
            // 
            StockId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockId.HeaderText = "Stock Id";
            StockId.Name = "StockId";
            StockId.ReadOnly = true;
            // 
            // StockQuentity
            // 
            StockQuentity.HeaderText = "Stock Quentity";
            StockQuentity.Name = "StockQuentity";
            StockQuentity.ReadOnly = true;
            // 
            // StockName
            // 
            StockName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockName.HeaderText = "Stock Name ";
            StockName.Name = "StockName";
            StockName.ReadOnly = true;
            // 
            // StockPrices
            // 
            StockPrices.HeaderText = "Stock Prices";
            StockPrices.Name = "StockPrices";
            StockPrices.ReadOnly = true;
            // 
            // StockStatus
            // 
            StockStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockStatus.HeaderText = "Stock Status";
            StockStatus.Name = "StockStatus";
            StockStatus.ReadOnly = true;
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmStock";
            Text = "Fual Stock ";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridviewStockmangement).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button btnBack;
        private TextBox textSearch;
        private Label label4;
        private Label label3;
        private ComboBox cmbStockStatus;
        private Button btnSearch;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridviewStockmangement;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnAddInventory;
        private Label label1;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn StockQuentity;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn StockPrices;
        private DataGridViewTextBoxColumn StockStatus;
    }
}