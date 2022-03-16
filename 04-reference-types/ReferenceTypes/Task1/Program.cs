using System;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите человека");
            Console.WriteLine("Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Фамилия");
            string lastname = Console.ReadLine();
            Console.WriteLine("Отчество");
            string otchestvo = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string year = Console.ReadLine();
            DateTime birth = DateTime.Parse(year);
            User User = new User(birth, name, lastname, otchestvo);
            Console.WriteLine(User.Name);
            Console.WriteLine(User.LastName);
            Console.WriteLine(User.Patronymic);
            Console.WriteLine(User.Age);
        }
    }
}
