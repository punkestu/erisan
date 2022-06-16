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
    public partial class menu2 : UserControl
    {
        private Form1 parent;
        private formDetail d;
        public menu2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            initData();
        }

        private void back_Click(object sender, EventArgs e)
        {
            parent.you.key = -1;
            parent.movetoMenu1(sender, e);
        }
        private void initData()
        {
            DataTable dt = parent.you.getArisan();
            foreach(DataRow r in dt.Rows)
            {
                string start = System.Convert.ToInt16(r[3]) == 1 ? "started" : "stopped";
                string roll = System.Convert.ToInt32(r[4]) == parent.you.key && start == "started"? "roll" : "disable";
                dataGridView1.Rows.Add(r[0], r[1], r[2], start, "", "", roll, r[4]);
            }
        }

        private void buat_Click(object sender, EventArgs e)
        {
            parent.movetoAddArisan(sender, e);
        }
        private void join_Click(object sender, EventArgs e)
        {
            parent.movetoJoinArisan(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "stopped")
                {
                    if (parent.you.key == System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value))
                    {
                        int id = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        if (parent?.you.arisan?.getJumlahAnggota(id) == parent?.you.arisan?.getTargetAnggota(id))
                        {
                            parent?.you.arisan?.startArisan(parent.you.key, id);
                            parent?.movetoMenu2(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("arisan dapat dimulai jika anggota penuh");
                        }
                    }
                    else
                    {
                        MessageBox.Show("hanya admin yang bisa start arisan");
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "started")
                {
                    if (parent?.you.key == System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value))
                    {
                        int id = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        parent?.you.arisan?.stopArisan(parent.you.key, id);
                        parent?.movetoMenu2(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("hanya admin yang bisa stop arisan");
                    }
                }
            }
            if(e.ColumnIndex == 4)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "started")
                {
                    if (parent?.you.arisan?.getPaymentArisan(new Npgsql.NpgsqlParameter("a.user_id",parent.you.key), new Npgsql.NpgsqlParameter("a.arisan_id", System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)), new Npgsql.NpgsqlParameter("payment_id", DBNull.Value)).Rows.Count != 0)
                    {
                        MessageBox.Show(parent?.you.bayarArisan(System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)).message);
                    }
                    else
                    {
                        MessageBox.Show("Kamu sudah bayar");
                    }
                }
                else
                {
                    MessageBox.Show("arisan belum dimulai");
                }
            }
            if(e.ColumnIndex == 5)
            {
                d = new formDetail(parent);
                int idArisan = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                d.initData(idArisan);
                d.Show();
            }
            if(e.ColumnIndex == 6)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "roll")
                {
                    int idArisan = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    int? targetAnggota = parent?.you.arisan?.getTargetAnggota(idArisan);
                    if (parent?.you.arisan?.getJumlahAnggota(idArisan) == targetAnggota && parent?.you.arisan?.getOnlyPaid(new Npgsql.NpgsqlParameter("a.arisan_id", idArisan)).Rows.Count == targetAnggota)
                    {
                        Kode? k = parent?.you.rollArisan(idArisan);
                        if(k?.code == 0)
                        {
                            parent.you.payment.dumpPaymentArisan(idArisan);
                            System.Data.DataTable? winner = parent?.you.arisan?.getOnlyWinner(new Npgsql.NpgsqlParameter("a.arisan_id", idArisan));
                            MessageBox.Show("Selamat pada "+winner?.Rows[winner.Rows.Count-1][2].ToString()+" karena telah memenangkan arisan hari ini");
                        }
                        else
                        {
                            MessageBox.Show(k.message);
                        }
                    }
                }
            }
        }
    }
}
