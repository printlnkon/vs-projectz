using System.Collections;
using System.Text;
using CustomNamespace;

namespace CustomNamespace
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {
            this.firstName = "no name";
            this.lastName = "no name";   
            this.age = 0;
        }

        public Person(string fName, string lName)
        {
            this.firstName = fName; 
            this.lastName = lName; 
            this.age = 0;
        }

        public Person(string newfName, string newLName, int newAge)
        {
            this.firstName = newfName; 
            this.lastName = newLName; 
            this.age = newAge;
        }

        public void displayInfo()
        {
            Console.WriteLine("First name: " + this.firstName); 
            Console.WriteLine("Last name: " + this.lastName);
            Console.WriteLine("Age: " + this.age);
        }

    }
}

namespace MIDTERM_PRACTICE
{

    public class DemoMethod
    {
        public void printRectArea(int width, int height)
        {
            int area = width * height;
            Console.WriteLine("The area of rectangle is " + area);
        }

        public int getRectArea(int width, int height)
        {
            int area = width * height;
            return area;
        }

    }

    public class DemoOverload
    {
        public int getArea(int side)
        {
            int area = side * side;
            return area;
        }

        public int getArea(int width, int height)
        {
            int area = width * height;
            return area;
        }

        public double getArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
    public struct Book
    {
        public string title;
        public string author;
        public long book_id;

        //mutator method that set values of the struct fields
        public void setValues(string newTitle, string newAuthor, int newBookID)
        {
            this.title = newTitle;
            this.author = newAuthor;
            this.book_id = newBookID;
        }

        //method that displays the values of struct fields
        public void displayValues()
        {
            Console.WriteLine("Book title: " + this.title);
            Console.WriteLine("Book author: " + this.author);
            Console.WriteLine("Book ID: " + this.book_id);
        }
    }

    public class Point
    {
        //instance variables
        private int xPos, yPos;
        //constructor Point
        public Point()
        {
            this.xPos = 0;
            this.yPos = 0;
        }

        public int xPoint
        {
            get
            {
                return this.xPos;
            }
            set
            {
                this.xPos = value;
            }
        }

        public int yPoint
        {
            get
            {
                return this.yPos;
            }
            set
            {
                this.yPos = value;
            }
        }


        public void displayPosition()
        {
            Console.WriteLine("xPos = " + this.xPos + " yPos = " + this.yPos);
        }

    }
    public class RectArea
    {
        private int width, height;
        public void setValues(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public int getRectArea()
        {
            return this.width * this.height;
        }
    }

    //public class Person
    //{
    //    private string firstName; 
    //    private string lastName; 
    //    private int age;

    //    public Person()
    //    {
    //        this.firstName = "no name"; 
    //        this.lastName = "no name"; 
    //        this.age = 0;
    //    }

    //    public Person(string fName, string lName)
    //    {
    //        this.firstName = fName; 
    //        this.lastName = lName;
    //        this.age = 0;
    //    }

    //    public Person(string newfName, string newLName, int newAge)
    //    {
    //        this.firstName = newfName; this.lastName = newLName; this.age = newAge;
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point();
            ////this following initialization automatically calls the set method
            //p1.xPoint = 20;
            //p1.yPoint = 10;
            ////accessing the property automatically calls the get method and return its value
            //int x = p1.xPoint;
            //Console.WriteLine("value of p1.xPoint is " + x);
            //Console.WriteLine("value of p1.yPoint is " + p1.yPoint);

            //Person p1 = new Person();
            //Person p2 = new Person("Kalfontein","Cruz");
            //Person p3 = new Person("Kalfontein", "Cruz", 21);
            //p1.displayInfo();
            //p2.displayInfo();
            //p3.displayInfo();
            StringBuilder sb = new StringBuilder("welcome");
            sb[2] = '*';
            Console.WriteLine(sb);

            //DemoMethod obj = new DemoMethod();
            //obj.printRectArea(5, 3);

            //int result = obj.getRectArea(5, 3);
            //Console.WriteLine($"result = {result}");

            //DemoOverload obj = new DemoOverload(); 
            //int square = obj.getArea(3);
            //int rectInt = obj.getArea(5, 3);
            //double rectDouble = obj.getArea(5.25, 3.25);

