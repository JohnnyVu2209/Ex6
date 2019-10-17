using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your ATM card: ");
            string cardID = Console.ReadLine();
            Account acc = new Account(cardID, 200000);
            Console.WriteLine("What you want to do? Deposit(D) or Withdraw(W)");
            string choose = Console.ReadLine();
            if (choose == "D" || choose == "d")
                acc.Deposit();
            else if (choose == "W" || choose == "w")
                acc.Withdraw();
            
                

        }
    }        
}

        
        
            
            
            
            
        