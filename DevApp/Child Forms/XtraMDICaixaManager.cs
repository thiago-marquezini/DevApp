using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Base;

using DevApp.Global;
using DevApp.Class_DataSource;
using DevApp.PopUp_Forms;
using DevApp.SQLite;

namespace DevApp.Child_Forms
{
    public partial class XtraMDICaixaManager : DevExpress.XtraEditors.XtraForm
    {
        public bool IsPreview = false;
        public int PreviewCaixaId = 0;

        CultureInfo CultureBR = new CultureInfo("pt-BR");

        private SQLiteCipher CaixaConnection = new SQLiteCipher();
        private clsCaixaQueries CaixaQueries = new clsCaixaQueries();

        private List<ClsDSCaixaResumo> CaixaItensResumo = new List<ClsDSCaixaResumo>();

        public XtraMDICaixaManager(bool _IsPreview, int _PreviewCaixaId = 0)
        {
            InitializeComponent();

            this.IsPreview = _IsPreview;
            this.PreviewCaixaId = _PreviewCaixaId;
        }

        private void XtraMDICaixaManager_Load(object sender, EventArgs e)
        {
            BuildCaixaReceipt();

            if (this.IsPreview)
            {
                // Load Preview
                txtCaixaSaldoInicial.Enabled = false;
                btnCaixaOpenClose.Text = "Abrir Caixa <b>(F5)</b>        ";
                btnCaixaOpenClose.Enabled = false;
                btnAddActivity.Enabled = false;
                btnPrintMovCaixa.Enabled = true;
                btnPrintResumoCaixa.Enabled = true;
                btnDeleteActivity.Enabled = false;
                panelCaixaStateColor.BackColor = Color.OrangeRed;
                lblCaixaState.Text = "Caixa Fechado";
                memoCaixaObs.ReadOnly = true;

                GetCustomCaixaInfo(this.PreviewCaixaId);
                GetCaixaActivity();
                CalculateResumo(false);

            } else
            {
                GetCurrentCaixaInfo();

                if (Globals.IsCaixaOpen)
                {
                    txtCaixaSaldoInicial.Enabled = false;
                    btnCaixaOpenClose.Text = "Fechar Caixa <b>(F5)</b>       ";
                    btnAddActivity.Enabled = true;
                    btnPrintMovCaixa.Enabled = true;
                    btnPrintResumoCaixa.Enabled = true;
                    btnDeleteActivity.Enabled = true;
                    panelCaixaStateColor.BackColor = Color.ForestGreen;
                    lblCaixaState.Text = "Caixa Aberto";

                    GetCaixaActivity();
                    CalculateResumo(false);
                }
                else
                {
                    txtCaixaSaldoInicial.Enabled = true;
                    btnCaixaOpenClose.Text = "Abrir Caixa <b>(F5)</b>        ";
                    btnAddActivity.Enabled = false;
                    btnPrintMovCaixa.Enabled = false;
                    btnPrintResumoCaixa.Enabled = false;
                    btnDeleteActivity.Enabled = false;
                    panelCaixaStateColor.BackColor = Color.OrangeRed;
                    lblCaixaState.Text = "Caixa Fechado";
                }
            }
            
        }

        public void GetCustomCaixaInfo(int CaixaId)
        {
            List<CaixaObj> cCaixaInfo = CaixaQueries.GetCustomCaixaInfo(CaixaConnection.Connection(), CaixaId);
            if (cCaixaInfo.Count == 1)
            {
                Globals.CaixaId = cCaixaInfo[0].Id;

                txtCaixaSaldoInicial.Text = cCaixaInfo[0].StartValue;
                lblCaixaOpenTime.Text = cCaixaInfo[0].OpenedAt;
                memoCaixaObs.Text = cCaixaInfo[0].Obs;
            }
        }

