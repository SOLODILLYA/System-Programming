using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Calculator2
    {
        public static void FactorialAsync(int n)
        {
            int? id = Task.CurrentId;
            Console.WriteLine($"Start of Operation (id = {id}) of calculation of factorial");
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Thread.Sleep(1000);
                Console.WriteLine($"\t{f}");
            }
            Console.WriteLine($"End of Operation (id = {id}) of calculation of factorial");
            Console.WriteLine($"\t\tResult: {n}! = {f}");
        }
    }
}
