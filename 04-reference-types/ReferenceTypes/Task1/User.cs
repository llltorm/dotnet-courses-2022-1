using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private DateTime _birthTime;
        private string _name;
        private string _lastName;
        private string _patronymic;

        public User(DateTime birthTime, string name, string lastName, string patronymic)
        {
            DateTime check = new DateTime(1900, 01, 01);
            if (birthTime.Date > DateTime.Now.Date || birthTime < check.Date)
            {
                throw new ArgumentOutOfRangeException($" Not correct time");
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(patronymic))
            {
                throw new ArgumentOutOfRangeException($" must be not empty");
            }
            _birthTime = birthTime;
            _name = name;
            _lastName = lastName;
            _patronymic = patronymic;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

/*        public void SetName(string value)
        {
            _name = value;
        }*/

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private int AgeCalculating()
        {
            int age;
            DateTime now = DateTime.Now;
            age = DateTime.Now.Year - _birthTime.Year;
            if (now.Month < _birthTime.Month || (now.Month == _birthTime.Month && now.Day < _birthTime.Day))
                age--;
            return age;
        }
        public int Age
        {
            ////Исправить дату для разных дней
            get { return AgeCalculating(); }
            //set  { _birthTime = value; }
        }

    }
}
