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



        public void PerformTransactions(int transactionType, Account account, double amount)
        {
            string amount1, amount2;
            int a1, a2;
            if (int.Equals(transactionType, 1))
            {
                for (int i = 0; i < myBank.Length; i++)
                {
                    if (myBank[i] == null)
                    {
                        //myBank[i] = account;
                        Console.WriteLine("Enter your amout: ");
                        amount1 = Console.ReadLine();
                        a1 = Convert.ToInt32(amount1);
                        myBank[i].Deposit(a1);
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
                        Console.WriteLine("Enter your amout: ");
                        amount1 = Console.ReadLine();
                        a1 = Convert.ToInt32(amount1);
                        myBank[i].Withdraw(a1);
                        break;
                    }
                }
            }
            else if (int.Equals(transactionType, 3))
            {
                for (int i = 0; i < myBank.Length; i++)
                {
                    if (myBank[i] == null)
                    {
                        Console.WriteLine("Enter your amout: ");
                        amount2 = Console.ReadLine();
                        a2 = Convert.ToInt32(amount2);
                        myBank[i].Transfer(a2);
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
