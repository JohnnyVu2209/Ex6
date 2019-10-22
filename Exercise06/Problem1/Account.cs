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
            Console.WriteLine("Users: {0}",id);
            money = amount;
            Console.WriteLine("Balance: {0}",money);
           
          
        }
        public void Withdraw()
        {
            Console.WriteLine("Please insert money you want to Withdraw");
            int amount = int.Parse(Console.ReadLine());
            if(amount > Balance())
            {
                Console.WriteLine("out of money");
            }
            else
            {
                money -= amount;
                Console.WriteLine("Withdraw successful");
            }
                        
        }
        public void Deposit()
        {
            Console.WriteLine("Please insert money you want to Deposit");
            int amount = int.Parse(Console.ReadLine());
            money += amount;
            Console.WriteLine("Deposit successful");
        }
        public int Balance()
        {
            return money;
        }
        
    }
}
