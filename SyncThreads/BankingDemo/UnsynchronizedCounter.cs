using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingDemo
{
    internal class UnsynchronizedCounter : Counter
    {
        public override void UpgradeCount()
        {
                _count += 10;
        }
    }
}
