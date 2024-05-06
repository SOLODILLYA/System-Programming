using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuadraticEquationsThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Thread> threads = new List<Thread>();
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            List<int> c = new List<int>();

            var startDelegate = new ParameterizedThreadStart(ThreadMethod);
            for (int i = 0; i < 5; i++)
            {
                threads.Add(new Thread(startDelegate));
            }
            for (int j = 0; j < threads.Count; j++)
            {
                a.Clear(); b.Clear(); c.Clear();
                for (int i = 0; i < 5; i++)
                {
                    a.Add(random.Next(-10, 10));
                    b.Add(random.Next(-10, 10));
                    c.Add(random.Next(-10, 10));
                }
                threads[j].Start((object)new DataStruct()
                {
                    num = j + 1,
                    a = a,
                    b = b,
                    c = c,
                });
            }
            for (int i = 0; i < 5; i++)
            {
                threads[i].Join();
            }
        }

        static void ThreadMethod(object dto)
        {
            DataStruct dataStruct = (DataStruct)dto;
            Console.WriteLine($"Thread-{dataStruct.num} - started");
            for (int i = 0; i < 5; i++)
            {
                int a = dataStruct.a[i];
                int b = dataStruct.b[i];
                int c = dataStruct.c[i];
                if (Math.Pow(b, 2) == (4 * a * c))
                {
                    Console.WriteLine($"Thread-{dataStruct.num} - division by 0");
                }
                else
                {
                    double answer1 = (-b - Math.Pow(Math.Pow(b, 2) - (4 * a * c), 0.5)) / (2 * a);
                    double answer2 = (-b + Math.Pow(Math.Pow(b, 2) - (4 * a * c), 0.5)) / (2 * a);
                    Console.WriteLine($"Thread-{dataStruct.num} - a:{a}, b:{b}, c:{c} - answer 1: {answer1}, answer 2: {answer2}");
                }
            }
            Console.WriteLine($"Thread- {dataStruct.num} - finished");
        }
    }
}
