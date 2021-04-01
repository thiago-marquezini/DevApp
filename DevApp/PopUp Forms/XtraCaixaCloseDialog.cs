using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevApp.Global;
using DevApp.Child_Forms;
using DevApp.SQLite;

namespace DevApp.PopUp_Forms
{
    public partial class XtraCaixaCloseDialog : DevExpress.XtraEditors.XtraForm
    {
        public bool DecisionMade = false;
        public int  DecisionId   = -1;

        XtraMDICaixaManager Caixa;

        public XtraCaixaCloseDialog(XtraMDICaixaManager _Caixa)
        {
            InitializeComponent();

            this.Caixa = _Caixa;
        }

        private void XtraCaixaCloseDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DecisionMade == false)
            {
                this.DecisionMade = true;
                this.DecisionId   = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DecisionMade = true;
            this.DecisionId   = 0;

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.Caixa.CalculateResumo(true, txtCaixaSaldoFinalTotal.Text))
            {
                this.DecisionMade = true;
                this.DecisionId = 1;

                this.Close();
            } else
            {
                XtraMessageBox.Show("Houve uma falha ao fechar o Caixa.", "Fechamento de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCloseAndPrint_Click(object sender, EventArgs e)
        {
            if (this.Caixa.CalculateResumo(true, txtCaixaSaldoFinalTotal.Text))
            {
                this.DecisionMade = true;
                this.DecisionId = 2;

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Houve uma falha ao fechar o Caixa.", "Fechamento de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XtraCaixaCloseDialog_Load(object sender, EventArgs e)
        {
            if (Globals.CaixaValorTotalDinheiro != 0)
            {
                txtCaixaSaldoFinalDinheiro.Text = Globals.CaixaValorTotalDinheiro.ToString().Insert(Globals.CaixaValorTotalDinheiro.ToString().Length - 2, ",");
            }

            if (Globals.CaixaValorTotal != 0)
            {
                txtCaixaSaldoFinalTotal.Text = Globals.CaixaValorTotal.ToString().Insert(Globals.CaixaValorTotal.ToString().Length - 2, ",");
            }
        }
    }
}