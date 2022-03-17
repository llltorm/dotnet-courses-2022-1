using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Round
    {
        private int _radius;
        private int _x;
        private int _y;
        public Round(int x, int y, int radius)
        {
            СheckPatronymic(radius);
            _x = x;
            _y = y;
            _radius = radius;
        }

        protected void СheckPatronymic(int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }
        }

        public int Radius
        {
            get { return _radius; }
            set 
            {
                СheckPatronymic(value);
                _radius = value;  
            }
        }

        public double Circumference()
        {
            return 2 * Math.PI * _radius;
        }
        public double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
