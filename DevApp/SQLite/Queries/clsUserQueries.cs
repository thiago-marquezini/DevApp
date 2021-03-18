using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data;
using System.Data.SQLite;

// TUTORIAL //
// https://www.codeproject.com/Articles/746191/SQLite-Helper-Csharp

namespace DevApp.SQLite.Queries
{
    class clsUserQueries
    {
        public void CreateDatabase()
        {
            SQLiteConnection.CreateFile("F:\\DevAppSQLiteDB\\DevApp.sqlite");
        }

        public void CreateUser(string User, string Password, int Level)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=F:\\DevAppSQLiteDB\\DevApp.sqlite"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.BeginTransaction();
                    try
                    {
                        var dic = new Dictionary<string, object>();
                        dic["name"] = User;
                        dic["password"] = Password;
                        dic["level"] = Level;

                        sh.Insert("users", dic);
                        sh.Commit();

                        XtraMessageBox.Show("User added successfully.", "Message", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        sh.Rollback();
                        XtraMessageBox.Show("Failed adding user.", "Message", MessageBoxButtons.OK);
                    }
                }

                conn.Close();
            }
        }

        public bool Login(string User, string Password)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=F:\\DevAppSQLiteDB\\DevApp.sqlite"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataTable dt = sh.Select("select * from users where name = @name and password = @password;",
                    new SQLiteParameter[] {
                        new SQLiteParameter("@name", sh.Escape(User)),
                        new SQLiteParameter("@password", sh.Escape(Password))
                    });

                    if (dt.Rows.Count == 1)
                    {
                        DataRow r = dt.Rows[0];
                        //foreach (DataRow r in dt.Rows)
                        //{
                        //}
                        string LogginedUserLevel = r["level"].ToString();
                        if (LogginedUserLevel == "1")
                        {
                            XtraMessageBox.Show("Login Success: " + r["name"].ToString(), "DevApp", MessageBoxButtons.OK);
                            return true;
                        } else
                        {
                            XtraMessageBox.Show("Login Not Authorized: " + r["name"].ToString(), "DevApp", MessageBoxButtons.OK);
                            return false;
                        }

                    } else
                    {
                        XtraMessageBox.Show("Incorrect username or password.", "DevApp", MessageBoxButtons.OK);
                    }

                    // Create Users Table
                    //SQLiteTable tb = new SQLiteTable("users");
                    //tb.Columns.Add(new SQLiteColumn("id", true));
                    //tb.Columns.Add(new SQLiteColumn("name"));
                    //tb.Columns.Add(new SQLiteColumn("password"));
                    //tb.Columns.Add(new SQLiteColumn("level", ColType.Decimal, false, false, true, "1"));
                    //sh.CreateTable(tb);

                    conn.Close();
                }
            }

            return true;
        }
    }
}
