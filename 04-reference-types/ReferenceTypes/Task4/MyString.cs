using System;
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

        public MyString(string S)
        {
            _str = S.ToCharArray();
        }

        public MyString(char[] S)
        {
            _str = S;
        }

        public char[] str
        {
            get { return _str; }
            set { _str = value; }
        }

        public static MyString operator +(MyString Object1, MyString Object2)
        {
            string sum = Object1.ToString() + Object2.ToString();
            MyString Object3 = new MyString(sum);
            return Object3;
        }


        public static MyString operator -(MyString Object1, MyString Object2)
        {
            string str1 = Object1.ToString();
            string str2 = Object2.ToString();
            return new MyString { _str = str1.Replace(str2, "").ToCharArray() };
        }

        public static bool operator ==(MyString Object1, MyString Object2)
        {
            if (Object1._str == Object2._str) { return true; }
            return false;
        }

        public static bool operator !=(MyString Object1, MyString Object2)
        {
            if (Object1._str != Object2._str) { return true; }
            return false;
        }

        public string ToString()
        {
            //a = "";
            string str = _str.ToString();
            return str;
        }
    }
}
