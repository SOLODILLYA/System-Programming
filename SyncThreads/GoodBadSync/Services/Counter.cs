using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBadSync.Services
{
    abstract class Counter
    {
        internal int _field1;
        internal int _field2;

        public int Field1 => _field1;
        public int Field2 => _field2;

        public abstract void UpdateFields();
    }
}
