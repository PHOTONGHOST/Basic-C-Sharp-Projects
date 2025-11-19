using System;

namespace MathOperationsAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Asks the user for a number and then reads the input as a string
            Console.WriteLine("Enter a number to multiply by 50:");
            string input1 = Console.ReadLine();

            // Converts the input into a large numeric type
            long num1 = Convert.ToInt64(input1);

            // Multiplies the number by 50
            long product = num1 * 50;

            // This prints the result to the console
            Console.WriteLine("Your number multiplied by 50 is: " + product);
            Console.WriteLine(); // spacing

            // Adds 25
            Console.WriteLine("Enter a number to add 25 to:");
            string input2 = Console.ReadLine();

            // Converts to an integer (or long if  that's preferred)
            long num2 = Convert.ToInt64(input2);

            // Adds 25
            long plus25 = num2 + 25;

            // Prints the result
            Console.WriteLine("Your number plus 25 is: " + plus25);
            Console.WriteLine();

            // Divides by 12.5
            Console.WriteLine("Enter a number to divide by 12.5:");
            string input3 = Console.ReadLine();

            // Converts to a double because 12.5 contains decimals
            double num3 = Convert.ToDouble(input3);

            // This divides by 12.5
            double divided = num3 / 12.5;

            // Prints the result
            Console.WriteLine("Your number divided by 12.5 is: " + divided);
            Console.WriteLine();

            // Check to see if the number greater than 50
            Console.WriteLine("Enter a number to check if it is greater than 50:");
            string input4 = Console.ReadLine();

            // Converts to a numeric value
            double num4 = Convert.ToDouble(input4);

            // Checks to see if the number is greater than 50 (will return a true or false)
            bool isGreater = num4 > 50;

            // Prints the boolean result
            Console.WriteLine("Is your number greater than 50? " + isGreater);
            Console.WriteLine();

            // Get remainder when dividing by 7
            Console.WriteLine("Enter a number to divide by 7 and get the remainder:");
            string input5 = Console.ReadLine();

            // Converts to integer
            int num5 = Convert.ToInt32(input5);

            // Use modulus % operator to get the remainder
            int remainder = num5 % 7;

            // Prints the result
            Console.WriteLine("The remainder when your number is divided by 7 is: " + remainder);
            Console.WriteLine();


            // End of the program
            Console.WriteLine("Program complete. Press Enter to exit.");
            Console.ReadLine(); 
        }
    }
}
