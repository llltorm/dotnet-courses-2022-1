﻿using System;
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
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }
            _x = x;
            _y = y;
            this._radius = radius;

        }
        public int Radius
        {
            get { return _radius; }
            set { _radius = value;  }
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
