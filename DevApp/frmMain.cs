using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.NativeMdi;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Database
using DevApp.Global;
using DevApp.Child_Forms;
using DevApp.PopUp_Forms;
using DevApp.SQLite.Queries;
using DevApp.ComponentOverride;

namespace DevApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private clsUserQueries Queries = new clsUserQueries();

        public void SplashScreen()
        {
            //Image myLogoImage = Resources.Logo;
            SplashScreenManager.ShowSkinSplashScreen(
                //logoImage: myLogoImage,
                title: "When Only The Best Will Do",
                subtitle: "DevExpress WinForms Controls",
                footer: "Copyright © 2000 - 2020 Developer Express Inc." + Environment.NewLine + "All Rights reserved.",
                loading: "Starting...",
                parentForm: this
            );

            Thread.Sleep(1000);
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            Thread.Sleep(1000);
        }

        public frmMain()
        {
            InitializeComponent();
            SplashScreen();

            // Change Ribbon SearchBox Text
            BarLocalizer.Active = new CustomBarLocalizer();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Enable Skins for Forms and MDI Forms
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            // Add background MDI Form
            XtraMDIBackground childForm = null;
            childForm = new XtraMDIBackground();
            childForm.Text = "MDI Background Form";
            childForm.MdiParent = this;
            childForm.AutoScroll = false;
            childForm.Show();

            //Queries.Login("admin", "123456");

            //Thread myNewThread = new Thread(() => MyMethod("param1", 5));
            //myNewThread.IsBackground = true;
            //myNewThread.Start();
        }

        private void MyMethod(string param1, int param2)
        {
            //do stuff
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMDICaixaMgr CAIXA = new XtraMDICaixaMgr();
            DevExpress.XtraEditors.XtraDialog.Show(CAIXA, "Gerenciador de Caixa", MessageBoxButtons.OK);
        }

        private void barEditItem5_EditValueChanged(object sender, EventArgs e)
        {
            string Value = barEditItem5.EditValue.ToString();
            if (XtraMessageBox.Show(Value, "Message", MessageBoxButtons.YesNo) != DialogResult.No)
            {

            }
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            // Ribbon Page Changed
            if (ribbon.SelectedPage == ribbonPage1)
            {
                //ribbon.SelectPage(ribbonPage4);
            }
        }

        void AddChild()
        {
            Form childForm = null;
            childForm = new XtraForm_Caixa();
            //childForm.Text = "Xtra Child Form";

            //SimpleButton btn = new SimpleButton();
            //btn.Text = "Button";
            //btn.Parent = childForm;

            childForm.WindowState = FormWindowState.Normal;
            childForm.MdiParent = this;
            childForm.Show();

            //frmLogin LoginForm = new frmLogin();
            //DevExpress.XtraEditors.XtraDialog.Show(LoginForm, "Sign in", MessageBoxButtons.OKCancel);
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
                if (XtraMessageBox.Show("Right click detected", "Message", MessageBoxButtons.YesNo) != DialogResult.No)
                {

                }
            //}
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
                if (XtraMessageBox.Show("Right click detected", "Message", MessageBoxButtons.YesNo) != DialogResult.No)
                {

                }
            //}
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Thread.Sleep(2000);
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            //for (int i = 0; i < 3; i++)
            //{
                AddChild();
            //}
        }

        private void btnFinanceiroCategDespesas_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFinanceiroCategDespesas CategDespesas = new XtraFinanceiroCategDespesas();
            CategDespesas.Text = "Categorias de Despesas";
            CategDespesas.WindowState = FormWindowState.Normal;
            CategDespesas.ShowDialog(this);
        }

        private void btnConfigAssist_ItemClick(object sender, ItemClickEventArgs e)
        {
            WizardConfigureApp ConfigWizard = new WizardConfigureApp();
            ConfigWizard.Show();
        }
    }
}