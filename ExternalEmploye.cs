using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomFilter
{
    public class ExternalEmploye : IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}