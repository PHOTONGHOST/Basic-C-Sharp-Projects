using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Asks the user to enter a number
            Console.WriteLine("Enter a number to divide by 2:");

            // Then reads the user input and converts it to an integer
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Part 2: This is for calling the void method
            // Since MathUtilities is static, we can call it directly without creating an instance of the class.
            MathUtilities.DivideByTwo(userNumber);

            // Part 3: This calls the overloaded method with an output parameter
            int outputResult; 

            MathUtilities.DivideByTwo(userNumber, out outputResult);
            Console.WriteLine("Result using output parameter: " + outputResult);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

