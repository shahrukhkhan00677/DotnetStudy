using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tpl_Study
{
    internal class TaskStudy
    {
       public Task ObjTask;
        public Action myAction;
        public Task TaskA;
      
        public  void DoWork ()
        {
            int i = 1;
            Console.WriteLine("Do Work Called");
            i = i + 5;
            //Thread.Sleep(1000);
            Console.WriteLine(i);
        }
        public  TaskStudy ()
        {
            myAction = DoWork;
            ObjTask = new Task(myAction);
            /*TaskA = new Task(
                () => Console.WriteLine("Hello from TaskA")
                ); */

            TaskA = new Task(myAction);


        }
    }
}
