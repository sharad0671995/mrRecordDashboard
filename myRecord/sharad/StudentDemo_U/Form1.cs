using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDemo_U
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Email = false;
        bool Password = false;

        string email_pattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        string password_pattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, email_pattern) == false)
            {
                txtEmail.Focus();
                errorProvider1.SetError(this.txtEmail, "Please Fill Correct");
            }else if (Regex.IsMatch(txtPassword.Text, password_pattern) == false)
            {
                txtPassword.Focus();
                errorProvider2.SetError(this.txtPassword, "Please Fill Correct");
            }else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");
                
                SqlCommand cmd = new SqlCommand("select * from Student_Detail   where Email=@Email and Password=@Password", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    Email = true;
                    Password = true;
                    Home_Pagecs home = new Home_Pagecs();
                    home.Show();
                    MessageBox.Show("Welcome");
                }else
                {
                    MessageBox.Show("Please enter valid Email and Password");
                }
                
                conn.Close();
                

                


    }
            }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sd = new SignUp();
            sd.Show();
            this.Hide();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtEmail.Text, email_pattern) == false)
            {
                txtEmail.Focus();
                errorProvider1.SetError(this.txtEmail, "Please Fill Correct");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, password_pattern) == false)
            {
                txtPassword.Focus();
                errorProvider2.SetError(this.txtPassword, "Please Fill Correct");
            }
            else
            {
                errorProvider2.Clear();

            }
        }

        private void checkBox1_Leave(object sender, EventArgs e)
        {
            

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;


            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
