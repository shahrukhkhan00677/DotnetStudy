using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        /* public string Name;
         public int Age; */

        private string Name;
        private int Age;

        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name)==true) 
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.Name = Name;
            }
            
          }
        public void getName()
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
               
            }
            else
            {
                Console.WriteLine("Your Name : " + this.Name);
            }
           
        }

        public void setAge(int Age)
        { if(Age >0)
            {
                this.Age = Age;
            }
            else {
                Console.WriteLine("Age should not be negative or Zero");
                    }
            
             }
        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your Age : " + this.Age);
            }
            else
            {
               
            }
            
        }
    }
}
