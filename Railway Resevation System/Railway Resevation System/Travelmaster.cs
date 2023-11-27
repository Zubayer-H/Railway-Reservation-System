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
    public partial class TravelMaster : Form
    {
        string conString = "Data Source=DESKTOP-TSHGALO;Initial Catalog=Project;Integrated Security=True;Pooling=False";
        public TravelMaster()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (travelcost.Text == "" || trainCode.Text == "" || dateTimePicker1.Text == "" || trainsource.Text == "" || destination.Text == "")
                MessageBox.Show("Please Fill up all Component!!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string COST = travelcost.Text;
                string CODE = trainCode.Text;
                string DATE = dateTimePicker1.Text;
                string SOURCE = trainsource.Text;
                string DESTINATION = destination.Text;

                string Queary = "INSERT INTO travel_master (DATE,CODE,SOURCE,DESTINATION,COST) VALUES('" + DATE + "','" + CODE + "','" + SOURCE + "','" + DESTINATION + "','" + COST + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added!! ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager travelmp1 = new Manager();
            travelmp1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void TRMremove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete travel_master where CODE  =@CODE", con);
            cmd.Parameters.AddWithValue("@CODE", trainCode.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Delated successfully!!");
        }

        private void TRMshowall_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from travel_master", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void travelcost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TravelMaster_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            travelcost.Text = trainCode.Text = dateTimePicker1.Text = trainsource.Text = destination.Text = "";
        }

        private void trainCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager travelmp1 = new Manager();
            travelmp1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from travel_master where CODE  =@CODE", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@CODE", trainCode.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (travelcost.Text == "" || trainCode.Text == "" || dateTimePicker1.Text == "" || trainsource.Text == "" || destination.Text == "")
                MessageBox.Show("Please fill up all component!!");
            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string COST = travelcost.Text;
                string CODE = trainCode.Text;
                string DATE = dateTimePicker1.Text;
                string SOURCE = trainsource.Text;
                string DESTINATION = destination.Text;


                SqlCommand cmd = new SqlCommand("Update travel_master set COST = @COST,CODE = @CODE,DATE=@DATE,SOURCE = @SOURCE,DESTINATION = @DESTINATION where ID  =@ID", con);

                cmd.Parameters.AddWithValue("@COST", travelcost.Text);
                cmd.Parameters.AddWithValue("@CODE", trainCode.Text);
                cmd.Parameters.AddWithValue("@DATE", dateTimePicker1.Text);

                cmd.Parameters.AddWithValue("@SOURCE", trainsource.Text);
                cmd.Parameters.AddWithValue("@DESTINATION", destination.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updeted!! ");
            }
        }
    }
}
