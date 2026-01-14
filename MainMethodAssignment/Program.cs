using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: This instantiates the MathProcessor class
            MathProcessor processor = new MathProcessor();

            // Part 2: This calls the integer method
            int intResult = processor.ProcessNumber(10);
            Console.WriteLine("Result from int method: " + intResult);

            // Part 3: This calls the decimal method
            int decimalResult = processor.ProcessNumber(5.5m);
            Console.WriteLine("Result from decimal method: " + decimalResult);

            // Part 4: This calls the string method
            int stringResult = processor.ProcessNumber("20");
            Console.WriteLine("Result from string method: " + stringResult);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

