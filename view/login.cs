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
    public partial class login : UserControl
    {
        private Form1 parent;
        public login(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            parent.movetoMenu1(sender, e);
        }

        private void masuk_Click(object sender, EventArgs e)
        {
            parent.you.login(username.Text, password.Text);
            if(parent.you.key != -1)
            {
                parent.movetoMenu2(sender, e);
            }
            else
            {
                MessageBox.Show("username atau password salah");
            }
        }
    }
}
