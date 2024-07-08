using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    partial class UpdateBookForm
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
            this.Backlink = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.ISBNVal = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.Label();
            this.publisherval = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.Authorvar = new System.Windows.Forms.TextBox();
            this.PDate = new System.Windows.Forms.Label();
            this.PDateval = new System.Windows.Forms.DateTimePicker();
            this.priceL = new System.Windows.Forms.Label();
            this.PriceVal = new System.Windows.Forms.DomainUpDown();
            this.category = new System.Windows.Forms.Label();
            this.categoryval = new System.Windows.Forms.ComboBox();
            this.UpdateBookBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Backlink
            // 
            this.Backlink.AutoSize = true;
            this.Backlink.LinkColor = System.Drawing.Color.Black;
            this.Backlink.Location = new System.Drawing.Point(12, 12);
            this.Backlink.Name = "Backlink";
            this.Backlink.Size = new System.Drawing.Size(50, 15);
            this.Backlink.TabIndex = 0;
            this.Backlink.TabStop = true;
            this.Backlink.Text = "Go Back";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.Label1.Location = new System.Drawing.Point(415, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 27);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Update Book";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.BookTitle.Location = new System.Drawing.Point(44, 186);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(119, 27);
            this.BookTitle.TabIndex = 2;
            this.BookTitle.Text = "Book Title";
            this.BookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(204, 182);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(216, 36);
            this.Title.TabIndex = 3;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ISBN.Location = new System.Drawing.Point(49, 250);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(59, 27);
            this.ISBN.TabIndex = 4;
            this.ISBN.Text = "ISBN";
            // 
            // ISBNVal
            // 
            this.ISBNVal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNVal.Location = new System.Drawing.Point(203, 245);
            this.ISBNVal.Name = "ISBNVal";
            this.ISBNVal.Size = new System.Drawing.Size(216, 36);
            this.ISBNVal.TabIndex = 5;
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.publisher.Location = new System.Drawing.Point(49, 315);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(115, 27);
            this.publisher.TabIndex = 6;
            this.publisher.Text = "publisher";
            // 
            // publisherval
            // 
            this.publisherval.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherval.Location = new System.Drawing.Point(203, 315);
            this.publisherval.Name = "publisherval";
            this.publisherval.Size = new System.Drawing.Size(216, 36);
            this.publisherval.TabIndex = 7;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.AuthorLabel.Location = new System.Drawing.Point(49, 382);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(87, 27);
            this.AuthorLabel.TabIndex = 8;
            this.AuthorLabel.Text = "Author";
            // 
            // Authorvar
            // 
            this.Authorvar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorvar.Location = new System.Drawing.Point(203, 382);
            this.Authorvar.Name = "Authorvar";
            this.Authorvar.Size = new System.Drawing.Size(216, 36);
            this.Authorvar.TabIndex = 9;
            // 
            // PDate
            // 
            this.PDate.AutoSize = true;
            this.PDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.PDate.Location = new System.Drawing.Point(481, 180);
            this.PDate.Name = "PDate";
            this.PDate.Size = new System.Drawing.Size(188, 27);
            this.PDate.TabIndex = 10;
            this.PDate.Text = "Publishing Date";
            // 
            // PDateval
            // 
            this.PDateval.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            this.PDateval.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDateval.Location = new System.Drawing.Point(682, 175);
            this.PDateval.Name = "PDateval";
            this.PDateval.Size = new System.Drawing.Size(257, 36);
            this.PDateval.TabIndex = 13;
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.priceL.Location = new System.Drawing.Point(520, 331);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(69, 27);
            this.priceL.TabIndex = 14;
            this.priceL.Text = "Price";
            // 
            // PriceVal
            // 
            this.PriceVal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceVal.Location = new System.Drawing.Point(674, 331);
            this.PriceVal.Name = "PriceVal";
            this.PriceVal.Size = new System.Drawing.Size(265, 36);
            this.PriceVal.TabIndex = 16;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.category.Location = new System.Drawing.Point(507, 254);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(120, 27);
            this.category.TabIndex = 17;
            this.category.Text = "Category";
            // 
            // categoryval
            // 
            this.categoryval.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryval.ItemHeight = 27;
            this.categoryval.Location = new System.Drawing.Point(676, 250);
            this.categoryval.Name = "categoryval";
            this.categoryval.Size = new System.Drawing.Size(263, 35);
            this.categoryval.TabIndex = 19;
            // 
            // UpdateBookBtn
            // 
            this.UpdateBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.UpdateBookBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBookBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBookBtn.Location = new System.Drawing.Point(725, 434);
            this.UpdateBookBtn.Name = "UpdateBookBtn";
            this.UpdateBookBtn.Size = new System.Drawing.Size(153, 65);
            this.UpdateBookBtn.TabIndex = 21;
            this.UpdateBookBtn.Text = "Update Book";
            this.UpdateBookBtn.UseVisualStyleBackColor = false;
            this.UpdateBookBtn.Click += new System.EventHandler(this.UpdateBookBtn_Click_1);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.Clear.Location = new System.Drawing.Point(189, 454);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(144, 45);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 76);
            this.panel1.TabIndex = 23;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(12, 81);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 22);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back to menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateBookForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 25);
            this.AutoScrollMargin = new System.Drawing.Size(16, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1021, 569);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.ISBNVal);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.publisherval);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.Authorvar);
            this.Controls.Add(this.PDate);
            this.Controls.Add(this.PDateval);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.PriceVal);
            this.Controls.Add(this.category);
            this.Controls.Add(this.categoryval);
            this.Controls.Add(this.UpdateBookBtn);
            this.Controls.Add(this.Clear);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateBookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdateBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox ISBNVal;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.TextBox publisherval;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox Authorvar;
        private System.Windows.Forms.Label PDate;
        private System.Windows.Forms.DateTimePicker PDateval;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.DomainUpDown PriceVal;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox categoryval;
        private System.Windows.Forms.Button UpdateBookBtn;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.LinkLabel Backlink;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}

