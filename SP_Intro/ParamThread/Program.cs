using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParamThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n> Main Thread Start");
            var startDelegate = new ParameterizedThreadStart(ThreadMethod);
            var thread1 = new Thread(startDelegate);
            var thread2 = new Thread(startDelegate);
            var thread3 = new Thread(startDelegate);

            thread1.Start((object)new DataStruct()
            {
                name = "Thread-1",
                tabs = "\t",
                iters = 30,
                sleep = 11
            });
            thread2.Start((object)new DataStruct()
            {
                name = "Thread-2",
                tabs = "\t\t",
                iters = 20,
                sleep = 20
            });
            thread3.Start((object)new DataStruct()
            {
                name = "Thread-3",
                tabs = "\t\t\t",
                iters = 10,
                sleep = 30
            });

            thread1.Join();
            thread2.Join();
            thread3.Join();
            Console.WriteLine("\n> Main Thread Finished");
        }

        static void ThreadMethod(object dto)
        {
            //dto = "Data Transit Object"

            DataStruct dataStruct = (DataStruct)dto;
            string name = dataStruct.name;
            string tabs = dataStruct.tabs;
            int iters = dataStruct.iters;
            int sleep = dataStruct.sleep;
            Console.WriteLine($"{tabs}{name} - started");
            for(int i = 0; i < iters; i++)
            {
                Console.WriteLine($"{tabs}{name} - {i + 1} action");
                Thread.Sleep(sleep);
            }
            Console.WriteLine($"{tabs}{name} - finished");
        }
    }
}
