namespace Forms
{
    partial class FrmUserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserList));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btxBack = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            txtSearchEmployee = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            btnAddEmpolyee = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 69);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(316, 22);
            label2.Name = "label2";
            label2.Size = new Size(196, 34);
            label2.TabIndex = 2;
            label2.Text = "List Of User";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.marketing_128622381;
            pictureBox2.Location = new Point(241, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btxBack
            // 
            btxBack.BackColor = Color.Peru;
            btxBack.BackgroundImageLayout = ImageLayout.Zoom;
            btxBack.ForeColor = SystemColors.ButtonHighlight;
            btxBack.Location = new Point(715, 417);
            btxBack.Name = "btxBack";
            btxBack.Size = new Size(70, 29);
            btxBack.TabIndex = 26;
            btxBack.Text = "Back";
            btxBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchEmployee);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAddEmpolyee);
            panel1.Controls.Add(btxBack);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 456);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 82);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 33;
            label1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search_43985684;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(207, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 29);
            btnSearch.TabIndex = 32;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(11, 100);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(190, 23);
            txtSearchEmployee.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(3, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(795, 264);
            dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            Column1.HeaderText = "Empolyee Id";
            Column1.Name = "Column1";
            // 
            // Column7
            // 
            Column7.HeaderText = "Date Of Birth";
            Column7.Name = "Column7";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name ";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Gmail";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Phone ";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Gender";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Role";
            Column6.Name = "Column6";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee_622869;
            pictureBox1.Location = new Point(634, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnAddEmpolyee
            // 
            btnAddEmpolyee.BackColor = Color.ForestGreen;
            btnAddEmpolyee.ForeColor = Color.White;
            btnAddEmpolyee.Location = new Point(666, 94);
            btnAddEmpolyee.Name = "btnAddEmpolyee";
            btnAddEmpolyee.Size = new Size(132, 36);
            btnAddEmpolyee.TabIndex = 29;
            btnAddEmpolyee.Text = "Add";
            btnAddEmpolyee.UseVisualStyleBackColor = false;
            // 
            // FrmEmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmEmployeeList";
            Text = "Employee LIst ";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btxBack;
        private Panel panel1;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearchEmployee;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btnAddEmpolyee;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}