using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStudy
{
    internal class Counter
    {
        public event EventHandler TargetReached;
         int CurrentScore { get; set; }
         int TargetScore { get; set; }

        public Counter(int a)
        {
            CurrentScore = 0;
            TargetScore = a;
            
        }
        public void Add(int b)
        {
            //CurrentScore = CurrentScore + b;
             CurrentScore += b;
            Console.WriteLine(CurrentScore);

            if(CurrentScore>TargetScore)
            {
                Console.WriteLine("Win");
                OnTargetReached();
            }
            
        }

        protected virtual void OnTargetReached() 
        {
          EventHandler handler = TargetReached;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }


    }
}
