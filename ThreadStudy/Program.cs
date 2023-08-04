// See https://aka.ms/new-console-template for more information
using ThreadStudy;

Console.WriteLine("Thread Study");

Student objStudent=new Student();
//objStudent.Work1();
//objStudent.Work2();

ThreadStart s1 = new ThreadStart(objStudent.Work1);

Thread thread1 = new Thread(s1);
thread1.Name = "my thread";

ThreadStart s2 = new ThreadStart(objStudent.Work2);

Thread thread2 = new Thread(s2);
thread2.Name = "my thread2";

thread2.Start();
thread1.Start();