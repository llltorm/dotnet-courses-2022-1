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

        public MyString(string s)
        {
            _str = s.ToCharArray();
        }

        public MyString(char[] s)
        {
            _str = s;
        }

        public char[] Str
        {
            get { return _str; }
            //set { _str = value; }
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
            return Object1._str == Object2._str; //сравнивать значения а не ссылки
        }

        public static bool operator !=(MyString Object1, MyString Object2)
        {
            return !(Object1 == Object2);
        }

        public override string ToString()
        {
            //a = "";
            string str = _str.ToString();
            return str;
        }
    }
}
