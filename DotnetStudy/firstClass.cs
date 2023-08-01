using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStudy
{
    internal class FirstClass
    {
        public int AddNumber(int a, int b)
        {
            //function body
            int c=a+b;
            return c;
        }

        public void PrintTable(int inputNumber)
        {
            for (int multiplier = 1; multiplier <= 10; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", inputNumber, multiplier, (inputNumber * multiplier));
            }
        }
    }
}
