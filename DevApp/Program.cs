using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread.  
            // Information on custom skins registered in the main thread is not available in the splash screen thread  
            // until you call the SplashScreenManager.RegisterUserSkins method.  
            // To provide information on custom skins to the splash screen thread, uncomment the following line. 
            //SplashScreenManager.RegisterUserSkins(asm);  

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
