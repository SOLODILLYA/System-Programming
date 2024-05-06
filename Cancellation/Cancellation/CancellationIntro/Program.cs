using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CancellationIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            var someTask = new Task(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Operation has been cancelled");
                        return;
                    }
                    Console.WriteLine($"Square of {i} equals to {i * i}");
                    Thread.Sleep(1000);
                }
            }, cancellationToken);
            someTask.Start();

            Thread.Sleep(5000);
            cancellationTokenSource.Cancel();

            Thread.Sleep(12000);
            Console.WriteLine($"Task Status: {someTask.Status}");

            Console.WriteLine("Finish");
        }
    }
}
