using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;


namespace DevApp.Threads
{
    public delegate void thResumoCallback();

    class CaixaResumoThread
    {
        private thResumoCallback FuncCallback;

        public CaixaResumoThread(thResumoCallback callbackDelegate)
        {
            this.FuncCallback = callbackDelegate;
        }

        public void Process()
        {
            // Do stuff

            if (this.FuncCallback != null)
                FuncCallback();
        }
    }


}
