using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MutexSync
{
    internal class MutexCounter
    {
        private int _count;
        private Mutex _mutex;
        public int Count => _count;

        public MutexCounter()
        {
            _mutex = new Mutex(false, "MY_SYNC_MUTEX");
        }

        public void UpdateFields()
        {
            for(int i = 0; i < 1_000_000; i++)
            {
                _mutex.WaitOne();
                _count++;
                _mutex.ReleaseMutex();
            }
        }
    }
}
