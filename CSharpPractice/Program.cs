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
            double[] numbers = new double[] {1, 2, 3, 42, 42154};
            var result = SimpleMath.Add(numbers);
            Console.WriteLine(result);

            BankAccount bankAccount = new BankAccount();
            bankAccount.AddToBalance(100);
            Console.WriteLine(bankAccount.Balance);

            ChildBankAccount childBankAccount = new ChildBankAccount();
            childBankAccount.AddToBalance(10);
            Console.WriteLine(childBankAccount.Balance);

            Console.ReadLine();
        }
    }

    class SimpleMath
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Add(double[] numbers)
        {
            double result = 0;
            foreach (double d in numbers)
            {
                result += d;
            }

            return result;
        }
    }
}
