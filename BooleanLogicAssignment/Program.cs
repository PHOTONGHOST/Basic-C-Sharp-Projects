using System;

namespace InsuranceApproval
{
    internal class Program
    {
        static void Main()
        {
            // Display's the program header
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine();

            // Asks for the applicant's age
  
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Asks about DUI history (if any)

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Asks for the number of speeding tickets (if any)
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Business Rules section

            bool ageRequirement = age > 15;             
            bool duiRequirement = hasDUI == false;     
            bool ticketRequirement = tickets <= 3;      

            // The applicant only qualifies if all the rules are true.
            bool isQualified = ageRequirement && duiRequirement && ticketRequirement;

            // Final Output section

            Console.WriteLine();
            Console.WriteLine("Qualified for car insurance?");
            Console.WriteLine(isQualified);
            Console.WriteLine();


            // This keeps the console window open
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}

