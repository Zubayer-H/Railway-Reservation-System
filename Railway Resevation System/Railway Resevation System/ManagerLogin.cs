using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Railway_Resevation_System
{
    public partial class ManagerLogin : Form
    {
        string conString = "Data Source=DESKTOP-TSHGALO;Initial Catalog=Project;Integrated Security=True;Pooling=False";
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void MBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage ml1 = new HomePage();
            ml1.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MPassword.PasswordChar = '\0';
            }
            else
            {
                MPassword.PasswordChar = '*';

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string Queary = "Select * from Managerprofile where USERNAME='"+MUserName.Text.Trim()+"' and PASSWORD ='"+MPassword.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand(Queary, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count ==1)
            {
                Manager maobj1 = new Manager();
                this.Hide();
                maobj1.Show();

            }
            else
            {
                MessageBox.Show("Check your username and Password");
            }

        }
    }
}
