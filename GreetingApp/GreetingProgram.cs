using System;

namespace GreetingApp;

internal class GreetingProgram
{
	private static void Main(string[] args)
	{
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		Console.Write("Enter the total number of your enrolled crouses: ");
        double courses = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Name: " + name);
		Console.WriteLine("Total enrolled courses: " + courses);
		Console.Write("Price of my favorite book: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.ReadKey();
	}
}
