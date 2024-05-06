using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.CodeDom;

namespace GoodBadSync.Services
{
    internal class MonitorCounter : Counter
    {

        public override void UpdateFields()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                Monitor.Enter(this);
                try
                {
                    _field1++;
                    if(_field1 % 2 == 0)
                    {
                        _field2++;
                    }
                }
                finally
                {
                    Monitor.Exit(this);
                }
            }
        }
    }
}
