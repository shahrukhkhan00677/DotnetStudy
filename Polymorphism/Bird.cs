using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Bird
    {
        public virtual void FlyingBird()
        {
            Console.WriteLine("Bird fly in the sky");
        }
    }

   /* internal class Bird
    {
        public void FlyingBird()
        {
            Console.WriteLine("Bird fly in the sky");
        }
    }*/
}

