using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Account
    {
        public int accountNumber;
        public string accountName;
        protected string dob, address;
        public double balance;
        public int transaction;
        //private Address address;

        public Account(int accountNumber, string accountName, double balance, string dob, string address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.dob = dob;
            this.address = address;
            //this.transaction = transaction;
            //this.address = address;
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
        public string DOB
        {
            get { return this.dob; }
            set { this.dob = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int Transaction
        {
            get { return this.transaction; }
            //set { this.transaction = value; }
        }

        //public Address Address
        //{
        //    get { return this.address; }
        //    set { this.address = value; }
        //}

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
                Console.WriteLine("Sorry, Invalid amount!");
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
            Console.WriteLine("Account Number: {0}\nAccount Name: {1}\nDate Of Birth: {2}\nBalance: {3}\nAddress: {4}", this.accountNumber, this.accountName, this.dob, this.balance, this.address);
            //this.address.GetAddress();
        }
    }
}
