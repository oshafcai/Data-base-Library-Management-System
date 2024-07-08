namespace LibraryManagementSystem
{
    partial class menuAdmin
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(155, 85);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(143, 27);
            this.mainLabel.TabIndex = 11;
            this.mainLabel.Text = "Main Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 72);
            this.panel1.TabIndex = 10;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBookBtn.Location = new System.Drawing.Point(108, 168);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(219, 51);
            this.addBookBtn.TabIndex = 12;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // editBookBtn
            // 
            this.editBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.editBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBookBtn.Location = new System.Drawing.Point(42, 247);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(167, 51);
            this.editBookBtn.TabIndex = 13;
            this.editBookBtn.Text = "Edit Book";
            this.editBookBtn.UseVisualStyleBackColor = false;
            this.editBookBtn.Click += new System.EventHandler(this.editBookBtn_Click);
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.editUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editUserBtn.Location = new System.Drawing.Point(42, 324);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(167, 51);
            this.editUserBtn.TabIndex = 15;
            this.editUserBtn.Text = "Edit User";
            this.editUserBtn.UseVisualStyleBackColor = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(160, 398);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(105, 47);
            this.logoutBtn.TabIndex = 16;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(225, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(225, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 51);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(443, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.editUserBtn);
            this.Controls.Add(this.editBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuAdmin";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}