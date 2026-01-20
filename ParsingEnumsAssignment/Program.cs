using System;

namespace ParsingEnumsAssignment
{
    // This creates an enum that represents the days of the week
    enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // This ask's the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            string userInput = Console.ReadLine();

            try
            {
                // This attempts to convert the user's input into the DaysOfTheWeek enum type
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(
                    typeof(DaysOfTheWeek),
                    userInput,
                    true
                );

                // If parsing was successful, this will display the result
                Console.WriteLine("You entered: " + today);
            }
            catch
            {
                // However, if parsing fails (an invalid input was entered), this error message will display
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

