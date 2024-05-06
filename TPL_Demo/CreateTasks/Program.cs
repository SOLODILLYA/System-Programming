using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*MainThread started");

            var task1 = new Task(() =>
            {
                Console.WriteLine("Task-1 async executing in ThreadPool");
            });

            var task2 = new Task(() =>
            {
                Console.WriteLine("Task-2 async executing in ThreadPool");
            });

            var task3 = new Task(() =>
            {
                Console.WriteLine("Task-3 async executing in ThreadPool");
            });
            task1.Start();
            task2.Start();
            task3.Start();

            Console.ReadKey();
            Console.WriteLine("*MainThread finished");
        }
    }
}
