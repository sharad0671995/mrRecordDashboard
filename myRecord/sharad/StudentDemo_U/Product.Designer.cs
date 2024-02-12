namespace StudentDemo_U
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.PId = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Pname = new System.Windows.Forms.Label();
            this.PQuantity = new System.Windows.Forms.Label();
            this.PPrice = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquatity = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(8, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "ProductList";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(129, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.Location = new System.Drawing.Point(276, 122);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(410, 122);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 35);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // PId
            // 
            this.PId.AutoSize = true;
            this.PId.BackColor = System.Drawing.Color.LightCoral;
            this.PId.Location = new System.Drawing.Point(35, 15);
            this.PId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PId.Name = "PId";
            this.PId.Size = new System.Drawing.Size(85, 20);
            this.PId.TabIndex = 5;
            this.PId.Text = "Product_id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(178, 17);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 26);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pname
            // 
            this.Pname.AutoSize = true;
            this.Pname.BackColor = System.Drawing.Color.LightCoral;
            this.Pname.Location = new System.Drawing.Point(33, 72);
            this.Pname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(115, 20);
            this.Pname.TabIndex = 7;
            this.Pname.Text = "Product_Name";
            // 
            // PQuantity
            // 
            this.PQuantity.AutoSize = true;
            this.PQuantity.BackColor = System.Drawing.Color.LightCoral;
            this.PQuantity.Location = new System.Drawing.Point(405, 78);
            this.PQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.Size = new System.Drawing.Size(132, 20);
            this.PQuantity.TabIndex = 8;
            this.PQuantity.Text = "Product_Quantity";
            // 
            // PPrice
            // 
            this.PPrice.AutoSize = true;
            this.PPrice.BackColor = System.Drawing.Color.LightCoral;
            this.PPrice.Location = new System.Drawing.Point(406, 23);
            this.PPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(108, 20);
            this.PPrice.TabIndex = 9;
            this.PPrice.Text = "Product_Price";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(178, 72);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 26);
            this.txtname.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(562, 17);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(148, 26);
            this.txtprice.TabIndex = 11;
            // 
            // txtquatity
            // 
            this.txtquatity.Location = new System.Drawing.Point(562, 72);
            this.txtquatity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtquatity.Name = "txtquatity";
            this.txtquatity.Size = new System.Drawing.Size(148, 26);
            this.txtquatity.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Location = new System.Drawing.Point(562, 122);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GreenYellow;
            this.button6.Location = new System.Drawing.Point(700, 122);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 14;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 316);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(840, 518);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtquatity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.PPrice);
            this.Controls.Add(this.PQuantity);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.PId);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label PId;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label Pname;
        private System.Windows.Forms.Label PQuantity;
        private System.Windows.Forms.Label PPrice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquatity;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}