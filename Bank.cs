using System;
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

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(Account account)
        {
            for (int j = 0; j < myBank.Length; j++)
            {
                if (myBank[j] == account)
                {
                    myBank[j] = null;
                    break;
                }
                Console.WriteLine("Account Deleted Successfully!");
            }
        }
        public void Transaction(int transactionType, Account account, double amount)
        {
            if(int.Equals(transactionType,"Withdraw"))
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
            else if(int.Equals(transactionType, "Deposit"))
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
