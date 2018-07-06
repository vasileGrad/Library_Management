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
    public partial class view_update_users : Form
    {
        public view_update_users(string id)
        {
            InitializeComponent();
            lblD.Text = id;
        }

        Config o = new Config();
        void loadData(string id)
        {
            try
            {
                string str = "SELECT * FROM users WHERE id=" + id;
                SqlCommand cmd = new SqlCommand(str, o.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtFName.Text = dt.Rows[0][1].ToString();
                txtLName.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                comCategory.Text = dt.Rows[0][5].ToString();
                comGender.Text = dt.Rows[0][6].ToString();
                txtBirthday.Text = dt.Rows[0][7].ToString();
                txtMobile.Text = dt.Rows[0][8].ToString();
                txtAddress.Text= dt.Rows[0][9].ToString();
                txtResidence.Text= dt.Rows[0][10].ToString();
                lblRoll.Text = dt.Rows[0][11].ToString();
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

        private void view_update_users_Load(object sender, EventArgs e)
        {
            loadData(lblD.Text);
        }

        private void view_update_users_FormClosing(object sender, FormClosingEventArgs e)
        {
            update_users o = new update_users();
            o.MdiParent = this.MdiParent;
            o.Show();
        }
              
        string img_file = null;
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "" && txtEmail.Text != ""  && comCategory.SelectedIndex != -1 && comGender.SelectedIndex != -1 && txtBirthday.Text != "" && txtMobile.Text != "" && txtAddress.Text != "" && txtResidence.Text != "" && lblRoll.Text != "")
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
                        string sql = "UPDATE users SET first_name='" + txtFName.Text + "', last_name='" + txtLName.Text + "', email='" + txtEmail.Text + "', category='" + comCategory.Text + "', gender='" + comGender.Text + "', birthday='" + txtBirthday.Text + "', mobile='" + txtMobile.Text + "', address='" + txtAddress.Text + "', residence='" + txtResidence.Text + "', roll_nr='" + lblRoll.Text + "', image= @pic WHERE id=" + lblD.Text + ""; 
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPEG|*.jpg|PNG|*.png";
            if (o.ShowDialog() != DialogResult.Cancel)
            {
                img_file = o.FileName;
                pictureBox1.Image = Image.FromFile(o.FileName);
            }
        }
    }
}
