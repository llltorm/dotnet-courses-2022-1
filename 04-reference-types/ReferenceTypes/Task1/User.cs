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
        private readonly DateTime check = new DateTime(1900, 01, 01);

        public User(DateTime birthTime, string name, string lastName, string patronymic)
        {
            СheckBirthTime(birthTime);
            СheckName(name);
            СheckLastName(lastName);
            СheckPatronymic(patronymic);
            _birthTime = birthTime;
            _name = name;
            _lastName = lastName;
            _patronymic = patronymic;
        }

        protected void СheckBirthTime(DateTime birthTime)
        {
            if (birthTime.Date > DateTime.Now.Date || birthTime < check.Date)
            {
                throw new ArgumentOutOfRangeException($" Not correct time");
            }
        }

        protected void СheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentOutOfRangeException($" must be not empty");
            }
        }

        protected void СheckLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentOutOfRangeException($" must be not empty");
            }
        }

        protected void СheckPatronymic(string patronymic)
        {
            if (string.IsNullOrEmpty(patronymic))
            {
                throw new ArgumentOutOfRangeException($" must be not empty");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                СheckName(value);
                _name = value;
            }
        }

        /*        public void SetName(string value)
                {
                    _name = value;
                }*/

        public string LastName
        {
            get { return _lastName; }
            set
            {
                СheckLastName(value);
                _lastName = value;
            }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                СheckPatronymic(value);
                _patronymic = value;
            }
        }

        protected static int YearCalculating(DateTime date)
        {
            int age;
            DateTime now = DateTime.Now;
            age = DateTime.Now.Year - date.Year;
            if (now.Month < date.Month || (now.Month == date.Month && now.Day < date.Day))
                age--;
            return age;
        }
        public int Age
        {
            ////Исправление даты для разных дней
            get { return YearCalculating(_birthTime); }
        }
    }

}
