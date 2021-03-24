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
        public DataTable Login(string Name, string Password)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM users WHERE name = @name AND password = @password;", new SQLiteParameter[] { new SQLiteParameter("@name", Name), new SQLiteParameter("@password", Password) });
        }

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
    }
}
