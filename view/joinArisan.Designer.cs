namespace projekPBO_Arisan
{
    partial class joinArisan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idarisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaArisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(30, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarisan,
            this.namaArisan,
            this.admin,
            this.join,
            this.detail});
            this.dataGridView1.Location = new System.Drawing.Point(115, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(570, 330);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idarisan
            // 
            this.idarisan.HeaderText = "id";
            this.idarisan.Name = "idarisan";
            this.idarisan.ReadOnly = true;
            this.idarisan.Visible = false;
            // 
            // namaArisan
            // 
            this.namaArisan.HeaderText = "Nama Arisan";
            this.namaArisan.Name = "namaArisan";
            this.namaArisan.ReadOnly = true;
            this.namaArisan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.namaArisan.Width = 200;
            // 
            // admin
            // 
            this.admin.HeaderText = "Admin";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            this.admin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.admin.Width = 125;
            // 
            // join
            // 
            this.join.HeaderText = "Join";
            this.join.Name = "join";
            this.join.ReadOnly = true;
            this.join.Text = "Join";
            this.join.UseColumnTextForButtonValue = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "Detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "Detail";
            this.detail.UseColumnTextForButtonValue = true;
            // 
            // joinArisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "joinArisan";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idarisan;
        private DataGridViewTextBoxColumn namaArisan;
        private DataGridViewTextBoxColumn admin;
        private DataGridViewButtonColumn join;
        private DataGridViewButtonColumn detail;
    }
}
