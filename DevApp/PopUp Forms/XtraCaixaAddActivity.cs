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

using DevApp.Child_Forms;
using DevApp.SQLite;

namespace DevApp.PopUp_Forms
{
    public partial class XtraCaixaAddActivity : DevExpress.XtraEditors.XtraForm
    {

        private SQLiteCipher CaixaAddActConnection = new SQLiteCipher();
        private clsCaixaQueries CaixaQueries = new clsCaixaQueries();

        private int CaixaId = -1;
        private XtraMDICaixaManager CaixaForm;

        public XtraCaixaAddActivity(XtraMDICaixaManager _CaixaForm, int CaixaId)
        {
            InitializeComponent();

            this.CaixaId = CaixaId;
            this.CaixaForm = _CaixaForm;
        }

        private void btnCancelAddActivity_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (CaixaQueries.AddCaixaActivity(CaixaAddActConnection.Connection(), radioActivityType.SelectedIndex, radioOperacaoTipo.SelectedIndex, editValorActivity.Text, -1, -1, "manual"))
            {
                this.Close();
                CaixaForm.GetCaixaActivity();
                CaixaForm.CalculateResumo(false);
            }
        }

        private void radioOperacaoTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (radioOperacaoTipo.SelectedIndex == 0)
            {
                //comboCategoriasDespesas.Enabled = true;
                //comboFornecedores.Enabled = true;

            } else if (radioOperacaoTipo.SelectedIndex == 1)
            {
                //comboCategoriasDespesas.Enabled = false;
                //comboFornecedores.Enabled = false;

            } else
            {
                //comboCategoriasDespesas.Enabled = false;
                //comboFornecedores.Enabled = false;
            }
        }

        private void editValorActivity_EditValueChanged(object sender, EventArgs e)
        {
        }
    }
}