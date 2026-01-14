using System;

namespace MethodAssignment
{
    // This class contains an method with an optional parameter
    public class OptionalMath
    {
        // This method takes will take two integers and return an integer as a result. The second parameter has a default value, which makes it optional.
        public int Calculate(int number1, int number2 = 5)
        {
            int result = number1 + number2;
            return result;
        }
    }
}

