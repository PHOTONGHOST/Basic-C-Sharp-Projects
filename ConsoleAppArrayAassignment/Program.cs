using System;
using System.Collections.Generic;

namespace ConsoleArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // String Array Section

            // Create a one-dimensional array of strings
            string[] animals = { "Dog", "Cat", "Elephant", "Lion", "Tiger" };

            // Ask the user to select an index
            Console.WriteLine("STRING ARRAY");
            Console.WriteLine("Select an index (0 - 4) to see an animal:");

            // Store the user's input as a string
            string stringInput = Console.ReadLine();

            // Try to convert the user's input into an integer
            bool validStringIndex = int.TryParse(stringInput, out int stringIndex);

            // Checks if the input is both a valid number AND within array bounds
            if (validStringIndex && stringIndex >= 0 && stringIndex < animals.Length)
            {
                Console.WriteLine($"You selected: {animals[stringIndex]}");
            }
            else
            {
                Console.WriteLine("That index does not exist in the string array.");
            }

            Console.WriteLine();

            // Integer Array Section

            // Create a one-dimensional array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("INTEGER ARRAY");
            Console.WriteLine("Select an index (0 - 4) to see a number:");

            // Stores the user's input
            string intInput = Console.ReadLine();

            bool validIntIndex = int.TryParse(intInput, out int intIndex);

            // Check if the index is valid
            if (validIntIndex && intIndex >= 0 && intIndex < numbers.Length)
            {

                Console.WriteLine($"You selected: {numbers[intIndex]}");
            }
            else
            {
                Console.WriteLine("That index does not exist in the integer array.");
            }

            Console.WriteLine();

            // List Section

            // Creates a list of strings
            List<string> colors = new List<string>()
            {
                "Red",
                "Blue",
                "Green",
                "Yellow",
                "Purple"
            };

            // Asks the user to select an index
            Console.WriteLine("STRING LIST");
            Console.WriteLine("Select an index (0 - 4) to see a color:");

            // Stores the user's input
            string listInput = Console.ReadLine();

            bool validListIndex = int.TryParse(listInput, out int listIndex);

            // Checks to see if the index is valid
            if (validListIndex && listIndex >= 0 && listIndex < colors.Count)
            {
               
                Console.WriteLine($"You selected: {colors[listIndex]}");
            }
            else
            {
                Console.WriteLine("That index does not exist in the list.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