            //Console.WriteLine(square + " / " + rectInt + " / " + rectDouble);

            //Book book1 = new Book();
            //initializing struct members
            //book1.title = "Object-Oriented Programming"; 
            //book1.author = "John Doe";
            //book1.book_id = 20190001;

            //accessing struct members
            //Console.WriteLine("Book title: " + book1.title); 
            //Console.WriteLine("Book author: " + book1.author); 
            //Console.WriteLine("Book ID: " + book1.book_id);

            //new instance of Book struct object and using its methods
            //Book book2 = new Book();
            //book2.setValues("C# Programming", "Jane Doe", 20190002); 
            //book2.displayValues();






            //int start = 1;
            //while (start <= 10)
            //{
            //    Console.WriteLine(start);
            //    start++;
            //}

            //int start = 1;
            //do { 
            //    Console.WriteLine(start);
            //    start++;
            //} while (start <= 15);


            //for (int start = 1; start <= 10; start++)
            //{
            //    Console.WriteLine(start);
            //}

            //for (int num = 1; num <= 10; num++)
            //{
            //    if (num == 10)
            //    {
            //        break; //if this statement is executed the loop will stop
            //    }
            //    Console.Write(num + " ");
            //}

            //for (int num = 1; num <= 10; num++)
            //{
            //    if (num == 5 || num == 6)
            //    {
            //        continue; //if this statement is executed it will ignore the print statement below and the execution jumps back to the loop
            //    }
            //    Console.Write(num + " ");
            //}

            //int[] numbers = new int[10];
            //numbers[0] = 45;
            //numbers[1] = 5;
            //numbers[2] = 5;
            //numbers[3] = 6;
            //numbers[4] = 7;
            //numbers[5] = 10;
            //numbers[6] = 34;
            //numbers[7] = 56;
            //numbers[8] = 75;
            //numbers[9] = 99;
            ////double[] grades = { 2.50, 2.75, 1.25, 5.0, 1.50 };
            //int studentGrade = numbers[9]; 
            //Console.WriteLine(studentGrade); //prints 2.75

            //foreach (int buh in numbers)
            //{
            //    Console.Write(numbers + " / ");
            //}

            //int[,] table = new int[2, 4];
            //int[,] table = {
            //        { 2, 3 },
            //        { 12, 5},
            //        { 3, 8 },
            //        { 18, 3 },
            //        { 69, 99 },
            //        };
            //Console.WriteLine(table[4, 0]);

            //ArrayList nameList = new ArrayList();
            //nameList.Add("Jack Paul");
            //nameList.Add("Adrian Castro"); 
            //nameList.Add("Peter Cruz"); 
            //nameList.Add("Angela Cruz");    
            //ArrayList nameList = new ArrayList()
            //{
            //    "titekomalake",
            //    "titekomalake1"
            //};
            ////Console.WriteLine(nameList[3]);
            //foreach (string name in nameList)
            //{
            //    Console.Write($"{name}\n");
            //}

            //char[] word = { 'H', 'e', 'l', 'l', 'o', '!' };
            //string strGreet = new string(word);
            //Console.WriteLine(strGreet);

            //string word1 = "Computer";
            //char letter = word1[2];
            //Console.WriteLine(letter);
            //////the value of variable letter is character 'm'

            //string word2 = "Computer";
            //int total = word2.Length;
            //Console.WriteLine(total);
            //////the value of variable total is 8

            //string word = "Computer";
            //bool isSame = word.Equals("computer", StringComparison.CurrentCultureIgnoreCase);
            //Console.WriteLine(isSame);

            //string word = "Computer";
            //int index = word.IndexOf('t');
            //Console.WriteLine(index);

            //string word = "Color";
            //string strChanged = word.Replace('o', '#');
            //Console.WriteLine(strChanged);

            //double value = 105.25;
            //string strValue = value.ToString();
            //Console.WriteLine(strValue);

            //string word = "COMPUTER";
            //string strConverted = word.ToLower();
            //Console.WriteLine(strConverted);

            //string word = "computer";
            //string strConverted = word.ToUpper();
            //Console.WriteLine(strConverted);

            //StringBuilder word = new StringBuilder("Computer");
            //word[0] = 'P';
            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.Write(word[i] + " + ");
            //}
        }
    }
}
