using GoodBadSync.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GoodBadSync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotGoodSync();
            VeryGoodSync();
            VeryGoodSyncSugar();
        }

        static void NotGoodSync() 
        {
            Console.WriteLine("\nIntelocked Sync (Not Good)");
            var counter1 = new InterlockedCounter();

            Thread[] threads = new Thread[5];
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(counter1.UpdateFields));
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"\n> Field1: {counter1.Field1}");
            Console.WriteLine($"    > Field2: {counter1.Field2}");
        }
        static void VeryGoodSync()
        {
            Console.WriteLine("\nMonitor Sync (Very Good)");
            var counter2 = new MonitorCounter();

            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(counter2.UpdateFields));
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"\n> Field1: {counter2.Field1}");
            Console.WriteLine($"    > Field2: {counter2.Field2}");
        }

        static void VeryGoodSyncSugar()
        {
            Console.WriteLine("\nLock Sync (Very Good Sugar)");
            var counter3 = new LockCounter();

            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(counter3.UpdateFields));
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"\n> Field1: {counter3.Field1}");
            Console.WriteLine($"    > Field2: {counter3.Field2}");
        }
    }
}
