﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _series;
        private int _length;
        //private int _capacity;

        public DynamicArray()
        {
            _series = new T[8];
            _length = 0;
            //_capacity = _series.Length;
        }

        public DynamicArray(int count) 
        {
            _series = new T[count];
            _length = _series.Length;
            //_capacity = _length;
        }

        public DynamicArray(T[] series)
        {
            _series = series;
            _length = _series.Length;
            //_capacity = _series.Length ;
        }


        public DynamicArray(IEnumerable<T> series): this (series.ToArray())
        {
            
/*            _series = (T[])series;
            _length = _series.Length;*/
            //_capacity = _series.Length;
        }


        public IEnumerator<T> GetEnumerator()
        {
            int counter = 0; 
            foreach (T v in _series)
            {
                if (counter < _length)
                {
                    counter++;
                    yield return v;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
            //if ((_length + massivValue.Length) >= _capacity)
            //{
            //    _capacity += (_length + massivValue.Length);
                Array.Resize(ref _series, _length + massivValue.Length);
            //}
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
            if ((_length != 0) && (_length >= _series.Length))
            {
                //_capacity *= 2;
                Array.Resize(ref _series, _series.Length * 2);
            }
        }

        public int Length
        {
            get { return _length; }
        }

        public int Capacity
        {
            get { return _series.Length; }
        }

        public void PrintSeries(DynamicArray<T> elems)
        {
            foreach (T elem in elems)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
