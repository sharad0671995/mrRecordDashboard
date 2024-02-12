namespace StudentDemo_U
{
    partial class VehicleDetail
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
            this.VehicleID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Make = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VehicleID
            // 
            this.VehicleID.AutoSize = true;
            this.VehicleID.Location = new System.Drawing.Point(61, 61);
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Size = new System.Drawing.Size(53, 13);
            this.VehicleID.TabIndex = 1;
            this.VehicleID.Text = "VehicleID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Location = new System.Drawing.Point(61, 97);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(34, 13);
            this.Make.TabIndex = 3;
            this.Make.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(61, 130);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 4;
            this.Model.Text = "Model";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(61, 170);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 5;
            this.Year.Text = "Year";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(61, 202);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 6;
            this.Color.Text = "Color";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(116, 94);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(116, 130);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 8;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(116, 167);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 9;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(116, 202);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 10;
            this.txtColor.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 309);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VehicleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.VehicleID);
            this.Controls.Add(this.button1);
            this.Name = "VehicleDetail";
            this.Text = "VehicleDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VehicleID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label Make;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}