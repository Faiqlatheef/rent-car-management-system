using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Ayubo_1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = userNameBox.Text;
            string password = passwordBox.Text;

            if (user_name == "admin" && password == "05")
            {
                MessageBox.Show(" login successfully....!...! ");
                this.Hide();
                new menu().Show();
            }
            else
            {
                MessageBox.Show(" check your user name and password...! ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
