using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(1991, 05, 06);
            DateTime dateGetJob = new DateTime(2015, 01, 06);
            Employer Emploer1 = new Employer(birth, "Евгений", "Петров", "Евгеньевич", dateGetJob, "Автомеханик", 150000, "ООО Единство");
            Employer Emploer2 = new Employer(birth, "Генадий", "Петров", "Евгеньевич", dateGetJob, "Автомеханик", 150000, "ООО Единство");
            Console.WriteLine(Emploer1.Equals(Emploer2));
        }
    }
}
