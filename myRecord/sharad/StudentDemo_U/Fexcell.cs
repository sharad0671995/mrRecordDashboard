using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDemo_U
{
    public partial class Fexcell : Form
    {


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BHDBMC2\\SQLEXPRESS;Initial Catalog=EmployeeMSystem;Integrated Security=True;Encrypt=True");
        public Fexcell()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Title = "Select Title";
            fopen.FileName = txtFileName.Text;
            fopen.Filter = "Excel Sheet (*.xlsx *)|*.xlsx* | All Files(*.*)| *.*";
            fopen.FilterIndex = 1;
            fopen.RestoreDirectory = true;
            if (fopen.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fopen.FileName;
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\abc1.accdb;Persist Security Info=False;";

            OleDbConnection theConnection = new OleDbConnection(@"connectionString" ) ;
            
            theConnection.Open();
            OleDbDataAdapter thda = new OleDbDataAdapter("Select *  from [Sheet1$]", theConnection);
            DataSet tsd = new DataSet();
            DataTable dt = new DataTable();
            thda.Fill(dt);
            this.dataGridView1.DataSource = dt.DefaultView;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
        }

        void fillgrid()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TProduct order by Id" ,conn) ;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Fexcell_Load(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}
