using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            /*
             * average; = used to calculate and store avg. grades
             * grades = 0; = used to calculate the total sum and divided grades
             */
            double average, grades = 0;

            Console.WriteLine("Enter 5 grades separated by new line: ");
            double fiveGrades; // used to store the user input for each grade

            for (int i = 0; i < 5; i++)
            {
                string userInput; // used to store the user input as a string

                while (true)
                {
                    userInput = Console.ReadLine();
                    if (userInput.Contains(" "))
                    {
                        // validation msg if the user input does not contain "spaces"
                        Console.WriteLine("Input cannot contain spaces. Please try again.");
                        Console.WriteLine();
                        continue;
                    }
                    if (double.TryParse(userInput, out fiveGrades) && fiveGrades >= 0 && fiveGrades <= 100)
                    {
                        if (fiveGrades == 0)
                        {
                            // validation msg if the user input "0"
                            Console.WriteLine("Invalid input. Please enter a non-zero integer value.");
                            Console.WriteLine();
                            continue;
                        }
                        break;
                    }
                    else
                    {
                        // validation msg if the user input "negative" or that "exceeds" the value of integer
                        Console.WriteLine("Invalid input. Please enter an integer value. ");
                        Console.WriteLine();
                    }
                }
                grades += fiveGrades;
            }

            // print out the output
            average = grades / 5;
            Console.WriteLine($"The average is {average} and round off to {Math.Round(average)}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
