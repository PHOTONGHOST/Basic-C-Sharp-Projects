using System;

namespace MainMethodAssignment
{
    // This class contains overloaded methods that can perform different math operations based on their parameter type
    public class MathProcessor
    {
        // First Method: Takes an integer and performs addition
        public int ProcessNumber(int number)
        {
            int result = number + 10;
            return result;
        }

        // Second Method: Takes a decimal and performs multiplication, then it returns it as an integer
        public int ProcessNumber(decimal number)
        {
            decimal result = number * 2;
            return Convert.ToInt32(result);
        }

        // Third Method: Takes a string, then converts it to an integer, performs subtraction, and finally returns it as an integer
        public int ProcessNumber(string number)
        {
            int convertedNumber = Convert.ToInt32(number);
            int result = convertedNumber - 5;
            return result;
        }
    }
}
