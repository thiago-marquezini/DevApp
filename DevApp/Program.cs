using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace DevApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // If your custom skin is derived from a template skin that resides in the BonusSkins library, ensure that you register the template skin first using the BonusSkins.Register method.  
            //DevExpress.UserSkins.BonusSkins.Register();  
            //Assembly asm = typeof(DevExpress.UserSkins.CustomSkin).Assembly;
            //DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
            //SplashScreenManager.RegisterUserSkins(asm);  

            // Linguagem pt-BR
            CultureInfo Culture = CultureInfo.CreateSpecificCulture("pt-BR");
            Thread.CurrentThread.CurrentUICulture = Culture;
            Thread.CurrentThread.CurrentCulture = Culture;
            CultureInfo.DefaultThreadCurrentCulture = Culture;
            CultureInfo.DefaultThreadCurrentUICulture = Culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
