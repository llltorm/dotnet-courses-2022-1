using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
			Figure[] fig = new Figure[5];
			Random randomGenerator = new Random();

			for (int i = 0; i < fig.Length; i++)
			{
				switch (randomGenerator.Next(5))
				{
					case 0:
						fig[i] = new Rectangle(10, 10);
						break;
					case 1:
						fig[i] = new Round(10);
						break;
					case 2:
						fig[i] = new Ring(10, 5);
						break;
					case 3:
						fig[i] = new Circle(10);
						break;
					case 4:
						fig[i] = new Line(10);
						break;
				}
			}
			double area = 0;
			for (int i = 0; i < fig.Length; i++)
			{
				if (fig[i] is Rectangle)
				{
					((Rectangle)fig[i]).Draw();
					area = ((Rectangle)fig[i]).GetArea();
				}
				else if (fig[i] is Round)
				{
					((Round)fig[i]).Draw();
					area = ((Round)fig[i]).GetArea();
				}
				else if (fig[i] is Ring)
				{
					((Ring)fig[i]).Draw();
					area = ((Ring)fig[i]).GetArea();
				}
				else if (fig[i] is Circle)
				{
					((Circle)fig[i]).Draw();
					area = ((Circle)fig[i]).GetArea();
				}
				else if (fig[i] is Line)
				{
					((Line)fig[i]).Draw();
					area = ((Line)fig[i]).GetArea();
				}
				Console.WriteLine(area);
			}
		}
    }
}
