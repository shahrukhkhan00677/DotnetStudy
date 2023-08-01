using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Person
    {
       public void Speak()
        {
            Console.WriteLine( "person speak any thing");
        }
        public void Speak(int num)
        {
            Console.WriteLine($"person tells about number={num}");
        }
    }
}
