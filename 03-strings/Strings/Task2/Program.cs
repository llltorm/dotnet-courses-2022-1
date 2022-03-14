using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи первую строку");
            string firstString = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            string secondString = Console.ReadLine();
            Console.WriteLine(CreateFinalString(firstString, secondString));
            Console.ReadKey();
        }

        public static string CreateFinalString(string firstString, string secondString)
        {
            string finalString = "";
            foreach (char symbol in firstString)
            {
                if (!secondString.Contains(symbol))
                {
                    finalString += symbol;
                }
                else
                {
                    finalString += symbol;
                    finalString += symbol;
                }
            }
            return finalString;
        }
    }
}
