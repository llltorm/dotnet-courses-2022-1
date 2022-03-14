using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            Console.WriteLine(СountingСharacter(str)/ words.Length);
        }

        public static int СountingСharacter(string str)
        {
            char[] charArray = str.ToCharArray();
            int sumCharacter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((!char.IsPunctuation(charArray[i])) && (!char.IsSeparator(charArray[i])))
                {
                    sumCharacter += 1;
                }
            }
            return sumCharacter;
        }
    }
}
