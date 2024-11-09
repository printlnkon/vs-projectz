namespace TryException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num1 ) 
                    { 
                    
                    }
                   
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
            




        }
    }
}
