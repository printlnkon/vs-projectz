using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double raiseNum = Math.Pow(5,2);
            Console.WriteLine($"Math Pow: {raiseNum}");

            double squareRoot = Math.Sqrt(15);
            Console.WriteLine($"Math Square Root: {squareRoot:F2}");

            double roundOff = Math.Round(95.90);
            Console.WriteLine($"Math Round: {roundOff}");

            double exponential = Math.Exp(5.00);
            Console.WriteLine($"Math Exponential: {exponential:F2}");

            double truncation = Math.Truncate(1203.0102);
            Console.WriteLine($"Math Truncate: {truncation}");

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
