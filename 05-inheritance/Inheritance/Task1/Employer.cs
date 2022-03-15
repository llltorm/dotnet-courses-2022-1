using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Employer : User
    {
        protected DateTime _dateGetJob;
        protected string _position;
        protected string _company;
        protected double _salary;

        public Employer(DateTime birthTime, string name, string sureName, string otchestvo, DateTime dateGetJob, string position, double salary, string company)
            : base(birthTime, name, sureName, otchestvo)
        {
            DateTime beginOfCompany = new DateTime(1995, 12, 12);
            if ((dateGetJob.Date < beginOfCompany.Date) || (dateGetJob > DateTime.Now))
            {
                throw new AccessViolationException("Дата начала работы некорректна");
            }
            if (salary < 13890)
            {
                throw new AccessViolationException("Зарплата не может быть меньше МРОТ");
            }
            if (String.IsNullOrEmpty(position) || String.IsNullOrEmpty(company))
            {
                throw new ArgumentOutOfRangeException("Значение не может быть пустым");
            }
            _dateGetJob = dateGetJob;
            _position = position;
            _salary = salary;
            _company = company;
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int Expirience
        {
            get { return YearCalculating(_dateGetJob); }
            //set { _getJob = value; }
        }

    }
}
