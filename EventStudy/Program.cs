// See https://aka.ms/new-console-template for more information
using EventStudy;

Console.WriteLine("Hello, World!");

Counter obj = new Counter(20);
obj.TargetReached += GameEnd;
obj.Add(6);
obj.Add(4);
obj.Add(6);
obj.Add(6);


static void GameEnd(object sender,EventArgs e )
{
    Console.WriteLine("Game has ended");
}