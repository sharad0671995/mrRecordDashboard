using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDemo_U
{
    public partial class Pro_Max : Form
    {


        public Pro_Max()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pro_Max_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Student_Detail   where FirstName=@FirstName", conn);
            cmd.Parameters.AddWithValue("@FirstName", (txtSearch.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
