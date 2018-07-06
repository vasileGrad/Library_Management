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
    public partial class view_details_books : Form
    {
        public view_details_books(string id)
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
                SqlCommand cmd = new SqlCommand(str, o.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lblTitle_Text.Text = dt.Rows[0][1].ToString();
                lblAuthor_Text.Text = dt.Rows[0][2].ToString();
                lblPublisher_Text.Text = dt.Rows[0][3].ToString();
                lblLocation_Text.Text = dt.Rows[0][4].ToString();
                lblYear_Text.Text = dt.Rows[0][5].ToString();
                lblType_Text.Text = dt.Rows[0][6].ToString();
                lblVolumes_Text.Text = dt.Rows[0][7].ToString();
                lblNr_Books_Text.Text = dt.Rows[0][8].ToString();
                lblAvailable_Text.Text = dt.Rows[0][9].ToString();
                lblFree_Books_Text.Text = dt.Rows[0][10].ToString();
                lblBorrowed_Text.Text = dt.Rows[0][11].ToString();
                lblISBN_NO_Text.Text = dt.Rows[0][12].ToString();
                lblNr_Inventory_Text.Text = dt.Rows[0][13].ToString();
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

        private void view_details_books_Load(object sender, EventArgs e)
        {
            loadData(lblID.Text);  
        }

        private void view_details_books_FormClosing(object sender, FormClosingEventArgs e)
        {
            view_books o = new view_books();
            //o.MdiParent = this.MdiParent;
            o.Show();
        }
        
    }
}
