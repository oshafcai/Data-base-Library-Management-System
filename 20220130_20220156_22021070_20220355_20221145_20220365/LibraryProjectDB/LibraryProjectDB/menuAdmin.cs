using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagmentSystem;

namespace LibraryManagementSystem
{
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.Show();
            this.Hide();
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            UpdateBookForm update = new UpdateBookForm();
            update.Show();
            this.Hide();
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            UpdateUserForm update = new UpdateUserForm();
            update.Show();
            this.Hide();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBookAdmin ab = new addBookAdmin();
            ab.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteBook deleteBook = new deleteBook();
            deleteBook.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteStudent deleteStudent = new deleteStudent();
            deleteStudent.Show();
            this.Hide();
        }
    }
}