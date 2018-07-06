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
    public partial class your_account : Form
    {
        public your_account(string id)
        {        
            InitializeComponent();
            lblID.Text = id;
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

        Config op = new Config();
        private void your_account_Load(object sender, EventArgs e)
        {
            loadData(lblID.Text);
            string str1 = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE users.id = " + lblID.Text;
            SqlCommand cmd1 = new SqlCommand(str1, op.con);
            int a = (Int32)cmd1.ExecuteScalar();

            if (a != 0)
            {
                loadgrid("SELECT books.id, book_inventory.datetime, books.title, books.author, books.publisher, books.location, books.year, books.type, books.nr_inventory, books.image FROM books RIGHT JOIN book_inventory ON books.id = book_inventory.book_id RIGHT JOIN users ON book_inventory.user_id = users.id WHERE users.id =" + lblID.Text);
            }
            else
            {
                lblNo_Borrow_book.Show();
            }
        }
    }
}



  
