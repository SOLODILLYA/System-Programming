using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessesScanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] procList = Process.GetProcesses();
            int count = 0;
            foreach(Process proc in procList)
            {
                count++;
                string displayInfo = $"{count}: {proc.ProcessName} -> {proc.Id} {proc.MainWindowTitle} => {proc.StartInfo.FileName}";
                displayInfo += $" / {proc.BasePriority}";
                Console.WriteLine(displayInfo);
            }
            var currentProc = Process.GetCurrentProcess();
            string displayCurrent = $"\n> Current Process: {currentProc.ProcessName}";
            displayCurrent += $" -> {currentProc.Id} / {currentProc.BasePriority}";
            Console.WriteLine(displayCurrent);
        }
    }
}
