using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Asks the user for a number
            Console.WriteLine("Please enter a number to perform math operations on:");

            string userInput = Console.ReadLine();
            int userNumber = Convert.ToInt32(userInput);

            // Part 2: Creates an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Part 3: Calls each method and displays the results
            int addResult = mathOps.AddTen(userNumber);
            Console.WriteLine($"After adding 10: {addResult}");

            // This calls the MultiplyByFive method
            int multiplyResult = mathOps.MultiplyByFive(userNumber);
            Console.WriteLine($"After multiplying by 5: {multiplyResult}");

            // This calls the SubtractThree method
            int subtractResult = mathOps.SubtractThree(userNumber);
            Console.WriteLine($"After subtracting 3: {subtractResult}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

