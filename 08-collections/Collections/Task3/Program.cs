using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I am walking home home down the street down";
            Print(CountWords(text));            
        }


        public static Dictionary<string, int> CountWords(string text)
        {
            string[] massivString = text.ToLower().Split(" ,.?!'()\"".ToCharArray());
            Dictionary<string, int> englishWords =new Dictionary<string, int>();
            for (int i  = 0; i < massivString.Length; i++)
            {
                if (!(englishWords.ContainsKey(massivString[i])))
                {
                    int count = 0;
                    for (int j = 0; j < massivString.Length; j++)
                    {
                        if (massivString[i] == massivString[j])
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        englishWords.Add(massivString[i], count);
                    }
                }
            }
            return englishWords;
        }


        public static void Print(Dictionary<string, int> englishWords) 
        {
            foreach (var element in englishWords)
            {
                Console.WriteLine(element);
            }
        }
    }
}
