// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("********************************** CollectionOfStudy ********************************** !");*/
#region CollectionList
/*List<string> listString = new List<string>();
List<int> listInt = new List<int>();    

listString.Add("Shahrukh");
listString.Add("Rohit");
listString.Add("Shubham");
listString.Add("Sagar");

listInt.Add(10);
listInt.Add(20);
listInt.Add(30);
listInt.Add(40);

foreach (string str in listString)
{
    Console.WriteLine(str);
}

foreach(int i in listInt)
{ 
    Console.WriteLine(i); 
}*/

#endregion

//H.W  what is Array

#region Array

/*Console.WriteLine("********************************** Array ********************************** !");

string[] name = { "shahrukh", "Ravi", "Sagar", "Shrikant", "Shubham" };

Console.WriteLine(name[0]);

Console.WriteLine(name[4]);

//for loop

for (int i = 0; i < name.Length; i++) {
Console.WriteLine(name[i]);
}

//foreach loop


foreach (string item in name)
{
    Console.WriteLine("forEachLoop "+item);
}

*//*//******************************************//*/

int[] num = {10,20,30,40,50,60,70 };

Console.WriteLine(num[3]);

//forLoop

for (int i = 0; i<num.Length; i++ )
{
    Console.WriteLine(num[i]);
}

//forEachLoop

foreach(int a in num)
{
    Console.WriteLine(a);
}*/

#endregion


#region sortArray

/* int[] num = { 10, 8, 12, 7, 15, 11, 20, 18 };

Console.WriteLine(num.Sum());
Array.Sort(num);
foreach (int num2 in num) 
{
    Console.WriteLine(num2);
}


//************************************************************//*/

/*
string[] alphabet = {"d","a","b","f","e","c" };
Array.Sort(alphabet);

foreach (string alpa in alphabet)
{
    Console.WriteLine(alpa);
}


Console.WriteLine("************************");
// 2-D array //

int[] num2d = { 1, 2, 3 , 4, 5, 6 , 7, 8, 9 };

Array.Sort(num2d);
foreach (int num3 in num2d)
{
    Console.WriteLine(num3);
}

Array.Reverse(num2d);
foreach(int num4 in num2d)
{
    Console.WriteLine(num4);
} */


#endregion


#region Dictionary

/*using CollectionStudy;

Student objStudent = new Student();
objStudent.id= 1;
objStudent.name = "ShahrukhKhan";
Student objStudent2 = new Student { id = 2, name = "RaviKumar" };
*/

/*List<Student> studentsList = new List<Student>();
studentsList.Add(objStudent);
studentsList.Add(objStudent2);
foreach (Student item in studentsList) 
{
    Console.WriteLine(item.name);
}*/


/*Student[] studentArray= new Student[2];
studentArray[0] = objStudent;
studentArray[1] = objStudent2;*/



//****************************************************************************************//
//Dictionary

/*Dictionary<int,string>studentDictionary = new Dictionary<int,string>();
//studentDictionary.Add(key=1,2,3  ,value="allName are value")//
studentDictionary.Add(1, "Shahrukh");
studentDictionary.Add(2, "Ravi");
studentDictionary.Add(3, "shrikant");
//value check
if (studentDictionary.ContainsKey(4)) ;

Console.WriteLine(studentDictionary[3]);*/


//***************************************************************************************//


/*Dictionary<int,Student>totalStudent=new Dictionary<int,Student>();
totalStudent.Add(1, objStudent);
totalStudent.Add(2, new Student{id=2 , name="KhanBhai"});*/

#endregion


#region Queue

//********************** Queue ************************//
// FIFO  First Come First Out

Queue<int> intergerQueue = new Queue<int>();
intergerQueue.Enqueue(1);
intergerQueue.Enqueue(2);
/*Console.WriteLine(intergerQueue.Dequeue());
Console.WriteLine(intergerQueue.Dequeue());*/


//*********************** Stack *************************//
//LIFO  Last Come First Out

Stack<int> integerStack = new Stack<int>();
integerStack.Push(1);
integerStack.Push(2);
/*Console.WriteLine(integerStack.Pop());
Console.WriteLine(integerStack.Pop());*/

#endregion