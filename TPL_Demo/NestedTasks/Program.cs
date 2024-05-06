using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NestedTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MainThread - Start");

            var outerTask = Task.Run(() =>
            {
                Console.WriteLine($"\t Outer task start");

                var innerTask = Task.Run(() =>
                {
                    Console.WriteLine($"\t\t Inner task start");
                    Thread.Sleep(5000);
                    Console.WriteLine($"\t\t Inner task finish");
                });
                innerTask.Wait();
                Console.WriteLine($"\t Outer task finish");
            });
            outerTask.Wait();
            Console.WriteLine("MainThread - Finish");
        }
    }
}
