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
    public partial class XtraFinanceiroCategDespesas : DevExpress.XtraEditors.XtraForm
    {
        public XtraFinanceiroCategDespesas()
        {
            InitializeComponent();
        }

        private void XtraFinanceiroCategDespesas_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            
        }
    }
}