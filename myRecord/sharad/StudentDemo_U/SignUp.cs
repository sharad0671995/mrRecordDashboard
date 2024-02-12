using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDemo_U
{
    public partial class SignUp : Form
    {

        string email_pattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        string password_pattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void txtRollNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRollNo.Text) == true)
            {
                txtRollNo.Focus();
                errorProvider1.SetError(this.txtRollNo, "Please Fill Id");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtfirstname_Leave(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(txtfirstname.Text) == true)
            {
                txtfirstname.Focus();
                errorProvider2.SetError(this.txtfirstname, "Please Fill First Name");
            }
            else
            {
                errorProvider2.Clear();

            }
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLastname.Text) == true)
            {
                txtLastname.Focus();
                errorProvider3.SetError(this.txtLastname, "Please Fill First Name");
            }
            else
            {
                errorProvider3.Clear();

            }
        }

        private void txtgender_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txtgender.SelectedItem == null)
            {
                errorProvider4.SetError(txtgender, "Please select gender");
                txtgender.Text = "Please select gender";
            }
            else
            {
                gender.Text = txtgender.SelectedItem.ToString();
                errorProvider4.Clear();
            }


        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtemail.Text, email_pattern) == false)
            {
                txtemail.Focus();
                errorProvider5.SetError(this.txtemail, "Please Fill Correct");
            }
            else
            {
                errorProvider5.Clear();

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, password_pattern) == false)
            {
                txtPassword.Focus();
                errorProvider6.SetError(this.txtPassword, "Please Fill Correct");
            }
            else
            {
                errorProvider6.Clear();

            }
        }

        private void txtcpass_Leave(object sender, EventArgs e)
        {
            if (txtcpass.Text != txtcpass.Text)
            {
                txtcpass.Focus();
                errorProvider7.SetError(this.txtcpass, "password Mismatch");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtRollNo.Text) == true)
            {
                txtRollNo.Focus();
                errorProvider1.SetError(this.txtRollNo, "Please Fill EmpId");
            }else

            if (string.IsNullOrEmpty(txtfirstname.Text) == true)
            {
                txtfirstname.Focus();
                errorProvider2.SetError(this.txtfirstname, "Please Fill First Name");
            }
            else if (string.IsNullOrEmpty(txtLastname.Text) == true)
            {
                txtLastname.Focus();
                errorProvider3.SetError(this.txtLastname, "Please Fill Last Name");
            }else if (txtgender.SelectedItem == null)
            {
                errorProvider4.SetError(txtgender, "Please select gender");
                txtgender.Text = "Please select gender";
            }
            
            else if (Regex.IsMatch(txtemail.Text, email_pattern) == false)
            {
                txtemail.Focus();
                errorProvider5.SetError(this.txtemail, "Please Fill Correct");
            }
            else if (Regex.IsMatch(txtPassword.Text, password_pattern) == false)
            {
                txtPassword.Focus();
                errorProvider6.SetError(this.txtPassword, "Please Fill Correct");
            }
            else if (txtcpass.Text != txtcpass.Text)
            {
                txtcpass.Focus();
                errorProvider7.SetError(this.txtcpass, "password Mismatch");
            } 
            else 

            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True");
              SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Student_Detail]
           ([FirstName]
           ,[LastName]
           ,[gender]
           ,[Email]
           ,[Password])
     VALUES
           ('"+txtfirstname.Text+"','"+txtLastname.Text+"','"+txtgender.Text+"','"+txtemail.Text+"','"+txtPassword.Text+"')",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                

                MessageBox.Show("Sign Up Done");
         

            }
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRollNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void reset_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtfirstname.Clear();
            txtLastname.Clear();
            txtgender.Items.Clear();
            txtemail.Clear();
            txtPassword.Clear();
            txtcpass.Clear();
            txtRollNo.Focus();

        

        }

        private void txtgender_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
