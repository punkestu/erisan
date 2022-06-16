using System.Data;
using Npgsql;

namespace Model
{
      public class PaymentHistory : Base
      {
            public PaymentHistory(DB db)
            {
                  this.db = db;
                  this.table = "paymenthistory";
                  if (!Tool.tableExist(this.db, "paymenthistory"))
                  {
                        string? res = this.db.nonQuery("CREATE TABLE paymentHistory(paymentHistory_id smallserial primary key, anggota_id integer not null, tanggal_bayar date not null);");
                        this.db.nonQuery("alter table payment add constraint arisan_fk foreign key (anggota_id) references anggota (anggota_id);");
                  }
            }
            public string dump(DataTable paymentH)
            {
                  foreach(DataRow r in paymentH.Rows){
                        string? res = this.db?.nonQuery("insert into paymenthistory(anggota_id, tanggal_bayar) values(@p1, @p2);", new NpgsqlParameter("p1", r[0]), new NpgsqlParameter("p2",r[1]));
                  }
                  return "success";
            }
      }
}