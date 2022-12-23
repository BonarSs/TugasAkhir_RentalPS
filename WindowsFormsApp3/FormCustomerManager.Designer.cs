namespace WindowsFormsApp3
{
    partial class FormCustomerManager
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
            this.login_tabelDataSet = new WindowsFormsApp3.login_tabelDataSet();
            this.logintabelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.btn_Hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.login_tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logintabelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_tabelDataSet
            // 
            this.login_tabelDataSet.DataSetName = "login_tabelDataSet";
            this.login_tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logintabelDataSetBindingSource
            // 
            this.logintabelDataSetBindingSource.DataSource = this.login_tabelDataSet;
            this.logintabelDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 56;
            this.dataGridView1.Size = new System.Drawing.Size(952, 479);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR", 9.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans KR", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans KR", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barang Pinjaman";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(143, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(143, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(143, 75);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 3;
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.btn_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simpan.Font = new System.Drawing.Font("Noto Sans KR Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Simpan.Location = new System.Drawing.Point(143, 111);
            this.btn_Simpan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(101, 38);
            this.btn_Simpan.TabIndex = 5;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = false;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(194)))), ((int)(((byte)(2)))));
            this.btn_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hapus.Font = new System.Drawing.Font("Noto Sans KR Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Hapus.Location = new System.Drawing.Point(248, 111);
            this.btn_Hapus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(101, 38);
            this.btn_Hapus.TabIndex = 7;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = false;
            this.btn_Hapus.Click += new System.EventHandler(this.btn_Hapus_Click);
            // 
            // FormCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCustomerManager";
            this.Text = "FormCustomerManager";
            this.Load += new System.EventHandler(this.FormCustomerManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logintabelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private login_tabelDataSet login_tabelDataSet;
        private System.Windows.Forms.BindingSource logintabelDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_Hapus;
    }
}