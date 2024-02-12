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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MeExit();
        }

        private void MeExit()
        {
            DialogResult iExit;

            iExit = MessageBox.Show("conform if you want exit","Save DataGridView",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        if(iExit== DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeExit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtSid, txtFirstname, txtlastname, txtAddress, txtbdate, txtMno);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            iDelete();
        }


        private void iDelete()
        {
            foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            iReset();
        }


        private void  iReset()
        {

            //*****Clear the data from textbox
            foreach (var c in this.Controls)
            { 
                if(c  is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                 
            }  

            // *********** clear all data from dataGridView
            int numRows = dataGridView1.Rows.Count;
                for(int i=0; i < numRows; i++)
            {
                try
                {

                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);

                }
                catch (Exception exe)
                {
                    MessageBox.Show("All rows has been deleted" +exe ,"dataGridView Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iReset();
        }

        Bitmap bitmap;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int Height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0,0,dataGridView1.Width,dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = Height;


        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
