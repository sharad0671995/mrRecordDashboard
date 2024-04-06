using EasyModbus;
using NModbus;
using NModbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Badave
{
    public partial class ModbusForm : Form
    {
        
        public ModbusForm()
        {
            InitializeComponent(); 
        }

        Timer timer;

       
        //private READ_BIFFER_SIZE As UnSort=256;
        ModbusClient plc1 = new ModbusClient();
        //moddata = read(m, target , address )
        private void button1_Click(object sender, EventArgs e)
        {
            plc1.IPAddress = "192.168.1.10";
            plc1.Port = Convert.ToInt32(502);
            plc1.Connect();

            if (plc1.Connected == true)
            {
                MessageBox.Show("Connection Done");
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ReadPlcData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // timer.Stop();
            ReadPlcData();
            // plc1.Disconnect();
        }

        void ReadPlcData()
        {
            //MessageBox.Show("Data Read");
            int[] plcData = plc1.ReadHoldingRegisters(0, 10);
            label4.Text = "";
            for (int i = 0; i < plcData.Length; i++)
            {
                label4.Text += "[" + i + "]=" + plcData[i] + "\n";
            }

            int torqueValue = plcData[8];
            if(torqueValue >=11 && torqueValue <= 13)
            {
                //OK
                plc1.WriteSingleRegister(9, 1);

                int[] outputValue = new int[4] {10,20,30,40};

                plc1.WriteMultipleRegisters(3, outputValue);
            }
            else
            {
                //NOK
                plc1.WriteSingleRegister(9, 0);

                int[] outputValue = new int[4] { 1,2,3,4 };

                plc1.WriteMultipleRegisters(3, outputValue);
            }
        }
    }
}
