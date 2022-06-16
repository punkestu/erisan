using System.Data;
using Npgsql;

namespace Model
{
      public class Payment : Base
      {
            PaymentHistory? history;
            public Payment(DB db)
            {
                  this.db = db;
                  this.table = "payment";
                  if (!Tool.tableExist(this.db, "payment"))
                  {
                        this.db.nonQuery("CREATE TABLE payment(payment_id smallserial primary key, anggota_id integer not null, tanggal_bayar date default now());");
                        this.db.nonQuery("alter table payment add constraint arisan_fk foreign key (anggota_id) references anggota (anggota_id);");
                  }
                  this.history = new PaymentHistory(db);
            }
            public string dumpPaymentArisan(int arisan_id)
            {
                  DataTable dt = get("a.anggota_id, tanggal_bayar","join anggota a on (a.anggota_id = payment.anggota_id)",new NpgsqlParameter("a.arisan_id",arisan_id));
                  this.history?.dump(dt);
                  string? res = this.db?.nonQuery("DELETE FROM payment p using anggota a WHERE a.anggota_id = p.anggota_id and a.arisan_id = @p1;", new NpgsqlParameter("p1", arisan_id));
                  return res == null ? "" : res;
            }
            public string addPayment(int anggota_id)
            {
                  string? res = this.db?.nonQuery("insert into payment(anggota_id) values(@p1);", new NpgsqlParameter("p1", anggota_id));
                  return res == null ? "" : res;
            }
      }
}