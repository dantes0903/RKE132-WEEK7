Console.WriteLine("Are you coming or leaving? (in/out):");
string userChioce = Console.ReadLine();

if (userChioce == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}





static void PrintHello()  //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, aligator");
}