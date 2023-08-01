// See https://aka.ms/new-console-template for more information
using ValueTypeReferenceTypeStudy;
#region ObjectClasStudy
/*
Student StudentObj  = new Student();

object myObject = new object();

int i = 10;
myObject = i; // boxing : value type to reference type 
Console.WriteLine( myObject);

int j = (int)myObject;  // unboxing refarence type to value type 

Console.WriteLine( j);

//object class parent of all classes , it like library 

// boxing and unboxing

*//*myObject.ToString
 myObject.Equals(i);*/

#endregion

#region ObjectClassFunctionStudy

Student studentObj = new Student();

object myObject = new object();

studentObj.id = 10;
studentObj.name = "Sagar";
Console.WriteLine(studentObj.ToString());


Student studentObj2 = new Student();
studentObj2.id = 20;
studentObj2.name = "Ravi";
studentObj2 = studentObj;
Console.WriteLine(studentObj2.Equals(studentObj));

string id = studentObj.id.ToString();

#endregion