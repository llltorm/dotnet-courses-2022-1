using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Впишите число");
            string inputString = Console.ReadLine();
            Process(inputString);
        }

        static void Process(string inputString)
        {
            string standart = @"^-?(0|[1-9]\d*)(\.\d+)?$";
            string science = @"-?\d*\.?\d+e[+-]?\d+";
            if (Regex.IsMatch(inputString, standart))
            {
                Console.WriteLine("Это число в обычной нотации ");

            }
            else if (Regex.IsMatch(inputString, science))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
        }
    }
}
