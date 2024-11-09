using System;

namespace Practice
{

    // new class
    //public class ThisKeyWord
    //{
    //    // instance variables
    //    private string firstName;
    //    private string lastName;
    //    private int age;

    //    // default constructor
    //    public ThisKeyWord ()
    //    {
    //        this.firstName = "";
    //        this.lastName = "";
    //        this.age = 0;
    //    }

    //    // overloading constructor w/ 2 parameters
    //    public ThisKeyWord (string fn, string ln)
    //    {
    //        this.firstName = fn;
    //        this.lastName = ln;
    //        Console.WriteLine($"Good day, {this.firstName} {this.lastName}!");
    //    }

    //    // overloading constructor w/ 3 parameters
    //    public ThisKeyWord(string fn, string ln, int age)
    //    {
    //        this.firstName = fn;
    //        this.lastName = ln;
    //        this.age = age;
    //        Console.WriteLine($"Good day, {this.firstName} {this.lastName}! You are {this.age} years old.");
    //    }

    //}

    public class Circle // 1
    {
        private double radius;
        public double getCircleDiameter(double r) // method that takes a radius of double type as the parameter
        {
            this.radius = r;
            return 2 * radius; // return the diameter of a circle, multiply radius by 2
        }
    }

    public struct Product // 2
    {
        private int code;
        private string description;
        private double price;
    }

    public class Person // 3
    {
        private string full_name;

        public Person()
        {
            full_name = "";
        }
    }

    namespace Accounts // 4
    {
        public class Account
        {
            private double account_number;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            double radius = 5.0;
            double diameter = c.getCircleDiameter(5.0);
            Console.WriteLine($"Diameter of the circle with radius {radius} is: {diameter}");

            //ThisKeyWord tkw1 = new ThisKeyWord();
            //ThisKeyWord tkw2 = new ThisKeyWord("Phoemela Caully", "Ibañez", 21);
            //ThisKeyWord tkw3 = new ThisKeyWord("Kalfontein", "Cruz", 21);

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
