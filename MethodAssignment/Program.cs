using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: This instantiates the OptionalMath class
            OptionalMath math = new OptionalMath();

            // Part 2: Asks the user for their first number
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            // STEP 3: Asks the user for their second number (also let's the user know this is optional)
            Console.WriteLine("Enter the second number (optional — press Enter to skip):");
            string secondInput = Console.ReadLine();

            int result;

            // Part 4: Determines whether the user entered a second number or not
            if (string.IsNullOrWhiteSpace(secondInput))
            {
                // If the user did not enter a second number, this calls the method with only the first number
                result = math.Calculate(firstNumber);
            }
            else
            {
                // If the user did enter a second number, this converts the input to an integer.
                int secondNumber = Convert.ToInt32(secondInput);

                // This calls the method with both numbers
                result = math.Calculate(firstNumber, secondNumber);
            }

            // Part 5: Displays the result to the user
            Console.WriteLine("Result: " + result);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
