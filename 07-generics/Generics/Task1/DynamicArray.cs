using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class DynamicArray<T>
    {
        private T[] _series;
        private int _length;
        private int _capacity; // убрать поле по возможности

        public DynamicArray(int count) 
        {
            _series = new T[count];
            _length = _series.Length;
            _capacity = _length;
            //Array.Resize(ref _series, _capacity);
        }

        public DynamicArray(T[] series)
        {
            _series = series;
            _length = _series.Length;
            _capacity = _series.Length ;
            //Array.Resize(ref _series, _capacity);
        }

        public DynamicArray()
        {
            _series = new T[8];
            _length = 0;
            _capacity = _series.Length;
            //Array.Resize(ref _series, _capacity);
        }

        public T this[int index]
        {
            get
            {
                if ((index < 0) || (index >= _length))
                    throw new IndexOutOfRangeException("Индекс находится за пределами границ массива");

                return _series[index];
            }
            set
            {
                if ((index < 0) || (index >= _length))
                    throw new IndexOutOfRangeException("Индекс находится за пределами границ массива");

                _series[index] = value;
            }
        }

/*        public bool Remove1(int index)
        {
            //index--;
            if (_length != 0)
            {
                if ((index < 0) || (index >= _length))
                {
                    throw new ArgumentException($"Значение {nameof(index)} находится за пределами границ массива");
                }

                for (int i = index; i < _length - 1; i++)
                {
                    _series[i] = _series[i + 1];
                }
                _length--;
*//*                if ((_length != 0) && (_length == _capacity - 1))
                {
                    _capacity -= 1;
                    Array.Resize(ref _series, _capacity);
                }*//*
                return true;
            }
            else { return false; }
        }*/

        public bool Remove(T elementValue)
        {
                for (int i = 0; i < _length; i++)
                {
                    if (_series[i].Equals(elementValue))
                    {
                        for (int j = i; j < _length; j++)
                        {
                            _series[j] = _series[j + 1];
                        }
                        _length--;
                        return true;
                    }
                }
                return false; 
        }

        

        public void Add(T elementValue)
        {
            CheckCapacityAndResize();
            _series[_length ] = elementValue;
            _length++;
        }

        public void AddRange(T[] massivValue)
        {
            if ((_length + massivValue.Length) >= _capacity)
            {
                _capacity += (_length + massivValue.Length);
                Array.Resize(ref _series, _capacity);
            }
            int counter = 0;
            for (int i = _length; i < (_length + massivValue.Length); i++)
            {
                _series[i] = massivValue[counter];
                counter++;
            }
            _length += massivValue.Length;
        }

        public void Insert(T elementValue, int index)
        {
            if ((index < 0) || (index > _length))
                throw new ArgumentException($"Значение {nameof(index)} находится за пределами границ массива");
            CheckCapacityAndResize();
            for (int i = _length; i > index; i--)
            {
                _series[i] = _series[i - 1];
            }
            _series[index] = elementValue;
            _length++;
        }

        public void CheckCapacityAndResize()
        {
            if ((_length != 0) && (_length >= _capacity))
            {
                _capacity *= 2;
                Array.Resize(ref _series, _capacity);
            }
        }

        public int Length
        {
            get { return _length; }
        }

        public int Capacity
        {
            get { return _capacity; }
        }

        public void PrintSeries()
        {
            Console.WriteLine(_capacity);
            Console.WriteLine(_length);
            for (int i = 0; i < _length; i++)
            {
                Console.WriteLine(_series[i]);
            }
        }

    }
}
