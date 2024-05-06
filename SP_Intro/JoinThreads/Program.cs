using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JoinThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> Main Thread started");
            var thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();
            thread.Join();
            Console.WriteLine("> Main Thread stopped");
        }

        static void ThreadMethod() 
        {
            Console.WriteLine("\t\t\t\t\t* Additional Thread started");
            Thread.Sleep(5000);
            Console.WriteLine("\t\t\t\t\t* Additional Thread stopped");
        }
    }
}
