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
    public partial class add_books : Form
    {
        public add_books()
        {
            InitializeComponent();
        }

        Config conf1 = new Config();
        private void add_books_Load(object sender, EventArgs e)
        {
           
        }

        public void clearall()
        {
            txtTitle.Clear(); txtAuthor.Clear(); txtPublisher.Clear(); txtLocation.Clear(); txtISBN_NO.Clear(); txtInventory.Clear();
            pictureBox1.Image = Properties.Resources.no_book;
            comType.Text = ""; comAvailable.Text = "";
            lblMessage.Text = "-";
            numYear.ResetText(); numVolumes.ResetText(); numBooks.ResetText(); numFree_Books.ResetText(); numBorrowed_Books.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitle.Text != "" && txtAuthor.Text != "" && txtPublisher.Text != "" && txtLocation.Text != "" && comType.SelectedIndex != -1 && comAvailable.SelectedIndex != -1 && txtISBN_NO.Text != "" && txtInventory.Text != "")
                {
                    string str = "SELECT COUNT(*) FROM books WHERE title='" + txtTitle.Text + "'and author='" + txtAuthor.Text + "'and publisher='" + txtPublisher.Text + "'and location='" + txtLocation.Text + "'and year='" + numYear.Text + "'and volumes='" + numVolumes.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, conf1.con);
                    int a = (Int32)cmd.ExecuteScalar();
                    if (a == 0)
                    {
                        if (img_file != null)
                        {
                            FileStream fs1 = new FileStream(img_file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image = new byte[fs1.Length];
                            fs1.Read(image, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();
                            SqlCommand cmd1 = new SqlCommand("insert into books(title, author, publisher, location, year, type, volumes, nr_books, available, nr_free, nr_borrowed, isbn_no, nr_inventory, image) values('" + txtTitle.Text + "', '" + txtAuthor.Text + "', '" + txtPublisher.Text + "', '" + txtLocation.Text + "', '" + numYear.Text + "', '" + comType.Text + "', '" + numVolumes.Text + "', '" + numBooks.Text + "', '" + comAvailable.Text + "', '" + numFree_Books.Text + "', '" + numBorrowed_Books.Text + "', '" + txtISBN_NO.Text + "', '" + txtInventory.Text + "', @pic)", conf1.con);
                            SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                            cmd1.Parameters.Add(prm);
                            cmd1.ExecuteNonQuery();
                            //con.Close();                 
                            clearall();
                            lblMessage.ForeColor = Color.Green;
                            lblMessage.Text = "User added into database!";
                        }
                        else
                        {
                            lblMessage.ForeColor = Color.Red;
                            lblMessage.Text = "Please Upload Image!";
                        }
                    }
                    else
                    {
                        //clearall();
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Database contains this book!";
                        MessageBox.Show("Database contains this book");
                    }

                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Please Enter All the Details";
                }


            }
            catch (Exception x)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = x.Message;
            }
        }

    private void btnClear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        string img_file = null;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() != DialogResult.Cancel)
            {
                img_file = o.FileName;
                pictureBox1.Image = Image.FromFile(o.FileName);
            }
        }
    }
}
