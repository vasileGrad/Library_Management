using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Library_Management.user_borrow_return_books;

namespace Library_Management
{
    public partial class borrow_books : Form
    {
        public borrow_books()
        {
            InitializeComponent();
        }

        public static class BookInfo   //  ca un fel de  session["BookId"]=id;
        {
            public static string BookId;
        }

        protected void showRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = 100;   
        }
        

        Config o = new Config();
        protected void loadgrid(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry, o.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();            
            da.Fill(dt);           
            dataGridView1.DataSource = dt;
            showRows();

            da.Dispose();    
        }

        private void update_books_Load(object sender, EventArgs e)
        {
            loadgrid("SELECT * FROM books where available='true' and nr_free!=0");
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch1.Text != "")
            {
                o.loadgrid("SELECT * FROM books WHERE title LIKE '%" + txtSearch1.Text + "%' OR author LIKE '%" + txtSearch1.Text + "%' OR publisher LIKE '%" + txtSearch1.Text + "%' OR location LIKE '%" + txtSearch1.Text + "%' OR year LIKE '%" + txtSearch1.Text + "%' OR type LIKE '%" + txtSearch1.Text + "%' OR isbn_no LIKE '%" + txtSearch1.Text + "%' OR nr_inventory LIKE '%" + txtSearch1.Text + "%'", dataGridView1);
                showRows();
            }
            else
            {
                o.loadgrid("SELECT * FROM books", dataGridView1);
                showRows();
            }
        }


        Config op = new Config();
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookInfo.BookId= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string str1 = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE users.id = " + UserInfo.UserId +" and book_id= "+ BookInfo.BookId ;
            SqlCommand cmd1 = new SqlCommand(str1, op.con);
            int a = (Int32)cmd1.ExecuteScalar();
                if (a == 1)
                {
                    MessageBox.Show("You cannot borrow more that one example from this book!");
                }
                else
                {
                    this.Hide();
                    borrow_question o = new borrow_question();
                    o.MdiParent = this.MdiParent;
                    o.Show();
                }       
        }       
    }
}
