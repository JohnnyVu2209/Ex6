using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Queue
    {
        int[] s = new int[100];
        int i = 0;
        int sta = 0;
        public void Enqueue(int item)
        {
            s[i] = item;
            i++;
            sta++;
        }
        public int Dequeue()
        {
            int queue = s[sta - i];
            i--;
            return queue;
        }
        public int Count()
        {
            return i;
        }
        public int Peek()
        {
            return s[sta - i];
        }
    }
}
