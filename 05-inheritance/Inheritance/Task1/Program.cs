using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(1991, 05, 06);
            DateTime dateGetJob = new DateTime(2015, 01, 06);
            Employer Emploer1 = new Employer(birth, "Евгений", "Петров", "Евгеньевич", dateGetJob, "Автомеханик", 150000, "ООО Единство");
            int age = Emploer1.Age;
            int exp = Emploer1.Expirience;
            Console.WriteLine($"Возраст - {age} лет");
            Console.WriteLine($"Опыт - {exp} лет.");
            Console.WriteLine("ФИО - {0} {1} {2}", Emploer1.LastName, Emploer1.Name, Emploer1.Patronymic);
            Emploer1.Position="";
            Emploer1.Salary = 120;
        }
    }
}
