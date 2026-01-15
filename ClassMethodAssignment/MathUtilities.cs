using System;

namespace ClassMethodAssignment
{
    // This static class contains math-related utility methods.
    public static class MathUtilities
    {
        // First Method: A void method that divides a number by 2
        // This method takes an integer parameter, then divides it by 2, and outputs the result to the console.
        public static void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine("Result (number divided by 2): " + result);
        }

        // Second Method: Uses an output parameter
        // This is an overloaded method that also divides by 2, but returns the result using an output parameter instead.
        public static void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }
    }
}

