using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fruit
    {
        public void Fruits (string a ,string b) 
        {
            Console.WriteLine(a+" "+b);

        }

        public void Fruits (string a, string b, string c)
        {
            Console.WriteLine(a+" "+b+" "+c);

        }
    }
}
