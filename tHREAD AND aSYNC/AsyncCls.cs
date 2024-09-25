using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tHREAD_AND_aSYNC
{
    class AsyncCls
    {

        public async void ThreadM1()
        {
            await Task.Run(() =>
            {

                for (int i = 0; i < 100; i++)
                {
                    Task.Delay(1000).Wait();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("ThreadM1 method called");
                }
            });
        }
        public async void ThreadM2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 150; i++)
            {
                Task.Delay(5000).Wait();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("ThreadM2 method called");
            }
            });
        }
        public async void ThreadM3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 200; i++)
            {
                Task.Delay(9000).Wait();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("ThreadM2 method called");
            }
            });

        }
    }
}
