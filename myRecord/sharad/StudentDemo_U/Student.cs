using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDemo_U
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFirstName.Text) == true)
            {
                txtFirstName.Focus();
                errorProvider1.SetError(this.txtFirstName, "Please Fill First Name");
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) == true)
            {
                txtFirstName.Focus();
                errorProvider2.SetError(this.txtLastName, "Please Fill Last Name");
            }
            else if (string.IsNullOrEmpty(txtAge.Text) == true)
            {
                txtAge.Focus();
                errorProvider3.SetError(this.txtAge, "Please Fill Age");
            }
            else if (string.IsNullOrEmpty(txtGrade.Text) == true)
            {
                txtGrade.Focus();
                errorProvider4.SetError(this.txtGrade, "Please Fill Grade");
            }else
            {
                string connectionString = "Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True";


                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                
                
          
                SqlCommand cmd = new SqlCommand("INSERT INTO Student([FirstName] ,[LastName],[Age],[Grade]) VALUES(@FirstName,@LastName,@Age,@Grade)", conn);
                cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("Age", txtAge.Text);
                cmd.Parameters.AddWithValue("Grade", txtGrade.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Success");



            }

        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) == true)
            {
                txtFirstName.Focus();
                errorProvider1.SetError(this.txtFirstName, "Please Fill First Name");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text) == true)
            {
                txtFirstName.Focus();
                errorProvider2.SetError(this.txtLastName, "Please Fill Last Name");
            }
            else
            {
                errorProvider2.Clear();

            }



        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text) == true)
            {
                txtAge.Focus();
                errorProvider3.SetError(this.txtAge, "Please Fill Age");
            }
            else
            {
                errorProvider3.Clear();

            }
        }

        private void txtGrade_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrade.Text) == true)
            {
                txtGrade.Focus();
                errorProvider4.SetError(this.txtGrade, "Please Fill Grade");
            }
            else
            {
                errorProvider4.Clear();

            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {

                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {

                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {

                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



       

        private void Student_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete From Student where FirstName=@FirstName ", conn);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Delete");

        }
    }
}
