using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;
namespace ParallelFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of main thread");
            Parallel.For(1, 16, Calculator1.FactorialAsync);
            Console.ReadKey();
            Console.WriteLine("End of main thread");
        }
    }
}
