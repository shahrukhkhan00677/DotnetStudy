using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingStudy
{
    internal class Student
    {
        public int Marks { get; set; }

        public void CalculateMarks()
        {
            int a = 0;
            int Marks = 100 / a;
        }
    }
}
