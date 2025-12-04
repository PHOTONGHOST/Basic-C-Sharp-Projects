using System;

namespace PackageExpress
{
    internal class Program
    {
        static void Main()
        {
            // The welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask's for the package weight
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // If the weight is over 50, then package will be too heavy, so the program will end
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            // Ask's for the package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask's for the package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask's for the package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Checks the combined dimensions of the packege
            decimal dimensionTotal = width + height + length;

            // If the total dimensions of the package exceed 50, then it's too large and the program will end
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculates the shipping quote/cost
            decimal quote = (width * height * length * weight) / 100;

            // This displays the final quote as a currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            // This keeps the console window open
            Console.ReadLine();
        }
    }
}
