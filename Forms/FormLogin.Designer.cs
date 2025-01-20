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
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(196, 232, 255);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtUsername);
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(474, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 621);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(61, 507);
            label4.Name = "label4";
            label4.Size = new Size(359, 20);
            label4.TabIndex = 11;
            label4.Text = "**Please contact with an admin for Login Credentials.";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(43, 257);
            textBox1.Margin = new Padding(10, 19, 89, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Enter Your Password";
            textBox1.Size = new Size(397, 29);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 230);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 166);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(160, 65);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(49, 108, 181);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(43, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(396, 44);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(43, 187);
            txtUsername.Margin = new Padding(10, 19, 89, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " e.g. +8801610137675";
            txtUsername.Size = new Size(397, 29);
            txtUsername.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new System.Drawing.Font("Segoe UI Black", 42F, FontStyle.Bold);
            label5.Location = new Point(31, 313);
            label5.Name = "label5";
            label5.Size = new Size(416, 74);
            label5.TabIndex = 3;
            label5.Text = "CHOWDHURY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new System.Drawing.Font("Segoe UI Black", 33F, FontStyle.Bold);
            label6.Location = new Point(36, 387);
            label6.Name = "label6";
            label6.Size = new Size(406, 60);
            label6.TabIndex = 4;
            label6.Text = "FILLING STATION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(954, 616);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN ";
            TransparencyKey = Color.WhiteSmoke;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txtUsername;
        private Label label1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
