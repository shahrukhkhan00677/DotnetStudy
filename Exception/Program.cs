// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*int i = 0;
int j = 1 / i;*/


try
{
    int i = 0;
    int j = 1 / i;

    // if any "exception" are avilable in the try than you are "not print" the any msg by console than you use to "finally"
    Console.WriteLine("my important topic");

}
catch(Exception ex)
{

    Console.WriteLine("Exception occured");

    Console.WriteLine(ex.Message);

    // stackTrace by find error particular line  
    Console.WriteLine(ex.StackTrace);
}

finally
{
    // finally are use to print any msg with any "Exception"
    Console.WriteLine("Hello exception world");
}