        private void GetCurrentCaixaInfo()
        {
            List<CaixaObj> CaixaInfo = CaixaQueries.GetCaixaInfo(CaixaConnection.Connection());
            if (CaixaInfo.Count == 1)
            {
                Globals.IsCaixaOpen = true;
                Globals.CaixaId = CaixaInfo[0].Id;

                txtCaixaSaldoInicial.Text = CaixaInfo[0].StartValue;
                lblCaixaOpenTime.Text = CaixaInfo[0].OpenedAt;
                memoCaixaObs.Text = CaixaInfo[0].Obs;
            }
        }

        public bool CalculateResumo(bool CloseCaixa, string UserInputEndVal = "")
        {
            int ValorInicial = 0;
            int SomaEntradas = 0;
            int SomaEntradasDinheiro = 0;
            int SomaEntradasCartaoPix = 0;
            int SomaSaidas = 0;
            int SomaSaidasDinheiro = 0;
            int SomaSaidasCartaoPix = 0;
            int SomaSaidasDespesas = 0;
            int SomaSaidasSangria = 0;
            int TotalEntradaSaida = 0;
            int CntTotalLancamentos = 0;
            int ValorTotal;
            int ValorTotalDinheiro;

            List<CaixaObj> CaixaInfo = CaixaQueries.GetCustomCaixaInfo(CaixaConnection.Connection(), Globals.CaixaId);
            if (CaixaInfo.Count == 1)
            {
                string sValorInicial = CaixaInfo[0].StartValue;
                ValorInicial = Int32.Parse(sValorInicial.Replace(".", "").Replace(",", ""));
            }

            List<CaixaActivityObj> CaixaActivity = CaixaQueries.GetCaixaActivity(CaixaConnection.Connection(), Globals.CaixaId);
            if (CaixaActivity.Count > 0)
            {
                CaixaActivity.ForEach(delegate (CaixaActivityObj Activity)
                {
                    int ActDirection = Int32.Parse(Activity.Direction);
                    switch (ActDirection)
                    {
                        case 0:
                            {
                                string ValorSaida = Activity.Saida;
                                ValorSaida = ValorSaida.Replace(".", "").Replace(",", "");
                                int iValorSaida = Int32.Parse(ValorSaida);
                                SomaSaidasDespesas += iValorSaida;
                                SomaSaidas += iValorSaida;
                                if ((Activity.FormaPgto == "Dinheiro") || (Activity.FormaPgto == "Cheque")) { SomaSaidasDinheiro += iValorSaida; }
                                if ((Activity.FormaPgto == "Debito") || (Activity.FormaPgto == "PIX")) { SomaSaidasCartaoPix += iValorSaida; }
                                break;
                            }

                        case 1:
                            {
                                string ValorSaida = Activity.Saida;
                                ValorSaida = ValorSaida.Replace(".", "").Replace(",", "");
                                int iValorSaida = Int32.Parse(ValorSaida);
                                SomaSaidasSangria += iValorSaida;
                                SomaSaidas += iValorSaida;
                                if ((Activity.FormaPgto == "Dinheiro") || (Activity.FormaPgto == "Cheque")) { SomaSaidasDinheiro += iValorSaida; }
                                if ((Activity.FormaPgto == "Debito") || (Activity.FormaPgto == "PIX")) { SomaSaidasCartaoPix += iValorSaida; }
                                break;
                            }

                        case 2:
                            {
                                string ValorEntrada = Activity.Entrada;
                                ValorEntrada = ValorEntrada.Replace(".", "").Replace(",", "");
                                int iValorEntrada = Int32.Parse(ValorEntrada);
                                SomaEntradas += iValorEntrada;
                                if ((Activity.FormaPgto == "Dinheiro") || (Activity.FormaPgto == "Cheque")) { SomaEntradasDinheiro += iValorEntrada; }
                                if ((Activity.FormaPgto == "Debito") || (Activity.FormaPgto == "PIX")) { SomaEntradasCartaoPix += iValorEntrada; }

                                break;
                            }

                        default: break;
                    }
                });

                TotalEntradaSaida = SomaEntradas - SomaSaidas;
            }

            ValorTotal = ValorInicial + TotalEntradaSaida;
            ValorTotalDinheiro = (ValorInicial + SomaEntradasDinheiro) - SomaSaidas;

            // Fechamento de Caixa
            if (CloseCaixa)
            {
                if (CaixaQueries.CloseCaixa(CaixaConnection.Connection(), (CntTotalLancamentos != 0) ? CntTotalLancamentos.ToString() : "0,00",
                                            (ValorTotal != 0) ? ValorTotal.ToString().Insert(ValorTotal.ToString().Length - 2, ",") : "0,00",
                                            UserInputEndVal,
                                            (SomaSaidasSangria != 0) ? SomaSaidasSangria.ToString().Insert(SomaSaidasSangria.ToString().Length - 2, ",") : "0,00",
                                            (SomaSaidasDespesas != 0) ? SomaSaidasDespesas.ToString().Insert(SomaSaidasDespesas.ToString().Length - 2, ",") : "0,00",
                                            (SomaEntradas != 0) ? SomaEntradas.ToString().Insert(SomaEntradas.ToString().Length - 2, ",") : "0,00"))
                {
                    return true;
                }
                else { return false; }

                // Atualizar a Interface do Resumo
            }
            else
            {
                SetResumoGridInfo(ValorInicial,
                                  SomaEntradasDinheiro,
                                  SomaEntradasCartaoPix,
                                  SomaEntradas,
                                  SomaSaidasDinheiro,
                                  SomaSaidasCartaoPix,
                                  ValorTotalDinheiro,
                                  ValorTotal);
            }

            Globals.CaixaValorTotal = ValorTotal;
            Globals.CaixaValorTotalDinheiro = ValorTotalDinheiro;

            return true;
        }

