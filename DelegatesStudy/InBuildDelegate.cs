using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesStudy
{
    //1.Action      > input somthing output void
    //2.Func        > that is a return type of func
    //3.Pradicate   > is use to return type bool value
    internal class InBuildDelegate
    {
       public Action<string,int,string> myActionDelegate;   //1.InBuild Delegate pass argument (1-16) that is no return type

       public Func<int, int, string> myFuncDelegate;        //2.return type

        public Predicate<DayOfWeek> myPredicateDelegate;    //3.is use to return type bool value

        public InBuildDelegate()   
        {
            myActionDelegate = PrintData;
            myFuncDelegate = AddData;
            myPredicateDelegate = IsWeekEnd;
        }
        private void PrintData(string data,int num , string name)  
        {
            Console.WriteLine(data);
            
            Console.WriteLine(num);
        }

        public string AddData(int a, int b)
        {
            return (a + b).ToString();

        }

        public bool IsWeekEnd(DayOfWeek day)
        {
            if(day == DayOfWeek.Sunday || day== DayOfWeek.Saturday)

            { 
                return true;
            }

            else 
            { 
                return false; 
            }
        }
    }
}
