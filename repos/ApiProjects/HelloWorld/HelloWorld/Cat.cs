using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Cat:AnimalOne
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat Meows"); 
        }
    }
}
