using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Round
    {
        protected int _radius;
        private int _x;
        private int _y;
        public Round(int x, int y, int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }
            _x = x;
            _y = y;
            _radius = radius;

        }
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public virtual double Circumference()
        {
            return 2 * Math.PI * _radius;
        }
        public virtual double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }

}
