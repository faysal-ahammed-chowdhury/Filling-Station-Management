namespace Forms
{
    partial class FormAddExpense
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
            btnClear = new Button();
            txtDescription = new TextBox();
            asrer = new Label();
            sd = new Label();
            btnCancel = new Button();
            txtAmount = new TextBox();
            label5 = new Label();
            txtExpenseId = new TextBox();
            bntAdd = new Button();
            panel2 = new Panel();
            lblUserName = new Label();
            label1 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            dtpTime = new DateTimePicker();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            chkCurrentTime = new CheckBox();
            cboCategory = new ComboBox();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(296, 424);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 42);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ScrollBar;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(400, 212);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(287, 29);
            txtDescription.TabIndex = 8;
            // 
            // asrer
            // 
            asrer.AutoSize = true;
            asrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asrer.Location = new Point(398, 183);
            asrer.Name = "asrer";
            asrer.Size = new Size(92, 21);
            asrer.TabIndex = 7;
            asrer.Text = "Description:";
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sd.Location = new Point(31, 183);
            sd.Name = "sd";
            sd.Size = new Size(73, 21);
            sd.TabIndex = 5;
            sd.Text = "Category";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 50, 49);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(138, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.ScrollBar;
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(400, 131);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(287, 29);
            txtAmount.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 102);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 3;
            label5.Text = "Amount:";
            // 
            // txtExpenseId
            // 
            txtExpenseId.BackColor = SystemColors.ScrollBar;
            txtExpenseId.Enabled = false;
            txtExpenseId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpenseId.Location = new Point(33, 131);
            txtExpenseId.Name = "txtExpenseId";
            txtExpenseId.ReadOnly = true;
            txtExpenseId.Size = new Size(287, 29);
            txtExpenseId.TabIndex = 2;
            // 
            // bntAdd
            // 
            bntAdd.BackColor = Color.Green;
            bntAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAdd.ForeColor = Color.White;
            bntAdd.Location = new Point(455, 424);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(114, 42);
            bntAdd.TabIndex = 0;
            bntAdd.Text = "Create";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(238, -118);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 56);
            panel2.TabIndex = 30;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = Color.Navy;
            lblUserName.Location = new Point(546, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(68, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(361, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Dashboard\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 102);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 1;
            label4.Text = "Expense ID:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(dtpTime);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(dtpDate);
            panel6.Controls.Add(chkCurrentTime);
            panel6.Controls.Add(cboCategory);
            panel6.Controls.Add(btnClear);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(txtDescription);
            panel6.Controls.Add(asrer);
            panel6.Controls.Add(sd);
            panel6.Controls.Add(txtAmount);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtExpenseId);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(bntAdd);
            panel6.Location = new Point(119, 43);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 533);
            panel6.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 19);
            label8.Name = "label8";
            label8.Size = new Size(291, 45);
            label8.TabIndex = 17;
            label8.Text = "Add New Expense";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(400, 291);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 16;
            label7.Text = "Time:";
            // 
            // dtpTime
            // 
            dtpTime.CalendarForeColor = SystemColors.AppWorkspace;
            dtpTime.CalendarMonthBackground = Color.White;
            dtpTime.CustomFormat = "";
            dtpTime.Enabled = false;
            dtpTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(401, 315);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(289, 29);
            dtpTime.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 290);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 14;
            label6.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.CalendarForeColor = SystemColors.AppWorkspace;
            dtpDate.CalendarMonthBackground = Color.White;
            dtpDate.CustomFormat = "";
            dtpDate.Enabled = false;
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(31, 314);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(289, 29);
            dtpDate.TabIndex = 13;
            // 
            // chkCurrentTime
            // 
            chkCurrentTime.AutoSize = true;
            chkCurrentTime.Checked = true;
            chkCurrentTime.CheckState = CheckState.Checked;
            chkCurrentTime.Location = new Point(30, 257);
            chkCurrentTime.Name = "chkCurrentTime";
            chkCurrentTime.Size = new Size(101, 19);
            chkCurrentTime.TabIndex = 12;
            chkCurrentTime.Text = "Current Time?";
            chkCurrentTime.UseVisualStyleBackColor = true;
            chkCurrentTime.CheckedChanged += chkCurrentTime_CheckedChanged;
            // 
            // cboCategory
            // 
            cboCategory.BackColor = SystemColors.ScrollBar;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Maintenance", "Utility", "Fuel", "Miscellaneous", "Transport", "Owner" });
            cboCategory.Location = new Point(33, 212);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(287, 29);
            cboCategory.TabIndex = 11;
            // 
            // FormAddExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 616);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Expense";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClear;
        private TextBox txtDescription;
        private Label asrer;
        private Label sd;
        private Button btnCancel;
        private TextBox txtAmount;
        private Label label5;
        private TextBox txtExpenseId;
        private Button bntAdd;
        private Panel panel2;
        private Label lblUserName;
        private Label label1;
        private Label label4;
        private Panel panel6;
        private DateTimePicker dtpDate;
        private CheckBox chkCurrentTime;
        private ComboBox cboCategory;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpTime;
        private Label label8;
    }
}