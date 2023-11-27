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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainMaster tml1 = new TrainMaster();
            tml1.Show();
        }

        private void PassengerMaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Passengermaster pml1 = new Passengermaster();
            pml1.Show();
        }

        private void TravelMaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            TravelMaster tml1 = new TravelMaster();
            tml1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin maob1 = new ManagerLogin();
            maob1.Show();
        }
    }
}
