// See https://aka.ms/new-console-template for more information
using SwitchStatement;

Console.WriteLine("Hello, World!");


/*Employee Objemployee= new Employee();
Console.WriteLine("Enter the Day Name");
string day=Console.ReadLine();
Objemployee.DoDailyWork(day);*/

Employee Objemployee = new Employee();
Console.WriteLine("Enter the Day Name");
string day = Console.ReadLine();
Objemployee.DoDailyWorkSwitch(day.ToUpper());