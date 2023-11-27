using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Resevation_System
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }

        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPas.Checked)
            {
                AdminPassword.PasswordChar = '\0';
            }
            else
            {
                AdminPassword.PasswordChar = '*';

            }
        }

        private void AdminClear_Click(object sender, EventArgs e)
        {
            AdminUsername.Clear();
            AdminPassword.Clear();
        }

        private void Bhomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homepage1 = new HomePage();
            homepage1.Show();
        }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;

            user = AdminUsername.Text;
            pass = AdminPassword.Text;

            if (user == "Admin" && pass == "Admin")
            {
                MessageBox.Show("Successful Logged in!");
                this.Hide();
                AdminPage apl1 = new AdminPage();
                apl1.Show();
            }
            else if(user == "Admin")
            {
                MessageBox.Show("Invalid Password");
            }
            else if(pass == "Admin")
            {
                MessageBox.Show("Invalid Username");
            }
            else
            {
                MessageBox.Show("Enter Right Username and Password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
