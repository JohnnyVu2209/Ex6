using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            s.Put(1);
            s.Put(2);
            s.Put(4);

            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            
        }
    }
}
