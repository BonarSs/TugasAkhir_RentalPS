namespace WindowsFormsApp3
{
    partial class FormAdmin
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
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.TxtBoxt_UserName = new System.Windows.Forms.TextBox();
            this.RegisterAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Noto Sans KR Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.register_button.Location = new System.Drawing.Point(269, 193);
            this.register_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(108, 37);
            this.register_button.TabIndex = 21;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Noto Sans KR Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.login_button.Location = new System.Drawing.Point(155, 193);
            this.login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(110, 37);
            this.login_button.TabIndex = 20;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.TxtBox_Password.Font = new System.Drawing.Font("Noto Sans KR", 9.75F, System.Drawing.FontStyle.Italic);
            this.TxtBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.TxtBox_Password.Location = new System.Drawing.Point(155, 140);
            this.TxtBox_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.Size = new System.Drawing.Size(222, 26);
            this.TxtBox_Password.TabIndex = 18;
            this.TxtBox_Password.Text = "Password";
            this.TxtBox_Password.TextChanged += new System.EventHandler(this.TxtBox_Password_TextChanged);
            // 
            // TxtBoxt_UserName
            // 
            this.TxtBoxt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.TxtBoxt_UserName.Font = new System.Drawing.Font("Noto Sans KR", 9.75F, System.Drawing.FontStyle.Italic);
            this.TxtBoxt_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.TxtBoxt_UserName.Location = new System.Drawing.Point(155, 106);
            this.TxtBoxt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxt_UserName.Name = "TxtBoxt_UserName";
            this.TxtBoxt_UserName.Size = new System.Drawing.Size(222, 26);
            this.TxtBoxt_UserName.TabIndex = 16;
            this.TxtBoxt_UserName.Text = "Username";
            this.TxtBoxt_UserName.TextChanged += new System.EventHandler(this.TxtBoxt_UserName_TextChanged);
            // 
            // RegisterAdmin
            // 
            this.RegisterAdmin.AutoSize = true;
            this.RegisterAdmin.Font = new System.Drawing.Font("Noto Sans KR", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegisterAdmin.ForeColor = System.Drawing.Color.White;
            this.RegisterAdmin.Location = new System.Drawing.Point(182, 61);
            this.RegisterAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterAdmin.Name = "RegisterAdmin";
            this.RegisterAdmin.Size = new System.Drawing.Size(169, 30);
            this.RegisterAdmin.TabIndex = 15;
            this.RegisterAdmin.Text = "Register Admin";
            this.RegisterAdmin.Click += new System.EventHandler(this.RegisterAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.ahhaerhaerhar;
            this.pictureBox1.Location = new System.Drawing.Point(-20, -191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 881);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.register_button);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.TxtBox_Password);
            this.panel1.Controls.Add(this.TxtBoxt_UserName);
            this.panel1.Controls.Add(this.RegisterAdmin);
            this.panel1.Location = new System.Drawing.Point(217, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 303);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.affae;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 96);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.TextBox TxtBoxt_UserName;
        private System.Windows.Forms.Label RegisterAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}