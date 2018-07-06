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
using static Library_Management.borrow_books;

namespace Library_Management
{
    public partial class return_books : Form
    {
        public return_books()
        {
            InitializeComponent();
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
            loadgrid("SELECT books.id, books.title, books.author, books.publisher, books.location, books.year, books.type, books.nr_inventory, books.image FROM books RIGHT JOIN book_inventory ON books.id = book_inventory.book_id RIGHT JOIN users ON book_inventory.user_id = users.id WHERE users.id = " + UserInfo.UserId);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookInfo.BookId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            this.Hide();
            return_question o = new return_question();
            o.MdiParent = this.MdiParent;
            o.Show();
        }

        private void return_books_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            user_borrow_return_books op = new user_borrow_return_books(UserInfo.UserId);
            op.MdiParent = this.MdiParent;
            op.Show();
        }
    }
}


