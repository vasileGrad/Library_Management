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
    public partial class user_home : Form
    {
        public user_home(string a, int id_user)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome " + a;
            lblId_User.Text = id_user.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
        private void yourAccountToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            your_account acc = new your_account(lblId_User.Text);
            //acc.MdiParent = this;
            acc.Show();
        }

        private void viewBookstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            view_books a = new view_books();
            //a.MdiParent = this;
            a.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_password cp = new change_password(lblId_User.Text);
            cp.MdiParent = this;
            cp.Show();
        }

        private void user_home_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
