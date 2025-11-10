using System;

namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()
        {
            // Display a message asking for the user's name
            Console.WriteLine("What is your name?");

            // Read the user's input and store it in a variable
            string name = Console.ReadLine();

            // Output a personalized greeting
            Console.WriteLine("Hello, " + name + "!");

            // Keep the console window open until the user presses a key
            Console.Read();
        }
    }
}
