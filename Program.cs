using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        //Random rnd = new Random();
        //int accountNo = rnd.Next(1, 1000);
        static void Main(string[] args)
        {
            string choice; 
            Bank bank = new Bank("YO Bank", 1000);
            Console.WriteLine("___________________________");
            Console.WriteLine("Welcome to YO Bank!");
            Console.WriteLine("___________________________");

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Here are your Options: ");
                Console.WriteLine("Open a Bank account");
                Console.WriteLine("Perform transactions for an account");
                Console.WriteLine("Exit the application");
                choice = Console.ReadLine();


            }
        }
    }
}
