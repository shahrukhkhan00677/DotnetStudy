using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Fan:AbstractFan
    //1. current flow swith to fan coil
    //2. Currnt in coil and Megnet genereted
    //3. fan is rotate
    {
        public override void On()
        {
         
            Console.WriteLine("Fan start");
        }

        public override void Off() 
        
        {
            Console.WriteLine("Fan Off");
        }
    }
}
