namespace projekPBO_Arisan
{
    partial class signup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daftar = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.telp = new System.Windows.Forms.TextBox();
            this.namaLengkap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(364, 291);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 8;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(364, 247);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "username";
            // 
            // daftar
            // 
            this.daftar.Location = new System.Drawing.Point(375, 418);
            this.daftar.Name = "daftar";
            this.daftar.Size = new System.Drawing.Size(75, 23);
            this.daftar.TabIndex = 9;
            this.daftar.Text = "daftar";
            this.daftar.UseVisualStyleBackColor = true;
            this.daftar.Click += new System.EventHandler(this.daftar_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(30, 32);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 6;
            this.back.Text = "< back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // telp
            // 
            this.telp.Location = new System.Drawing.Point(364, 380);
            this.telp.Name = "telp";
            this.telp.Size = new System.Drawing.Size(100, 23);
            this.telp.TabIndex = 13;
            // 
            // namaLengkap
            // 
            this.namaLengkap.Location = new System.Drawing.Point(364, 203);
            this.namaLengkap.Name = "namaLengkap";
            this.namaLengkap.Size = new System.Drawing.Size(100, 23);
            this.namaLengkap.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "no telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "nama lengkap";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(364, 337);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(100, 23);
            this.alamat.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "alamat";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telp);
            this.Controls.Add(this.namaLengkap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daftar);
            this.Controls.Add(this.back);
            this.Name = "signup";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox password;
        private TextBox username;
        private Label label2;
        private Label label1;
        private Button daftar;
        private Button back;
        private TextBox telp;
        private TextBox namaLengkap;
        private Label label3;
        private Label label4;
        private TextBox alamat;
        private Label label5;
    }
}
