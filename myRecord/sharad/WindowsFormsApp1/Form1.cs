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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string cs = "Data Source=DESKTOP-DNJS4DS;Initial Catalog=E-Server-File-Transfer;Integrated Security=True";
            // string gender = string.Empty;
            string cs = Properties.Settings.Default.constr;
            SqlConnection conn = new SqlConnection(cs);
            string DateOfBirth = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            //string DateOfBirth = dateTimePicker1.Value.Date;
            // cmd.CommandText = "INSERT INTO Category (name,address,gender) VALUES (@name,@address,@gender)";
            SqlCommand cmd = new SqlCommand("INSERT INTO Category (name,address,gender,city,admin,dateOfBirth) VALUES (@name,@address,@gender,@city,@admin,@dateOfBirth)", conn);
           // SqlCommand cmd = new SqlCommand("Select * from Category", conn);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@address", textBox2.Text);
            cmd.Parameters.AddWithValue("@city", comboBox1.GetItemText(comboBox1.SelectedItem));
            cmd.Parameters.AddWithValue("@admin", checkBox1.Checked);
            // cmd.Parameters.AddWithValue("@dateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@dateOfBirth", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            if (radioButton1.Checked == true)
                cmd.Parameters.AddWithValue("@gender", "Male");
            else
                cmd.Parameters.AddWithValue("@gender", "Female");
            //dataGridView1.AutoGenerateColumm ns = true;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            /*  SqlDataAdapter da = new SqlDataAdapter();
           //da.SelectCommand = Cmd(); 
           DataTable table1 = new DataTable();
           da.Fill(table1);
        DataRow itemrow = table1.NewRow();
           itemrow[1] = "Select Category";
           table1.Rows.InsertAt(itemrow, 0);
            AS Date, CONVERT(varchar, 
                         dbo.View_CheckSheetDetails.CreatedDate, 108) AS Time

           comboBox1.DataSource = table1;
           comboBox1.DisplayMember = "category";
           comboBox1.ValueMember = "id";
          */
            // MessageBox.Show("All Data Succesfully Save into  Database ");
            

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           // label4.Text = comboBox1.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string cs = Properties.Settings.Default.constr;
            SqlConnection conn = new SqlConnection(cs);
           
            //SqlCommand cmd = new SqlCommand("INSERT INTO Category (name,address,gender,city,admin,dateOfBirth) VALUES (@name,@address,@gender,@city,@admin,@dateOfBirth)", conn);
             SqlCommand cmd = new SqlCommand("Select * from Category", conn);
            
            //dataGridView1.AutoGenerateColumm ns = true;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
