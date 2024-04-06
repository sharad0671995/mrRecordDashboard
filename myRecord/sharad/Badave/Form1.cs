using EasyModbus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Search_Click(object sender, EventArgs e)
        {
            //label1.Text = Color.GreenYellow;
            //string constr = Properties.Settings.Default.Conn;
            string constr = "Data Source=DESKTOP-DNJS4DS;Initial Catalog=e-JH-PM-Mgt-Badve;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);

            // var columnData = new System.Collections.Generic.List<>();
            string searchDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            SqlCommand com = new SqlCommand("SP_AndonMaster", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Action", "GetAndonResult");
            com.Parameters.AddWithValue("@searchDate", searchDate);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            string[] dataArray = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int plcAddress = Convert.ToInt32(dt.Rows[i]["plcAddress"].ToString());
                int plcStatus = Convert.ToInt32(Convert.ToBoolean(dt.Rows[i]["Status"]));
                label2.Text += "[" + plcAddress + "] = " + plcStatus + "\n";

                WritePlcData(plcAddress, plcStatus);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            //ReadPlcData();
        }

        Timer timer;
        ModbusClient plc1 = new ModbusClient();
        void ConnectPlc()
        {
            try
            {
                plc1 = new ModbusClient();

                //plc1.IPAddress = Properties.Settings.Default.PlcIpAddress;

                //plc1.Port = Properties.Settings.Default.PlcPortNumber;

                plc1.IPAddress = "127.0.0.1";
                plc1.Port = Convert.ToInt32(502);

                plc1.Connect();

                label3.Text = "PLC Connected";

                // plc1.IPAddress = "192.168.1.10";
                //plc1.Port = Convert.ToInt32(502);
                // plc1.Connect();
            }
            catch(Exception ex)
            {
                label3.Text = ex.Message;
                plc1 = new ModbusClient();
            }
        }
        public void WritePlcData(int plcAddress, int PlcStatus)
        {
            if (plc1.Connected == true)
            {
                plc1.WriteSingleRegister(plcAddress, PlcStatus);
                //plc1.WriteMultipleRegisters(3, outputValue);
            }
            else
            {
                ConnectPlc();
                WritePlcData(plcAddress, PlcStatus);
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            ReadPlcData();
        }
         
        public void ReadPlcData()
        {
           plc1.IPAddress = "127.0.0.1";
           plc1.Port = Convert.ToInt32(502);
           plc1.Connect();

            if (plc1.Connected == true)
            {
               // MessageBox.Show("Connection Done");
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }


            //int[] plcAddress =
            int[] plcData = plc1.ReadHoldingRegisters(0, 10);
            label2.Text="";
            for (int i = 0; i < plcData.Length; i++)
            {
                label2.Text += "[" + i + "]=" + plcData[i] + "\n";
            }


            //int torqueValue = plcData[8];
           /* bool Status = false;
            if(Status == true)
            {
                plc1.WriteSingleRegister(9, 1);

                int[] outputValue = new int[4] { 10, 20, 30, 40 };

                plc1.WriteMultipleRegisters(3, outputValue);
            }
            */
            int torqueValue = plcData[8];
            if (torqueValue >= 11 && torqueValue <= 13)
            {

                plc1.WriteSingleRegister(9, 1);

                int[] outputValue = new int[4] { 10, 20, 30, 40 };

                plc1.WriteMultipleRegisters(3, outputValue);
            }
            else
            {
                //NOK
                plc1.WriteSingleRegister(9, 0);

                int[] outputValue = new int[4] { 1, 2, 3, 4 };

                plc1.WriteMultipleRegisters(3, outputValue);
            }
            
        }

       /* private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
       */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.Rows[0].Cells[1].ReadOnly = true;

        }

      // string searchDate  =DateTime.Today.ToString("MM-dd-yyyy");
       
      string searchDate = "03/14/2024";
        //string searchDate = DateTime.Today.ToString("22/02/2024");
        private void Form1_Load(object sender, EventArgs e)
        {
            getdata(searchDate);
            //  button1.Visible = true;
            Search.Visible=false;
            dateTimePicker1.Visible = false;

           // this.StartPosition = FormStartPosition.Manual;
           // this.Location = new Point(0, 0);
           // Size formSize = new Size(Screen.GetWorkingArea(this).Width, Screen.GetWorkingArea(this).Height);
            //this.Size = new Size(formSize.Width, formSize.Height);
        }

        public void getdata(string searchDate)
        {
            //label1.Text = Color.GreenYellow;
            //string constr = Properties.Settings.Default.Conn;
            string constr = "Data Source=DESKTOP-DNJS4DS;Initial Catalog=e-JH-PM-Mgt-Badve;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);

            // var columnData = new System.Collections.Generic.List<>();
            //string searchDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            SqlCommand com = new SqlCommand("SP_AndonMaster", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Action", "GetAndonResult");
            com.Parameters.AddWithValue("@searchDate", searchDate);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            string[] dataArray = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int plcAddress = Convert.ToInt32(dt.Rows[i]["plcAddress"].ToString());
                int plcStatus = Convert.ToInt32(Convert.ToBoolean(dt.Rows[i]["Status"]));
                label2.Text += "[" + plcAddress + "] = " + plcStatus + "\n";

                WritePlcData(plcAddress, plcStatus);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }
    }
}



