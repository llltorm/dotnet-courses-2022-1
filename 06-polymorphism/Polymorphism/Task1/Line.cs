using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Line : Figure
    {
		protected double _length;

		public Line(double length)
		{
			_length = length;
		}

		public override double GetArea()
		{
			return 0;
		}

		public override void Draw()
		{
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			return string.Format($"Это линия длиною {_length}");
		}
	}
}
