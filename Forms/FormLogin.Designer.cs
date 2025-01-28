using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Forms
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            chkShowPass = new CheckBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(196, 232, 255);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(chkShowPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPhone);
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(575, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 702);
            panel1.TabIndex = 2;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Cursor = Cursors.Hand;
            chkShowPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            chkShowPass.Location = new Point(86, 322);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(138, 25);
            chkShowPass.TabIndex = 12;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(111, 569);
            label4.Name = "label4";
            label4.Size = new Size(381, 20);
            label4.TabIndex = 11;
            label4.Text = "**Please contact with an admin for Login Credentials.";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtPassword.Location = new Point(86, 284);
            txtPassword.Margin = new Padding(10, 19, 89, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Enter Your Password";
            txtPassword.Size = new Size(437, 32);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(83, 252);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(83, 170);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 40F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(77, 36);
            label1.Name = "label1";
            label1.Size = new Size(179, 72);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(49, 108, 181);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(86, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(437, 52);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Info;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtPhone.Location = new Point(86, 199);
            txtPhone.Margin = new Padding(10, 19, 89, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter Your Phone";
            txtPhone.Size = new Size(437, 32);
            txtPhone.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new System.Drawing.Font("Segoe UI Black", 42F, FontStyle.Bold);
            label5.Location = new Point(57, 360);
            label5.Name = "label5";
            label5.Size = new Size(455, 74);
            label5.TabIndex = 3;
            label5.Text = "MANAGEMENT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new System.Drawing.Font("Segoe UI Black", 33F, FontStyle.Bold);
            label6.Location = new Point(311, 240);
            label6.Name = "label6";
            label6.Size = new Size(195, 60);
            label6.TabIndex = 4;
            label6.Text = "FILLING";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new System.Drawing.Font("Segoe UI Black", 33F, FontStyle.Bold);
            label7.Location = new Point(282, 300);
            label7.Name = "label7";
            label7.Size = new Size(224, 60);
            label7.TabIndex = 5;
            label7.Text = "STATION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1184, 701);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN ";
            TransparencyKey = Color.WhiteSmoke;
            FormClosing += FormLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txtPhone;
        private Label label1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkShowPass;
        private Label label7;
        private PictureBox pictureBox1;
    }
}
