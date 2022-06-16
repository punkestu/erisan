public class Kode
{
      public int code;
      public string? message;

      public Kode(int code, string message)
      {
            this.code = code;
            this.message = message;
      }
}
public class Account
{
      public int key { set; get; }
      public Model.Arisan? arisan { set; get; }
      public Model.Anggota? anggota { set; get; }
      public Model.Payment? payment { set; get; }
      public Model.Winner? winner { set; get; }
      public Model.Users? user { set; get; }
      public Account(int key = -1)
      {
            this.key = key;
      }
      public Kode Register(string nama_lengkap, string username, string password, string alamat, string telp)
      {
            if (user != null)
            {
                  if (!user.isExist(new Npgsql.NpgsqlParameter("user_name", username)))
                  {
                        user.registerUser(nama_lengkap, username, password, alamat, telp);
                        this.key = System.Convert.ToInt32(user.getAccount(username, password).Rows[0][0]);
                        return new Kode(0, "success");
                  }
                  return new Kode(2, "user is exist");
            }
            return new Kode(1, "user table is null");
      }
      public Kode login(string username, string password)
      {
            if (user != null)
            {
                  System.Data.DataTable dt = user.getAccount(username, password);
                  if (dt.Rows.Count != 0)
                  {
                        this.key = System.Convert.ToInt32(dt.Rows[0][0]);
                        return new Kode(0, "success");
                  }
                  return new Kode(2, "user not found");
            }
            return new Kode(1, "user table is null");
      }
      public Kode buatArisan(string? namaArisan, int targetArisan, int targetAnggota, int iuran, DateTime start, DateTime limit)
      {
            if (this.arisan != null && this.anggota != null)
            {
                  if (!this.arisan.isExist(new Npgsql.NpgsqlParameter("nama_arisan", namaArisan)))
                  {
                        this.arisan.createArisan(namaArisan, this.key, targetArisan, targetAnggota, iuran, start, limit);
                        System.Data.DataRow? r = arisan.getLastRow();
                        if (r != null)
                        {
                              this.anggota.createAnggota(System.Convert.ToInt32(r[0]), this.key);
                              return new Kode(0, "success");
                        }
                        return new Kode(3, "row is null");
                  }
                  return new Kode(2, "this arisan name is exist");
            }
            return new Kode(1, "arisan or anggota table is null");
      }
      public Kode joinArisan(int arisan_id)
      {
            if (this.anggota != null && this.arisan != null)
            {
                  System.Data.DataTable? dt = this.arisan?.get(new Npgsql.NpgsqlParameter("arisan_id", arisan_id), new Npgsql.NpgsqlParameter("start", System.Convert.ToInt32(0)));
                  if (dt?.Rows.Count != 0)
                  {
                        if (!this.anggota.isExist(new Npgsql.NpgsqlParameter("arisan_id", System.Convert.ToInt32(dt?.Rows[0][0])), new Npgsql.NpgsqlParameter("user_id", this.key)))
                        {
                              this.anggota.createAnggota(arisan_id, this.key);
                              return new Kode(0, "success");
                        }
                        return new Kode(3, "you have been join this arisan");
                  }
                  return new Kode(2, "arisan is empty");
            }
            return new Kode(1, "arisan or anggota table is null");
      }
      public Kode bayarArisan(int arisan_id)
      {
            if (this.arisan != null && this.anggota != null && this.payment != null)
            {
                  if (this.arisan.isExist(new Npgsql.NpgsqlParameter("arisan_id", arisan_id), new Npgsql.NpgsqlParameter("start", 1)))
                  {
                        System.Data.DataTable dt = this.anggota.get(new Npgsql.NpgsqlParameter("arisan_id", arisan_id), new Npgsql.NpgsqlParameter("user_id", this.key));
                        payment.addPayment(System.Convert.ToInt32(dt.Rows[0][0]));
                        return new Kode(0, "success");
                  }
                  return new Kode(2, "arisan is not found");
            }
            return new Kode(1, "arisan or anggota or payment table is null");
      }
      public Kode rollArisan(int arisan_id)
      {
            if (this.arisan != null && this.winner != null)
            {
                  if (System.Convert.ToInt32(this.arisan.getAdmin(arisan_id)[0]) == this.key)
                  {
                        System.Data.DataTable dt = arisan.getWinnerArisan(new Npgsql.NpgsqlParameter("winner_id", DBNull.Value));
                        if (dt.Rows.Count != 0)
                        {
                              Random r = new Random();
                              int rid = 0;
                              for (int ctr = 0; ctr <= 100; ctr++)
                                    rid = r.Next(dt.Rows.Count);
                              this.winner.addWinner(System.Convert.ToInt32(dt.Rows[rid][0]));
                              return new Kode(0, "success");
                        }
                        return new Kode(2, "semua anggota sudah menang");
                  }
                  return new Kode(3, "anda bukan admin");
            }
            return new Kode(1, "arisan table is null");
      }
      public System.Data.DataTable? getArisan()
      {
            return this.arisan?.getYourArisan(this.key);
      }
}