// See https://aka.ms/new-console-template for more information
using Tpl_Study;
// Diff B/W Task and Thread =>  
// 
Console.WriteLine("Hello, World!");

TaskStudy objTaskStudy = new TaskStudy();

objTaskStudy.ObjTask.Start();

objTaskStudy.TaskA.Start();
objTaskStudy.TaskA.Wait();
objTaskStudy.ObjTask.Wait();
