using System;

namespace MethodsAndObjectsAssignment
{
    // This class represents a person
    public class Person
    {
        // This is a property to store the person's first name
        public string FirstName { get; set; }

        // This is a property to store the person's last name
        public string LastName { get; set; }

        // This void method prints the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

