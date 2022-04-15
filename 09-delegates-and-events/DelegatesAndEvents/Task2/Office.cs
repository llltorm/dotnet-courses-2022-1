using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public delegate void Greet(OfficeEventArgs e);

    public delegate void SayingGoodbye(OfficeEventArgs e);
    class Office
    {
        public event Greet PersonCame;

        public event SayingGoodbye PersonLeft;

        //public event Coming PersonCame;

        //public event Leaving PersonLeft;

        public void Come(Person person)
        {
            Console.WriteLine($"[На работу пришёл {person.Name}]");

            PersonCame?.Invoke(new OfficeEventArgs() { Name = person.Name, Time = DateTime.Now });

            PersonCame += person.Greet;
            PersonLeft += person.SayingGoodbye;

            Console.WriteLine();
        }
        public void Leave(Person person)
        {
            Console.WriteLine($"[{person.Name} ушёл домой]");

            PersonCame -= person.Greet;
            PersonLeft -= person.SayingGoodbye;

            PersonLeft?.Invoke(new OfficeEventArgs() { Name = person.Name });

            Console.WriteLine();
        }
    }
}
