using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            const int n = 25;
            var task1 = new Task<long>(() => Factorial(n)); 
            task1.Start();

            //2
            var task2 = new Task<Book>(() => new Book()
            {
                Title = "Kobzar",
                Author = "Taras Hrihorovich Shevchenko"
            });
            task2.Start();

            //3
            task1.Wait();
            Console.WriteLine($"{n}! = {task1.Result}");

            //4
            task2.Wait();
            Console.WriteLine(task2.Result);
        }

        static long Factorial(long n) 
        {
            long f = 1;
            for(int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
