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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogIn m1 = new AdminLogIn();
            m1.Show();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ManagerLogin ml1 = new ManagerLogin();
            ml1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
