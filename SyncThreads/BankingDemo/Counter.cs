using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
    internal abstract class Counter
    {

        public int _count;
        public int Count => _count;
        public abstract void UpgradeCount();
    }
}
