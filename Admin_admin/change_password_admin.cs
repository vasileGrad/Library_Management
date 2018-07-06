using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class change_password_admin : Form
    {
        SqlCommandBuilder builder;
        SqlDataAdapter da;
        DataSet ds;
        public change_password_admin(string id)
        {
            InitializeComponent();
            lblID.Text = id;
        }

        public void clearall()
        {
            txtNew_Pass.Text = ""; txtConfirm_Pass.Text = "";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Config config = new Config();
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNew_Pass.Text == "" && txtConfirm_Pass.Text == "")
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Please fill all fields!";
            }
            else if (txtNew_Pass.Text != txtConfirm_Pass.Text)
            {
                clearall();
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Password Mismatch!";
            }
            else
            {
                txtNew_Pass.Text = Encrypt(txtNew_Pass.Text);
                string qry1 = "UPDATE admin SET password='" + txtNew_Pass.Text + "'where id=" + lblID.Text;
                SqlCommand cmd1 = new SqlCommand(qry1, config.con);
                cmd1.ExecuteReader();
                clearall();
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Password Changed!";
            }
        }
    }
}

