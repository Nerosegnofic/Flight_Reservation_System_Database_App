using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Reservation_System_App
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1SAIF6;Initial Catalog=Fligh_Reservation_System;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(); // ModifyFlight
            f6.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Admin
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); // ModifyAircraft
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // Aircraft
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(); // Flight
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(); // Passenger
            f9.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(); // Customer
            f7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(); // Ticket
            f8.ShowDialog();
        }
    }
}
