using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp.Global
{
    public static class Globals
    {
        public static List<string> onlineMembers = new List<string>();

        public static bool IsCaixaOpen { get; set; }
        public static int CaixaId { get; set; }


        static Globals()
        {
            IsCaixaOpen = false;
            CaixaId     = -1;
        }
    }
}
