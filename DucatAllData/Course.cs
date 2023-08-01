using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucatAllData
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Trainer CourseTrainer { get; set; }
    }
}
