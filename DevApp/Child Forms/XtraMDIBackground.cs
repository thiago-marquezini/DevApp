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
    public partial class XtraMDIBackground : DevExpress.XtraEditors.XtraForm
    {
        public XtraMDIBackground()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void XtraMDIBackground_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}