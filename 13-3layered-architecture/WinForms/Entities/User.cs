using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }

        public List<string> Awards = new List<string>();

        public string Awarding
        {
            get
            {
                string Str = "";
                foreach (var element in Awards)
                { Str += element + " "; }
                return Str;
            }
        }
    }

}
