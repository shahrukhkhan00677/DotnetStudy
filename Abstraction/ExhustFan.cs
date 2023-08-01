using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class ExhustFan:Ifan
    {
        public void On()
        {
            Console.WriteLine("Fan is on");
        }

        public void Off()
        {
            Console.WriteLine("Fan is off");
        }

    }
}
