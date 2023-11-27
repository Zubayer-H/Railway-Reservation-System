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
    public partial class TrainMaster : Form
    {
        string conString = "Data Source=DESKTOP-TSHGALO;Initial Catalog=Project;Integrated Security=True;Pooling=False";


        public TrainMaster()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager tmp1 = new Manager();
            tmp1.Show();
        }

        private void TMadd_Click(object sender, EventArgs e)
        {
            if (traincapacity.Text == "" || trainname.Text == "" || trainstatus.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                var CAPACITY = int.Parse(traincapacity.Text);
                string NAME = trainname.Text;
                string STATUS = trainstatus.Text;

                string Queary = "INSERT INTO train_master (NAME,CAPACITY,STATUS) VALUES('" + NAME + "','" + CAPACITY + "','" + STATUS + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added !! ");
            }

        }

        private void TMedit_Click(object sender, EventArgs e)
        {
            if (traincapacity.Text == "" || trainname.Text == "" || trainstatus.Text == "")
                MessageBox.Show("Please fill up all component!!");
            else {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update train_master set NAME = @NAME,CAPACITY = @CAPACITY,STATUS = @STATUS where NAME  =@NAME", con);

                cmd.Parameters.AddWithValue("@NAME", trainname.Text);
                cmd.Parameters.AddWithValue("@CAPACITY", int.Parse(traincapacity.Text));
                cmd.Parameters.AddWithValue("@STATUS", trainstatus.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updated !! ");
            }
            
        }

        private void TMremove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete train_master where NAME  =@NAME", con);
            cmd.Parameters.AddWithValue("@NAME", trainname.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Removed !! ");
        }
        
        private void TMshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from train_master", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
        private void TrainMaster_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            traincapacity.Text = trainname.Text = trainstatus.Text = "";
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager tmp1 = new Manager();
            tmp1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from train_master where NAME  =@NAME", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@NAME", trainname.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
