using System;

namespace AbstractClassAssignment
{
    // Employee actually inherits from our abstract Person class
    public class Employee : Person
    {
        // This method is used to override and implement the abstract SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}

