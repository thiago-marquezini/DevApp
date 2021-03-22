using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevApp.Global;
using DevApp.Helpers;
using DevApp.Class_DataSource;
using DevApp.PopUp_Forms;
using DevApp.SQLite.Queries;

using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;

namespace DevApp.Child_Forms
{
    public partial class XtraMDICaixaMgr : DevExpress.XtraEditors.XtraUserControl
    {
        private clsCaixaQueries CaixaQueries = new clsCaixaQueries();
        private List<ClsDSCaixaResumo> CaixaItensResumo = new List<ClsDSCaixaResumo>();

        public XtraMDICaixaMgr()
        {
            InitializeComponent();
        }

        private void XtraMDICaixaMgr_Load(object sender, EventArgs e)
        {
            BuildCaixaReceipt();
            GetCurrentCaixaInfo();

            if (Globals.IsCaixaOpen)
            {
                txtCaixaSaldoInicial.Enabled = false;
                btnCaixaOpenClose.Text = "Fechar Caixa";
                btnAddActivity.Enabled = true;
                btnDeleteActivity.Enabled = true;
                panelCaixaStateColor.BackColor = Color.PaleGreen;
                lblCaixaState.Text = "Caixa Aberto";

                GetCaixaActivity();
            }
            else
            {
                txtCaixaSaldoInicial.Enabled = true;
                btnCaixaOpenClose.Text = "Abrir Caixa";
                btnAddActivity.Enabled = false;
                btnDeleteActivity.Enabled = false;
                panelCaixaStateColor.BackColor = Color.OrangeRed;
                lblCaixaState.Text = "Caixa Fechado";
            }
        }

        public void GetCurrentCaixaInfo()
        {
            DataTable CaixaInfo = CaixaQueries.GetCaixaInfo();
            if (CaixaInfo.Rows.Count == 1)
            {
                DataRow CaixaRow = CaixaInfo.Rows[0];

                Globals.IsCaixaOpen = true;
                Globals.CaixaId = Int32.Parse(CaixaRow["id"].ToString());

                txtCaixaSaldoInicial.Text = CaixaRow["startvalue"].ToString();
                lblCaixaOpenTime.Text     = CaixaRow["openedat"].ToString();
                memoCaixaObs.Text         = CaixaRow["obs"].ToString();

                gridViewCaixaResumo.SetRowCellValue(0, "Valor", CaixaRow["startvalue"].ToString());
            }
        }

        public void GetCaixaActivity()
        {
            DataTable dt = CaixaQueries.GetCaixaActivity(Globals.CaixaId);
            gridCaixaActivity.DataSource = dt;
        }

        private void BuildCaixaReceipt()
        {
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 0,  Descricao = "(+) SALDO INICIAL",          Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 1,  Descricao = "(+) ENTRADAS NO CAIXA",      Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 2,  Descricao = "   ACRECIMOS",               Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 3,  Descricao = "     Dinheiro/Cheque",       Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 4,  Descricao = "     Pix/Cartao",            Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 5,  Descricao = "   TOTAL - ENTRADAS",        Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 6,  Descricao = "     Total:",                Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 7,  Descricao = "",                           Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 8,  Descricao = "(+) SAIDAS NO CAIXA",        Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 9,  Descricao = "   SANGRIAS E DESPESAS",     Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 10, Descricao = "     Dinheiro/Cheque",       Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 11, Descricao = "     Pix/Cartao",            Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 12, Descricao = "",                           Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 13, Descricao = "(=) SALDO FINAL",            Valor = "" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 14, Descricao = "   Somente Dinheiro",        Valor = "R$ 0,00" });
            CaixaItensResumo.Add(new ClsDSCaixaResumo() { ID = 15, Descricao = "   TUDO:",                   Valor = "R$ 0,00" });

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
                    string ActivityId = gridViewCaixaActivity.GetFocusedRowCellValue("id").ToString();
                    CaixaQueries.DeleteCaixaActivity(ActivityId);

                    gridViewCaixaActivity.DeleteRow(gridViewCaixaActivity.FocusedRowHandle);
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
            // Check whether the LayoutControl can be previewed.
            if (!gridCaixaActivity.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            gridCaixaActivity.ShowPrintPreview();
        }

