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


using DevApp.Global;
using DevApp.User_Forms;
using DevApp.Child_Forms;
using DevApp.PopUp_Forms;
using DevApp.SQLite;
using DevApp.ComponentOverride;

namespace DevApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            SplashScreen();

            ribbon.Minimized = true;
            nativeMdiView1.BackgroundImage = Image.FromFile("C:\\Users\\Thiago\\Desktop\\DevApp\\Resouces\\bg.png");
        }

        public void SplashScreen()
        {
            //Image myLogoImage = Resources.Logo;
            SplashScreenManager.ShowSkinSplashScreen(
                //logoImage: myLogoImage,
                title: "DevApp Business Management",
                subtitle: "Open Source Restaurant Manager",
                footer: "Copyright © 2021 DevApp Solucoes." + Environment.NewLine + "Todos os direitos reservados.",
                loading: "Iniciando DevApp v1.3..",
                parentForm: this
            );

            Thread.Sleep(2000);
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            XtraLogin Login = new XtraLogin(this);
            Login.Text = "Login de Usuario";
            Login.WindowState = FormWindowState.Normal;
            Login.ShowDialog(this);
        }

        public void ShowCurrentCaixa()
        {
            XtraMDICaixaManager CAIXA = new XtraMDICaixaManager(false);
            CAIXA.Text = "Gerenciador de Caixa";
            CAIXA.WindowState = FormWindowState.Normal;
            CAIXA.MdiParent = this;
            CAIXA.Show();
        }

        public void ShowCustomCaixa(int CaixaId)
        {
            XtraMDICaixaManager CAIXA = new XtraMDICaixaManager(true, CaixaId);
            CAIXA.Text = "Historico - Caixa de " + LogginedUser.DisplayName + " - Id: " + CaixaId.ToString();
            CAIXA.WindowState = FormWindowState.Normal;
            CAIXA.MdiParent = this;
            CAIXA.Show();
        }

        public void SetLogginedUser()
        {
            lblLogginedUser.Caption = "<b>Usuario</b>: " + LogginedUser.DisplayName;
            ribbon.Minimized = false;
        }

        private void barEditItem5_EditValueChanged(object sender, EventArgs e)
        {
            string Value = barEditItem5.EditValue.ToString();
            if (XtraMessageBox.Show(Value, "Message", MessageBoxButtons.YesNo) != DialogResult.No)
            {

            }
        }


        private void btnShowCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMDICaixaManager CAIXA = new XtraMDICaixaManager(false);
            CAIXA.Text = "Gerenciador de Caixa";
            CAIXA.WindowState = FormWindowState.Normal;
            CAIXA.MdiParent = this;
            CAIXA.Show();
        }

        private void btnShowCaixaHist_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMDICaixaHistory childForm = new XtraMDICaixaHistory(this);
            childForm.Text = "Historico de Abertura e Fechamento de Caixa";
            childForm.WindowState = FormWindowState.Normal;
            childForm.MdiParent = this;
            childForm.Show();
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

        private void btnCadastroClientes_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnShowTables_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPedidoCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SQLiteCipher TestConn = new SQLiteCipher();
            TestConn.SetupDB();
        }
    }
}