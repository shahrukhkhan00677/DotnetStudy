using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorStudy
{
    internal class HomeLoanAccount:BankAccount
    {
        public HomeLoanAccount():base(10)
        {
            Console.WriteLine("HomeLoanAccount constructor called");
        }
        
        
    }
}
