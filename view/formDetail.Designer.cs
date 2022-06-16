namespace projekPBO_Arisan
{
    partial class formDetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.namaArisan = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.Label();
            this.tanggota = new System.Windows.Forms.Label();
            this.iuran = new System.Windows.Forms.Label();
            this.mulai = new System.Windows.Forms.Label();
            this.batas = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.bayar,
            this.menang});
            this.dataGridView1.Location = new System.Drawing.Point(71, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(449, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            // 
            // nama
            // 
            this.nama.FillWeight = 200F;
            this.nama.HeaderText = "Nama Anggota";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nama.Width = 200;
            // 
            // bayar
            // 
            this.bayar.HeaderText = "Bayar";
            this.bayar.Name = "bayar";
            this.bayar.ReadOnly = true;
            // 
            // menang
            // 
            this.menang.HeaderText = "Menang";
            this.menang.Name = "menang";
            this.menang.ReadOnly = true;
            // 
            // namaArisan
            // 
            this.namaArisan.AutoSize = true;
            this.namaArisan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namaArisan.Location = new System.Drawing.Point(71, 22);
            this.namaArisan.Name = "namaArisan";
            this.namaArisan.Size = new System.Drawing.Size(97, 20);
            this.namaArisan.TabIndex = 1;
            this.namaArisan.Text = "Nama arisan";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(76, 90);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(49, 15);
            this.admin.TabIndex = 2;
            this.admin.Text = "Admin: ";
            // 
            // target
            // 
            this.target.AutoSize = true;
            this.target.Location = new System.Drawing.Point(76, 114);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(81, 15);
            this.target.TabIndex = 3;
            this.target.Text = "Target Arisan: ";
            // 
            // tanggota
            // 
            this.tanggota.AutoSize = true;
            this.tanggota.Location = new System.Drawing.Point(76, 139);
            this.tanggota.Name = "tanggota";
            this.tanggota.Size = new System.Drawing.Size(94, 15);
            this.tanggota.TabIndex = 4;
            this.tanggota.Text = "Target Anggota: ";
            // 
            // iuran
            // 
            this.iuran.AutoSize = true;
            this.iuran.Location = new System.Drawing.Point(317, 90);
            this.iuran.Name = "iuran";
            this.iuran.Size = new System.Drawing.Size(40, 15);
            this.iuran.TabIndex = 5;
            this.iuran.Text = "Iuran: ";
            // 
            // mulai
            // 
            this.mulai.AutoSize = true;
            this.mulai.Location = new System.Drawing.Point(317, 114);
            this.mulai.Name = "mulai";
            this.mulai.Size = new System.Drawing.Size(87, 15);
            this.mulai.TabIndex = 6;
            this.mulai.Text = "Tanggal Mulai: ";
            // 
            // batas
            // 
            this.batas.AutoSize = true;
            this.batas.Location = new System.Drawing.Point(317, 138);
            this.batas.Name = "batas";
            this.batas.Size = new System.Drawing.Size(85, 15);
            this.batas.TabIndex = 7;
            this.batas.Text = "Tanggal Batas: ";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(76, 52);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(43, 15);
            this.start.TabIndex = 8;
            this.start.Text = "started";
            // 
            // formDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.start);
            this.Controls.Add(this.batas);
            this.Controls.Add(this.mulai);
            this.Controls.Add(this.iuran);
            this.Controls.Add(this.tanggota);
            this.Controls.Add(this.target);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.namaArisan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formDetail";
            this.Text = "formDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label namaArisan;
        private Label admin;
        private Label target;
        private Label tanggota;
        private Label iuran;
        private Label mulai;
        private Label batas;
        private Label start;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewCheckBoxColumn bayar;
        private DataGridViewCheckBoxColumn menang;
    }
}