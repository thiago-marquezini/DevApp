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

namespace DevApp
{
    public partial class WizardConfigureApp : DevExpress.XtraEditors.XtraForm
    {
        public WizardConfigureApp()
        {
            InitializeComponent();
        }

        private void welcomeWizardPage1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            //if (progressPanel1.Enabled)
            //{
            //    e.Valid = false;
            //    if (!e.Valid)
            //        e.ErrorText = "The login information you supplied is not valid.";
            //}
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }
    }
}