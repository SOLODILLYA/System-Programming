using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutexSync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mutex Synchronization");
            var counter = new MutexCounter();

            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(counter.UpdateFields));
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"\t Finish Count Value: {counter.Count}");

        }
    }
}
