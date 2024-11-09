namespace _06Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineSeparator line = new LineSeparator();

            // one-dimensional array
            Console.WriteLine(line.line);
            Console.WriteLine("One-Dimensional Arrays");
            Console.WriteLine(line.line);
            string[] nameOfClassmates = { "Drixcien", "Solito", "Gabriel", "Roel", "Marcus", "Red" };
            foreach (string i in nameOfClassmates)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine(line.line);

            // two-dimensional array
            char[,] sixAlphabets = new char[2, 3];

            // initializing array with first six (6) letters of the alphabet
            char letter = 'A';
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sixAlphabets[i, j] = letter;
                    letter++;
                }
            }

            Console.WriteLine("\n" + line.line);
            Console.WriteLine("Two-Dimensional Arrays");
            Console.WriteLine(line.line);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // display the output
                    Console.Write(sixAlphabets[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(line.line);

            Console.WriteLine("\n" + line.line);
            Console.WriteLine("A string with any message");
            Console.WriteLine(line.line);

            string message = "Hello, I hope you are doing well.";
            Console.WriteLine(message);

            // check if the message contains the substring "hello"
            bool containsHello = message.Contains("hello", StringComparison.OrdinalIgnoreCase);

            if (containsHello)
            {
                Console.WriteLine(line.line);
                Console.WriteLine("The message contains \"hello\".");
                Console.WriteLine(line.line);
            }
            else
            {
                Console.WriteLine(line.line);
                Console.WriteLine("The message does not contain string \"hello\".");
                Console.WriteLine(line.line);
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }

        class LineSeparator()
        {
            public string line = "================================";
        }

    }
}
