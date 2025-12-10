using System;

namespace WhileDoWhileAssignment
{
    internal class Program
    {
        static void Main()
        {
  
            // Boolean Comparison using a WHILE loop
            int counter = 0;

            while (counter < 5)
            {
                Console.WriteLine("While Loop: Counter is " + counter);

                counter++;
            }


            Console.WriteLine();


            // Boolean Comparison using a DO-WHILE loop

            int number = 10;

            // Note that the do-while loop will always run at least once
            do
            {
                Console.WriteLine("Do-While Loop: Number is " + number);

                number--;

            } while (number > 7); // Condition, this will run again while the number is greater than 7


            // The end of program
            Console.WriteLine();
            Console.WriteLine("Program complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
