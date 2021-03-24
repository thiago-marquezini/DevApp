using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;

using DevApp.Global;

namespace DevApp.SQLite.Queries
{
    class clsCaixaHistQueries
    {
        public DataTable ListarCaixas()
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa ORDER BY id DESC;", null);
        }

        public DataTable ListarPorPeriodo(string DateInicio, string DateFinal)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa WHERE opendate BETWEEN @inicio AND @fim ORDER BY id DESC;", new SQLiteParameter[] { new SQLiteParameter("@inicio", DateInicio), new SQLiteParameter("@fim", DateFinal) });
        }

        public DataTable ListarPorUsuario(string Usuario)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa WHERE owner = @usuario ORDER BY id DESC;", new SQLiteParameter[] { new SQLiteParameter("@usuario", Usuario) });
        }
    }
}
