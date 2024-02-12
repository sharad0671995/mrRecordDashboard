namespace StudentDemo_U
{
    partial class Home_Pagecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Pagecs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.stdRNo = new System.Windows.Forms.Label();
            this.txtStdRNo = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.OliveDrab;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(84, 37);
            this.Display.TabIndex = 1;
            this.Display.Text = "Dispaly";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Teal;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.LightCoral;
            this.Update.Location = new System.Drawing.Point(26, 176);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(81, 37);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DeepPink;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(140, 176);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 37);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(22, 93);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(82, 20);
            this.FirstName.TabIndex = 7;
            this.FirstName.Text = "FirstName";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(113, 90);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(146, 26);
            this.txtFirstname.TabIndex = 8;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(22, 133);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(82, 20);
            this.LastName.TabIndex = 9;
            this.LastName.Text = "LastName";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(115, 130);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(144, 26);
            this.txtLastname.TabIndex = 10;
            // 
            // stdRNo
            // 
            this.stdRNo.AutoSize = true;
            this.stdRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdRNo.Location = new System.Drawing.Point(22, 60);
            this.stdRNo.Name = "stdRNo";
            this.stdRNo.Size = new System.Drawing.Size(66, 20);
            this.stdRNo.TabIndex = 12;
            this.stdRNo.Text = "StdRNo";
            // 
            // txtStdRNo
            // 
            this.txtStdRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdRNo.Location = new System.Drawing.Point(113, 57);
            this.txtStdRNo.Name = "txtStdRNo";
            this.txtStdRNo.Size = new System.Drawing.Size(146, 26);
            this.txtStdRNo.TabIndex = 13;
            this.txtStdRNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(584, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Search here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Home_Pagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 420);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtStdRNo);
            this.Controls.Add(this.stdRNo);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Home_Pagecs";
            this.Text = "Home_Pagecs";
            this.Load += new System.EventHandler(this.Home_Pagecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label stdRNo;
        private System.Windows.Forms.TextBox txtStdRNo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}