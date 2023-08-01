// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

//string are immutable that are not change  

StringBuilder sb = new StringBuilder();
sb.Append("my name is shahrukh");
sb.Append("i live in Noida");
sb.AppendLine("I study DotNet");
Console.WriteLine(sb);


string s1 = "My Name is Shahrukh";
s1 = s1+"I Live in Noida";
s1 =s1+ "I study DotNet";
Console.WriteLine(s1);

//H.W
//1.Ref And out
//2.readonly and constant