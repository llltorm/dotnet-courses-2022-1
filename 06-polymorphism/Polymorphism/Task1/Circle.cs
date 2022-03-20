using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Circle : Figure
    {
		protected double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public override double GetArea()
		{
			return _radius * _radius * Math.PI;
		}

		public override void Draw()
		{
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			return string.Format($"Это круг с радиусом {_radius}");
		}
	}
}
