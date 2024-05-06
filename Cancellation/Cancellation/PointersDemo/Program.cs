using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Pointers Demo");

            //2
            unsafe
            {
                long* ptr, ptr1;
                long a = 10;
                long b = 25;

                ptr = &a;
                Console.WriteLine(*ptr);
                ptr1 = &b;
                Console.WriteLine((int)ptr1);

                *ptr *= 2;
                *ptr1 /= 2;

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
            }

            //3
            unsafe
            {
                int number = 2;
                Power(&number, 10);
                Console.WriteLine($"2 ^ 10 = {number}");
            }
        }
        unsafe static void Power(int* x, int n)
        {
            int a = *x;
            for(int i = 1; i < n; i++)
            {
                *x *= a;
            }

        }
    }
}
