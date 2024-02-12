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
    public partial class MyShow : Form
    {
        
        
        public MyShow()
        {
            InitializeComponent();

            openFileDialog2 = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
                Title = "Select a PDF File",
                Multiselect = false
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imageLocation = "";
            
            
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "icon";
            openFileDialog.Filter = "icon(*.png ;*.jpeg;*.gif) |*.png ;*.jpeg;*.gif ;";
                 openFileDialog.ShowDialog();
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
;            
           
        }
        // File upload 
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the file dialog properties
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "All Files|*.*";

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected file path in the TextBox
                txtPath.Text = openFileDialog.FileName;
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);
                // Perform the file upload logic here (e.g., save the file to a server or process it)
                // You can replace this part with your own logic.
                MessageBox.Show("File uploaded successfully!");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Set the selected file path to the TextBox
                txtppp.Text = openFileDialog2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = txtppp.Text;
            

            if (!string.IsNullOrEmpty(filePath))
            {
                // Your upload logic goes here
                MessageBox.Show($"File '{filePath}' uploaded and Save Database successfully!", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a PDF file to upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
