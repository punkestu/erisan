namespace projekPBO_Arisan
{
    partial class menu1
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
            this.masuk = new System.Windows.Forms.Button();
            this.daftar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // masuk
            // 
            this.masuk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.masuk.FlatAppearance.BorderSize = 0;
            this.masuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masuk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masuk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.masuk.Location = new System.Drawing.Point(300, 298);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(200, 50);
            this.masuk.TabIndex = 0;
            this.masuk.Text = "Masuk";
            this.masuk.UseVisualStyleBackColor = false;
            this.masuk.Click += new System.EventHandler(this.masuk_Click);
            // 
            // daftar
            // 
            this.daftar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.daftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daftar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daftar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.daftar.Location = new System.Drawing.Point(300, 373);
            this.daftar.Name = "daftar";
            this.daftar.Size = new System.Drawing.Size(200, 50);
            this.daftar.TabIndex = 1;
            this.daftar.Text = "Daftar";
            this.daftar.UseVisualStyleBackColor = true;
            this.daftar.Click += new System.EventHandler(this.daftar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 64F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(221, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 114);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Risan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daftar);
            this.Controls.Add(this.masuk);
            this.Name = "menu1";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button masuk;
        private Button daftar;
        private Label label1;
    }
}
