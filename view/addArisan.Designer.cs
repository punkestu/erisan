namespace projekPBO_Arisan
{
    partial class addArisan
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.namaArisan = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.limit = new System.Windows.Forms.DateTimePicker();
            this.targetArisan = new System.Windows.Forms.NumericUpDown();
            this.targetAnggota = new System.Windows.Forms.NumericUpDown();
            this.iuran = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.targetArisan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetAnggota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iuran)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "< back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // namaArisan
            // 
            this.namaArisan.Location = new System.Drawing.Point(296, 183);
            this.namaArisan.Name = "namaArisan";
            this.namaArisan.Size = new System.Drawing.Size(200, 23);
            this.namaArisan.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(296, 361);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 23);
            this.start.TabIndex = 6;
            // 
            // limit
            // 
            this.limit.Location = new System.Drawing.Point(296, 404);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(200, 23);
            this.limit.TabIndex = 7;
            // 
            // targetArisan
            // 
            this.targetArisan.Location = new System.Drawing.Point(296, 230);
            this.targetArisan.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.targetArisan.Name = "targetArisan";
            this.targetArisan.Size = new System.Drawing.Size(200, 23);
            this.targetArisan.TabIndex = 8;
            // 
            // targetAnggota
            // 
            this.targetAnggota.Location = new System.Drawing.Point(296, 273);
            this.targetAnggota.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.targetAnggota.Name = "targetAnggota";
            this.targetAnggota.Size = new System.Drawing.Size(200, 23);
            this.targetAnggota.TabIndex = 9;
            // 
            // iuran
            // 
            this.iuran.Location = new System.Drawing.Point(296, 316);
            this.iuran.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.iuran.Name = "iuran";
            this.iuran.Size = new System.Drawing.Size(200, 23);
            this.iuran.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Arisan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Target Arisan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Target Anggota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Iuran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Batas";
            // 
            // addArisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iuran);
            this.Controls.Add(this.targetAnggota);
            this.Controls.Add(this.targetArisan);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.namaArisan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "addArisan";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.targetArisan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetAnggota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iuran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox namaArisan;
        private DateTimePicker start;
        private DateTimePicker limit;
        private NumericUpDown targetArisan;
        private NumericUpDown targetAnggota;
        private NumericUpDown iuran;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
