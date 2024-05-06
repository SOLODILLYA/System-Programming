using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> * Main Thread Started");

            var threadStartDelegate = new ThreadStart(ThreadMethod);
            var additionalThread = new Thread(threadStartDelegate);
            additionalThread.IsBackground = true;
            additionalThread.Start();

            for (int i = 0; i < 20; i++)
            {
                    Console.WriteLine($"Hello from Main Thread - {i + 1}");
            }
            Console.WriteLine("> * Main Thread Finished");
        }

        static void ThreadMethod()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"\t\t\tHello from Additional Thread - {i + 1}");
            }
        }
    }
}
