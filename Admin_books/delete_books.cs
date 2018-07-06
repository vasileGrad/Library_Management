using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Library_Management.borrow_books;

namespace Library_Management
{
    public partial class delete_books : Form
    {
        SqlCommandBuilder builder;
        SqlDataAdapter da;
        DataSet ds;

        public delete_books()
        {
            InitializeComponent();
        }

        void showRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = 100;
        }

        Config conf = new Config();
        private void delete_books_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Name = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;

            ds = new DataSet();
            da = new SqlDataAdapter("SELECT * FROM books", conf.con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            showRows();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                conf.loadgrid("SELECT * FROM books WHERE title LIKE '%" + txtSearch.Text + "%' OR author LIKE '%" + txtSearch.Text + "%' OR publisher LIKE '%" + txtSearch.Text + "%' OR location LIKE '%" + txtSearch.Text + "%' OR year LIKE '%" + txtSearch.Text + "%' OR type LIKE '%" + txtSearch.Text + "%' OR isbn_no LIKE '%" + txtSearch.Text + "%' OR nr_inventory LIKE '%" + txtSearch.Text + "%'", dataGridView1);
                showRows();
            }
            else
            {
                conf.loadgrid("SELECT * FROM books", dataGridView1);
                showRows();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookInfo.BookId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                if ((MessageBox.Show(" Confirm Delete? ", " Delete ", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Please click Update to delete the book !");
                }
            }
        }

        Config config = new Config();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE book_id = " + BookInfo.BookId;
            SqlCommand cmd = new SqlCommand(str, config.con);
            int a = (Int32)cmd.ExecuteScalar();
            if (a == 0)
            {
                try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Data Updated!");
                delete_books o = new delete_books();
                this.Hide();
                o.MdiParent = this.MdiParent;
                o.Show();
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                this.Hide();
                MessageBox.Show("You can't delete this book because it is borrowed by "+a+" person(s)!");
                delete_books o = new delete_books();
                o.MdiParent = this.MdiParent;
                o.Show();
            }
        }
    }
}


    



    
   



