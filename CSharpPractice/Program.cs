using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Classes;

namespace CSharpPractice
{
    class Program
    {
        private static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AddToBalance(100);
            Console.WriteLine(bankAccount.Balance);

            Console.ReadLine();
        }
    }

    class SimpleMath
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
