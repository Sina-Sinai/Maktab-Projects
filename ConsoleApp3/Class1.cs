using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    
     public class People
    {
        private static string? name;
        public static int? age;

        public int x = 0;
        public People()
        {
            name = "ali";
            age = 19;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void intruduce()
        {
            Console.WriteLine($"Hi, My name is {name} and I'm {age} yers old");
        }

        //public People(string Name, int Age) {
        //    name = Name;
        //    age = Age;
        //}
    }
}
