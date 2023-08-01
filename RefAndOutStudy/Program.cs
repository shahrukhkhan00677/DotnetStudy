// See https://aka.ms/new-console-template for more information

//Ref and out both are keyword

using RefAndOutStudy;



int Marks1 = 60;
Student objStu = new Student();
objStu.CalculateMarks1(Marks1);
Console.WriteLine("Normal = "+ Marks1);

int Marks = 60;
//int Marks;
Student objStudent = new Student();
objStudent.CalculateMarks(ref Marks);
Console.WriteLine("Ref = "+Marks);

int Marksout;
// int Marksout=50;
Student objStudent1 = new Student();
objStudent1.CalculateMarksout(out Marksout);
Console.WriteLine("Out = "+Marksout);



/*int Marks = 60;
int marksout;
Student objstudent = new Student();
objstudent.CalculateMarks(ref Marks);
Console.WriteLine(Marks);
//Out
objstudent.CalculateMarksOut(out marksout);
Console.WriteLine("out- " + marksout);*/