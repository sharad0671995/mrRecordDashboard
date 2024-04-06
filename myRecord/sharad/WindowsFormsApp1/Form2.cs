using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Timer timer;
        private int count;
        DataTable dt = new DataTable();
        DataRow dr;
        String[] s1;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadFiles(Properties.Settings.Default.SouceFolderPath);
        }

        string destinationPath = Properties.Settings.Default.DestinationFolderPath;
        private void button1_Click(object sender, EventArgs e)
        {
            

            //folderBrowserDialog1 dia

            count = 0;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            //Initialize Directory path
            // s1 = Directory.GetFiles(@"C:\New folder");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
          
            string[] files = Directory.GetFiles(fbd.SelectedPath);
            LoadFiles(fbd.SelectedPath);


        }

        private void LoadFiles(string SouceFolderPath)
        {
            dt = new DataTable();
            //Add Data Grid Columns with name
            dt.Columns.Add("File_Name");
            dt.Columns.Add("File_Type");
            dt.Columns.Add("File_Size");
            dt.Columns.Add("Create_Date");

            sourceParentDir = SouceFolderPath;
            ListFile(SouceFolderPath);
            //File Name, File Type, File size, create date

            if (dt.Rows.Count > 0)
            {
                //Finally Add DataTable into DataGridView
                dataGridView1.DataSource = dt;
            }
        }

        string sourceParentDir = "";

        public void ListFile(string dir)
        {
            
            string[] files = Directory.GetFiles(dir);
            //listBox1.Items.Add(dir);
           
                foreach (string file in files)
                {
                    //Get each file information
                    FileInfo f = new FileInfo(file);
                    FileSystemInfo f1 = new FileInfo(file);
                    dr = dt.NewRow();
                    //Get File name of each file name
                    dr["File_Name"] = f1.Name;
                    //Get File Type/Extension of each file 
                    dr["File_Type"] = f1.Extension;
                    //Get File Size of each file in KB format
                    dr["File_Size"] = (f.Length / 1024).ToString();
                    //Get file Create Date and Time 
                    dr["Create_Date"] = f1.CreationTime.Date.ToString("dd/MM/yyyy");
                    //Insert collected file details in Datatable
                    dt.Rows.Add(dr);
                //bool status = true;
              /* if (!File.Exists(f.Name))
                 {
                    //return true;
                    MessageBox.Show("Already Present ");
                 }
                 else
                 {
                     CopyFile(dir, file, (f.Length / 1024).ToString());
                 }
                 
              */
             
                    CopyFile(dir, file, (f.Length / 1024).ToString());
              

                   
                }
           
            string[] subDirs = Directory.GetDirectories(dir);
            if (subDirs.Length > 0) {
            foreach (string subDir in subDirs)
            {
                ListFile(subDir);
            }
            }
        }

        private void CopyFile(string dirPath, string filePath, string fileSize)
        {
            string destinationPath = Properties.Settings.Default.DestinationFolderPath;
            FileSystemInfo f2 = new FileInfo(dirPath);
            //string desinationPathFolder = destinationPath + "\\" + f2.Name;

            string targateDir = dirPath.Substring(sourceParentDir.Length);
            string desinationPathFolder = destinationPath + "\\" + targateDir;
            if (!System.IO.Directory.Exists(desinationPathFolder))
            {
                System.IO.Directory.CreateDirectory(desinationPathFolder);
            }
            FileSystemInfo f1 = new FileInfo(filePath);
            bool status = f1.Exists;
            string dest = desinationPathFolder + "\\" + f1.Name;
            if (status)
            {
                
                System.IO.File.Copy(filePath, dest, true);
            }
            

            //SourceFilePath, DestinationFilePath, DateTime
            // SaveData(SourceFilePath, DestinationFilePath);
            string sourcePath = Properties.Settings.Default.SouceFolderPath;
            SaveData(sourcePath, dest);
        }

        void SaveData(string targateDir,string desinationPathFolder)
        {
            // string cs = "Data Source=DESKTOP-DNJS4DS;Initial Catalog=E-Server-File-Transfer;Integrated Security=True";
            string cs = Properties.Settings.Default.constr;
            SqlConnection conn = new SqlConnection(cs);

            
            SqlCommand com = new SqlCommand("SP_FileSystem", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Action", "Insert");
            com.Parameters.AddWithValue("@SourceFilePath", targateDir);
            com.Parameters.AddWithValue("@DestinationFilePath", desinationPathFolder);
            SqlDataAdapter da = new SqlDataAdapter(com);
            
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 60)
            {
                count = 0;
                timer.Stop();
                Application.Restart();
            }
        }


        public string secondsToTime(int seconds)
        {
            int minutes = 0;
            int hours = 0;

            while (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            string strHours = hours.ToString();
            string strMinutes = minutes.ToString();
            string strSeconds = seconds.ToString();

            if (strHours.Length < 2)
                strHours = "0" + strHours;
            if (strMinutes.Length < 2)
                strMinutes = "0" + strMinutes;
            if (strSeconds.Length < 2)
                strSeconds = "0" + strSeconds;

            return strHours + ":" + strMinutes + ":" + strSeconds;
        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {

            string fileName = textBox1.Text;
            string sourcePath = @"C:\New folder";
            // string targetPath = @"C:\New fold";
            string targetPath = @"\\DESKTOP-BHDBMC2\SharadKute";
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            MessageBox.Show("file Copied   " +textBox1.Text);
            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
            MessageBox.Show("All Copy ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Copy(@"C:\New folder", @"C:\New fold");
           
            Copy(@"C:\New folder", @"\\DESKTOP-KVTONP6\share");
            string SoucePah = textBox1.Text;
            string targetPath = textBox1.Text;
            //Copy(SoucePah ,targetPath );
        }


       
    }
}
