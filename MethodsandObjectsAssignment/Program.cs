using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates and initialize an Employee object, then creates a new employee object and sets its properties
            Employee employee = new Employee()
            {
                FirstName = "Sample",   
                LastName = "Student",   
                Id = 1                  
            };

            // This is the inherited SayName() method
            employee.SayName();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

