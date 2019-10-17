using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Account
    {
        int money;
        public Account(string id,int amount)
        {
            money = amount;
           
          
        }
        public void Withdraw()
        {
            Console.WriteLine("Please insert money you want to Withdraw");
            int amount = int.Parse(Console.ReadLine());  
            money -= amount;
            
        }
        public void Deposit()
        {
            Console.WriteLine("Please insert money you want to Deposit");
            int amount = int.Parse(Console.ReadLine());
            money += amount;
        }
        public int Balance()
        {
            return money;
        }
        
    }
}