        private void btnPrintResumoCaixa_Click(object sender, EventArgs e)
        {
            // Check whether the LayoutControl can be previewed.
            if (!gridCaixaResumo.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            gridCaixaResumo.ShowPrintPreview();
        }

        private void btnCaixaOpenClose_Click(object sender, EventArgs e)
        {
            if (Globals.IsCaixaOpen)
            {
                XtraCaixaCloseDialog CloseCaixaDialog = new XtraCaixaCloseDialog();

                CloseCaixaDialog.Text = "Fechamento do Caixa";
                CloseCaixaDialog.WindowState = FormWindowState.Normal;
                CloseCaixaDialog.ShowDialog(this);

                while (!CloseCaixaDialog.DecisionMade) { Thread.Sleep(500); }

                switch (CloseCaixaDialog.DecisionId)
                {
                    case 0:  goto Exit;
                    case 1:  goto CloseAnyway;
                    case 2:  goto CloseAndPrint;
                    default: break;
                }

                CloseAnyway: if (CaixaQueries.CloseCaixa())
                {
                    Globals.IsCaixaOpen = false;

                    txtCaixaSaldoInicial.Enabled = true;
                    btnCaixaOpenClose.Text = "Abrir Caixa";
                    btnAddActivity.Enabled = false;
                    btnDeleteActivity.Enabled = false;
                    panelCaixaStateColor.BackColor = Color.OrangeRed;
                    lblCaixaState.Text = "Caixa Fechado";

                    gridCaixaActivity.DataSource = null;

                    goto Exit;
                }

                CloseAndPrint: if (CaixaQueries.CloseCaixa())
                {
                    Globals.IsCaixaOpen = false;

                    txtCaixaSaldoInicial.Enabled = true;
                    btnCaixaOpenClose.Text = "Abrir Caixa";
                    btnAddActivity.Enabled = false;
                    btnDeleteActivity.Enabled = false;
                    panelCaixaStateColor.BackColor = Color.OrangeRed;
                    lblCaixaState.Text = "Caixa Fechado";

                    gridCaixaActivity.DataSource = null;

                    goto Exit;
                }

                Exit:
                Thread.Sleep(1); // just because a label requires some code after declaration

            } else
            {
                if (CaixaQueries.OpenCaixa(txtCaixaSaldoInicial.Text))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    Thread.Sleep(1000);

                    Globals.IsCaixaOpen = true;

                    txtCaixaSaldoInicial.Enabled = false;
                    btnCaixaOpenClose.Text = "Fechar Caixa";
                    btnAddActivity.Enabled = true;
                    btnDeleteActivity.Enabled = true;
                    panelCaixaStateColor.BackColor = Color.PaleGreen;
                    lblCaixaState.Text = "Caixa Aberto";

                    GetCurrentCaixaInfo();
                    GetCaixaActivity();

                    SplashScreenManager.CloseForm();
                }
            }
        }

        private void gridViewCaixaActivity_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewCaixaActivity.FocusedRowHandle >= 0)
            {
                string ActivityType = gridViewCaixaActivity.GetFocusedRowCellValue("tipo").ToString(); ;
                if (ActivityType == "pedido") { btnDeleteActivity.Enabled = false; } else { btnDeleteActivity.Enabled = true; }
            }
        }

        private void gridViewCaixaResumo_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if ((e.RowHandle == 0) || (e.RowHandle == 1) || (e.RowHandle == 2)
                || (e.RowHandle == 5) || (e.RowHandle == 8) || (e.RowHandle == 9)
                || (e.RowHandle == 13) || (e.RowHandle == 15))
            {
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }

            if ((e.RowHandle == 2) || (e.RowHandle == 5) || (e.RowHandle == 9))
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
            if (e.Column.FieldName == "entrada" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    e.Column.AppearanceCell.ForeColor = Color.Green;
                }
                
            }

            if (e.Column.FieldName == "saida" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    e.Column.AppearanceCell.ForeColor = Color.Red;
                }
            }
        }

        private void gridViewCaixaActivity_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "entrada")
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

            if (e.Column.FieldName == "saida")
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

        private void gridViewCaixaResumo_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
        }

       
    }
}
