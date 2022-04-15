using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person
    {
        public string Name { get; set; }

        public void Greet(OfficeEventArgs e)
        {
            string greeting;
            if (e.Time.Hour > 16)
            {
                greeting = "Добрый вечер";
            }
            else if (e.Time.Hour > 11)
            {
                greeting = "Добрый день";
            }
            else
            {
                greeting = "Доброе утро";
            }
            Console.WriteLine("'{0}, {1}!', - сказал {2}.", greeting, e.Name, Name);
        }

        public void SayingGoodbye(OfficeEventArgs e)
        {
            Console.WriteLine("'До свидания, {0}!', - сказал {1}.", e.Name, Name);
        }
    }
}
