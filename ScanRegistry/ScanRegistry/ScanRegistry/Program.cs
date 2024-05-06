using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ScanRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectItem = 0;

            //-> list of main branches of system registry
            var branches = new RegistryKey[]
            {
                Registry.ClassesRoot,
                Registry.CurrentUser,
                Registry.LocalMachine,
                Registry.Users,
                Registry.CurrentConfig,
            };

            //2 Loop of dialog to select branch of registry
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t=====================================");
                Console.WriteLine("\tList of System Registry Global Keys");
                Console.WriteLine("\t=====================================");

                int i = 0;
                foreach (var branch in branches)
                {
                    Console.WriteLine($"\t {++i}. {branch.Name}");
                }
                Console.WriteLine("\t 0.Exit");


                Console.WriteLine("\t=====================================");
                Console.WriteLine("\n> Choose number of Target Global Key: ");
                selectItem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(selectItem > 0 && selectItem <= branches.GetLength(0))
                {
                    ScanRegKeys(branches[selectItem - 1]);
                    Console.ReadKey();
                }

            } while (selectItem != 0);

            Console.WriteLine("\n\nFinish");
        }

        static void ScanRegKeys(RegistryKey key)
        {
            string[] names = key.GetSubKeyNames();
            Console.WriteLine($"SubKeys of {key.Name}");
            Console.WriteLine("------------------------------------------------");
            foreach(string name in names)
            {
                Console.WriteLine($" - {name}");
            }
            Console.WriteLine("------------------------------------------------");

        }
    }
}
