﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class MyString
    {
        private char[] _str;

        public MyString()
        {
            _str = new char[0];
        }

        public MyString(string s)
        {
            _str = s.ToCharArray();
        }

        public MyString(char[] s)
        {
            //s.Clone();
            //s.CopyTo(_str, 0); // переделать, чтобы не было ссылки
            _str = (char[])s.Clone();
        }

        public char[] Str
        {
            get { return _str; }
            //set { _str = value; }
        }

        public static MyString operator +(MyString object1, MyString object2)
        {
            string sum = String.Concat(object1._str) + String.Concat(object2._str);
            MyString Object3 = new MyString(sum);
            return Object3;
        }


        public static MyString operator -(MyString object1, MyString object2)
        {
            string str1 = object1.ToString();
            string str2 = object2.ToString();
            int index = str1.IndexOf(str2);
            string subtract = (index < 0) ? str1 : str1.Remove(index, str2.Length);
            MyString Object3 = new MyString(subtract);
            return Object3;
        }

        public static bool operator ==(MyString object1, MyString object2)
        {
            return object1.ToString() == object2.ToString(); 
            //return Object1._str.Equals(Object2._str);
        }

        public static bool operator !=(MyString object1, MyString object2)
        {
            return !(object1 == object2);
        }

        public override string ToString()
        {
            string str = String.Concat(_str);
            return str;
        }
    }
}
