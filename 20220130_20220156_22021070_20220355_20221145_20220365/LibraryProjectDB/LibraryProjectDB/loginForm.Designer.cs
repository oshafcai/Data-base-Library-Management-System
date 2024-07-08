using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class loginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signup_in_login = new System.Windows.Forms.Button();
            this.fillAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 93);
            this.panel1.TabIndex = 0;
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(95, 199);
            this.usernameText.Margin = new System.Windows.Forms.Padding(5);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(269, 36);
            this.usernameText.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 336);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 36);
            this.textBox2.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AccessibleName = "";
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(170, 156);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(126, 27);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // passwordText
            // 
            this.passwordText.AccessibleName = "";
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(176, 246);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(118, 27);
            this.passwordText.TabIndex = 5;
            this.passwordText.Text = "Password";
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.White;
            this.passField.Location = new System.Drawing.Point(95, 291);
            this.passField.Margin = new System.Windows.Forms.Padding(5);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(269, 36);
            this.passField.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(170, 347);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(123, 40);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPass.Location = new System.Drawing.Point(161, 409);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(184, 27);
            this.checkBoxPass.TabIndex = 9;
            this.checkBoxPass.Text = "show password";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Don\'t have account ? ";
            // 
            // signup_in_login
            // 
            this.signup_in_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.signup_in_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_in_login.Location = new System.Drawing.Point(300, 471);
            this.signup_in_login.Name = "signup_in_login";
            this.signup_in_login.Size = new System.Drawing.Size(123, 40);
            this.signup_in_login.TabIndex = 11;
            this.signup_in_login.Text = "SignUp";
            this.signup_in_login.UseVisualStyleBackColor = false;
            this.signup_in_login.Click += new System.EventHandler(this.signup_in_login_Click_1);
            // 
            // fillAll
            // 
            this.fillAll.AccessibleName = "";
            this.fillAll.AutoSize = true;
            this.fillAll.ForeColor = System.Drawing.Color.Red;
            this.fillAll.Location = new System.Drawing.Point(131, 437);
            this.fillAll.Name = "fillAll";
            this.fillAll.Size = new System.Drawing.Size(258, 27);
            this.fillAll.TabIndex = 12;
            this.fillAll.Text = "All fields are required!";
            this.fillAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(469, 530);
            this.Controls.Add(this.fillAll);
            this.Controls.Add(this.signup_in_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup_in_login;
        private Label fillAll;
    }
}
