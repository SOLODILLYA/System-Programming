using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AbortThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMethod)); 
            t.Start();

            Console.WriteLine(" *Press any key to ABORT calc thread...");
            Console.ReadLine();

            t.Abort();

            Console.WriteLine(" *Press any key to finish program...");
            Console.ReadLine();
        }

        static void ThreadMethod()
        {
            bool trigger = false;
            try
            {
                for(int i = 0; i < 25; i++)
                {
                    Console.WriteLine($" {i + 1}");
                    Thread.Sleep(1000);
                }
                trigger = true;
            }
            finally
            {
                if (trigger)
                {
                    Console.WriteLine("Working Thread has been stopped!");
                }
                else
                {
                    Console.WriteLine("Working Thread has been ABORTED!");
                }
            }
        }
    }
}
