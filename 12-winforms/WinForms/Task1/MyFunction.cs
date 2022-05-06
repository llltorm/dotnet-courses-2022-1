using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MyFunction
    {

        public static int CalculateAge(DateTime date)
        {
            var age = DateTime.Now.Year - date.Year;
            return age;
        }
    }
}
