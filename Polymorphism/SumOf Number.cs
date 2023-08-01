using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class SumOf_Number
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Add(int a,int b, int c) 
        {
            Console.WriteLine(a+b+c);
        }

        
    }   
     
}
