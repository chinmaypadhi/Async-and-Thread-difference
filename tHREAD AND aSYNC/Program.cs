using System;
using System.Threading;

namespace tHREAD_AND_aSYNC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thread block
            ThreadCls obj = new ThreadCls();
            Thread thg1 = new Thread(obj.ThreadM1);
            Thread thg2 = new Thread(obj.ThreadM2);
            Thread thg3 = new Thread(obj.ThreadM3);
            thg1.Start();
            thg2.Start();
            thg3.Start();
            #endregion


            #region Async (task) block 
            //AsyncCls obj = new AsyncCls();
            
            //obj.ThreadM2();
            //obj.ThreadM1();
            //obj.ThreadM3();
         
            #endregion

            Console.Read();
        }
    }
}
