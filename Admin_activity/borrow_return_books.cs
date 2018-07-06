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
    public partial class borrow_return_books : Form
    {
        public borrow_return_books()
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

        private void borrow_return_books_Load(object sender, EventArgs e)
        {
            loadgrid("SELECT id, first_name, last_name, email, category, gender, birthday, mobile, address, residence, roll_nr, image  FROM users");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                o.loadgrid("SELECT * FROM users WHERE first_name LIKE '%" + txtSearch.Text + "%' OR last_name LIKE '%" + txtSearch.Text + "%' OR email LIKE '%" + txtSearch.Text + "%' OR birthday LIKE '%" + txtSearch.Text + "%' OR mobile LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%' OR residence LIKE '%" + txtSearch.Text + "%' OR roll_nr LIKE '%" + txtSearch.Text + "%'", dataGridView1);
                showRows();
            }
            else
            {
                o.loadgrid("SELECT id, first_name, last_name, email, category, gender, birthday, mobile, address, residence, roll_nr, image  FROM users", dataGridView1);
                showRows();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
            user_borrow_return_books o = new user_borrow_return_books(id);
            o.MdiParent = this.MdiParent;
            o.Show();
        }
    }
}
