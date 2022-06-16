namespace projekPBO_Arisan
{
    partial class menu2
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
            this.back = new System.Windows.Forms.Button();
            this.buat = new System.Windows.Forms.Button();
            this.join = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idArisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaArisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bayar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.roll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(35, 29);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "< back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // buat
            // 
            this.buat.Location = new System.Drawing.Point(323, 394);
            this.buat.Name = "buat";
            this.buat.Size = new System.Drawing.Size(75, 23);
            this.buat.TabIndex = 1;
            this.buat.Text = "buat arisan";
            this.buat.UseVisualStyleBackColor = true;
            this.buat.Click += new System.EventHandler(this.buat_Click);
            // 
            // join
            // 
            this.join.Location = new System.Drawing.Point(424, 394);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(75, 23);
            this.join.TabIndex = 2;
            this.join.Text = "join arisan";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArisan,
            this.namaArisan,
            this.admin,
            this.start,
            this.bayar,
            this.detail,
            this.roll,
            this.idAdmin});
            this.dataGridView1.Location = new System.Drawing.Point(75, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 212);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idArisan
            // 
            this.idArisan.HeaderText = "idarisan";
            this.idArisan.Name = "idArisan";
            this.idArisan.ReadOnly = true;
            this.idArisan.Visible = false;
            // 
            // namaArisan
            // 
            this.namaArisan.HeaderText = "Nama Arisan";
            this.namaArisan.Name = "namaArisan";
            this.namaArisan.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.HeaderText = "Admin";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // start
            // 
            this.start.HeaderText = "Start";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // bayar
            // 
            this.bayar.HeaderText = "Bayar";
            this.bayar.Name = "bayar";
            this.bayar.ReadOnly = true;
            this.bayar.Text = "Bayar";
            this.bayar.UseColumnTextForButtonValue = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "Detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "Detail";
            this.detail.UseColumnTextForButtonValue = true;
            // 
            // roll
            // 
            this.roll.HeaderText = "Roll";
            this.roll.Name = "roll";
            this.roll.ReadOnly = true;
            // 
            // idAdmin
            // 
            this.idAdmin.HeaderText = "idAdmin";
            this.idAdmin.Name = "idAdmin";
            this.idAdmin.ReadOnly = true;
            this.idAdmin.Visible = false;
            // 
            // menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.join);
            this.Controls.Add(this.buat);
            this.Controls.Add(this.back);
            this.Name = "menu2";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button back;
        private Button buat;
        private Button join;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idArisan;
        private DataGridViewTextBoxColumn namaArisan;
        private DataGridViewTextBoxColumn admin;
        private DataGridViewButtonColumn start;
        private DataGridViewButtonColumn bayar;
        private DataGridViewButtonColumn detail;
        private DataGridViewButtonColumn roll;
        private DataGridViewTextBoxColumn idAdmin;
    }
}
