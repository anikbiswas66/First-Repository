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
            Bank bank = new Bank("Personal Bank", 5);
            bank.AddAccount(new Account(1001, "Rahim", 20000, new Address("2", "101/A", "Dhaka", "Bangladesh")));
            bank.AddAccount(new Account(1002, "Karim", 40000, new Address("4", "102/B", "Barisal", "Bangladesh")));
            bank.AddAccount(new Account(1003, "Jamal", 60000, new Address("6", "202/C", "Rajshahi", "Bangladesh")));
            bank.AddAccount(new Account(1004, "Jobbar", 80000, new Address("8", "111/G", "Sylhet", "Bangladesh")));
            bank.AddAccount(new Account(1006, "Hasan", 120000, new Address("12", "800/K", "Khulna", "Bangladesh")));
            bank.PrintAllAccountDetails();
        }
    }
}
