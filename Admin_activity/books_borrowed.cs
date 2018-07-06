using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class books_borrowed : Form
    {
        public books_borrowed()
        {
            InitializeComponent();
        }

        void showRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = 100;   
        }
        

        Config o = new Config();
        void loadgrid(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry, o.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();            
            da.Fill(dt);           
            dataGridView1.DataSource = dt;
            showRows();

            da.Dispose();    
        }

        private void books_borrowed_Load(object sender, EventArgs e)
        {
            loadgrid("SELECT * FROM books");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                o.loadgrid("SELECT * FROM books WHERE title LIKE '%" + txtSearch.Text + "%' OR author LIKE '%" + txtSearch.Text + "%' OR publisher LIKE '%" + txtSearch.Text + "%' OR location LIKE '%" + txtSearch.Text + "%' OR year LIKE '%" + txtSearch.Text + "%' OR type LIKE '%" + txtSearch.Text + "%' OR isbn_no LIKE '%" + txtSearch.Text + "%' OR nr_inventory LIKE '%" + txtSearch.Text + "%'", dataGridView1);
                showRows();
            }
            else
            {
                o.loadgrid("SELECT * FROM books", dataGridView1);
                showRows();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
            book_users o = new book_users(id);
            o.MdiParent = this.MdiParent;
            o.Show();
        }
    }
}
