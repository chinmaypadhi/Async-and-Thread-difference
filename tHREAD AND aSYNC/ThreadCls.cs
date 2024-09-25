using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tHREAD_AND_aSYNC
{
    class ThreadCls
    {
        public void ThreadM1()
        {

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ThreadM1 method called");
            }
        }
        public void ThreadM2()
        {
            for (int i = 0; i < 150; i++)
            {
                Thread.Sleep(5000);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("ThreadM2 method called");
            }
        }
        public void ThreadM3()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(9000);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("ThreadM2 method called");
            }
        }

    }
}
