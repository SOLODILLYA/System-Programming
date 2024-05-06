using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GoodBadSync.Services
{
    internal class InterlockedCounter : Counter
    {
        public override void UpdateFields() 
        { 
            for(int i = 0; i < 1_000_000; i++)
            {
                Interlocked.Increment(ref _field1);//safe _field1++
                if(_field1 % 2 == 0)
                {
                    Interlocked.Increment(ref _field2);//safe _field2++
                }
            }
        }

    }
}
