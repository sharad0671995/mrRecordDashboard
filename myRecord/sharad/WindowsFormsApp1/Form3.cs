using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //dataGridView1.Visible = false;
                listBox1.Items.Clear();
                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);

                ListFile(fbd.SelectedPath);
                //foreach (string dir in dirs)
                //{
                //    string[] files = Directory.GetFiles(dir);
                //    listBox1.Items.Add(dir);
                //    foreach (string file in files)
                //    {
                //        listBox1.Items.Add(file);
                //    }
                //}
            }
        }

        public void ListFile(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            listBox1.Items.Add(dir);
            foreach (string file in files)
            {
                FileInfo f = new FileInfo(file);
                listBox1.Items.Add(file + " : Size-"+ (f.Length / 1024).ToString() +"Kb");
                SaveLog(file, (f.Length / 1024).ToString());
            }
            string[] subDirs = Directory.GetDirectories(dir);
            foreach (string subDir in subDirs)
            {
                ListFile(subDir);
            }
        }

        private void SaveLog(string filePath, string fileSize)
        {
            
        }
    }
}
