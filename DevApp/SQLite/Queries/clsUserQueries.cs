using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using SQLite;

namespace DevApp.SQLite
{
    class clsUserQueries
    {
        public List<UserObj> Login(SQLiteConnection db, string Name, string Password)
        {
            return db.Table<UserObj>().Where(t => (t.Name == Name) && (t.Password == Password)).OrderByDescending(t => t.Id).ToList();
        }
    }
}
