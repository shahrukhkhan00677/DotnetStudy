// See https://aka.ms/new-console-template for more information
using DucatAllData;

Console.WriteLine("*****************************  DucatDataAll  *************************");

//Trainer ***************************************************

List<Trainer> ListTrainers = new List<Trainer>();   

Trainer T1 = new Trainer();
T1.TrainerId = 1;
T1.TrainerName = "Shahrukh khan";
ListTrainers.Add(T1);

Trainer T2 = new Trainer();
T2.TrainerId = 2;
T2.TrainerName = "Khan Bhai";


ListTrainers.Add(T2);

foreach (Trainer objtrainer in ListTrainers)
{
    Console.WriteLine("Trainer Id = "+objtrainer.TrainerId);
    Console.WriteLine("Trainer Name = "+objtrainer.TrainerName);
}

//Course ********************************************************

List<Course> listCourse = new List<Course>();

Course objcourse = new Course();
objcourse.CourseId = 1;
objcourse.CourseName = "Ravi kumar";

//objCourse.CourseTrainer = T1;
objcourse.CourseTrainer = new Trainer();
objcourse.CourseTrainer.TrainerId = 101;
objcourse.CourseTrainer.TrainerName = "Mateen Khan";

//Console.WriteLine(objcourse.CourseTrainer.TrainerName = "Mateen Khan"); 
listCourse.Add(objcourse);

foreach ( Course obj in listCourse)
{
    Console.WriteLine("");
    Console.WriteLine("************** Course Data ***************");
    Console.WriteLine("");
    Console.WriteLine("Course ID = "+ obj.CourseId);
    Console.WriteLine("Course Name = "+ obj.CourseName);
    Console.WriteLine("Course Trainer ID = "+obj.CourseTrainer.TrainerId);
    Console.WriteLine("Course Trainer Name = "+obj.CourseTrainer.TrainerName);
}


// Student ***************************************************************

List<Student> ListStudents = new List<Student>();

Student objStudent = new Student();
objStudent.Id = 102;
objStudent.Name = "Sagar Kumar";

objStudent.CourseStudent = new Course();
objStudent.CourseStudent.CourseId = 12;
objStudent.CourseStudent.CourseName = "Java Script";

ListStudents.Add(objStudent);

foreach (Student objst in ListStudents)
{

    Console.WriteLine("");
    Console.WriteLine("************** Student Data ***************");
    Console.WriteLine("");
    Console.WriteLine("Student ID = "+objst.Id);
    Console.WriteLine("Student Name = "+objst.Name);
    Console.WriteLine("Student Course Id = "+objst.CourseStudent.CourseId);
    Console.WriteLine("Stdent Course Name = "+objst.CourseStudent.CourseName);
}



