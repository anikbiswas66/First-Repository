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
            string choice, accountName, dob, address;

            Random rnd = new Random();
            int accountNo = rnd.Next(100, 1000);
            accountNo++;

            Bank bank = new Bank("YO Bank", 1000);
            Console.WriteLine("___________________________");
            Console.WriteLine("Welcome to YO Bank!");
            Console.WriteLine("___________________________");

            //for(int i = 0; i<10; i++)
            //{
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Here are your Options: ");
                Console.WriteLine("Open a Bank account");
                Console.WriteLine("Perform transactions for an account");
                Console.WriteLine("Exit the application");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "open":
                        {
                            Console.WriteLine("Open Savings Account");
                            Console.WriteLine("Open Checking Account");
                            Console.WriteLine("Exit from the application");
                            string choice1 = Console.ReadLine();

                            if (choice1 == "quit")
                            {
                                break;
                            }
                            else if (choice1 == "savings")
                            {
                                Console.WriteLine("Enter Your Name : ");
                                accountName = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter Date of Birth :");
                                dob = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter Adress :");
                                address = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter Balance :");
                                string balance1 = Console.ReadLine();
                                int b1 = Convert.ToInt32(balance1);
                                Console.WriteLine();

                                SavingsAccount sa = new SavingsAccount(accountNo, accountName, b1, dob, address);
                            }
                            else if (choice == "checking")
                            {
                                Console.WriteLine("Enter Your Name : ");
                                accountName = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter Date of Birth :");
                                dob = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter Adress :");
                                address = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter Balance :");
                                string balance1 = Console.ReadLine();
                                int b1 = Convert.ToInt32(balance1);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case "account":
                        {
                            Console.WriteLine("Make a deposit");
                            Console.WriteLine("Make a withdrawal");
                            Console.WriteLine("Make a transfer");
                            Console.WriteLine("Show the number transactions and balance");
                            Console.WriteLine("Exit the application");
                            string choice2 = Console.ReadLine();

                            if (choice2 == "quit")
                            {
                                break;
                            }
                            else if (choice2 == "deposit")
                            {
                                bank.PerformTransactions(1, accountNo);
                            }
                            else if (choice2 == "withdraw")
                            {
                                bank.PerformTransactions(2, accountNo);
                            }
                            else if (choice2 == "transfer")
                            {
                                bank.PerformTransactions(3, accountNo);
                            }
                            else if (choice2 == "show")
                            {
                                bank.PerformTransactions(4, accountNo);
                            }
                            break;
                        }
                    case "quit":
                        return;

                    default:
                        Console.WriteLine("Sorry, Wrong Input!");
                        break;
                }
            }
        }
    }
}

