using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will display the current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time:");
            Console.WriteLine(currentDateTime);

            // Ask's the user for a number of hours
            Console.WriteLine("\nEnter a number of hours:");

            int hours = Convert.ToInt32(Console.ReadLine());

            // This calculates the future date and time then adds the user-entered number of hours to the current time
            DateTime futureDateTime = currentDateTime.AddHours(hours);

            // This will display the future date and time
            Console.WriteLine("\nThe date and time in " + hours + " hour(s) will be:");
            Console.WriteLine(futureDateTime);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
