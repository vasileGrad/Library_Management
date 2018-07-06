using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Library_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        string qry, qry1;
        SqlCommand cmd, cmd1;
        Config conf = new Config();

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                Byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public void clearAll()
        {
            txtFirst_Name.Text = ""; txtPassword.Text = ""; comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Encrypt(txtPassword.Text);

            if (txtFirst_Name.Text != "" && txtPassword.Text != "" && comboBox1.SelectedIndex !=-1)
            {          
                if (txtFirst_Name.Text !="admin" && comboBox1.Text == "Student")
                {    
                    qry = "SELECT first_name, password FROM users WHERE first_name='"+txtFirst_Name.Text+"' AND password='"+txtPassword.Text+"'";
                    cmd = new SqlCommand(qry, conf.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        qry1 = "SELECT id FROM users WHERE first_name='" + txtFirst_Name.Text + "' AND password='" + txtPassword.Text + "'";
                        cmd1 = new SqlCommand(qry1, conf.con);
                        int id = (Int32)cmd1.ExecuteScalar();
                        this.Dispose(false);
                        user_home a = new user_home(txtFirst_Name.Text, id);
                        a.Show();
                    }
                    else
                    {
                        clearAll();
                        label4.ForeColor = Color.Red;
                        label4.Text = "Invalid Username, Password or Type!";
                        dr.Close();
                    }
                
                }
                else if(comboBox1.Text != "Student")
                {
                    qry = "SELECT name, password FROM admin WHERE name='" + txtFirst_Name.Text + "' AND password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(qry, conf.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        qry1 = "SELECT id FROM admin WHERE password='" + txtPassword.Text+"'";
                        cmd1 = new SqlCommand(qry1, conf.con);
                        int id = (Int32)cmd1.ExecuteScalar();
                        this.Dispose(false);
                        admin_home a = new admin_home(txtFirst_Name.Text, id);
                        a.Show();
                    }
                    else
                    {
                        clearAll();
                        label4.ForeColor = Color.Red;
                        label4.Text = "Invalid Username, Password or Type!";
                        dr.Close();
                    }
                }
                else
                {
                    clearAll();
                    label4.ForeColor = Color.Red;
                    label4.Text = "Invalid Type!";
                }
            }

            else
            {
                clearAll();
                label4.ForeColor = Color.Red;
                label4.Text = "Please fill all the credentials !";
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            Application.Exit();
            }
            catch (Exception)
            {

                MessageBox.Show("Please close open windows!");
            }
            
        }

        public void clear()
        {
            txtFirst_Name.Clear();
            txtPassword.Clear();
            comboBox1.SelectedIndex = -1;
            label4.Text = "-";
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
