namespace StudentDemo_U
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            this.SignUpk = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.StdRoll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.ConformP = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpk
            // 
            this.SignUpk.AutoSize = true;
            this.SignUpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpk.Location = new System.Drawing.Point(218, 33);
            this.SignUpk.Name = "SignUpk";
            this.SignUpk.Size = new System.Drawing.Size(110, 33);
            this.SignUpk.TabIndex = 0;
            this.SignUpk.Text = "SignUp";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(207, 91);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(147, 26);
            this.txtRollNo.TabIndex = 1;
            this.txtRollNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtRollNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRollNo_KeyPress);
            this.txtRollNo.Leave += new System.EventHandler(this.txtRollNo_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtgender.Location = new System.Drawing.Point(207, 246);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(147, 28);
            this.txtgender.TabIndex = 3;
            this.txtgender.SelectedIndexChanged += new System.EventHandler(this.txtgender_SelectedIndexChanged);
            this.txtgender.Leave += new System.EventHandler(this.txtgender_Leave);
            // 
            // StdRoll
            // 
            this.StdRoll.AutoSize = true;
            this.StdRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdRoll.Location = new System.Drawing.Point(98, 97);
            this.StdRoll.Name = "StdRoll";
            this.StdRoll.Size = new System.Drawing.Size(66, 20);
            this.StdRoll.TabIndex = 6;
            this.StdRoll.Text = "StdRNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "FirstName";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(207, 149);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(147, 26);
            this.txtfirstname.TabIndex = 8;
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstname_KeyPress);
            this.txtfirstname.Leave += new System.EventHandler(this.txtfirstname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "lastName";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(207, 198);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(147, 26);
            this.txtLastname.TabIndex = 10;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(98, 244);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(63, 20);
            this.gender.TabIndex = 11;
            this.gender.Text = "Gender";
            // 
            // ConformP
            // 
            this.ConformP.AutoSize = true;
            this.ConformP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConformP.Location = new System.Drawing.Point(98, 355);
            this.ConformP.Name = "ConformP";
            this.ConformP.Size = new System.Drawing.Size(80, 20);
            this.ConformP.TabIndex = 13;
            this.ConformP.Text = "ConformP";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(98, 285);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 20);
            this.email.TabIndex = 14;
            this.email.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(207, 285);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(147, 26);
            this.txtemail.TabIndex = 15;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(98, 320);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 16;
            this.Password.Text = "Passowrd";
            // 
            // txtcpass
            // 
            this.txtcpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpass.Location = new System.Drawing.Point(207, 355);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.Size = new System.Drawing.Size(147, 26);
            this.txtcpass.TabIndex = 17;
            this.txtcpass.UseSystemPasswordChar = true;
            this.txtcpass.Leave += new System.EventHandler(this.txtcpass_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(207, 320);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(147, 26);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Orange;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(247, 403);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 50);
            this.reset.TabIndex = 19;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 477);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtcpass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ConformP);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StdRoll);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.SignUpk);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpk;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.Label StdRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label ConformP;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}