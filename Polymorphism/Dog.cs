using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Dog:Animal
    {
        public override void AnimalSound() 
        
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
