using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();
            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);

            //Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Count());
        }
    }
}
