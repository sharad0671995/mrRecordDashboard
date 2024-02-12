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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentDemo_U
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();

            txtid.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtquatity.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");




            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("ProList", conn);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            
            conn.Close();


        }

        private void Product_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            
            txtid.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtquatity.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Product_id = txtid.Text;
            string Produt_Name = txtname.Text;
            string Product_price = txtprice.Text;
            string Product_Quantity = txtquatity.Text;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("InsertPro ", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product_id", Product_id);
                    cmd.Parameters.AddWithValue("@Product_Name", Produt_Name);
                    cmd.Parameters.AddWithValue("@Product_price", Product_price);
                    cmd.Parameters.AddWithValue("@Product_Quantity", Product_Quantity);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("data Added");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string Product_id = txtid.Text;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ProDelete", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product_id", Product_id);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("data Deleted");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string Product_id = txtid.Text;
            string Product_Name = txtname.Text;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ProUpdate", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product_id", Product_id);
                    cmd.Parameters.AddWithValue("@Product_Name", Product_Name);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("data Update");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Product_id = txtid.Text;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("ProSearch", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product_id", Product_id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    
                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("data Search");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtquatity.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["Product_id"].Value.ToString();
                txtname.Text = row.Cells["Product_Name"].Value.ToString();
                txtprice.Text = row.Cells["Product_Price"].Value.ToString();
                txtquatity.Text = row.Cells["Product_Quantity"].Value.ToString();
            }

            
        }
    }
}
