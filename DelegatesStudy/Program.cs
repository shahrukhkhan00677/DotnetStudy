// See https://aka.ms/new-console-template for more information
using DelegatesStudy;

Console.WriteLine("Hello, World!");

//StationaryShop objData = new StationaryShop();
//objData.PrintData("pen");
//objData.objMyDelegate("Pencils");

InBuildDelegate objData= new InBuildDelegate();

/*objData.myActionDelegate("Shahrukh",32995,"ravi") ;

Console.WriteLine(objData.myFuncDelegate(10, 20));*/

objData.IsWeekEnd(DayOfWeek.Sunday);

bool data=objData.myPredicateDelegate(DayOfWeek.Sunday);
Console.WriteLine(data);


//Console.WriteLine(ClassStudent.Sagar);