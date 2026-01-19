using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Create a new Employee object and initialize its properties
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // This calls the SayName() method implemented in Employee
            employee.SayName();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

