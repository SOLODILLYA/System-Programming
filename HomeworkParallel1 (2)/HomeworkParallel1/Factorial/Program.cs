using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of main thread");
            //1
            Action[] actions = { () => Factorial(10) };
            Parallel.Invoke(actions);
            //2
            Parallel.For(5, 8, MultiplicationTable);
            //3
            List<int> list = new List<int>{ 10, 2, 4, 3, 5, 6};
            Action[] actions2 = { () => GetAverage(list), () => GetMax(list), () => GetMin(list), () => GetSum(list) };
            Parallel.Invoke(actions2);
            Console.ReadKey();
            Console.WriteLine("End of main thread");
        }

        static void Factorial(int n)
        {
            Console.WriteLine($"Start of Async Factorial");
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Thread.Sleep(1000);
                Console.WriteLine($"\t{f}");
                Action[] actions = { () => SumOfNumbers(f) };
                Parallel.Invoke(actions);
            }

            Console.WriteLine($"End of of Async Factorial");
            Console.WriteLine($"\t\tResult: {10}! = {f}");
        }

        static void SumOfNumbers(int n)
        {
            int start = n;
            int sum = 0;
            int num = 0;
            while(n/1 > 0)
            {
                sum += n % 10;
                num++;
                n /= 10;
            }
            Console.WriteLine($"\t\tSum of Numbers in {start} = {sum}");
            Console.WriteLine($"\t\tNumber of Numbers in {start} = {num}");
        }

        static void MultiplicationTable(int n)
        {
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
                Thread.Sleep(1000);
            }
        }

        static void GetMax(List<int> nums)
        {
            int res = nums[0];
            foreach(int x in nums)
            {
                if(x > res)
                {
                    res = x;
                }
            }

            Console.WriteLine("Max: " + res);
        }

        static void GetMin(List<int> nums)
        {
            int res = nums[0];
            foreach (int x in nums)
            {
                if (x < res)
                {
                    res = x;
                }
            }

            Console.WriteLine("Min: " + res);
        }

        static void GetAverage(List<int> nums)
        {
            int res = 0;
            foreach (int x in nums)
            {
                res += x;
            }
            res = res / nums.ToArray().Length;

            Console.WriteLine("Average: " + res);
        }

        static void GetSum(List<int> nums)
        {
            int res = 0;
            foreach (int x in nums)
            {
                res += x;
            }
            Console.WriteLine("Sum: " + res);
        }
    }
}
