using System.Data;
using Npgsql;

namespace Model
{
      public class Winner : Base
      {
            public Winner(DB db)
            {
                  this.db = db;
                  this.table = "winner";
                  if (!Tool.tableExist(this.db, "winner"))
                  {
                        this.db.nonQuery("CREATE TABLE winner(winner_id smallserial primary key, anggota_id integer not null, tanggal_pengumuman date default now());");
                        this.db.nonQuery("alter table winner add constraint arisan_fk foreign key (anggota_id) references anggota (anggota_id);");
                  }
            }
            public string addWinner(int anggota_id)
            {
                  string? res = this.db?.nonQuery("insert into Winner(anggota_id) values(@p1);", new NpgsqlParameter("p1", anggota_id));
                  return res == null ? "" : res;
            }
      }
}