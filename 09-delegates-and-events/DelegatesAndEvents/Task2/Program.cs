using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mary = new Person { Name = "Mary" };
            Person kate = new Person { Name = "Kate" };
            Person hugo = new Person { Name = "Hugo" };

            Office office = new Office();

            office.Come(mary);
            office.Come(kate);
            office.Come(hugo);
            office.Leave(kate);
            office.Leave(hugo);
            office.Leave(mary);
        }
    }



}
