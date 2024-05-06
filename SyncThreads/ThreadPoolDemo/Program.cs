using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Main Thread - Start");
            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(WorkingMethod, i + 1);
            }
            Console.ReadKey();
            Console.WriteLine("*** Main Thread - Finish");
        }

        static void WorkingMethod(object state)
        {
            Console.WriteLine($"\tThread: {Thread.CurrentThread.ManagedThreadId}; state: {state}");
            Thread.Sleep(1000);
        }
    }
}
