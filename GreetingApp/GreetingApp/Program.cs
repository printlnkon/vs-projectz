using System;

public class GreetingApp
{
    public static void Main(string[] args)
    {
        string name;
        while (true)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name) && IsAllLetters(name))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid name.");
            }
        }

        int courses;
        while (true)
        {
            Console.Write("Enter the total number of your enrolled courses: ");
            string coursesInput = Console.ReadLine();
            if (int.TryParse(coursesInput, out courses) && courses >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid course value.");
                

            }
        }

        double book;
        while (true)
        {
            Console.Write("Enter the price of your favorite book: ");
            string bookInput = Console.ReadLine();
            if (double.TryParse(bookInput, out book) && book >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid price.");
            }
        }

        Console.WriteLine();

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total number of enrolled courses: " + courses);
        Console.WriteLine("Price of your favorite book: " + book);
        Console.WriteLine("Press any key to Exit...");
        Console.ReadKey();
    }

    // Function to check if a string contains only letters
    static bool IsAllLetters(string s)
    {
        foreach (char c in s)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }
}