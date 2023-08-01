using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{   
    //1.Abstract class can have Abstract method
    //2.Abstract method are metod with only declication on defination
    //3.we can not create obj of abstract class
    //4. we can only child of abstract class and than give defination in child class
    internal abstract class AbstractFan
    {
        public abstract void On();
        public abstract void Off();

        public void Showlight()
        {
            Console.WriteLine("Light started");
        }
    }
}
