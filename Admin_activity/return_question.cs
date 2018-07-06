using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Library_Management.borrow_books;
using static Library_Management.user_borrow_return_books;

namespace Library_Management
{
    public partial class return_question : Form 
    {
        public return_question()
        {
            InitializeComponent();
        }

        Config config = new Config();
        private void btnYes_Click(object sender, EventArgs e)
        {
            string qry = "delete from book_inventory where book_id=" +BookInfo.BookId+ "and user_id="+UserInfo.UserId;
            SqlCommand cmd = new SqlCommand(qry, config.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();

            string str1 = "select nr_free from books where id= " + BookInfo.BookId;
            SqlCommand cmd1 = new SqlCommand(str1, config.con);
            int a = (Int32)cmd1.ExecuteScalar();

            if (a == 0)
            {
                string str2 = "update books set available='true', nr_free=nr_free+1, nr_borrowed=nr_borrowed-1 where id=" + BookInfo.BookId;
                SqlCommand cmd2 = new SqlCommand(str2, config.con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                da2.Dispose();
            }
            else
            {
                string str3 = "update books set nr_free = nr_free+1, nr_borrowed = nr_borrowed - 1 where id = " + BookInfo.BookId;
                SqlCommand cmd3 = new SqlCommand(str3, config.con);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                da3.Dispose();
            }

            this.Hide();
            user_borrow_return_books o = new user_borrow_return_books(UserInfo.UserId);
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            return_books o = new return_books();
            this.Hide();
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        private void borrow_question_FormClosing(object sender, FormClosingEventArgs e)
        {
            return_books o = new return_books();
            this.Hide();
            o.MdiParent = this.MdiParent;
            o.Show();
        }
    }
    
}
