using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace invokeMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(Operation1, Operation2);
            Console.ReadKey();
        }

        static void Operation1()
        {
            Console.WriteLine($"Execution of first operation with ID: {Task.CurrentId}");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\tOperation-1 => task-{i + 1}");
                Thread.Sleep(1);
            }
        }

        static void Operation2()
        {
            Console.WriteLine($"Execution of first operation with ID: {Task.CurrentId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\t\tOperation-2 => task-{i + 1}");
                Thread.Sleep(1);
            }
        }
    }
}
