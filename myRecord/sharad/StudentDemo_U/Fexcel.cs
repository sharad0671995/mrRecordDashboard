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
    public partial class Fexcel : Form
    {
        public Fexcel()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdopen = new OpenFileDialog();
            fdopen.Title = "Select File ";
            fdopen.FileName = txtFileName.Text;
            fdopen.Filter = "Excel Sheet (*.xls) |* .xls|All Files (*.*)|*.*";
            fdopen.FilterIndex = 1;
            fdopen.RestoreDirectory = true;

            if (fdopen.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fdopen.FileName;

            }

        }
    }
}
