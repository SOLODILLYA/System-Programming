using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingDemo
{
        internal class MonitorCounter : Counter
        {
            public override void UpgradeCount()
            {
                for (int i = 0; i < 30_000; i++)
                {
                    Monitor.Enter(this);
                    try
                    {
                        _count+=10;
                    }
                    finally
                    {
                        Monitor.Exit(this);
                    }
                }
            }
        }
}
