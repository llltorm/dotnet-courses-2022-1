using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class List : IIndexableSeries
	{
		private double[] _series;
		private int _currentIndex;

		public List(double[] series)
		{
			_series = series;
			_currentIndex = 0;
		}

		public double GetCurrent()
		{
			return _series[_currentIndex];
		}

		public bool MoveNext()
		{
			_currentIndex = _currentIndex < _series.Length - 1 ? _currentIndex + 1 : 0;
			return true;
		}

		public void Reset()
		{
			_currentIndex = 0;
		}

        public double this[int index]
        {
            get { return _series[index]; }
        }
    }
}
