using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
        class SavingsAccount : Account
        {
            public SavingsAccount(AccountHolder accountHolder, int accountNumber, double balance) : base(accountNumber, accountHolder, balance)
            {
                AccountNumber = accountNumber;
                Type = AccountType.Savings;
                Balance = balance;
                AccountHolder = accountHolder;
            }
        }
}
