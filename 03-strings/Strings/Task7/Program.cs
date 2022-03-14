using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст со временем");
            string inputString = Console.ReadLine();
            Console.WriteLine("Время в тексте присутствует {0} раз", СountingTime(inputString));
        }

        public static int СountingTime(string inputString)
        {
            Regex time = new Regex(@"([0-1]?\d|2[0-3])(:([0-5][0-9]))");
            MatchCollection count = time.Matches(inputString);
            return count.Count;
        }
    }
}
