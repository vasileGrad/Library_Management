using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class admin_home : Form
    {
        public admin_home(string a, int id)
        {
            InitializeComponent();
            lblMessage.Text = "Welcome " + a;
            lblID.Text = id.ToString();
            timer1.Start();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_books a = new add_books();
            a.MdiParent = this;
            a.Show();
        }

        private void searchBookstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            search_books a = new search_books();
            //a.MdiParent = this;
            a.Show();
        }

        private void updateBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_books b = new update_books();
            //b.MdiParent = this;
            b.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            toolStripTextBox1.Text = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_users b = new add_users();
            b.MdiParent = this;
            b.Show();
        }

        private void updateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_users u = new update_users();
            u.Show();
        }

        private void deleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_users u = new delete_users();
            //u.MdiParent = this;
            u.Show();
        }
        private void toolStripMenuDelete_Books_Click(object sender, EventArgs e)
        {
            delete_books u = new delete_books();
            //u.MdiParent = this;
            u.Show();
        }

        private void admin_home_Load(object sender, EventArgs e)
        {

        }

        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrow_return_books u = new borrow_return_books();
            //u.MdiParent = this;
            u.Show();
        }
        private void booksBorrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            books_borrowed u = new books_borrowed();
            //u.MdiParent = this;
            u.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            change_password_admin pass = new change_password_admin(lblID.Text);
            //pass.MdiParent = this;
            pass.Show();
        }

        private void admin_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                MessageBox.Show("Please close all open windows!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                MessageBox.Show("Please close open windows!");
            }
        }
    }
}
