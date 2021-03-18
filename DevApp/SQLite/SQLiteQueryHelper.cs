using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;

namespace DevApp.SQLite
{
    class SQLiteQueryHelper
    {
        public static DataTable QueryToDataTable(string Query, SQLiteParameter[] Params)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=F:\\DevAppSQLiteDB\\DevApp.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    if (Params != null)
                    {
                        foreach (SQLiteParameter Param in Params)
                        {
                            Param.Value = sh.Escape(Param.Value.ToString());
                        }
                    }

                    DataTable dt = sh.Select(Query, Params);

                    conn.Close();

                    return dt;
                }
            }
        }

        public static bool ExecuteQuery(string Query, SQLiteParameter[] Params)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=F:\\DevAppSQLiteDB\\DevApp.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    /*
                    if (Params != null)
                    {
                        foreach (SQLiteParameter Param in Params)
                        {
                            Param.Value = sh.Escape(Param.Value.ToString());
                        }
                    }
                    */

                    try { sh.Execute(Query, Params); } catch { return false; }

                    conn.Close();

                    return true;
                }
            }
        }
    }
}
