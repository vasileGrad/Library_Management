using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        public static int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 20)
            {
                this.Dispose(false);
                Login o = new Login();
                o.Show();
            }
        }

        private void start_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
