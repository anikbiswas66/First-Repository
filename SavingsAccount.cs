using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class SavingsAccount:Account
    {
        public SavingsAccount(int accountNumber, string accountName, double balance, string dob, string address):base(accountNumber, accountName, balance, dob, address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.dob = dob;
            this.address = address;
        }
        override public void Withdraw(double amount)
        {
            if (balance > amount && amount > 0)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Sorry Boss, Not Sufficient Balance");
            }
        }

        override public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else 
            { 
                Console.WriteLine("Sorry Boss, Can't Accept!");
            }
        }
        //SavingsAccount.ShowAccountInformation();
    }
}

