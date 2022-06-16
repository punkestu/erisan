using System.Data;
using Npgsql;

namespace Model
{
      public class Users : Base
      {
            public Users(DB db)
            {
                  this.db = db;
                  this.table = "users";
                  if (!Tool.tableExist(this.db, "users"))
                  {
                        this.db.nonQuery("CREATE TABLE users(user_id smallserial primary key,nama_lengkap varchar(30) not null, user_name varchar(30) not null unique, password varchar(30) not null, alamat_user varchar(50) not null,no_telp_user varchar(20) not null);");
                  }
            }
            public DataTable getAccount(string? username, string? password){
                  return get("user_id","",new NpgsqlParameter("user_name",username), new NpgsqlParameter("password",password));
            }
            public string registerUser(string? name, string? username, string? password, string? alamat, string? telp)
            {
                  string? res = this.db?.nonQuery("insert into Users(nama_lengkap, user_name, password, alamat_user, no_telp_user) values(@p1, @p2, @p3, @p4, @p5);", new NpgsqlParameter("p1", name), new NpgsqlParameter("p2", username), new NpgsqlParameter("p3",password), new NpgsqlParameter("p4",alamat), new NpgsqlParameter("p5",telp));
                  return res == null ? "" : res;
            }
      }
}