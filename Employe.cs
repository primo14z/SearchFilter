using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomFilter
{
    public class Employe : IPerson
    {
        public string Position { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
    }
}