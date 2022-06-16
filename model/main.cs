using Npgsql;
using System.Data;
namespace Model
{
      public class DB
      {
            public NpgsqlConnection? conn;
            public DB()
            {
                  try
                  {
                        this.conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=erisan; UserId=postgres; Password=qonitah00");
                        this.conn.Open();
                  }
                  catch (Exception ex)
                  {
                        System.Console.WriteLine(ex.Message);
                  }
            }
            public DataTable query(string sql, params NpgsqlParameter[] parameters)
            {
                  try
                  {
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conn);
                        foreach (var p in parameters)
                        {
                              cmd.Parameters.Add(p);
                        }
                        cmd.CommandType = CommandType.Text;
                        cmd.Prepare();
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmd.Dispose();
                        return dt;
                  }
                  catch (Exception ex)
                  {
                        System.Console.WriteLine(ex.Message);
                        return new DataTable();
                  }

            }
            public string nonQuery(string sql, params NpgsqlParameter[] parameters)
            {
                  try
                  {
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conn);
                        foreach (var p in parameters)
                        {
                              cmd.Parameters.Add(p);
                        }
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                  }
                  catch (Exception ex)
                  {
                        System.Console.WriteLine(ex.Message);
                        return ex.Message;
                  }
                  return "";
            }
            public void Close()
            {
                  this.conn?.Close();
            }
      }
      public class Base
      {
            protected DB? db;
            protected string? table;
            protected DataTable get(string col, string join, params NpgsqlParameter[] par)
            {
                  DataTable? dt = new DataTable();
                  string con = "where";
                  foreach (var p in par)
                  {
                        if (con != "where")
                        {
                              con += " and";
                        }
                        if (p.Value == DBNull.Value)
                        {
                              con += " " + p.ParameterName + " is null";
                        }
                        else
                        {
                              con += " " + p.ParameterName + " = @" + p.ParameterName;
                        }
                  }

                  if (con == "where")
                  {
                        dt = this.db?.query("select " + col + " from " + table + " " + join + ";");
                  }
                  else
                  {
                        dt = this.db?.query("select " + col + " from " + table + " " + join + con + ";", par);
                  }
                  return dt == null ? new DataTable() : dt;
            }
            public DataTable get(params NpgsqlParameter[] parameter)
            {
                  DataTable dt = get("*", "", parameter);
                  return dt;
            }
            public DataRow? getLastRow(params NpgsqlParameter[] parameters){
                  DataTable dt = get("*","",parameters);
                  if(dt.Rows.Count != 0){
                        return dt.Rows[dt.Rows.Count-1];
                  }
                  return null;
            }
            public bool isExist(params NpgsqlParameter[] parameter)
            {
                  DataTable dt = get("*", "", parameter);
                  if (dt.Rows.Count != 0)
                  {
                        return true;
                  }
                  return false;
            }
      }
      public class Tool
      {
            public static void PrintTable(DataTable? dt)
            {
                  DataTableReader? dtReader = dt?.CreateDataReader();
                  if (dtReader != null)
                  {
                        while (dtReader.Read())
                        {
                              for (int i = 0; i < dtReader?.FieldCount; i++)
                              {
                                    Console.Write("{0}: {1}  | ",
                                        dtReader.GetName(i).Trim(),
                                        dtReader?.GetValue(i)?.ToString()?.Trim());
                              }
                              Console.WriteLine();
                        }
                        dtReader.Close();
                  }
            }
            public static bool tableExist(DB db, string tableName)
            {
                  return System.Convert.ToString(db.query("SELECT EXISTS ( SELECT FROM information_schema.tables WHERE table_schema = 'public' AND table_name = '" + tableName + "');").Rows[0][0]) == "True";
            }
      }
}