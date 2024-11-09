using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApps
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            int pieces;
            while (true)
            {
                Console.Write("Enter the pieces of apple: ");
                string input1 = Console.ReadLine();
                if (input1.Contains(" ")) // validation if the user input with "spaces"
                {
                    Console.WriteLine("Input cannot contain spaces. Please try again.");
                    Console.WriteLine();
                    continue;
                }
                    if (int.TryParse(input1, out pieces) && pieces >= 0)
                    {
                        if (pieces == 0) // validation if the user input with "0" value
                        {
                            Console.WriteLine("Invalid input. Please enter a non-zero integer value.");
                            Console.WriteLine();
                            continue;
                        }
                        break;
                    }
                else
                {   // validation if the user input "negative" integer
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    Console.WriteLine();
                }
            }

            double totalPrice;
            while (true)
            {
                Console.WriteLine();
                Console.Write($"Enter total price of {pieces} apple(s): ");
                string input2 = Console.ReadLine();
                if (input2.Contains(" ")) // validation if the user input with "spaces"
                {
                    Console.WriteLine("Input cannot contain spaces. Please try again.");
                    Console.WriteLine();
                    continue;
                }
                    if (double.TryParse(input2, out totalPrice) && totalPrice >= 0)
                    {
                        if (totalPrice == 0) // validation if the user input with "0" value
                        {
                            Console.WriteLine("Invalid input. Please enter a non-zero integer value.");
                            Console.WriteLine();
                            continue;
                        }
                        break;
                    }
                else
                {
                    // validation if the user input "negative" integer
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                    Console.WriteLine();
                }
            }

            // converts double to float
            float originalPrice = (float)totalPrice;
            Console.WriteLine();
            Console.WriteLine($"The total price of {pieces} apple(s) is: {totalPrice}");
         
            Console.WriteLine();
            Console.WriteLine($"The value of original price is: {originalPrice} ");
            
            // convert float data type to int
            int convertedPrice = (int)Math.Round(totalPrice);
            Console.WriteLine($"The value of converted price is: {convertedPrice} ");

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
