using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotGoodSync();
            VeryGoodSync();
        }

        static void NotGoodSync()
        {
            Console.WriteLine("\nUnsynchronized");
            var counter1 = new UnsynchronizedCounter();

            Thread[] threads = new Thread[3];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(delegate ()
                {
                    for (int j = 1; j <= 30_000; j++)//треба було зробити більше транзакцій, бо 3000 і без синхронізації давали правильну відповідь
                    {
                        counter1.UpgradeCount();
                    }
                });
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"\n> Amoun: {counter1.Count}");
        }
        static void VeryGoodSync()
        {
            Console.WriteLine("\nMonitor Sync");
            var counter2 = new MonitorCounter();

            Thread[] threads = new Thread[3];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(counter2.UpgradeCount));
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"\n> Amount: {counter2.Count}");
        }
    }
}
