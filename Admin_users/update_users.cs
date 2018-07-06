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
    public partial class update_users : Form
    {
        public update_users()
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

        string qry_str = "SELECT  id, first_name, last_name, email, category, gender, birthday, mobile, address, residence, roll_nr, image  FROM users";
        private void update_users_Load(object sender, EventArgs e)
        {
            loadgrid(qry_str);
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
                o.loadgrid(qry_str, dataGridView1);
                showRows();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
            view_update_users o = new view_update_users(id);
            o.MdiParent = this.MdiParent;
            o.Show();
        }
    }
}
