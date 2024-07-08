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
    public partial class menuUser : Form
    {
        public menuUser()
        {
            InitializeComponent();
        }




        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.Show();
            this.Hide();
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            borrowBook newForm = new borrowBook();
            newForm.Show();
            this.Hide();
        }

        private void browseBookBtn_Click(object sender, EventArgs e)
        {
            browseBooks newForm = new browseBooks();
            newForm.Show();
            this.Hide();
        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            UpdateUserForm update = new UpdateUserForm();
            update.Show();
            this.Hide();
        }

        private void menuUser_Load(object sender, EventArgs e)
        {

        }
    }
}