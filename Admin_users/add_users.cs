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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Library_Management
{
    public partial class add_users : Form
    {
        public add_users()
        {
            InitializeComponent();
        }

        Config conf1 = new Config();

        private void add_users_Load(object sender, EventArgs e)
        {
            lblRoll.Text = getroll();
        }

        string getroll()
        { 
            string qry = "select count(*) from users";
            SqlCommand cmd = new SqlCommand(qry, conf1.con);
            int a = 101 + (Int32)cmd.ExecuteScalar();
            string reg = "MM" + a.ToString();
            return reg;
         }

        public void clearall()
        {
            txtF_Name.Clear(); txtL_Name.Clear(); txtEmail.Clear(); lblEmailValid.ResetText(); txtPass.Clear();  txtMobile.Clear(); txtAddress.Clear(); txtResidence.Clear(); dateTimePickerBirthday.ResetText(); lblRoll.Text = "----";
            pictureBox1.Image = Properties.Resources.no_image;
            comboCategory.Text = ""; comboGender.Text = "";
            lblMessage.Text = "-"; 
            lblRoll.Text = getroll();
        }

        string img_file = null;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() != DialogResult.Cancel)
            {
                img_file = o.FileName;
                pictureBox1.Image = Image.FromFile(o.FileName);
            }
        }

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                Byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string re = @"^([\w]+)@([\w]+)\.([\w]+)$";
            Regex regex = new Regex(re);

            if (txtF_Name.Text != "" && txtL_Name.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && comboCategory.SelectedIndex != -1 && comboGender.SelectedIndex != -1 && txtMobile.Text != "" && txtAddress.Text != "" && txtResidence.Text != "" && lblRoll.Text != "")
            {
                string str = "SELECT COUNT(*) FROM users WHERE first_name='" + txtF_Name.Text + "'and last_name='" + txtL_Name.Text + "'and email='" + txtEmail.Text + "'and birthday='" + dateTimePickerBirthday.Text+"'";
                SqlCommand cmd = new SqlCommand(str, conf1.con);
                int a = (Int32)cmd.ExecuteScalar();
                MessageBox.Show(a + "===Nr users");
                if (a == 0)
                {
                    if (regex.IsMatch(txtEmail.Text))
                    {
                        if (img_file != null)
                        {
                            string pass1 = Encrypt(txtPass.Text);
                            txtPass.Text = pass1;
                            FileStream fs1 = new FileStream(img_file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            byte[] image = new byte[fs1.Length];
                            fs1.Read(image, 0, Convert.ToInt32(fs1.Length));
                            fs1.Close();
                            SqlCommand cmd1 = new SqlCommand("insert into users(first_name, last_name, email, password, category, gender, birthday, mobile, address, residence, roll_nr, image) values('" + txtF_Name.Text + "', '" + txtL_Name.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "', '" + comboCategory.Text + "', '" + comboGender.Text + "', '" + dateTimePickerBirthday.Text + "', '" + txtMobile.Text + "', '" + txtAddress.Text + "', '" + txtResidence.Text + "', '" + lblRoll.Text + "', @pic)", conf1.con);
                            SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                            cmd1.Parameters.Add(prm);
                            cmd1.ExecuteNonQuery();

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
                        lblEmailValid.ForeColor = Color.Red;
                        lblEmailValid.Text = "Invalid Email!";
                    }
                }
                else
                {
                    clearall();
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Database contains this user!";
                }
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Please Enter All the Details";
            }
        }
        
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearall();
        }
    }
}
