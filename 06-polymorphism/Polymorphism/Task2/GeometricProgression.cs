using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GeometricProgression : ISeries
    {
		double _start;
		double _step;
		int _currentIndex;

		public GeometricProgression(double start, double step)
		{
			_start = start;
			_step = step;
			_currentIndex = 1;
		}

		public double GetCurrent()
		{
			//return _start + _step * _currentIndex;
			return _start * Math.Pow(_step, _currentIndex);
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
	}
}
