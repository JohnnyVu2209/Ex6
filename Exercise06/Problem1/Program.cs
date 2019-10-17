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
            string FilePath = @"D:\Vu\C#\Account.txt";


            string ID = "";string Pin = "";
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            StreamReader str = new StreamReader(fs, Encoding.UTF8);
            String[] ListAccount = str.ReadToEnd().Split(' ');
            for (int i = 0; i < ListAccount.Length; i++)
            {
                String[] AtmAccount = ListAccount[i].Split('_');
                for (int j = 0; j < AtmAccount.Length; j++)
                {
                    ID = AtmAccount[0];
                    Pin = AtmAccount[1];
                    Console.WriteLine(ID);
                }
            }
            
            str.Close();
            if(cardID == ID)
            {
                Console.Write("Pin: ");
                string pass = Console.ReadLine();
                if(pass == Pin)
                {
                    Account acc = new Account(cardID,200000);
                    Console.WriteLine("ID Acount: {0}", cardID);
                    Console.WriteLine("Balance: {0}", acc.Balance());
                    Console.WriteLine();
                   
                    while(true)
                    {
                        Console.WriteLine("You want: Withdraw(W) Or Deposit(D) or End(E)");
                        string want = Console.ReadLine();
                        if (want == "W" || want == "w")
                        { acc.Withdraw(); Console.WriteLine("balance: {0}", acc.Balance()); }

                        else if (want == "D" || want == "d")
                        { acc.Deposit(); Console.WriteLine("balance: {0}", acc.Balance()); }
                        else if (want == "e" || want == "E")
                            break;
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Wrong ID");
            }
        
        }

        
        static void ReadAccount(string FilePath, out string ID , out string Pin)
        {
            ID = ""; Pin = "";
            
            
            
            
        }
    }

}
