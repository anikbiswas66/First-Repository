using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Sorry, Insufficient funds!");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount!");
            }
            balance -= amount;
            Console.WriteLine("Withdraw Done!");
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Sorry, Invalid deposit amount!");
            }
            balance += amount;
            Console.WriteLine("Deposit Done!");
        }
        public void Transfer(Account receiver, double amount)
        {
            this.Withdraw(amount);
            receiver.Deposit(amount);
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("_______________________________");
            Console.WriteLine();
            Console.WriteLine("Account Number: {0}\nAccount Name: {1}\nBalance: {2}\nAddress: {3}", this.accountNumber, this.accountName, this.balance, this.address);
            this.address.GetAddress();
        }
    }
}
