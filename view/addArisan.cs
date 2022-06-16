using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekPBO_Arisan
{
    public partial class addArisan : UserControl
    {
        private Form1 parent;
        public addArisan(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.movetoMenu2(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(parent.you.buatArisan(namaArisan.Text, System.Convert.ToInt32(targetArisan.Value), System.Convert.ToInt32(targetAnggota.Value), System.Convert.ToInt32(iuran.Value), start.Value, limit.Value).message);
            parent.movetoMenu2(sender, e);
        }

        private void taretArisan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
