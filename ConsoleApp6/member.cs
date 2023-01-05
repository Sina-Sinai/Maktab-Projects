using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class member : IPerson
    {
        public Person.Role Rolee { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public Person.Gender sexuality { get; set; }
        public string Password { get; set; }

    }
}
