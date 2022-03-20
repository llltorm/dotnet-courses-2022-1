using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Figure
    {
		protected double _radius;

		public Round(double radius)
		{
			_radius = radius;
		}

		public override double GetArea()
		{
			return Math.PI * _radius * _radius;
		}

		public override void Draw()
		{
			Console.WriteLine($"Это окружность с радиусом {_radius}");
		}
	}
}
