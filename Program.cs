using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int accountNo = rnd.Next(1, 1000);

            Bank bank = new Bank("Personal Bank", 5);
            bank.AddAccount(new Account(1, "Rahim", 20000, new Address("2", "101/A", "Dhaka", "Bangladesh")));
            bank.AddAccount(new Account(2, "Karim", 40000, new Address("4", "102/B", "Barisal", "Bangladesh")));
            bank.AddAccount(new Account(3, "Jamal", 60000, new Address("6", "202/C", "Rajshahi", "Bangladesh")));
            bank.AddAccount(new Account(4, "Jobbar", 80000, new Address("8", "111/G", "Sylhet", "Bangladesh")));

            //Transactions:
            bank.Transaction(1, bank.myBank[0], 500);
            bank.Transaction(2, bank.myBank[0], 100);
            bank.Transaction(2, bank.myBank[1], 400);
            bank.Transaction(1, bank.myBank[1], 100);

            //Print Details:
            bank.PrintAllAccountDetails();
            //bank.DeleteAccount(bank.MyBank[1]);
        }
    }
}
