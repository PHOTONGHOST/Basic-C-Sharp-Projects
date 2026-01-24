using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This ask's the user to enter a number
            Console.WriteLine("Please enter a number:");

            string userInput = Console.ReadLine();

            // This defines the file path where the number will be saved, then this file will be created in the program's directory
            string filePath = "NumberLog.txt";

            // First this Writes the user's input to the text file, then File.WriteAllText will create the file if it does not exist and write the user's number into it
            File.WriteAllText(filePath, userInput);

            string fileContents = File.ReadAllText(filePath);

            // This displays the contents of the file to the user
            Console.WriteLine("\nThe number read from the file is:");
            Console.WriteLine(fileContents);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
