using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BankAccount
    {
        private int account_number;
        private int account_balance;

        public void setDeposite(int a)
        { if(a<=0)
            {
                Console.WriteLine( "you can add not negative value");
            }
            else
            {
                this.account_balance = a;
            }
        }
        public void getDeposite()
        {
            if (this.account_balance==0) 
            {
               
            }
            else
            {
                Console.WriteLine(this.account_balance); 
            }
        }

    }
}
