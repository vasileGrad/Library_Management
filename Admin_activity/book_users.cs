using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management
{
    public partial class book_users : Form
    {

        public book_users(string id)
        {        
            InitializeComponent();
            lblID.Text = id;
        }

        Config o = new Config();
               
        void loadData(string id)
        {
            try
            {
                string str = "SELECT * FROM books WHERE id=" + id;
                string str1 = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE books.id = " + id;
                SqlCommand cmd = new SqlCommand(str, o.con);               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommand cmd1 = new SqlCommand(str1, o.con);
                int a = (Int32)cmd1.ExecuteScalar();
                DataTable dt = new DataTable();
                da.Fill(dt);
                lblTitle_Text.Text = dt.Rows[0][1].ToString();
                lblAuthor_Text.Text = dt.Rows[0][2].ToString();
                lblPublisher_Text.Text = dt.Rows[0][3].ToString();
                lblLocation_Text.Text = dt.Rows[0][4].ToString();
                lblYear_Text.Text = dt.Rows[0][5].ToString();
                lblBorrowed_Books_Text.Text= a.ToString();
                byte[] img = (byte[])dt.Rows[0][14];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (o.con.State == ConnectionState.Open)
                {
                    o.con.Close();
                }
            }
        }

        void showRows()
        {
            foreach (DataGridViewRow row in dataGridViewBorrow_Return_Book.Rows)
                row.Height = 100;
        }


        void loadgrid(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry, op.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBorrow_Return_Book.DataSource = dt;
            showRows();
            //da.Dispose();
        }

        Config op = new Config();
        private void book_users_Load(object sender, EventArgs e)
        {
            loadData(lblID.Text);
            string str1 = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE books.id = " + lblID.Text;
            SqlCommand cmd1 = new SqlCommand(str1, op.con);
            int a = (Int32)cmd1.ExecuteScalar();

            if (a != 0)
            {
                loadgrid("SELECT users.id, book_inventory.datetime, users.first_name, users.last_name, users.email, users.category, users.roll_nr, users.image FROM users left JOIN book_inventory ON users.id = book_inventory.user_id left JOIN books ON book_inventory.book_id = books.id WHERE book_id =" + lblID.Text +" order by users.id");
            }
            else
            {
                lblNo_Borrow_book.Show();
            }
        }
        private void book_users_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            books_borrowed b = new books_borrowed(); 
            b.MdiParent = this.MdiParent;
            b.Show();
        }

    }
}



  
