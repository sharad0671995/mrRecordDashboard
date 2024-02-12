using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentDemo_U
{
    public partial class Home_Pagecs : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");
       
        public Home_Pagecs()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select * from Student_Detail ", conn);
        
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {

            



        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string StdRNo = txtStdRNo.Text;
           

            string qry = "Delete from  Student_Detail   Where StdRNo=" + StdRNo;

            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data Deleted");



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string StdRNo = txtStdRNo.Text;
            string FirstName = txtFirstname.Text;
            string LastName = txtLastname.Text;

            string qry = "Update Student_Detail  SET  FirstName='" + FirstName + "'  , LastName='" + LastName + "' Where StdRNo="+StdRNo;

            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data Update");

        }

        private void Home_Pagecs_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            /*  string ConnectionString = "Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True";
              SqlConnection conn = new SqlConnection(ConnectionString);
              conn.Open();
              int StdRNo = txtStdRNo.Text;


              // string qry = "Select * from  Student_Detail Where StdRNo="+StdRNo;
       string qry= "";

              SqlCommand cmd = new SqlCommand(qry, conn);
              cmd.ExecuteNonQuery();
              conn.Close();




              MessageBox.Show("search");
            */

           


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pro_Max pro = new Pro_Max();
            pro.Show();

            this.Hide();
            
        }
    }
}
