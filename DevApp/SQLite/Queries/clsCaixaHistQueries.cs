using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using DevApp.Global;

namespace DevApp.SQLite
{
    class clsCaixaHistQueries
    {
        public List<CaixaObj> ListarCaixas(SQLiteConnection db)
        {
            return db.Table<CaixaObj>().OrderByDescending(t => t.Id).ToList();
        }

        public List<CaixaObj> ListarPorPeriodo(SQLiteConnection db, string DateInicio, string DateFinal)
        {
            string PeriodQry = $"SELECT * FROM caixa WHERE opendate BETWEEN " + DateInicio + " AND " + DateFinal + " ORDER BY id DESC;";
            return db.Query<CaixaObj>(PeriodQry);

        }

        public List<CaixaObj> ListarPorUsuario(SQLiteConnection db, string Usuario)
        {
            return db.Table<CaixaObj>().Where(t => t.Owner == Usuario).OrderByDescending(t => t.Id).ToList();
        }
    }
}
