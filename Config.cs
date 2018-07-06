using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Library_Management
{
    class Config
    {
        public SqlConnection con;
        public string str;

        public Config()
        {
            try
            {
                str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\VASILE\Documents\Visual Studio 2015\Projects\Library_Management\Library_Management\Library.mdf;Integrated Security=True;User Instance=True";
                //str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Library.mdf;Integrated Security=True;User Instance=True";
                con = new SqlConnection(str);
                con.Open();
                //MessageBox.Show("Database Connected !");
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void loadgrid(string qry, DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(qry, con);
            da.SelectCommand = cmd;
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];
            da.Dispose();
            cmd.Dispose();
        }
    }
}
