using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> listInt = new DynamicArray<int>(new int[] { 5, 8, 6, 3, 1 });
            DynamicArray<string> listSterting = new DynamicArray<string>(new string[] { "элемент1", "элемент2", "элемент3", "элемент4", "элемент5" });
            listSterting.Add("элемент?");
            listSterting.PrintSeries();
            listSterting.Insert("элемент??", 3);
            listSterting.PrintSeries();
            listSterting.Remove("элемент3");
            listSterting.PrintSeries();
            listSterting.AddRange(new string[] { "элемент6", "элемент7", "элемент8"});
            listSterting.PrintSeries();
        }

    }

}
