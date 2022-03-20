using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Rectangle : Figure
    {
		protected double _width;
		protected double _height;

		public Rectangle(double width, double height)
		{
			_width = width;
			_height = height;
		}

		public override double GetArea()
		{
			return _width * _height;
		}

		public override void Draw()
		{
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			return string.Format($"Это прямоугольник со сторонами {_width} и {_height}");
		}
	}
}
