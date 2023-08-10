using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadStudy
{
    internal class Student
    {
        public void Work1()
        {

            for (int i = 1; i < 20; i++)
            {


                //if (i == 10)
               // {
                 //   Console.WriteLine("thread stop for 10 sec");
                    Thread.Sleep(1000);  // time in millisecond


                //}
                Console.WriteLine("Work1 :" + i);

            }
            //Console.WriteLine("Work1 called");
        }

        public void Work2()
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Work2 :" + i);
                Thread.Sleep(1000);
            }
            //Console.WriteLine("Work2 called");
             // time in millisecond

        }
    }
}
