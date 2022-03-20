using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class ArithmeticProgression : IIndexableSeries
	{
		double _start, _step;
		int _currentIndex;

		public ArithmeticProgression(double start, double step)
		{
			_start = start;
			_step = step;
			_currentIndex = 1;
		}

		public double GetCurrent()
		{
			return _start + _step * _currentIndex;
		}

		public bool MoveNext()
		{
			_currentIndex++;
			return true;
		}

		public void Reset()
		{
			_currentIndex = 1;
		}

        public double this[int index]
        {
            get
            {
                return _start + _step * index;
            }
        }

    }
}
