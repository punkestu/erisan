using System.Data;
using Npgsql;

namespace Model
{
      public class Arisan : Base
      {
            public Arisan(DB db)
            {
                  this.db = db;
                  this.table = "arisan";
                  if (!Tool.tableExist(this.db, "arisan"))
                  {
                        this.db.nonQuery(@"CREATE TABLE arisan(
                              arisan_id smallserial primary key,
                              admin integer not null, 
                              nama_arisan varchar(30) not null unique,
                              target_arisan integer not null,
                              target_anggota integer not null,
                              angsur_per_anggota integer not null,
                              tanggal_mulai date not null,
                              tanggal_batas date, start integer default 0);");
                        this.db.nonQuery("ALTER TABLE arisan ADD CONSTRAINT user_fk FOREIGN KEY (admin) REFERENCES users(user_id);");
                  }
            }
            public DataRow? getArisanDetail(int arisan_id)
            {
                  DataTable dt = get("nama_arisan, start, nama_lengkap, target_arisan, target_anggota, angsur_per_anggota, tanggal_mulai, tanggal_batas", "join users u on (u.user_id = admin)", new NpgsqlParameter("arisan_id", arisan_id));
                  return dt.Rows.Count == 0 ? null : dt.Rows[0];
            }
            public int getJumlahAnggota(int arisan_id)
            {
                  DataTable dt = get("count(anggota_id)", "join anggota a on(a.arisan_id = arisan.arisan_id)", new NpgsqlParameter("a.arisan_id", arisan_id));
                  return System.Convert.ToInt32(dt.Rows[0][0]);
            }
            public int getTargetAnggota(int arisan_id)
            {
                  DataTable dt = get("target_anggota", "", new NpgsqlParameter("arisan_id", arisan_id));
                  return System.Convert.ToInt32(dt.Rows[0][0]);
            }
            public DataTable getListArisan(params NpgsqlParameter[] parameters)
            {
                  return get("arisan_id, nama_arisan, nama_lengkap as admin", "join users u on (u.user_id = admin)", parameters);
            }
            public DataTable getYourArisan(int key)
            {
                  return get("arisan.arisan_id, nama_arisan, nama_lengkap, start, admin", "join anggota a on(arisan.arisan_id = a.arisan_id) join users u on(u.user_id = admin)", new NpgsqlParameter("a.user_id", key));
            }
            public DataRow getAdmin(int arisan_id)
            {
                  return get("admin", "", new NpgsqlParameter("arisan_id", arisan_id)).Rows[0];
            }
            public DataTable getAnggotaArisan(params NpgsqlParameter[] parameters)
            {
                  return get("a.anggota_id, nama_arisan, nama_lengkap", "join anggota a on(a.arisan_id = arisan.arisan_id) join users u on (u.user_id = a.user_id)", parameters);
            }
            public DataTable getPaymentArisan(params NpgsqlParameter[] parameters)
            {
                  return get("a.anggota_id, nama_arisan, nama_lengkap, tanggal_bayar, payment_id", "join anggota a on(arisan.arisan_id = a.arisan_id) left join payment p on (a.anggota_id = p.anggota_id) join users u on(u.user_id = a.user_id)", parameters);
            }
            public DataTable getOnlyPaid(params NpgsqlParameter[] parameters)
            {
                  return get("a.anggota_id, nama_arisan, nama_lengkap, tanggal_bayar, payment_id", "join anggota a on(arisan.arisan_id = a.arisan_id) join payment p on (a.anggota_id = p.anggota_id) join users u on(u.user_id = a.user_id)", parameters);
            }
            public DataTable getWinnerArisan(params NpgsqlParameter[] parameters)
            {
                  return get("a.anggota_id, nama_arisan, nama_lengkap, tanggal_pengumuman, winner_id", "join anggota a on(arisan.arisan_id = a.arisan_id) left join winner w on (a.anggota_id = w.anggota_id) join users u on(u.user_id = a.user_id)", parameters);
            }
            public DataTable getOnlyWinner(params NpgsqlParameter[] parameters)
            {
                  return get("a.anggota_id, nama_arisan, nama_lengkap, tanggal_pengumuman, winner_id", "join anggota a on(arisan.arisan_id = a.arisan_id) join winner w on (a.anggota_id = w.anggota_id) join users u on(u.user_id = a.user_id)", parameters);
            }
            public string clearWinnerArisan(int arisan_id)
            {
                  string? res = this.db?.nonQuery("delete from winner w join anggota a on (a.anggota_id = w.anggota_id) where a.arisan_id = @p1", new NpgsqlParameter("p1", arisan_id));
                  return res == null ? "" : res;
            }
            public string createArisan(string? namaArisan, int idAdmin, int targetArisan, int targetAnggota, int iuran, DateTime start, DateTime limit)
            {
                  string? res = this.db?.nonQuery("insert into Arisan(nama_arisan, admin, target_arisan, target_anggota, angsur_per_anggota, tanggal_mulai, tanggal_batas) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7);", new NpgsqlParameter("p1", namaArisan), new NpgsqlParameter("p2", idAdmin), new NpgsqlParameter("p3", targetArisan), new NpgsqlParameter("p4", targetAnggota), new NpgsqlParameter("p5", iuran), new NpgsqlParameter("p6", start.Date), new NpgsqlParameter("p7", limit.Date));
                  return res == null ? "" : res;
            }
            public string startArisan(int key, int arisan_id)
            {
                  string? res = this.db?.nonQuery("update arisan set start = 1 where arisan_id = @p1 and admin = @p2", new NpgsqlParameter("p1", arisan_id), new NpgsqlParameter("p2", key));
                  return res == null ? "" : res;
            }
            public string stopArisan(int key, int arisan_id)
            {
                  string? res = this.db?.nonQuery("update arisan set start = 0 where arisan_id = @p1 and admin = @p2", new NpgsqlParameter("p1", arisan_id), new NpgsqlParameter("p2", key));
                  return res == null ? "" : res;
            }
      }
}