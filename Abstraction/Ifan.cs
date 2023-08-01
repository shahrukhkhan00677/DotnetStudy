using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{    // 1. user interface uses keyword
     //2. interface  can have method without any defination
     //3. interface do not have abstract keyword
     //4. we can not create object of interface
     //5. we have to inherite interface in a class and give defination to method missing defination 
    internal interface Ifan
    {
        public void On();
        public void Off();

        public void Showlight()
        {
            Console.WriteLine("Light started");
        }

    }
}
