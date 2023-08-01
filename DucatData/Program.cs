// See https://aka.ms/new-console-template for more information
using DucatData;

Console.WriteLine("******************************************** Ducat Data *******************************************");

List<Course> courses = new List<Course>();

Course objCourse1 = new Course()
{
    CourseName = "C#",
    Teacher="MohdMateenSir",
    Students=new string[] {"Ravi","Sagar","Rohit","Shrikant"}

};
Course objCourse2 = new Course()
{
    CourseName = "JAVA",
    Teacher = "GouravSir",
    Students = new string[] { "Mohan", "Vashu", "Salman", "Ram" }
};
Course objCourse3 = new Course()
{
    CourseName = "Paython",
    Teacher = "MohitSir",
    Students = new string[] { "Rohan", "Deepak", "Karan", "Shahrukh" }
};

courses.Add(objCourse1);
courses.Add(objCourse2);
courses.Add(objCourse3);

foreach (Course objCourse in courses)
{
    Console.WriteLine("CourseName :- "+ objCourse.CourseName);
    
    Console.WriteLine("Teacher = "+ objCourse.Teacher);
    Console.WriteLine("Student:- ");
    foreach(string studentName in objCourse.Students)
    {
        Console.WriteLine(studentName);
    }
    Console.WriteLine("");
}