using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Static Variable 
// Static Function
// Static Class
// Static Constractor

namespace StaticStudy
{
    internal static class Student   // Static class can have only static property and mamber
    {
        public static int Id { get; set; }   // we can not create any object of without static class
        public static string Name { get; set; }
        public static string CollegeName { get; set; }

        /*public void Print()
        {
            Console.WriteLine("Called the print function");
        }*/

        //with Static
        public static void Print()
        {
            Console.WriteLine("Called the print function");
        }
    }
}
