using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с HTML символами");
            string input = Console.ReadLine();
            Console.WriteLine($"Итоговая строка: {ReplaceHtmlSymbol(input)}");
        }

        public static string ReplaceHtmlSymbol(string input)
        {
            Regex html = new Regex("<[^>]+>");
            string output = html.Replace(input, "_");
            return output;
        }
    }
}
