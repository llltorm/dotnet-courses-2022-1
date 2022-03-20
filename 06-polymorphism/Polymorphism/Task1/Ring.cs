using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ring : Round
    {
		protected double _innerR;

		public Ring(double radius, double innerRadius)
			: base(radius)
		{
			_innerR = innerRadius;
		}

		public override double GetArea()
		{
			return base.GetArea() - Math.PI * _innerR * _innerR;
		}

		public override void Draw()
		{
			Console.WriteLine("Это окружность с внешним радиусом {0} и внутренним {1}", _radius, _innerR);
		}
	}
}
