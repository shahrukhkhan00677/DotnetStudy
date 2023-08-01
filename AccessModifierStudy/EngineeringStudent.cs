using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierStudy
{
    internal class EngineeringStudent:Student
    {
       public void showEngineeringStudent()
        {
            Console.WriteLine("Name of EngineeringStudent"+name);
        }
    }
}