        private void SetResumoGridInfo(int ValorInicial, int SomaEntradasDinheiro, int SomaEntradasCartaoPix, int SomaEntradas, int SomaSaidasDinheiro, int SomaSaidasCartaoPix, int ValorTotalDinheiro, int ValorTotal)
        {
            // VALOR INICIAL
            // ..
            if (ValorInicial != 0)
            {
                string sValorInicial = ValorInicial.ToString().Insert(ValorInicial.ToString().Length - 2, ",");
                txtCalcText.Text = sValorInicial.ToString();
                gridViewCaixaResumo.SetRowCellValue(0, "Valor", txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(0, "Valor", "R$ 0,00"); }


            //
            // Atualizar "ENTRADAS - ACRECIMOS - DINHEIRO"
            //..
            if (SomaEntradasDinheiro != 0)
            {
                string sSomaEntradasDinheiro = SomaEntradasDinheiro.ToString().Insert(SomaEntradasDinheiro.ToString().Length - 2, ",");
                txtCalcText.Text = sSomaEntradasDinheiro.ToString();
                gridViewCaixaResumo.SetRowCellValue(6, "Valor", txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(6, "Valor", "R$ 0,00"); }
            // Atualizar "ENTRADAS - ACRECIMOS - CARTAO/PIX"
            //
            if (SomaEntradasCartaoPix != 0)
            {
                string sSomaEntradasCartaoPix = SomaEntradasCartaoPix.ToString().Insert(SomaEntradasCartaoPix.ToString().Length - 2, ",");
                txtCalcText.Text = sSomaEntradasCartaoPix.ToString();
                gridViewCaixaResumo.SetRowCellValue(7, "Valor", txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(7, "Valor", "R$ 0,00"); }
            // Atualizar "ENTRADAS - TOTAL"
            //
            if (SomaEntradas != 0)
            {
                string sSomaEntradas = SomaEntradas.ToString().Insert(SomaEntradas.ToString().Length - 2, ",");
                txtCalcText.Text = sSomaEntradas.ToString();
                gridViewCaixaResumo.SetRowCellValue(9, "Valor", txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(9, "Valor", "R$ 0,00"); }


            //
            // Atualizar "SAIDAS - DINHEIRO"
            // ..
            if (SomaSaidasDinheiro != 0)
            {
                string sSomaSaidasDinheiro = SomaSaidasDinheiro.ToString().Insert(SomaSaidasDinheiro.ToString().Length - 2, ",");
                txtCalcText.Text = sSomaSaidasDinheiro.ToString();
                gridViewCaixaResumo.SetRowCellValue(13, "Valor", "-" + txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(13, "Valor", "R$ 0,00"); }
            // Atualizar "SAIDAS - CARTAO/PIX"
            // ..
            if (SomaSaidasCartaoPix != 0)
            {
                string sSomaSaidasCartaoPix = SomaSaidasCartaoPix.ToString().Insert(SomaSaidasCartaoPix.ToString().Length - 2, ",");
                txtCalcText.Text = sSomaSaidasCartaoPix.ToString();
                gridViewCaixaResumo.SetRowCellValue(14, "Valor", "-" + txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(14, "Valor", "R$ 0,00"); }

            //
            // Atualizar "TOTAL DINHEIRO"
            // ..
            if (ValorTotalDinheiro != 0)
            {
                string sValorTotalDinheiro = ValorTotalDinheiro.ToString().Insert(ValorTotalDinheiro.ToString().Length - 2, ",");
                txtCalcText.Text = sValorTotalDinheiro.ToString();
                gridViewCaixaResumo.SetRowCellValue(17, "Valor", txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(17, "Valor", "R$ 0,00"); }


            // Atualizar "TOTAL"
            // ..
            if (ValorTotal != 0)
            {
                string sValorTotal = ValorTotal.ToString().Insert(ValorTotal.ToString().Length - 2, ",");
                txtCalcText.Text = sValorTotal.ToString();
                gridViewCaixaResumo.SetRowCellValue(18, "Valor", txtCalcText.Text);
            }
            else { gridViewCaixaResumo.SetRowCellValue(18, "Valor", "R$ 0,00"); }
        }

        public void GetCaixaActivity()
        {
            List<CaixaActivityObj> dt = CaixaQueries.GetCaixaActivity(CaixaConnection.Connection(), Globals.CaixaId);
            gridCaixaActivity.DataSource = dt;
        }

        private void BuildCaixaReceipt()
        {
            CaixaItensResumo.Clear();

            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 0,  Descricao = "(+) SALDO INICIAL", Valor = "R$ 0,00" });

            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 1,  Descricao = "(+) ENTRADAS NO CAIXA", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 2,  Descricao = "  PEDIDOS", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 3,  Descricao = "   Dinheiro/Cheque", Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 4,  Descricao = "   Debito/PIX", Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 5,  Descricao = "  ACRECIMOS", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 6,  Descricao = "   Dinheiro/Cheque", Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 7,  Descricao = "   Debito/PIX", Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 8,  Descricao = "  TOTAL", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 9,  Descricao = "   Total:", Valor = "R$ 0,00" });

            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 10, Descricao = "", Valor = "" });

            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 11, Descricao = "(+) SAIDAS NO CAIXA", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 12, Descricao = "  SANGRIAS E DESPESAS", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 13, Descricao = "   Dinheiro/Cheque", Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 14, Descricao = "   Debito/PIX", Valor = "R$ 0,00" });

            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 15, Descricao = "", Valor = "" });

            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 16, Descricao = "(=) SALDO FINAL", Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 17, Descricao = "  Somente Dinheiro", Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 18, Descricao = "  TUDO:", Valor = "R$ 0,00" });

            gridCaixaResumo.DataSource = CaixaItensResumo;

            gridCaixaResumo.MainView.BeginUpdate();
            try
            {
                gridViewCaixaResumo.Appearance.Empty.BackColor = Color.Transparent;
                gridViewCaixaResumo.Appearance.Row.BackColor = Color.Transparent;
            }
            finally { gridCaixaResumo.MainView.EndUpdate(); }
        }



        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            if (gridViewCaixaActivity.FocusedRowHandle >= 0)
            {
                if (XtraMessageBox.Show("Tem certeza que deseja remover este registro?", "Confirmar exclusao", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    string ActivityId = gridViewCaixaActivity.GetFocusedRowCellValue("Id").ToString();
                    CaixaQueries.DeleteCaixaActivity(CaixaConnection.Connection(), ActivityId);

                    gridViewCaixaActivity.DeleteRow(gridViewCaixaActivity.FocusedRowHandle);

                    CalculateResumo(false);
                }
            }
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            XtraCaixaAddActivity CaixaAddActivity = new XtraCaixaAddActivity(this, Globals.CaixaId);

            CaixaAddActivity.Text = "Adicionar Entrada / Saida";
            CaixaAddActivity.WindowState = FormWindowState.Normal;
            CaixaAddActivity.ShowDialog(this);
        }

        private void btnPrintMovCaixa_Click(object sender, EventArgs e)
        {
            if (!gridCaixaActivity.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            gridCaixaActivity.PrintDialog();
        }

        private void btnPrintResumoCaixa_Click(object sender, EventArgs e)
        {
            if (!gridCaixaResumo.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            gridCaixaResumo.ShowPrintPreview();
        }

        private void btnCaixaOpenClose_Click(object sender, EventArgs e)
        {
            if (Globals.IsCaixaOpen)
            {
                XtraCaixaCloseDialog CloseCaixaDialog = new XtraCaixaCloseDialog(this);

                CloseCaixaDialog.Text = "Fechamento do Caixa";
                CloseCaixaDialog.WindowState = FormWindowState.Normal;
                CloseCaixaDialog.ShowDialog(this);

                while (!CloseCaixaDialog.DecisionMade) { Thread.Sleep(500); }

                switch (CloseCaixaDialog.DecisionId)
                {
                    case 0: goto Exit;
                    case 1: goto CloseAnyway;
                    case 2: goto CloseAndPrint;
                    default: break;
                }

            CloseAnyway:

                Globals.IsCaixaOpen = false;

                txtCaixaSaldoInicial.Text = "R$ 0,00";
                txtCaixaSaldoInicial.Enabled = true;
                btnCaixaOpenClose.Text = "Abrir Caixa <b>(F5)</b>        ";
                btnAddActivity.Enabled = false;
                btnPrintMovCaixa.Enabled = false;
                btnPrintResumoCaixa.Enabled = false;
                btnDeleteActivity.Enabled = false;
                panelCaixaStateColor.BackColor = Color.OrangeRed;
                lblCaixaState.Text = "Caixa Fechado";
                lblCaixaOpenTime.Text = "Caixa Fechado";

                gridCaixaActivity.DataSource = null;
                gridCaixaResumo.DataSource = null;

                BuildCaixaReceipt();

                goto Exit;


            CloseAndPrint:

                Globals.IsCaixaOpen = false;

                gridCaixaResumo.PrintDialog();

                txtCaixaSaldoInicial.Text = "R$ 0,00";
                txtCaixaSaldoInicial.Enabled = true;
                btnCaixaOpenClose.Text = "Abrir Caixa <b>(F5)</b>        ";
                btnAddActivity.Enabled = false;
                btnPrintMovCaixa.Enabled = false;
                btnPrintResumoCaixa.Enabled = false;
                btnDeleteActivity.Enabled = false;
                panelCaixaStateColor.BackColor = Color.OrangeRed;
                lblCaixaState.Text = "Caixa Fechado";
                lblCaixaOpenTime.Text = "Caixa Fechado";

                gridCaixaActivity.DataSource = null;
                gridCaixaResumo.DataSource = null;

                BuildCaixaReceipt();

                goto Exit;

            Exit:
                Thread.Sleep(1); // just because a label requires some code after declaration

            }
            else
            {
                if (CaixaQueries.OpenCaixa(CaixaConnection.Connection(), txtCaixaSaldoInicial.Text, memoCaixaObs.Text))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    Thread.Sleep(1000);

                    Globals.IsCaixaOpen = true;

                    txtCaixaSaldoInicial.Enabled = false;
                    btnCaixaOpenClose.Text = "Fechar Caixa <b>(F5)</b>       ";
                    btnAddActivity.Enabled = true;
                    btnPrintMovCaixa.Enabled = true;
                    btnPrintResumoCaixa.Enabled = true;
                    btnDeleteActivity.Enabled = true;
                    panelCaixaStateColor.BackColor = Color.PaleGreen;
                    lblCaixaState.Text = "Caixa Aberto";

                    GetCurrentCaixaInfo();
                    GetCaixaActivity();
                    CalculateResumo(false);

                    SplashScreenManager.CloseForm();
                }
            }
        }

        private void gridViewCaixaActivity_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewCaixaActivity.FocusedRowHandle >= 0)
            {
                if (!this.IsPreview)
                {
                    string ActivityType = gridViewCaixaActivity.GetFocusedRowCellValue("Tipo").ToString();
                    if ((ActivityType == "pedido") || (ActivityType == "inicial"))
                    {
                        btnDeleteActivity.Enabled = false;
                    }
                    else
                    {
                        btnDeleteActivity.Enabled = true;
                    }

                } else
                {
                    btnDeleteActivity.Enabled = false;
                }
                
            }
        }

        private void gridViewCaixaResumo_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if ((e.RowHandle == 0) || (e.RowHandle == 1) || (e.RowHandle == 2)
                || (e.RowHandle == 5) || (e.RowHandle == 8) || (e.RowHandle == 11)
                || (e.RowHandle == 12) || (e.RowHandle == 16) || (e.RowHandle == 18))
            {
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }

            if ((e.RowHandle == 2) || (e.RowHandle == 5) || (e.RowHandle == 8) || (e.RowHandle == 12))
            {
                if (e.Column.FieldName == "Descricao")
                {
                    e.Appearance.ForeColor = Color.DimGray;
                }
            }
        }

        private void gridViewCaixaActivity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Entrada" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    decimal price = Convert.ToDecimal(e.Value);
                    e.DisplayText = string.Format(CultureBR, "{0:c}", price);

                    e.Column.AppearanceCell.ForeColor = Color.Green;
                }

            }

            if (e.Column.FieldName == "Saida" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    decimal price = Convert.ToDecimal(e.Value);
                    e.DisplayText = string.Format(CultureBR, "{0:c}", price);

                    e.Column.AppearanceCell.ForeColor = Color.Red;
                }
            }
        }

        private void gridViewCaixaActivity_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Entrada")
            {
                if (e.DisplayText.Length > 0)
                {
                    String RawNumber = e.DisplayText.Replace("R$ ", "").Replace(".", "").Replace(",", "");
                    if (Int32.Parse(RawNumber) > 0)
                    {
                        Brush brush = new SolidBrush(Color.Green);
                        Rectangle r = e.Bounds;
                        e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                        e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                        e.Handled = true;
                    }
                }
            }

            if (e.Column.FieldName == "Saida")
            {
                if (e.DisplayText.Length > 0)
                {
                    String RawNumber = e.DisplayText.Replace("R$ ", "").Replace(".", "").Replace(",", "");
                    if (Int32.Parse(RawNumber) > 0)
                    {
                        Brush brush = new SolidBrush(Color.Red);
                        Rectangle r = e.Bounds;
                        e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                        e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                        e.Handled = true;
                    }
                }
            }
        }

        private void XtraMDICaixaManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsPreview)
            {
                CaixaQueries.SetCaixaObs(CaixaConnection.Connection(), memoCaixaObs.Text);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}