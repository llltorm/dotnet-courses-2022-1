using System;
using System.Collections.Generic;
using System.Text;

namespace PLWinForm
{
    class MyFunction
    {
        public static int CalculateAge(DateTime date)
        {
            var age = DateTime.Now.Year - date.Year;
            return age;
        }
    }
}
