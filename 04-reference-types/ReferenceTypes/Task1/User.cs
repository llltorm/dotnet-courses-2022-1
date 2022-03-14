using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private DateTime _birthTime;
        private string _name;
        private string _surename;
        private string _otchestvo;

        public User(DateTime birthTime, string name, string sureName, string otchestvo)
        {
            DateTime check = new DateTime(1900, 01, 01);
            if (birthTime.Date > DateTime.Now.Date || birthTime < check.Date)
            {
                throw new ArgumentOutOfRangeException($" Not correct time");
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(sureName) || string.IsNullOrEmpty(otchestvo))
            {
                throw new ArgumentOutOfRangeException($" must be not empty");
            }
            _birthTime = birthTime;
            _name = name;
            _surename = sureName;
            _otchestvo = otchestvo;
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
            get { return _surename; }
            set { _surename = value; }
        }

        public string Otchestvo
        {
            get { return _otchestvo; }
            set { _otchestvo = value; }
        }

        private static int AgeCalculating(DateTime date)
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
            ////Исправить дату для разных дней
            get { return AgeCalculating(_birthTime); }
            //set  { _birthTime = AgeCalculating(value); }
        }

    }
}
