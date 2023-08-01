using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Eagle:Bird
    {
        public override void FlyingBird()
        {
            Console.WriteLine("Eagle fly in the sky");
        }
    }

   /* internal class Eagle : Bird
    {
        public void FlyingBird()
        {
            Console.WriteLine("Eagle fly in the sky");
        }
    }*/
}
