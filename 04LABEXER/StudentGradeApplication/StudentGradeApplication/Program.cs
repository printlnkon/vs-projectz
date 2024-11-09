using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("=====Student Grade Application=====");
            Console.WriteLine("=============================================");

            string name;
            do
            {
                Console.WriteLine();
                Console.WriteLine("=============================================");
                Console.Write("Name: ");
                name = Console.ReadLine().Trim();
                if (!IsValidName(name))
                {
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Invalid input. Please enter valid name.");
                    Console.WriteLine("=============================================");
                }
            } while (!IsValidName(name));

            double eng, math, sci, fil, his;
            bool isValidInput;

            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("=====Grades======");
            Console.WriteLine("=============================================");

            do
            {
                eng = GetValidGrade("English");
                math = GetValidGrade("Math");
                sci = GetValidGrade("Science");
                fil = GetValidGrade("Filipino");
                his = GetValidGrade("History");

                // validate if all grades are within the range
                isValidInput = eng >= 50 && eng <= 100 &&
                               math >= 50 && math <= 100 &&
                               sci >= 50 && sci <= 100 &&
                               fil >= 50 && fil <= 100 &&
                               his >= 50 && his <= 100;

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid grade. Please try again.");
                }
            } while (!isValidInput);

            // calculate the average grade
            double sum = eng + math + sci + fil + his;
            double ave = sum / 5;

            // determine if pass or true
            string pORf = (ave >= 74.45) ? "passed" : "failed";

            // for output
            Console.WriteLine("\n=============================================");
            Console.WriteLine($"The student {pORf}.");
            Console.WriteLine("=============================================");

            Console.WriteLine("\n=============================================");
            Console.WriteLine($"The general average of {name} is {ave:F2}.");
            Console.WriteLine("=============================================");

            Console.WriteLine("\n=============================================");
            Console.Write("Press any key to exit...");
            Console.ReadLine();
            Console.WriteLine("=============================================");
        }

        static double GetValidGrade(string subject)
        {
            double grade;
            bool isValidGrade;
            do
            {
                Console.WriteLine();
                Console.WriteLine("=============================================");
                Console.Write($"{subject}: ");
                string input = Console.ReadLine();
                Console.WriteLine("=============================================");

                isValidGrade = double.TryParse(input, out grade) && grade >= 50 && grade <= 100 && CountDecimals(input) <= 2;
                if (!isValidGrade)
                {
                    Console.WriteLine("Invalid grades input. Please try again.");
                    Console.WriteLine("=============================================");
                }
            } while (!isValidGrade);

            // round to 2 decimal places
            grade = Math.Round(grade, 2);
            return grade;
        }

        // determine the user name input
        static bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            foreach (char c in name.Trim())
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        // determine the grade user input no more than 2 decimal place
        static int CountDecimals(string input)
        {
            int decimalIndex = input.IndexOf(".");
            return decimalIndex == -1 ? 0 : input.Length - decimalIndex -1;
        }
    }
}
