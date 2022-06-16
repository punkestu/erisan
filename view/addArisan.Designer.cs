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
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(25, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(300, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Buat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // namaArisan
            // 
            this.namaArisan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namaArisan.Location = new System.Drawing.Point(300, 153);
            this.namaArisan.Name = "namaArisan";
            this.namaArisan.Size = new System.Drawing.Size(200, 25);
            this.namaArisan.TabIndex = 1;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start.Location = new System.Drawing.Point(300, 357);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 25);
            this.start.TabIndex = 5;
            // 
            // limit
            // 
            this.limit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limit.Location = new System.Drawing.Point(300, 408);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(200, 25);
            this.limit.TabIndex = 6;
            // 
            // targetArisan
            // 
            this.targetArisan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetArisan.Location = new System.Drawing.Point(300, 204);
            this.targetArisan.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.targetArisan.Name = "targetArisan";
            this.targetArisan.Size = new System.Drawing.Size(200, 25);
            this.targetArisan.TabIndex = 2;
            // 
            // targetAnggota
            // 
            this.targetAnggota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetAnggota.Location = new System.Drawing.Point(300, 255);
            this.targetAnggota.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.targetAnggota.Name = "targetAnggota";
            this.targetAnggota.Size = new System.Drawing.Size(200, 25);
            this.targetAnggota.TabIndex = 3;
            // 
            // iuran
            // 
            this.iuran.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iuran.Location = new System.Drawing.Point(300, 306);
            this.iuran.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.iuran.Name = "iuran";
            this.iuran.Size = new System.Drawing.Size(200, 25);
            this.iuran.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Arisan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Target Arisan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(300, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Target Anggota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(300, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Iuran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(300, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(300, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
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
