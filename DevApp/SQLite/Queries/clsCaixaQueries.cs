using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

using DevApp.Global;

namespace DevApp.SQLite.Queries
{
    class clsCaixaQueries
    {
        public bool OpenCaixa(string StartValue)
        {
            StartValue = StartValue.Replace("R$ ", "");

            try
            {
                SQLiteQueryHelper.ExecuteQuery("INSERT INTO caixa (openedat,closedat,owner,isopen,startvalue,total_lancamentos,obs,endvalue,endvalueuser,sangria,despesas,acrecimos,opendate) VALUES (@openedat,@closedat,@owner,@isopen,@startvalue,@total_lancamentos,@obs,@endvalue,@endvalueuser,@sangria,@despesas,@acrecimos,@opendate)",
                                            new SQLiteParameter[] {
                                                new SQLiteParameter("@openedat", DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt")),
                                                new SQLiteParameter("@closedat", ""),
                                                new SQLiteParameter("@owner", "Sistema"),
                                                new SQLiteParameter("@isopen", "1"),
                                                new SQLiteParameter("@startvalue", StartValue),
                                                new SQLiteParameter("@total_lancamentos", "1"),
                                                new SQLiteParameter("@obs", 0),
                                                new SQLiteParameter("@endvalue", "0,00"),
                                                new SQLiteParameter("@endvalueuser", "0,00"),
                                                new SQLiteParameter("@sangria", "0,00"),
                                                new SQLiteParameter("@despesas", "0,00"),
                                                new SQLiteParameter("@acrecimos", "0,00"),
                                                new SQLiteParameter("@opendate", DateTime.Now.ToString("d/MM/yyyy")),     
                                            });

                DataTable CaixaInfo = GetCaixaInfo();
                if (CaixaInfo.Rows.Count == 1)
                {
                    DataRow CaixaRow = CaixaInfo.Rows[0];
                    AddCaixaActivity(Convert.ToInt32(CaixaRow["id"].ToString()), 0, 3, StartValue, -1, -1, "inicial");

                } else
                {
                    MessageBox.Show("Houve uma falha ao abrir o caixa. Contate o administrador.", "Erro");
                }
                    

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool CloseCaixa(string total_lancamentos, string endvalue, string endvalueuser, string sangria, string despesas, string acrecimos)
        {
            return SQLiteQueryHelper.ExecuteQuery("UPDATE caixa SET isopen = 0, closedat = @closedat, total_lancamentos = @total_lancamentos," +
                                                  " endvalue = @endvalue, endvalueuser = @endvalueuser, sangria = @sangria, despesas = @despesas," +
                                                  " acrecimos = @acrecimos WHERE isopen = 1 AND id = @id;", 
                                                new SQLiteParameter[] {
                                                    new SQLiteParameter("@closedat", DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt")),
                                                    new SQLiteParameter("@total_lancamentos", total_lancamentos),
                                                    new SQLiteParameter("@endvalue", endvalue),
                                                    new SQLiteParameter("@endvalueuser", endvalueuser.Replace("R$ ", "")),
                                                    new SQLiteParameter("@sangria", sangria),
                                                    new SQLiteParameter("@despesas", despesas),
                                                    new SQLiteParameter("@acrecimos", acrecimos),

                                                    new SQLiteParameter("@id", Globals.CaixaId) 
                                                });
        }

        public DataTable GetCaixaInfo()
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa WHERE isopen = 1;", null);
        }

        public DataTable GetCustomCaixaInfo(int CaixaId)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa WHERE id = @id;", new SQLiteParameter[] { new SQLiteParameter("@id", CaixaId) });
        }

        public DataTable GetCaixaValorInicial(int CaixaId)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT startvalue FROM caixa WHERE id = @id;", new SQLiteParameter[] { new SQLiteParameter("@id", CaixaId) });
        }

        public DataTable GetCaixaActivity(int CaixaId)
        {
            return SQLiteQueryHelper.QueryToDataTable("SELECT * FROM caixa_activity INNER JOIN caixa ON caixa.id = caixa_activity.id_caixa WHERE caixa.id = @caixaid;", new SQLiteParameter[] { new SQLiteParameter("@caixaid", CaixaId) }); 
        }

        public DataTable SetCaixaObs(int CaixaId, string Obs)
        {
            return SQLiteQueryHelper.QueryToDataTable("UPDATE caixa SET obs = @obs WHERE id = @id;", new SQLiteParameter[] { new SQLiteParameter("@obs", Obs), new SQLiteParameter("@id", CaixaId) });
        }

        public bool DeleteCaixaActivity(string ActivityId)
        {
            return SQLiteQueryHelper.ExecuteQuery("DELETE FROM caixa_activity WHERE id = @id;", new SQLiteParameter[] { new SQLiteParameter("@id", ActivityId) });
        }

        public bool AddCaixaActivity(int CaixaId, int Payment, int Direction, string Value, int Category, int Supply, string Type)
        {
            Value = Value.Replace("R$ ", "");

            string sPayment = (Payment == 0) ? "Dinheiro" : (Payment == 1) ? "Cheque" : (Payment == 2) ? "Debito" : (Payment == 3) ? "PIX" : "Unknown";
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
                                                new SQLiteParameter("@tipo", Type),
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
