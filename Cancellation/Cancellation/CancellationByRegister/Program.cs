using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CancellationByRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            var someTask = new Task(() =>
            {
                int i = 1;

                cancellationToken.Register(() =>
                {
                    Console.WriteLine("Command for cancellation has been received");
                    i = 10;
                });

                for (; i <= 10; i++)
                {
                    Console.WriteLine($"Square of {i} equals to {i * i}");
                    Thread.Sleep(1000);
                }
            }, cancellationToken);
            someTask.Start();

            Thread.Sleep(3500);
            cancellationTokenSource.Cancel();
            Console.WriteLine($"Task Status: {someTask.Status}");
     
            cancellationTokenSource.Dispose();
            Console.WriteLine("Finish");
        }
    }
}
