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


        //public void PerformTransactions(int transactionType, Account account, double amount)
        //{
        //    string amount1, amount2;
        //    int a1, a2;
        //    if (int.Equals(transactionType, 1))
        //    {
        //        for (int i = 0; i < myBank.Length; i++)
        //        {
        //            if (myBank[i] == null)
        //            {
        //                //myBank[i] = account;
        //                Console.WriteLine("Enter your amout: ");
        //                amount1 = Console.ReadLine();
        //                a1 = Convert.ToInt32(amount1);
        //                myBank[i].Deposit(a1);
        //                break;

        //            }
        //        }
        //    }
        //    else if (int.Equals(transactionType, 2))
        //    {
        //        for (int i = 0; i < myBank.Length; i++)
        //        {
        //            if (myBank[i] == null)
        //            {
        //                Console.WriteLine("Enter your amout: ");
        //                amount1 = Console.ReadLine();
        //                a1 = Convert.ToInt32(amount1);
        //                myBank[i].Withdraw(a1);
        //                break;
        //            }
        //        }
        //    }
        //    else if (int.Equals(transactionType, 3))
        //    {
        //        for (int i = 0; i < myBank.Length; i++)
        //        {
        //            if (myBank[i] == null)
        //            {
        //                Console.WriteLine("Enter your amout: ");
        //                amount2 = Console.ReadLine();
        //                a2 = Convert.ToInt32(amount2);
        //                myBank[i].Transfer(a2);
        //                break;
        //            }
        //        }

        //    }
        //}


//----------------------------------------------------------------------------------------------------------------------------------------------------

        //public void PerformTransactions(string transactionType, int accountNumber)
        //{

        //    string amount1, amount2, amount3;
        //    int a1, a2, a3;

        //    for (int i = 0; i < myBank.Length; i++)
        //    {
        //        if (myBank[i].AccountNumber == accountNumber)
        //            Console.WriteLine("Ready to go!");
        //        {
        //            if (transactionType == "deposit")
        //            {
        //                Console.WriteLine("Enter your amount: ");
        //                amount1 = Console.ReadLine();
        //                a1 = Convert.ToInt32(amount1);
        //                myBank[i].Deposit(a1);
        //                break;
        //            }

        //            else if (transactionType == "withdraw")
        //            {
        //                Console.WriteLine("Enter your amount: ");
        //                amount2 = Console.ReadLine();
        //                a2 = Convert.ToInt32(amount2);
        //                myBank[i].Withdraw(a2);
        //                break;
        //            }
        //            else if (transactionType == "transfer")
        //            {
        //                Console.WriteLine("Enter your amount: ");
        //                amount3 = Console.ReadLine();
        //                a3 = Convert.ToInt32(amount3);
        //                for (int j = 0; j < myBank.Length; j++)
        //                {
        //                    if (myBank[j].AccountNumber == accountNumber)
        //                    {
        //                        myBank[i].Transfer(myBank[j], a3);
        //                        break;
        //                    }
        //                }
        //            }
        //            else if (transactionType == "show")
        //            {
        //                //for (i = 0; i < myBank.Length; i++)
        //                //{
        //                //    if (myBank[i] == null)
        //                //    {
        //                //        continue;
        //                //    }
        //                //    myBank[i].ShowAccountInformation();
        //                Console.WriteLine("Account Number is: " + myBank[i].AccountNumber);
        //                Console.WriteLine("Account Balance is: " + myBank[i].balance);
        //                myBank[i].ShowAccountInformation();
        //            }
        //            else
        //                break;
        //        }

//-----------------------------------------------------------------------------------------------------------------------------------------------

        public void PerformTransactions(string transactionType)
        {
            double amount;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (transactionType == "deposit")
                {
                    for (int j = 0; j < myBank.Length; j++)
                    {
                        if (myBank[j] == null)
                        {
                            Console.WriteLine("Enter your amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            myBank[j].Deposit(amount);
                            //double a1 = amount;
                            break;
                        }
                    }
                }
                else if (transactionType == "withdraw")
                {
                    for (int k = 0; k < myBank.Length; k++)
                    {
                        if (myBank[k] == null)
                        {
                            Console.WriteLine("Enter your amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            myBank[k].Withdraw(amount);
                            break;
                        }
                    }
                }
                else if (transactionType == "transfer")
                {
                    for (int w = 0; w < myBank.Length; w++)
                    {
                        if (myBank[w] == null)
                        {
                            Console.WriteLine("Enter your amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            myBank[w].Transfer(myBank[w], amount);
                            break;
                        }
                    }
                }
                else if (transactionType == "show")
                {
                    Console.WriteLine("Enter your amount: ");
                    Console.WriteLine("Account Number is: " + myBank[i].AccountNumber);
                    Console.WriteLine("Account Balance is: " + myBank[i].balance);
                    myBank[i].ShowAccountInformation();

                }
                else
                    break;
            }
        }
    }
}
