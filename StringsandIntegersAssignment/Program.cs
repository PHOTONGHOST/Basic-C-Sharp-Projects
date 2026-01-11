using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a list of integers to divide
            List<int> numbers = new List<int>() { 10, 25, 50, 100, 200 };

            // Asks the user for a number to divide each list number by
            Console.WriteLine("Enter a number to divide each number in the list by:");

            // Reads the user's input as a string
            string userInput = Console.ReadLine();

            // Puts the conversion + loop inside a try/catch block
            try
            {
                // Convert the user's input into an integer (can throw FormatException)
                int divisor = Convert.ToInt32(userInput);

                // Loop through each integer in the list
                for (int i = 0; i < numbers.Count; i++)
                {
                    int result = numbers[i] / divisor;
                    Console.WriteLine($"{numbers[i]} divided by {divisor} = {result}");
                }
            }
            catch (FormatException ex)
            {
                // This is the error that happens when the input cannot be converted into an integer
                Console.WriteLine("ERROR: Please enter a whole number (not letters or symbols).");
                Console.WriteLine("Technical message: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                // This is the error that happens when the user tries to divide by zero
                Console.WriteLine("ERROR: You cannot divide by zero.");
                Console.WriteLine("Technical message: " + ex.Message);
            }
            catch (Exception ex)
            {
                // This catches any other unexpected errors that may occur
                Console.WriteLine("ERROR: Something went wrong.");
                Console.WriteLine("Technical message: " + ex.Message);
            }

            // Code below the try/catch to show that the program continues
            Console.WriteLine("\nThe program has escaped from the try/catch block and continued execution.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

