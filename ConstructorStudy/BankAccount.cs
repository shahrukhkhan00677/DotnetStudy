using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorStudy
{
    // 1. constructor is special function with same name that of class
    // 2. constructor has no return type
    // 3. constructor can has argumrent 
    // 4. whenever we create object constructor is automaticaly called
   
    internal class BankAccount
    {
       /* public BankAccount() 
        {
            Console.WriteLine("BankAccount Constuctor Called");
        }*/

        public BankAccount(int balance)
        {
            Console.WriteLine("BankAccount Constuctor Called with balance=" + balance);
        }

        
    }
}
