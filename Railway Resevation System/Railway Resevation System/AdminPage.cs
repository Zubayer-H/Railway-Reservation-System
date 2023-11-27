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
    public partial class AdminPage : Form
    {
        string conString = "Data Source=DESKTOP-TSHGALO;Initial Catalog=Project;Integrated Security=True;Pooling=False";

        public AdminPage()
        {
            InitializeComponent();
        }

        private void APBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogIn m2 = new AdminLogIn();
            m2.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }
       
        private void ManagerInsert_Click(object sender, EventArgs e)
        {
            if (Mid.Text == "" || MaName.Text == "" || MaAddress.Text == "" || MaContact.Text == "" || MaUsername.Text == "" || MaPassword.Text == "")
                MessageBox.Show("Please fil up all the component  !!");
            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                var ID = int.Parse(Mid.Text);
                string NAME = MaName.Text;
                string ADDRESS = MaAddress.Text;
                string CONTACT = MaContact.Text;
                string USERNAME = MaUsername.Text;
                string PASSWORD = MaPassword.Text;

                string Queary = "INSERT INTO ManagerProfile (ID,NAME,ADDRESS,CONTACT,USERNAME,PASSWORD) VALUES('" + ID + "','" + NAME + "','" + ADDRESS + "','" + CONTACT + "','" + USERNAME + "','" + PASSWORD + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Successfully Inserted !!");


            }
            
            

            

        }

        private void showall_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ManagerProfile", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ManagerUpdate_Click(object sender, EventArgs e)
        {

            if (MaName.Text == "" || MaAddress.Text == "" || MaContact.Text == ""|| Mid.Text == "" || MaUsername.Text == "" || MaPassword.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();





                SqlCommand cmd = new SqlCommand("Update ManagerProfile set NAME = @NAME,ADDRESS = @ADDRESS,CONTACT = @CONTACT,ID=@ID,USERNAME = @USERNAME,PASSWORD = @PASSWORD where ID  =@ID", con);

                cmd.Parameters.AddWithValue("@NAME", MaName.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", MaAddress.Text);
                cmd.Parameters.AddWithValue("@CONTACT", MaContact.Text);
                cmd.Parameters.AddWithValue("@ID", int.Parse(Mid.Text));
                cmd.Parameters.AddWithValue("@USERNAME", MaUsername.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", MaPassword.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updeted !! ");
                
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagerReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            Mid.Clear();
            MaName.Clear();
            MaPassword.Clear();
            MaAddress.Clear();
            MaContact.Clear();
            MaUsername.Clear();
            Mid.Focus();
        }

        private void ManagerSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ManagerProfile where ID  =@ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@ID", int.Parse(Mid.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ManagerDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete ManagerProfile where ID  =@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(Mid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Delated successfully !!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogIn m2 = new AdminLogIn();
            m2.Show();
        }
    }
}
