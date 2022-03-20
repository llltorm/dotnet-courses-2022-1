using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString exampleOne = new MyString();
            MyString exampleTwo = new MyString("Пример");
            char[] example = { 'П', 'р', 'и', 'м', 'е', 'р' };
            MyString exampleThree = new MyString(example);
            Console.WriteLine(exampleTwo.Str);
            Console.WriteLine(exampleThree.Str);
            MyString summ = exampleThree + exampleTwo;
            Console.WriteLine(summ.Str);
            Console.WriteLine(exampleTwo.ToString());
            bool сomparison = (exampleThree == exampleTwo);
            Console.WriteLine(сomparison);
        }
    }
}
