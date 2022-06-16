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
    public partial class menu1 : UserControl
    {
        private Form1 parent;
        public menu1(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void masuk_Click(object sender, EventArgs e)
        {
            parent.movetoLogin(sender, e);
        }

        private void daftar_Click(object sender, EventArgs e)
        {
            parent.movetoSignup(sender, e);
        }
    }
}
