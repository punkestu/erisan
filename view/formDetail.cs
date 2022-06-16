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
    public partial class formDetail : Form
    {
        private Form1? parent;
        public formDetail(Form1? parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public void initData(int idArisan)
        {
            DataRow? arisan = parent?.you.arisan?.getArisanDetail(idArisan);
            DataTable? anggota = parent?.you.anggota?.getAnggotaDetail(idArisan);
            namaArisan.Text = arisan?[0].ToString();
            start.Text = "Status : "+(System.Convert.ToInt16(arisan?[1]) == 1? "Started" : "Stop");
            admin.Text =    "Admin : "+arisan?[2].ToString();
            target.Text =   "Target Arisan : " + arisan?[3].ToString();
            tanggota.Text = "Target Anggota : " + arisan?[4].ToString();
            iuran.Text = "Iuran : " + arisan?[5].ToString();
            mulai.Text = "Tanggal Mulai : " + arisan?[6].ToString();
            batas.Text = "Tanggal Batas : " + arisan?[6].ToString();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (DataRow? r in anggota?.Rows)
            {
                //MessageBox.Show("bayar: "+r[1].ToString() + "| Menang: " + r[2].ToString());
                dataGridView1.Rows.Add(r?[0], r?[1].ToString() != "", r?[2].ToString() != "");
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
