using System.Data;
using Npgsql;

namespace Model
{
      public class Anggota : Base
      {
            public Anggota(DB db)
            {
                  this.db = db;
                  this.table = "anggota";
                  if (!Tool.tableExist(this.db, "anggota"))
                  {
                        this.db.nonQuery("CREATE TABLE anggota(anggota_id smallserial primary key, user_id integer not null, arisan_id integer not null);");
                        this.db.nonQuery("alter table Anggota add constraint arisan_fk foreign key (arisan_id) references Arisan (arisan_id);");
                        this.db.nonQuery("alter table Anggota add constraint user_fk foreign key (user_id) references Users (user_id);");
                  }
            }
            public DataTable getNotWin(int arisan_id){
                  return get("u.user_id, u.name", "join arisan ar on (anggota.arisan_id = ar.arisan_id) left join winner w on (anggota.user_id != ", new NpgsqlParameter("ar.arisan_id",arisan_id));
            }
            public DataTable getAnggotaDetail(int arisan_id)
            {
                  return get("u.nama_lengkap, p.payment_id, w.winner_id", "join users u on(u.user_id = anggota.user_id) left join payment p on (p.anggota_id = anggota.anggota_id) left join winner w on (w.anggota_id = anggota.anggota_id)", new NpgsqlParameter("anggota.arisan_id",arisan_id));
            }
            public string createAnggota(int arisan_id, int user_id)
            {
                  string? res = this.db?.nonQuery("insert into Anggota(arisan_id, user_id) values(@p1,@p2);", new NpgsqlParameter("p1", arisan_id), new NpgsqlParameter("p2", user_id));
                  return res == null ? "" : res;
            }
      }
}