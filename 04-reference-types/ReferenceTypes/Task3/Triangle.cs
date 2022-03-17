using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Triangle
    {
        private static int _a;
        private static int _b;
        private static int _c;

        public int A
        {
            get { return _a; }
        }
        public int B
        {
            get { return _b; }
        }

        public int C
        {
            get { return _c; }
        }

        public double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public double GetPerimeter()
        {
            return _a + _b + _c;
        }

        public Triangle(int A, int B, int C)
        {
            if ((A + B < C) || (A + C < B) || (B + C < A))
            {
                throw new ArgumentException("This triangle is not exist");
            }
            _a = A;
            _b = B;
            _c = C;
        }
    }
}
