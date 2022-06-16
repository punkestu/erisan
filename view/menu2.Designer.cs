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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(25, 35);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Logout";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // buat
            // 
            this.buat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buat.FlatAppearance.BorderSize = 0;
            this.buat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buat.Location = new System.Drawing.Point(250, 394);
            this.buat.Name = "buat";
            this.buat.Size = new System.Drawing.Size(150, 40);
            this.buat.TabIndex = 1;
            this.buat.Text = "Buat arisan";
            this.buat.UseVisualStyleBackColor = false;
            this.buat.Click += new System.EventHandler(this.buat_Click);
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.join.FlatAppearance.BorderSize = 0;
            this.join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.join.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.join.Location = new System.Drawing.Point(406, 394);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(150, 40);
            this.join.TabIndex = 2;
            this.join.Text = "Join arisan";
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(78, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(644, 253);
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
            this.namaArisan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // admin
            // 
            this.admin.HeaderText = "Admin";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            this.admin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
