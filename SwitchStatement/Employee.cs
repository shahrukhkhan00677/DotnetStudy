using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Employee
    {
        #region if else 
        /*public void DoDailyWork(string day)
        {
            *//*string day = "Monday";*//*
            if (day == "Monday") 
            {
                Console.WriteLine("Go to Office");
            }
            else if(day == "Tuesday") 
            {
                Console.WriteLine( "Go to Seals site 1");
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine("Go to Seals site 2");
            }
            else if (day == "Thusday")
            {
                Console.WriteLine("Go to Seals site 3");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("Go to Seals site 4");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("Go to Seals site 5");
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("stay at Home");
            }

        }*/
        #endregion

        public void DoDailyWorkSwitch(string day)
        {
            switch (day)
            {
                case "MONDAY":
                    Console.WriteLine("Go to Site 1");
                    break;
                case "Tuesday":
                    Console.WriteLine("Go to Site 2");
                    break;
                case "Wednesday":
                    Console.WriteLine("Go to Site 3");
                    break;
                case "Thursday":
                    Console.WriteLine("Go to Site 4");
                    break;
                case "Friday":
                    Console.WriteLine("Go to Site 5");
                    break;
                case "Saturday":
                    Console.WriteLine("Go to Site 6");
                    break;
                case "Sunday":
                    Console.WriteLine("Stay at Home");
                    break;
                default: Console.WriteLine("No maching day found");
                    break;


            }
        }
    }
}
