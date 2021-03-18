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

namespace DevApp.PopUp_Forms
{
    public partial class XtraCaixaCloseDialog : DevExpress.XtraEditors.XtraForm
    {
        public bool DecisionMade = false;
        public int  DecisionId   = -1;

        public XtraCaixaCloseDialog()
        {
            InitializeComponent();
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
            this.DecisionMade = true;
            this.DecisionId = 1;

            this.Close();
        }

        private void btnCloseAndPrint_Click(object sender, EventArgs e)
        {
            this.DecisionMade = true;
            this.DecisionId = 2;

            this.Close();
        }
    }
}