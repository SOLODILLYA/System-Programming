using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SuspendThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMetod)); 
            t.Start();

            Console.WriteLine("Press any key to SUSPEND calc thread ...");
            Console.ReadKey();

            t.Suspend();
            Console.WriteLine("Calc thread has been suspended");

            Console.WriteLine("Press any key to RESUME calc thread ...");
            Console.ReadKey();

            t.Resume();
        }

        static void ThreadMetod()
        {
            for(int i = 0; i < 25; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(1000);
            }
        }
    }
}
