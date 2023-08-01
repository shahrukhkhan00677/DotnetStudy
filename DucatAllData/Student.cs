using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucatAllData
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Course CourseStudent { get; set; }
        
    }
}
