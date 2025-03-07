using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        public String Name;
        public Person(string name)
        {
            Name = name;
            Console.WriteLine("Hi, this is a defualt constructor");
        }
    }
}
