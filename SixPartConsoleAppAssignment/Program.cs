using System;
using System.Collections.Generic;

namespace ConsoleAppAssignmentParts1To6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1:

            // Creates a one-dimensional array of strings
            string[] words = { "Hello", "Welcome", "Goodbye", "CSharp", "Programming" };

            // Ask the user to input some text
            Console.WriteLine("PART 1: Enter text to append to each word in the array:");
            string userInput = Console.ReadLine();

            // This loop updates the array only; it does not print anything.
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + " " + userInput;
            }

            // Second loop prints each updated string one at a time
            Console.WriteLine("\nPART 1: Updated array values:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Part 2:

            /*
             * The following while loop would have been an infinite loop because:
             * - The condition (true) never actaully becomes false
             * - There is also no break or exit condition
             * 
             * It's commented out so the program will run normally.
             */

            // while (true)
            // {
            //     Console.WriteLine("This would run forever.");
            // }

            /*
             * FIX:
             * We control the loop using a counter and a condition that
             * eventually becomes false, so it stops properly.
             */

            Console.WriteLine("\nPART 2: Fixed loop (runs 5 times):");
            int counter = 0;

            while (counter < 5)
            {
                Console.WriteLine("Fixed loop iteration: " + counter);
                counter++; // Incrementing here prevents an infinite loop
            }

            // Part 3:

            // A loop that uses "<" as the comparison operator
            Console.WriteLine("\nPART 3: Loop using < operator (i < 3):");
            for (int i = 0; i < 3; i++) // Runs when i = 0, 1, 2
            {
                Console.WriteLine("i is: " + i);
            }

            // A loop that uses "<=" as the comparison operator
            Console.WriteLine("\nPART 3: Loop using <= operator (i <= 3):");
            for (int i = 0; i <= 3; i++) // Runs when i = 0, 1, 2, 3
            {
                Console.WriteLine("i is: " + i);
            }

            // Part 4:

            // Creates a list of strings where each item is unique
            List<string> uniqueGames = new List<string>
            {
                "Halo",
                "Doom",
                "Minecraft",
                "Skyrim",
                "Terraria"
            };

            // Ask the user to input text to search for in the unique list
            Console.WriteLine("\nPART 4: Unique list search");
            Console.WriteLine("Type a game title to search for (example: Halo):");
            string userSearchUnique = Console.ReadLine();

            bool foundUnique = false;

            // Loop through the list to search for a match
            for (int i = 0; i < uniqueGames.Count; i++)
            {
                // Compare user input to the current item (case-insensitive)
                if (uniqueGames[i].Equals(userSearchUnique, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {i}: {uniqueGames[i]}");

                    foundUnique = true;

                    break;
                }
            }

            // If no match was found, tell the user their input is not on the list
            if (!foundUnique)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // Part 5:

            // Create a list of strings that has at least two identical strings
            List<string> duplicatedAnimals = new List<string>
            {
                "Wolf",
                "Fox",
                "Bear",
                "Fox",
                "Eagle",
                "Wolf"
            };

            // Asks the user to input text to search for in the list
            Console.WriteLine("\nPART 5: Duplicate list search (shows ALL matching indices)");
            Console.WriteLine("Type an animal to search for (example: Fox):");
            string userSearchDuplicate = Console.ReadLine();

            bool foundDuplicate = false;

            // Loops through the list and print ALL indices that match
            for (int i = 0; i < duplicatedAnimals.Count; i++)
            {
                // Compare user input to the current item (case-insensitive)
                if (duplicatedAnimals[i].Equals(userSearchDuplicate, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {i}: {duplicatedAnimals[i]}");

                    foundDuplicate = true;
                }
            }

            // If no matches were found, tells the user their input is not on the list
            if (!foundDuplicate)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // Part 6:

            // Creates a list with at least two identical strings
            List<string> colorsWithDuplicates = new List<string>
            {
                "Red",
                "Blue",
                "Green",
                "Blue",
                "Yellow",
                "Red"
            };

            // Create a HashSet to track which items we've seen already
            HashSet<string> seenColors = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nPART 6: Duplicate tracker (shows whether item appeared already)");

            // Foreach loop evaluates each item and prints whether it has already appeared
            foreach (string color in colorsWithDuplicates)
            {
                if (seenColors.Contains(color))
                {
                    Console.WriteLine($"{color} - already appeared in the list.");
                }
                else
                {
                    Console.WriteLine($"{color} - first time appearing.");

                    seenColors.Add(color);
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}