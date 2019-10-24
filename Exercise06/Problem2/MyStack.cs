using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
   
    public class MyStack
    {
         int[] s = new int[100];
         int i = 0;
        public void Put(int item)
         {
             s[i] = item;
             i++;
         }
        public int Pop()
        {
            i--;
            return (s[i]);
        }
        public int Count()
        {
            return i;
        }
        public int Peek()
        {
            return s[i - 1];
            //hello
        }

    }
    
}
