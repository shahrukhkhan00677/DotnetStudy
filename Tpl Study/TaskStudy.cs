using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpl_Study
{
    internal class TaskStudy
    {
        Task objTask;


        public  void DoWork ()
        {
            Console.WriteLine("DoWork Called");
        }
        public  TaskStudy ()
        { 
            objTask = new Task ();

        }
    }
}
