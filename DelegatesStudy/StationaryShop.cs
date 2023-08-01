using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesStudy
{
    //Delegates are pointer function 
    public delegate void myDelegate(string data);
    internal class StationaryShop
    {
        public myDelegate objMyDelegate;
        
        private void PrintData(string data)
        {
            Console.WriteLine(data);

        }
        private void PrintInformation(string data)
        {
            Console.WriteLine("Information :" +data);

        }
        private void PrintInteger(int data)
        {
            Console.WriteLine("Information :" + data);

        }
        public StationaryShop()   //that is constructor 
        {
            /*objMyDelegate = PrintData;*/
            // objMyDelegate = PrintInformation;
            // objMyDelegate = PrintInteger;      //mismatch data type

            //multitask delegate
            objMyDelegate = PrintData;
            objMyDelegate = objMyDelegate + PrintInformation;
        }
    }
}
