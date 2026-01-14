using System;

namespace CallingMethodsAssignment
{
    // This class contains the math methods that operate on an integer 
    public class MathOperations
    {
        // This method takes an integer, adds 10 to it, and then returns the result
        public int AddTen(int number)
        {
            int result = number + 10;
            return result;
        }

        // This method takes an integer, multiplies it by 5, and then returns the result
        public int MultiplyByFive(int number)
        {
            int result = number * 5;
            return result;
        }

        // This method takes an integer, subtracts 3 from it, and then returns the result
        public int SubtractThree(int number)
        {
            int result = number - 3;
            return result;
        }
    }
}
