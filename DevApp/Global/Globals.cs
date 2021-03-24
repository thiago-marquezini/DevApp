using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevApp.Global
{
    public static class LogginedUser
    {
        public static bool Loggined = false;
        public static string Username;
        public static string DisplayName;
        public static string LastActivity;
        public static int Level;
    }

    public static class Globals
    {
        public static List<string> onlineMembers = new List<string>();

        // Caixa
        // 
        public static bool IsCaixaOpen { get; set; }
        public static int CaixaId { get; set; }
        public static int CaixaValorTotal { get; set; }
        public static int CaixaValorTotalDinheiro { get; set; }


        static Globals()
        {
            IsCaixaOpen = false;
            CaixaId = -1;
        }

        public static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }

        public static List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        // Set entire form controls text font
        //List<Control> allControls = Globals.GetAllControls(this);
        //allControls.ForEach(k => k.Font = new System.Drawing.Font("Verdana", 8));

    }
}
