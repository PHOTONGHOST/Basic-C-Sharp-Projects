using System;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            // Prints the program title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine(); // spacing

            // PERSON 1 INFORMATION section
            
            Console.WriteLine("Person 1");

            // Ask for hourly rate and converts it to decimal
            Console.WriteLine("Enter hourly rate:");
            decimal p1HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Asks for weekly hours
            Console.WriteLine("Enter hours worked per week:");
            decimal p1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            // PERSON 2 INFORMATION section

            Console.WriteLine("Person 2");

            // Asks for the hourly rate
            Console.WriteLine("Enter hourly rate:");
            decimal p2HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Asks for weekly hours
            Console.WriteLine("Enter hours worked per week:");
            decimal p2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(); // spacing

            // CALCULATE ANNUAL SALARIES section

            // Gives us the annual salary = hourly rate × hours per week × 52 weeks
            decimal p1AnnualSalary = p1HourlyRate * p1HoursPerWeek * 52;
            decimal p2AnnualSalary = p2HourlyRate * p2HoursPerWeek * 52;

            // Prints the results
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1AnnualSalary);
            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2AnnualSalary);
            Console.WriteLine();

            // COMPARE INCOMES section

            // Checks whether Person 1 makes more money and gives a boolean result
            bool person1MakesMore = p1AnnualSalary > p2AnnualSalary;

            // Prints the true/false comparison result
            Console.WriteLine("Person 1 makes more money than Person 2:");
            Console.WriteLine(person1MakesMore);
            Console.WriteLine();

            // Keeps the window open
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
