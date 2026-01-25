using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This ask's the user for their age
                Console.WriteLine("Please enter your age:");

                // This will read the user input and attempt to convert it to an integer
                int age = Convert.ToInt32(Console.ReadLine());

                // This validates the age input, and if the age is zero or a negative number, then it will throw an exception
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // This will calculate the year of birth then display it to the user
                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - age;

                Console.WriteLine("You were born in the year: " + yearBorn);
            }
            catch (ArgumentOutOfRangeException)
            {
                // This is what comes up with a zero or negative age input
                Console.WriteLine("Age must be a positive number greater than zero.");
            }
            catch (Exception)
            {
                // This will handle any other unexpected errors
                Console.WriteLine("An error occurred. Please enter a valid number.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
