using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncMethods
{
    internal class Program
    {
        delegate long AsyncSumDelegate(long n);
        static void Main(string[] args)
        {
            AsyncSumDelegate asyncDelegate = Sum;
            asyncDelegate.BeginInvoke(1_000_000, AsyncCallback, asyncDelegate);
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }

        static long Sum(long n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++){
                res += i;
            }
            return res;
        }

        static void AsyncCallback(IAsyncResult ar)
        {
            AsyncSumDelegate delegateClone = (AsyncSumDelegate)ar.AsyncState;
            long result = delegateClone.EndInvoke(ar);
            Console.WriteLine("Calculations has been finished");
            Console.WriteLine($"Result: {result}");
        }
    }
}
