// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please type your name:");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself");
Console.WriteLine($@"What would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");

var gameSelected = Console.ReadLine();

if(gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("addition game selected");

} else if(gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("subtraction game selected");

}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("multiplication game selected");

}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("division game selected");

}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("invalid input");
}


