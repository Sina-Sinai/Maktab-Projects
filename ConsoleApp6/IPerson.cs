using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp6.Person;

namespace ConsoleApp6
{
    internal interface IPerson
    {
        public Role Rolee { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        public Gender sexuality { get; set; }
        public string Password { get; set; }

    }
}
