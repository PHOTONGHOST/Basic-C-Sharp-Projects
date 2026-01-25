using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This creates a const variable (of note that Const variables cannot be changed after being set)
            const string applicationName = "Constructor Assignment App";

            Console.WriteLine(applicationName);

            // This creates a variable using the 'var' keyword, then the compiler automatically determines the type
            var currentYear = 2026;

            Console.WriteLine("Current year: " + currentYear);

            // This creates an object using the first constructor (this also uses constructor chaining)
            Person person1 = new Person("Alice");

            // This creates a object using the second constructor and then displays the properties
            Person person2 = new Person("Bob", 30);

            Console.WriteLine($"{person1.Name} is {person1.Age} years old.");
            Console.WriteLine($"{person2.Name} is {person2.Age} years old.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
