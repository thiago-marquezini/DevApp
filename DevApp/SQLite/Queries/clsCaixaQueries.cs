using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SQLite;

using DevApp.Global;

namespace DevApp.SQLite
{
    class clsCaixaQueries
    {
        public bool OpenCaixa(SQLiteConnection db, string StartValue, string Obs)
        {
            StartValue = StartValue.Replace("R$ ", "");

            var Caixa = new CaixaObj()
            {
                OpenedAt = DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt"),
                ClosedAt = "",
                Owner = "Sistema",
                IsOpen = "1",
                StartValue = StartValue,
                TotalLancamentos = "1",
                Obs = Obs,
                EndValue = "0,00",
                EndValueUser = "0,00",
                Sangria = "0,00",
                Despesas = "0,00",
                Acrecimos = "0,00",
                OpenDate = DateTime.Now.ToString("d/MM/yyyy")

            };

            if (db.Insert(Caixa) > 0) 
            {
                var CaixaActivity = new CaixaActivityObj()
                {
                    IdCaixa = Caixa.Id,
                    DataHora = DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt"),
                    Descricao = "Saldo Inicial",
                    Entrada = StartValue,
                    Saida = "",
                    FormaPgto = "Dinheiro",
                    Tipo = "inicial",
                    IdPedido = "",
                    Direction = "3"
                };

                if (db.Insert(CaixaActivity) > 0)
                {
                    return true;
                }

                return false;

            } else
            { 
                return false; 
            }
        }

        public bool CloseCaixa(SQLiteConnection db, string total_lancamentos, string endvalue, string endvalueuser, string sangria, string despesas, string acrecimos)
        {
            List<CaixaObj> CurrentCaixa = db.Table<CaixaObj>().Where(t => t.Id == Globals.CaixaId).ToList();

            var Caixa = new CaixaObj {
                                            Id = Globals.CaixaId,
                                            OpenedAt = CurrentCaixa[0].OpenedAt,
                                            ClosedAt = DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt"),
                                            Owner = CurrentCaixa[0].Owner,
                                            IsOpen = "0",
                                            StartValue = CurrentCaixa[0].StartValue,
                                            TotalLancamentos = total_lancamentos,
                                            Obs = CurrentCaixa[0].Obs,
                                            EndValue = endvalue,
                                            EndValueUser = endvalueuser.Replace("R$ ", ""),
                                            Sangria = sangria,
                                            Despesas = despesas,
                                            Acrecimos = acrecimos,
                                            OpenDate = CurrentCaixa[0].OpenDate
            };

            if (db.Update(Caixa) > 0)
            {
                return true;
            }

            return false;
        }


        public List<CaixaObj> GetCaixaInfo(SQLiteConnection db)
        {
            return db.Table<CaixaObj>().Where(t => t.IsOpen == "1").ToList();
        }


        public List<CaixaObj> GetCustomCaixaInfo(SQLiteConnection db, int CaixaId)
        {
            return db.Table<CaixaObj>().Where(t => t.Id == CaixaId).ToList();
        }


        public List<CaixaActivityObj> GetCaixaActivity(SQLiteConnection db, int CaixaId)
        {
            string ActivityQry = $"SELECT * FROM caixa_activity INNER JOIN caixa ON caixa.Id = caixa_activity.IdCaixa WHERE caixa.Id = " + CaixaId  + ";";
            return db.Query<CaixaActivityObj>(ActivityQry);
        }


        public void SetCaixaObs(SQLiteConnection db, string Obs)
        {
            List<CaixaObj> CurrentCaixa = db.Table<CaixaObj>().Where(t => t.Id == Globals.CaixaId).ToList();

            var Caixa = new CaixaObj
            {
                Id = Globals.CaixaId,
                OpenedAt = CurrentCaixa[0].OpenedAt,
                ClosedAt = CurrentCaixa[0].ClosedAt,
                Owner = CurrentCaixa[0].Owner,
                IsOpen = CurrentCaixa[0].IsOpen,
                StartValue = CurrentCaixa[0].StartValue,
                TotalLancamentos = CurrentCaixa[0].TotalLancamentos,
                Obs = Obs,
                EndValue = CurrentCaixa[0].EndValue,
                EndValueUser = CurrentCaixa[0].EndValueUser,
                Sangria = CurrentCaixa[0].Sangria,
                Despesas = CurrentCaixa[0].Despesas,
                Acrecimos = CurrentCaixa[0].Acrecimos,
                OpenDate = CurrentCaixa[0].OpenDate
            };

            db.Update(Caixa);
        }


        public bool DeleteCaixaActivity(SQLiteConnection db, string ActivityId)
        {
            if (db.Delete<CaixaActivityObj>(ActivityId) > 0) return true; 
            return false;
        }

        public bool AddCaixaActivity(SQLiteConnection db, int Payment, int Direction, string Value, int Category, int Supply, string Type)
        {
            Value = Value.Replace("R$ ", "");

            string sPayment = (Payment == 0) ? "Dinheiro" : (Payment == 1) ? "Cheque" : (Payment == 2) ? "Debito" : (Payment == 3) ? "PIX" : "Unknown";
            string sEntrada = (Direction == 2) ? Value : "";
            string sSaida = (Direction == 0 || Direction == 1) ? Value : "";
            string Desc = (Direction == 0) ? "Saida - Despesa" : (Direction == 1) ? "Saida - Sangria" : "Entrada - Acrecimo";
            if (Direction == 3) { Desc = "Saldo Inicial"; sEntrada = Value; }

            try
            {
                var CaixaActivity = new CaixaActivityObj()
                {
                    IdCaixa = Globals.CaixaId,
                    DataHora = DateTime.Now.ToString("d/MM/yyyy h:mm:ss tt"),
                    Descricao = Desc,
                    Entrada = sEntrada,
                    Saida = sSaida,
                    FormaPgto = sPayment,
                    Tipo = Type,
                    IdPedido = "",
                    Direction = Direction.ToString()
                };

                db.Insert(CaixaActivity);
                return true;

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
