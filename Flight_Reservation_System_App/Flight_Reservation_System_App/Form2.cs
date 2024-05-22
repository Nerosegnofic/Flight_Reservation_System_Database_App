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

namespace Flight_Reservation_System_App
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1SAIF6;Initial Catalog=Fligh_Reservation_System;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
            display_data();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Admin VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully.");
            display_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display_data();
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Admin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Admin WHERE Admin_ID='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully.");
            display_data();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Assuming new_email_value, new_password_value, new_first_name_value, new_last_name_value, new_phone_value, new_authenticate_value, and your_admin_id_value are variables holding the new values
            string query = "UPDATE Admin SET ";

            // Check if each value is provided and add it to the query if so
            if (!string.IsNullOrEmpty(textBox2.Text))
                query += "Email = '" + textBox2.Text + "', ";
            if (!string.IsNullOrEmpty(textBox3.Text))
                query += "password = '" + textBox3.Text + "', ";
            if (!string.IsNullOrEmpty(textBox4.Text))
                query += "First_Name = '" + textBox4.Text + "', ";
            if (!string.IsNullOrEmpty(textBox5.Text))
                query += "Last_Name = '" + textBox5.Text + "', ";
            if (!string.IsNullOrEmpty(textBox6.Text))
                query += "Phone = '" + textBox6.Text + "', ";
            if (!string.IsNullOrEmpty(textBox7.Text))
                query += "Authenticate = '" + textBox7.Text + "', ";

            // Remove the trailing comma and space
            query = query.TrimEnd(' ', ',');

            // Add the WHERE clause
            query += " WHERE Admin_ID = '" + textBox1.Text + "'";

            // Set the command text
            cmd.CommandText = query;


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully.");
            display_data();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
