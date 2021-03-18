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
using DevApp.PopUp_Forms;
using DevApp.SQLite.Queries;

using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;

namespace DevApp.Child_Forms
{
    public partial class XtraMDICaixaMgr : DevExpress.XtraEditors.XtraUserControl
    {
 
        private clsCaixaQueries CaixaQueries = new clsCaixaQueries();

        public XtraMDICaixaMgr()
        {
            InitializeComponent();
            GetCurrentCaixaInfo();
        }

        private void XtraMDICaixaMgr_Load(object sender, EventArgs e)
        {
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
            }
        }

        public void GetCaixaActivity()
        {
            DataTable dt = CaixaQueries.GetCaixaActivity(Globals.CaixaId);
            gridCaixaActivity.DataSource = dt;
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

        private void btnCaixaOpenClose_Click(object sender, EventArgs e)
        {
            if (Globals.IsCaixaOpen)
            {
                XtraCaixaCloseDialog CloseCaixaDialog = new XtraCaixaCloseDialog();

                CloseCaixaDialog.Text = "Fechamento do Caixa";
                CloseCaixaDialog.WindowState = FormWindowState.Normal;
                CloseCaixaDialog.ShowDialog(this);

                while (!CloseCaixaDialog.DecisionMade) { Thread.Sleep(500); } // each form has its own thread

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

                    goto Exit; // Not needed :) but I feel good to add it
                }

                // this is what the goto exit; is going to do:
                // .. nothing
                // nothing ends here, lets do what was going to be done anyway
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
    }
}
