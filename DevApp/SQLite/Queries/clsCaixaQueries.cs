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
    class clsCaixaQueries
    {
        public bool OpenCaixa(string StartValue)
        {
            try
            {
                SQLiteQueryHelper.ExecuteQuery("INSERT INTO caixa (openedat,closedat,owner,isopen,startvalue,total_lancamentos) VALUES (@openedat,@closedat,@owner,@isopen,@startvalue,@total_lancamentos)",
                                            new SQLiteParameter[] {
                                                new SQLiteParameter("@openedat", DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt")),
                                                new SQLiteParameter("@closedat", ""),
                                                new SQLiteParameter("@owner", "Sistema"),
                                                new SQLiteParameter("@isopen", 1),
                                                new SQLiteParameter("@startvalue", StartValue),
                                                new SQLiteParameter("@total_lancamentos", 0)
                                            });

                DataTable CaixaInfo = GetCaixaInfo();
                if (CaixaInfo.Rows.Count == 1)
                {
                    DataRow CaixaRow = CaixaInfo.Rows[0];

                    AddCaixaActivity(Convert.ToInt32(CaixaRow["id"].ToString()), 0, 3, StartValue, -1, -1);
                }
                    

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool CloseCaixa()
        {
            return SQLiteQueryHelper.ExecuteQuery("UPDATE caixa SET isopen = 0 WHERE isopen = 1 AND id = @id;", new SQLiteParameter[] { new SQLiteParameter("@id", Globals.CaixaId) });
        }

        public DataTable GetCaixaInfo()
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa WHERE isopen = 1;", null);
        }

        public DataTable GetCaixaActivity(int CaixaId)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa_activity INNER JOIN caixa ON caixa.id = caixa_activity.id_caixa WHERE caixa.isopen = 1 AND caixa.id = @caixaid;", new SQLiteParameter[] { new SQLiteParameter("@caixaid", CaixaId) }); 
        }

        public bool DeleteCaixaActivity(string ActivityId)
        {
            return SQLiteQueryHelper.ExecuteQuery("DELETE FROM caixa_activity WHERE id = @id;", new SQLiteParameter[] { new SQLiteParameter("@id", ActivityId) });
        }

        public bool AddCaixaActivity(int CaixaId, int Payment, int Direction, string Value, int Category, int Supply)
        {
            string sPayment = (Payment == 0) ? "Dinheiro" : "Cheque";
            string sEntrada = (Direction == 2) ? Value : "";
            string sSaida   = (Direction == 0 || Direction == 1) ? Value : "";
            string Desc     = (Direction == 0) ? "Saida - Despesa" : (Direction == 1) ? "Saida - Sangria" : "Entrada - Acrecimo";

            if (Direction == 3) { Desc = "Saldo Inicial"; sEntrada = Value; }

            try
            {
                SQLiteQueryHelper.ExecuteQuery("INSERT INTO caixa_activity (id_caixa,dataehora,descricao,entrada,saida,formapgto,tipo,direction) VALUES (@id_caixa,@dataehora,@descricao,@entrada,@saida,@formapgto,@tipo,@direction);",
                                            new SQLiteParameter[] {
                                                new SQLiteParameter("@id_caixa", CaixaId),
                                                new SQLiteParameter("@dataehora", DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt")),
                                                new SQLiteParameter("@descricao", Desc),
                                                new SQLiteParameter("@entrada", sEntrada),
                                                new SQLiteParameter("@saida", sSaida),
                                                new SQLiteParameter("@formapgto", sPayment),
                                                new SQLiteParameter("@tipo", "manual"),
                                                new SQLiteParameter("@direction", Direction)
                                            });
                return true;

            } catch
            {
                return false;
            }
            
            
        }

    }
}
