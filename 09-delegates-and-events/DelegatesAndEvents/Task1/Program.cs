using System;

namespace Task1
{
    class Program
    {
        public delegate int CompareTwoStrings(string string1, string string2);

        static void Main(string[] args)
        {
            string[] str = { "ааааа", "ббб", "вввв", "ааа", "а", "аааааааааа", "ааа", "аааа", "аааааа" };
            Sort(str, CompareStrings);
            Print(str);
        }

        public static void Print(string[] str)
        {
            foreach (string elem in str)
            {
                Console.WriteLine(elem);
            }
        }

        public static void Sort(string[] str, CompareTwoStrings predicate)
        {
            for (int j = 0; j < str.Length; j++)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (predicate(str[i], str[i + 1]) > 0)
                    {
                        string elem = str[i];
                        str[i] = str[i + 1];
                        str[i + 1] = elem;
                    }
                }
            }
        }



        public static int CompareStrings(string stringFirst, string stringSecond)
        {
            if(stringFirst.Length > stringSecond.Length)
            {
                return 1;
            }
            if (stringFirst.Length < stringSecond.Length)
            {
                return -1;
            }
            for (int i = 0; i < stringFirst.Length; i++)
            {
                if (stringFirst[i] > stringSecond[i])
                {
                    return 1;
                }
                if (stringFirst[i] < stringSecond[i])
                {
                    return -1;
                }
            }
            return 0;
        }


    }
}
