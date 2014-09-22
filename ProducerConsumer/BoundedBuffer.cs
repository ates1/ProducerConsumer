using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class BoundedBuffer
    {
        private Queue<int> _queue;
        private int _cap;

       
        public BoundedBuffer(int capacity)
        {
            this._cap = capacity;
            this._queue = new Queue<int>();
        }

        public bool IsFull()
        {
            if (this._queue.Count >= this._cap)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return true;
        }




    }
}