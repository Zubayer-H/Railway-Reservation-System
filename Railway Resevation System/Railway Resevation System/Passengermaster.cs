using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Railway_Resevation_System
{
    public partial class Passengermaster : Form
    {
        string conString = "Data Source=DESKTOP-TSHGALO;Initial Catalog=Project;Integrated Security=True;Pooling=False";
        public Passengermaster()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager pmp1 = new Manager();
            pmp1.Show();
        }

        private void PassShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from passenger_master", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void PMadd_Click(object sender, EventArgs e)
        {
            if (passname.Text == "" || passaddress.Text == "" || Passgender.Text == "" || Passphone.Text == "")
                MessageBox.Show("Please Fill up all Component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string NAME = passname.Text;
                string ADDRESS = passaddress.Text;
                string GENDER = Passgender.Text;
                string NUMBER = Passphone.Text;

                string Queary = "INSERT INTO passenger_master (NAME,ADDRESS,GENDER,NUMBER) VALUES('" + NAME + "','" + ADDRESS + "','" + GENDER + "','" + NUMBER + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added!! ");
            }
        }

        private void TMremove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete passenger_master where NAME  =@NAME", con);
            cmd.Parameters.AddWithValue("@NAME", passname.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Delated successfully !!");
        }

        private void PMedit_Click(object sender, EventArgs e)
        {
            
        }

        private void TMreset_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            passname.Text = passaddress.Text = Passgender.Text = Passphone.Text = "";
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager pmp1 = new Manager();
            pmp1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from passenger_master where NAME  =@NAME", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@NAME", passname.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnedit(object sender, EventArgs e)
        {
            if (passname.Text == "" || passaddress.Text == "" || Passgender.Text == "" || Passphone.Text == "")
                MessageBox.Show("Please Fill up all Component !!");
            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update passenger_master set NAME = @NAME,ADDRESS = @ADDRESS,GENDER = @GENDER,NUMBER= @NUMBER where NAME  =@NAME", con);

                cmd.Parameters.AddWithValue("@NAME", passname.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", passaddress.Text);
                cmd.Parameters.AddWithValue("@GENDER", Passgender.Text);
                cmd.Parameters.AddWithValue("@NUMBER", Passphone.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Edited !! ");
            }
            
        }
    }
}
