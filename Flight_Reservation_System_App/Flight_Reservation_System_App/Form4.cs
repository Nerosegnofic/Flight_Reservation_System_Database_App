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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flight_Reservation_System_App
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D1SAIF6;Initial Catalog=Fligh_Reservation_System;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
            display_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Modify_Aircraft VALUES('" + textBox1.Text + "', '" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully.");
            display_data();
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Modify_Aircraft";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Modify_Aircraft WHERE Admin_ID='" + textBox1.Text + "' OR Aircraft_ID = '"+ textBox2.Text +"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully.");
            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Assuming new_email_value, new_password_value, new_first_name_value, new_last_name_value, new_phone_value, new_authenticate_value, and your_admin_id_value are variables holding the new values
            string query = "UPDATE Modify_Aircraft SET ";

            // Check if each value is provided and add it to the query if so
            if (!string.IsNullOrEmpty(textBox1.Text))
                query += "Admin_ID = '" + textBox1.Text + "', ";
            if (!string.IsNullOrEmpty(textBox2.Text))
                query += "Aircraft_ID = '" + textBox2.Text + "', ";

            // Remove the trailing comma and space
            query = query.TrimEnd(' ', ',');

            // Add the WHERE clause
            query += " WHERE Admin_ID = '" + textBox1.Text + "' OR Aircraft_ID = '"+textBox2.Text+"' ";

            // Set the command text
            cmd.CommandText = query;


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully.");
            display_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
