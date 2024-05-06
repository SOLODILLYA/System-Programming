using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoodBadSync.Services
{
    internal class LockCounter : Counter
    {
        private object _lockObj;
        public LockCounter()
        {
            _lockObj = new object();
        }
        public override void UpdateFields()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                lock (_lockObj)
                {
                    _field1++;
                    if (_field1 % 2 == 0)
                    {
                        _field2++;
                    }
                }
                    
                
            }
        }
    }
}
