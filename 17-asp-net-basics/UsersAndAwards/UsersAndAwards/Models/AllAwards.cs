using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Entities
{
    public class AllAwards
    {
        public IEnumerable<Award> awards { get; set; }

        public int id { get; set; }
    }
}