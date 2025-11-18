using System;

namespace DailyReport
{
    internal class Program
    {
        static void Main()
        {
            // Prints the school name
            Console.WriteLine("Academy of Learning Career College");

            // Prints the report header
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine(); 

            // Ask's for the student's name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // Ask what course the student is on
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            // Ask's for the page number and converts input into an integer
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask's if the student needs help and converts input into boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask's about positive experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            // Ask's for any additional feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string additionalFeedback = Console.ReadLine();

            // Ask's for study hours, then converts input into a double 
            Console.WriteLine("How many hours did you study today?");
            double studyHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(); // for spacing

            // The final message 
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // This will prevent the window from closing immediately
            Console.ReadLine();
        }
    }
}
