using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsnantAndReadonly
{
    internal class Student
    {
        const int ID = 32995;
        readonly string name;   //only change in public access modifier
       static readonly int age;  // only change in static

        public Student ()
        {
            
            name = "Shahrukh";
        }
        static Student()
        {
            age = 25;
        }

        public void Result()
        {
            Console.WriteLine("Const ID = "+ ID);
            Console.WriteLine("Readonly name = "+ name );
            Console.WriteLine("Static readonly Age = "+ age);
        }
    }
    
       
}
