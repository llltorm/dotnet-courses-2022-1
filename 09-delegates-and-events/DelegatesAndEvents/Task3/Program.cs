using System;
using System.Threading;

namespace Task3
{
    class Program
    {
        static public event Finish callback;

        public delegate void Finish(string message);

        public delegate int CompareTwoStrings(string String1, string String2);

        static void Main(string[] args)
        {
            string[] str1 = { "ааааа", "ббб", "вввв", "ааа", "а", "аааааааааа", "ааа", "аааа", "аааааа" };
            string[] str2 = { "ппппп", "ррр", "сссс", "ппп", "п", "test1", "ааа", "аааа", "аааааа" };

            Thread[] threads = new Thread[2];
            callback += CallingFinishMessage;
            threads[0] = SortAsync(str1, CompareStrings);
            threads[1] = SortAsync(str2, CompareStrings);

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

        public static Thread SortAsync(string[] stringArr, CompareTwoStrings compStr)
        {
            //callback += CallingFinishMessage;
            Thread thread = new Thread(() => Run(stringArr, compStr));
            thread.Start();
            return thread;
        }

        static void Run(string[] stringArr, CompareTwoStrings compStr)
        {
            /*lock(syncLock)*/
            //callback += CallingFinishMessage;
            Sort(stringArr, compStr);
            callback?.Invoke("Thread was finished!");
        }

        static void CallingFinishMessage(string message)
        {
            Console.WriteLine(message);
        }


        public static int CompareStrings(string stringFirst, string stringSecond)
        {
            if (stringFirst.Length > stringSecond.Length)
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
