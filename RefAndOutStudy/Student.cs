using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutStudy
{
    internal class Student
    {
       


        public void CalculateMarks1(int Marks1)
        {
            Marks1 = 10;
        }
        //ref
         public void CalculateMarks(ref int Marks)
         {
             Marks = 10;
         }
        //out
        public void CalculateMarksout(out int Marksout)
        {
            Marksout = 10;
        }

        // variable type
        const int Id = 32995;
        readonly string name;

        public Student()
        {
            name ="Shahrukh" ;
        }



        /*private const string CollegeName = "Ducat";
       private readonly string SchoolName = "Ducat";
       public Student()
       {
           //CollegeName = "Ducat1";
           SchoolName = "ABCSCHOOL";
       }
       public void CalculateMarks(ref int Marks)
       {
           Marks = 10;
       }
       public void CalculateMarksOut(out int Marks)
       {
           Marks = 20;
       }*/
    }
}
