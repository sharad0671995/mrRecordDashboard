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

namespace StudentDemo_U
{
    public partial class VehicleDetail : Form
    {
        public VehicleDetail()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");




            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("Select * from VehicleDetail", conn);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string VehicleID = txtId.Text;
            string Make = txtMake.Text;
            string Model = txtModel.Text;
            string Year = txtYear.Text;
            string color = txtColor.Text;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("InsertVehicle_sp ", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
                    cmd.Parameters.AddWithValue("@Make", Make);
                    cmd.Parameters.AddWithValue("@Model ", Model);
                    cmd.Parameters.AddWithValue("@Year", Year);

                    cmd.Parameters.AddWithValue("@Color",color);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("data Added");
        }
    }
}
