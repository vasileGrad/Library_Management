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
    public partial class view_update_books : Form
    {
        public view_update_books(string id)
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
                txtTitle.Text = dt.Rows[0][1].ToString();
                txtAuthor.Text = dt.Rows[0][2].ToString();
                txtPublisher.Text = dt.Rows[0][3].ToString();
                txtLocation.Text = dt.Rows[0][4].ToString();
                numYear.Text = dt.Rows[0][5].ToString();
                comType.Text = dt.Rows[0][6].ToString();
                numVolumes.Text = dt.Rows[0][7].ToString();
                numBooks.Text = dt.Rows[0][8].ToString();
                comAvailable.Text = dt.Rows[0][9].ToString();
                numFree_Books.Text = dt.Rows[0][10].ToString();
                numBorrowed_Books.Text = dt.Rows[0][11].ToString();
                txtISBN_NO.Text = dt.Rows[0][12].ToString();
                txtInventory.Text = dt.Rows[0][13].ToString();
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

        private void view_update_books_Load(object sender, EventArgs e)
        {
            loadData(lblID.Text);  
        }

        string img_file = null;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtAuthor.Text != "" && txtPublisher.Text != "" && txtLocation.Text != "" && numYear.Text != "" && comType.SelectedIndex != -1 && numVolumes.Text != "-1" && numBooks.Text != "-1" && comAvailable.Text != "-1" && numFree_Books.Text != "-1" && numBorrowed_Books.Text != "-1" && txtISBN_NO.Text != "" && txtInventory.Text != "")
            {
                try
                {
                    o.con.Open();
                    if (img_file != null)
                    {
                        FileStream fs1 = new FileStream(img_file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        byte[] image = new byte[fs1.Length];
                        fs1.Read(image, 0, Convert.ToInt32(fs1.Length));
                        fs1.Close();
                        string sql = "UPDATE books SET title='" + txtTitle.Text + "', author='" + txtAuthor.Text + "', publisher='" + txtPublisher.Text + "', location='" + txtLocation.Text + "', year='" + numYear.Text + "', type='" + comType.Text + "', volumes='" + numVolumes.Text + "', nr_books='" + numBooks.Text + "', available='" + comAvailable.Text + "', nr_free='" + numFree_Books.Text + "', nr_borrowed='" + numBorrowed_Books.Text + "', isbn_no='" + txtISBN_NO.Text + "', nr_inventory='" + txtInventory.Text + "', image= @pic WHERE id=" + lblID.Text + "";
                        SqlCommand cmd = new SqlCommand(sql, o.con);
                        SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                        cmd.Parameters.Add(prm);
                        cmd.ExecuteNonQuery();

                        lblMessage.ForeColor = Color.Green;
                        lblMessage.Text = "User details updated!";

                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Please Upload Image!";
                    }

                    //lblMessage.ForeColor = Color.Green;
                    //lblMessage.Text = "User details updated!";
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
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Please Enter All the Details!";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() != DialogResult.Cancel)
            {
                img_file = o.FileName;
                pictureBox1.Image = Image.FromFile(o.FileName);
            }
        }

        private void view_update_books_FormClosing(object sender, FormClosingEventArgs e)
        {
            update_books o = new update_books();
            o.MdiParent = this.MdiParent;
            o.Show();
        }
        
    }
}
