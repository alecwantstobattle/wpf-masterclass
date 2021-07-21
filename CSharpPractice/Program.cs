using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        private static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            if (numberTwo == 1)
            {
                var numberThree = 12f;
            }

            var numberOne = 23.45;
            Console.WriteLine(numberOne);
            string message = Console.ReadLine();
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
