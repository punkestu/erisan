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
            this.SuspendLayout();
            // 
            // masuk
            // 
            this.masuk.Location = new System.Drawing.Point(315, 241);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(200, 50);
            this.masuk.TabIndex = 0;
            this.masuk.Text = "Masuk";
            this.masuk.UseVisualStyleBackColor = true;
            this.masuk.Click += new System.EventHandler(this.masuk_Click);
            // 
            // daftar
            // 
            this.daftar.Location = new System.Drawing.Point(315, 317);
            this.daftar.Name = "daftar";
            this.daftar.Size = new System.Drawing.Size(200, 50);
            this.daftar.TabIndex = 1;
            this.daftar.Text = "Daftar";
            this.daftar.UseVisualStyleBackColor = true;
            this.daftar.Click += new System.EventHandler(this.daftar_Click);
            // 
            // menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.daftar);
            this.Controls.Add(this.masuk);
            this.Name = "menu1";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private Button masuk;
        private Button daftar;
    }
}
