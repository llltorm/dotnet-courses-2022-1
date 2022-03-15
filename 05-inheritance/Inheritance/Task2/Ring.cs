using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Ring : Round
    {
        private int _innerRadius;

        public Ring(int x, int y, int radius, int innerRadius) : base(x, y, radius)
        {
            if (innerRadius <= 0)
            {
                throw new ArgumentException("Radius can't be 0 or less");
            }
            if (innerRadius > radius)
            {
                throw new ArgumentException("Outer radius can't be less than inner");
            }
            _innerRadius = innerRadius;
        }

        public int InnerRadius
        {
            get { return _innerRadius; }
            set { _innerRadius = value;  }
        }
        public override double Circumference()
        {
            return 2 * Math.PI * _radius + 2 * Math.PI * _innerRadius;
        }


        public override double Area()
        {
            return Math.PI * _radius * _radius - Math.PI * _innerRadius * _innerRadius;
        }
    }
}
