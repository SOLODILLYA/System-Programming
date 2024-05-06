using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MainThread - Start");
            var taskArray = new Task[]
            {
                new Task(() => Console.WriteLine("\t Task-1")),
                new Task(() => Console.WriteLine("\t Task-2")),
                new Task(() => Console.WriteLine("\t Task-3")),
            };

            foreach (var task in taskArray)
            {
                task.Start();
            }

            Task.WaitAll(taskArray);

            Console.WriteLine("MainThread - Finish");
        }
    }
}
