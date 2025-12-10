using System;
using System.Text;   // Required for StringBuilder

namespace StringAssignment
{
    internal class Program
    {
        static void Main()
        {
 
            // 1. Concentrating 3 strings

            string part1 = "Hello, ";
            string part2 = "my name is ";
            string part3 = "the Programmer.";

            string fullSentence = part1 + part2 + part3;

            Console.WriteLine("Concatenated String:");
            Console.WriteLine(fullSentence);
            Console.WriteLine(); 

            // 2. converting the concnetrated string to uppercase

            string upperSentence = fullSentence.ToUpper();

            Console.WriteLine("Uppercase Version:");
            Console.WriteLine(upperSentence);
            Console.WriteLine();

            // 3. Creating a paragraph using the StringBuilder

            StringBuilder paragraph = new StringBuilder();

            // Appends the sentences one at a time
            paragraph.Append("This is the first sentence of the paragraph. ");
            paragraph.Append("Here is another sentence that adds more detail. ");
            paragraph.Append("Finally, this is the last sentence that completes the paragraph.");

            // Displays the paragraph
            Console.WriteLine("Paragraph Built with StringBuilder:");
            Console.WriteLine(paragraph.ToString());
            Console.WriteLine();


            // End of program
            Console.WriteLine("Program complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
