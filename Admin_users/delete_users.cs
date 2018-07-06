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
    public partial class delete_users : Form
    {
        SqlCommandBuilder builder;
        SqlDataAdapter da;
        DataSet ds;

        public delete_users()
        {
            InitializeComponent();
        }

        void showRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = 100;
        }

        Config o = new Config();
        string qry_str = "SELECT  id, first_name, last_name, email, category, gender, birthday, mobile, address, residence, roll_nr, image  FROM users";
        private void delete_users_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Name = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;

            ds = new DataSet();
            da = new SqlDataAdapter(qry_str, o.con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            showRows();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                o.loadgrid("SELECT * FROM users WHERE first_name LIKE '%" + txtSearch.Text + "%' OR last_name LIKE '%" + txtSearch.Text + "%' OR email LIKE '%" + txtSearch.Text + "%' OR birthday LIKE '%" + txtSearch.Text + "%' OR mobile LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%' OR residence LIKE '%" + txtSearch.Text + "%' OR roll_nr LIKE '%" + txtSearch.Text + "%'", dataGridView1);
                showRows();
            }
            else
            {
                o.loadgrid(qry_str, dataGridView1);
                showRows();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserInfo.UserId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                if ((MessageBox.Show(" Confirm Delete? ", " Delete ", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Data Deleted!  Please click Update !");
                }
            }
        }

        Config config = new Config();
        private void Update_Click(object sender, EventArgs e)
        {
            string str = "SELECT COUNT(*) FROM books INNER JOIN book_inventory ON books.id = book_inventory.book_id INNER JOIN users ON book_inventory.user_id = users.id WHERE users.id = " + UserInfo.UserId;
            SqlCommand cmd = new SqlCommand(str, config.con);
            int a = (Int32)cmd.ExecuteScalar();
            if (a == 0)
            {
                try
                {
                    da.Update(ds.Tables[0]);
                    MessageBox.Show("Data Updated!");
                    delete_users o = new delete_users();
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
                MessageBox.Show("You can't delete this user because he has "+ a +" book(s) borrowed!");
                delete_users o = new delete_users();
                o.MdiParent = this.MdiParent;
                o.Show();
            }
        }
    }
}


    



    
   



