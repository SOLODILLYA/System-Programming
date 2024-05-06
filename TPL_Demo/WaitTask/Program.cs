using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Start of main thread");
            Console.WriteLine("Crteation of async task");
            var task = new Task(DisplaySomething);
            task.Start();
            task.Wait();
            Console.WriteLine("*End of main thread");
        }

        static void DisplaySomething()
        {
            Console.WriteLine("Start of output");
            Console.WriteLine("\t\tProcess of output...");
            Console.WriteLine("End of output");
        }
    }
}
