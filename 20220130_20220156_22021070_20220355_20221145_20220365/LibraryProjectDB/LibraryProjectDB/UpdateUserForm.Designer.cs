namespace LibraryManagmentSystem
{
    partial class UpdateUserForm
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
            this.Label0 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.NuserN = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.userNVal = new System.Windows.Forms.TextBox();
            this.NusernameVal = new System.Windows.Forms.TextBox();
            this.passVal = new System.Windows.Forms.TextBox();
            this.EmailVal = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.Location = new System.Drawing.Point(150, 55);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(143, 22);
            this.Label0.TabIndex = 0;
            this.Label0.Text = "Update details";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(27, 117);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 22);
            this.username.TabIndex = 1;
            this.username.Text = "Current user name";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NuserN
            // 
            this.NuserN.AutoSize = true;
            this.NuserN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuserN.Location = new System.Drawing.Point(27, 170);
            this.NuserN.Name = "NuserN";
            this.NuserN.Size = new System.Drawing.Size(153, 22);
            this.NuserN.TabIndex = 2;
            this.NuserN.Text = "New user name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(27, 221);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(95, 22);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(27, 269);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 22);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // userNVal
            // 
            this.userNVal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNVal.Location = new System.Drawing.Point(231, 117);
            this.userNVal.Name = "userNVal";
            this.userNVal.Size = new System.Drawing.Size(173, 30);
            this.userNVal.TabIndex = 5;
            this.userNVal.TextChanged += new System.EventHandler(this.userNVal_TextChanged);
            // 
            // NusernameVal
            // 
            this.NusernameVal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NusernameVal.Location = new System.Drawing.Point(231, 170);
            this.NusernameVal.Name = "NusernameVal";
            this.NusernameVal.Size = new System.Drawing.Size(173, 30);
            this.NusernameVal.TabIndex = 6;
            this.NusernameVal.TextChanged += new System.EventHandler(this.NusernameVal_TextChanged);
            // 
            // passVal
            // 
            this.passVal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passVal.Location = new System.Drawing.Point(231, 221);
            this.passVal.Name = "passVal";
            this.passVal.Size = new System.Drawing.Size(173, 30);
            this.passVal.TabIndex = 7;
            // 
            // EmailVal
            // 
            this.EmailVal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailVal.Location = new System.Drawing.Point(231, 269);
            this.EmailVal.Name = "EmailVal";
            this.EmailVal.Size = new System.Drawing.Size(173, 30);
            this.EmailVal.TabIndex = 8;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(248, 323);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(137, 36);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(31, 330);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(76, 29);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 51);
            this.panel1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(10, 379);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 18);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back to menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 23);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(542, 509);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.username);
            this.Controls.Add(this.NuserN);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.userNVal);
            this.Controls.Add(this.NusernameVal);
            this.Controls.Add(this.passVal);
            this.Controls.Add(this.EmailVal);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Clear);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label NuserN;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox userNVal;
        private System.Windows.Forms.TextBox NusernameVal;
        private System.Windows.Forms.TextBox passVal;
        private System.Windows.Forms.TextBox EmailVal;

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


