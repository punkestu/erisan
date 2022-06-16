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
    public partial class joinArisan : UserControl
    {
        private Form1 parent;
        private formDetail? d;
        public joinArisan(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            initData();
        }
        private void initData()
        {
            DataTable? dt = parent.you.arisan?.getListArisan(new Npgsql.NpgsqlParameter("start", System.Convert.ToInt32(0)));
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow r in dt.Rows)
                {
                    dataGridView1.Rows.Add(r[0],r[1], r[2]);
                    DataGridViewButtonCell c1 = (DataGridViewButtonCell)dataGridView1.Rows[i].Cells[3];
                    c1.FlatStyle = FlatStyle.Flat;
                    c1.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    c1.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
                    DataGridViewButtonCell c2 = (DataGridViewButtonCell)dataGridView1.Rows[i].Cells[4];
                    c2.FlatStyle = FlatStyle.Flat;
                    c2.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    c2.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
                    i++;
                }
            }
            else
            {
                MessageBox.Show("data is null");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parent.movetoMenu2(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                MessageBox.Show(parent.you.joinArisan(System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)).message);
                parent.movetoMenu2(sender, e);
            }
            if(e.ColumnIndex == 4)
            {
                d = new formDetail(parent);
                int idArisan = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                d.initData(idArisan);
                d.Show();
            }
        }
    }
}
