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
            Random rnd = new Random();
            int accountNo = rnd.Next(1, 200);

            Bank bank = new Bank("Personal Bank", 5);
            bank.AddAccount(new Account(accountNo, "Rahim", 20000, new Address("2", "101/A", "Dhaka", "Bangladesh")));
            bank.AddAccount(new Account(accountNo+1, "Karim", 40000, new Address("4", "102/B", "Barisal", "Bangladesh")));
            bank.AddAccount(new Account(accountNo+2, "Jamal", 60000, new Address("6", "202/C", "Rajshahi", "Bangladesh")));
            bank.AddAccount(new Account(accountNo+3, "Jobbar", 80000, new Address("8", "111/G", "Sylhet", "Bangladesh")));
            bank.AddAccount(new Account(accountNo+4, "Hasan", 120000, new Address("12", "800/K", "Khulna", "Bangladesh")));

            //Transactions:
            bank.Transaction(1, bank.myBank[0], 2000);
            bank.PrintAllAccountDetails();
            bank.DeleteAccount(bank.MyBank[2]);
        }
    }
}
