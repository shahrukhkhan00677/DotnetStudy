using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        private int _sid;
        private string _Sname;
        private int _sage;
        private string _fname;

        public int sid {
            set {
                if (value <= 0)
                { Console.WriteLine("plz enter valid student ID"); }
                else { this._sid = value; }
               
            }
            get {
                return this._sid;
            }

        }

    }
}
