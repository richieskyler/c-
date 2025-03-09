using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PersonInterface : IPerson
    {
        public void die()
        {
            Console.WriteLine("I am dead");
        }

        public void eat()
        {
            Console.WriteLine("I am eating");
        }

        public void talk()
        {
            Console.WriteLine("I am talking");
        }

        public void walk()
        {
            Console.WriteLine("I am walking");
        }
    }
}
