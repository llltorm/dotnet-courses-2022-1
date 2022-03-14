using System;
using System.Globalization;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Что сравнивать:");
            Console.WriteLine("1) ru vs en");
            Console.WriteLine("2) en vs invariant");
            Console.WriteLine("3) ru vs invariant");
            int option = int.Parse(Console.ReadLine());
            double number = 123.6546;
            DateTime timeTightNow = DateTime.Now;
            string ru = "ru-RU";
            string eng = "en-EN";
            string invariant = "";
            if (option == 1)
            {

                TimeDate(ru, timeTightNow);
                TimeDate(eng, timeTightNow);
                Numbers(ru, number);
                Numbers(eng, number);
            }
            else if (option == 2)
            {
                TimeDate(eng, timeTightNow);
                TimeDate(invariant, timeTightNow);
                Numbers(eng, number);
                Numbers(invariant, number);
            }
            else if (option == 3)
            {
                TimeDate(ru, timeTightNow);
                TimeDate(invariant, timeTightNow);
                Numbers(ru, number);
                Numbers(invariant, number);
            }
            else
            {
                Console.WriteLine("What's no use");
            }



            static void TimeDate(string cult, DateTime Time)
            {
                Console.WriteLine("Дата и время " + cult);
                var culture = CultureInfo.GetCultureInfo(cult);
                Console.WriteLine("Date format (long):  {0}", Time.ToString("D", culture));
                Console.WriteLine("Date format (short): {0}", Time.ToString("d", culture));
                Console.WriteLine("Full format (long):  {0}", Time.ToString("F", culture));
                Console.WriteLine("Full format (short): {0}", Time.ToString("f", culture));
                Console.WriteLine("Time format (long):  {0}", Time.ToString("T", culture));
                Console.WriteLine("Time format (short): {0}", Time.ToString("t", culture));
                Console.WriteLine("General format (long):  {0}", Time.ToString("G", culture));
                Console.WriteLine("General format (short): {0}", Time.ToString("g", culture));
            }


            static void Numbers(string cult, double Value)
            {
                Console.WriteLine("Запись чисел " + cult);
                var culture = CultureInfo.GetCultureInfo(cult);
                Console.WriteLine("Decimal and group separator: {0}", Value.ToString("N", culture));
                Console.WriteLine("Currency: {0}", Value.ToString("C", culture));
                Console.WriteLine("Fixed-point:  {0}", Value.ToString("F", culture));
                Console.WriteLine("Percent: {0}", Value.ToString("P", culture));
            }
        }
    }
}
