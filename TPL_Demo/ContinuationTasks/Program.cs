using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ContinuationTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*MainThread started");

            var task1 = new Task<int>(() => CalcSum(120,230));
            var task2 = task1.ContinueWith((sum) => DisplayResult(sum.Result));

            task1.Start();
            task2.Wait();
            Console.WriteLine("*MainThread finished");
        }

        static int CalcSum(int x, int y)
        {
            Thread.Sleep(1000);
            Console.WriteLine("> calcSum finish");
            return x + y;
        }

        static void DisplayResult(int sum)
        {
            Thread.Sleep(1000);
            Console.WriteLine("DisplayResult execute");
            Console.WriteLine($"> sum = {sum}");
            Console.WriteLine("DisplayResult finish");
        }
    }
}
