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
    public partial class user_borrow_return_books : Form
    {
        public static class UserInfo
        {
            public static string UserId;
        }

        public user_borrow_return_books(string id)
        {        
            InitializeComponent();
            lblID.Text = id;
            UserInfo.UserId = lblID.Text;
        } 

        Config o = new Config();
        void loadData(string id)
        {
            try
            {
                string str = "SELECT * FROM users WHERE id=" + id;
                string str1 = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE users.id = " + lblID.Text;
                SqlCommand cmd = new SqlCommand(str, o.con);               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommand cmd1 = new SqlCommand(str1, o.con);
                int a = (Int32)cmd1.ExecuteScalar();

                DataTable dt = new DataTable();
                da.Fill(dt);
                lblF_Name_Text.Text = dt.Rows[0][1].ToString();
                lblL_Name_Text.Text = dt.Rows[0][2].ToString();
                lblRoll_Id_Text.Text = dt.Rows[0][10].ToString();
                lblCategory_Text.Text = dt.Rows[0][5].ToString();
                lblBorrowed_Books_Text.Text= a.ToString();
                byte[] img = (byte[])dt.Rows[0][12];
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

        private void user_borrow_return_books_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            borrow_return_books b = new borrow_return_books(); 
            b.MdiParent = this.MdiParent;
            b.Show();
        }

        Config op = new Config();
        private void user_borrow_return_books_Load(object sender, EventArgs e)
        {
            loadData(lblID.Text);
            string str1 = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE users.id = " + lblID.Text;
            SqlCommand cmd1 = new SqlCommand(str1, op.con);
            int a = (Int32)cmd1.ExecuteScalar();

            if (a != 0)
            {
                loadgrid("SELECT books.title, books.author, books.publisher, books.location, books.year, books.type, books.nr_inventory, books.image FROM books RIGHT JOIN book_inventory ON books.id = book_inventory.book_id RIGHT JOIN users ON book_inventory.user_id = users.id WHERE users.id =" + lblID.Text);
            }
            else
            {
                lblNo_Borrow_book.Show();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(lblBorrowed_Books_Text.Text);
            if (Convert.ToInt32(lblBorrowed_Books_Text.Text) < 3)
            {
                this.Hide();
                borrow_books o = new borrow_books();
                o.MdiParent = this.MdiParent;
                o.Show();
            }
            else
                MessageBox.Show("You have already borrowed 3 books!");    
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(lblBorrowed_Books_Text.Text);
            if (nr == 0)
            {        
                MessageBox.Show("You have no books borrowed!");
            }
            else
            {
                this.Hide();
                return_books o = new return_books();
                o.MdiParent = this.MdiParent;
                o.Show();
            }
        }
    }
}



  
