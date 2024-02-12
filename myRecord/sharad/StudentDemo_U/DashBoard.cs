using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDemo_U
{
    public partial class DashBoard : Form
    {
       
        public DashBoard()
        {
            InitializeComponent();
        }

        
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}
