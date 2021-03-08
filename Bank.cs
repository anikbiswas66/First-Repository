﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Bank
    {
        public string bankName;
        public Account[] myBank;

        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }

        public void OpenAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;

                    Console.WriteLine("Welcome, New Account has opened Successfully!");
                    Console.WriteLine("Account Number is: " + myBank[i].AccountNumber);

                    break;
                }
            }
        }

        //public void PerformTransactions(int transactionType, Account account, int accountNumber, double amount)
        //{
            //int count = 0;

            //string amount1, amount2, amount3;
            //int a1, a2, a3;

            //for (int i = 0; i < count; i++)
            //{
            //    if (myBank[i].AccountNumber == accountNumber)
            //        Console.WriteLine("Ready to go!");
            //    {
            //        if(int.Equals(transactionType, 1))
            //        {
            //            Console.WriteLine("Enter your amount: ");
            //            amount1 = Console.ReadLine();
            //            a1 = Convert.ToInt32(amount1);
            //            myBank[i].Deposit(a1);
            //            break;
            //        }

            //    }
            //}

            public void PerformTransactions(int transactionType, Account account, double amount)
            {
            if (int.Equals(transactionType, 1))
            {
                for (int i = 0; i < myBank.Length; i++)
                {
                    if (myBank[i] == null)
                    {
                        //myBank[i] = account;
                        account.Withdraw(amount);
                        break;
                    }
                }
            }
            else if (int.Equals(transactionType, 2))
            {
                for (int i = 0; i < myBank.Length; i++)
                {
                    if (myBank[i] == null)
                    {
                        account.Deposit(amount);
                        break;
                    }
                }
            }
        }

        public void PrintAllAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
    }
}
