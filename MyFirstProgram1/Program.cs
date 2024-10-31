// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please type your name:");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");
Console.WriteLine($@"What would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("----------------------------------------");

