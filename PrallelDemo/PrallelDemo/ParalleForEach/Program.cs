using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;

namespace ParalleForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of main thread");

            ParallelLoopResult res = Parallel.ForEach<int>(new List<int>
            {
                14, 3, 11, 5, 9, 4, 7
            }, Calculator1.FactorialAsync);

            Console.ReadKey();
            Console.WriteLine("End of main thread");
        }
    }
}
