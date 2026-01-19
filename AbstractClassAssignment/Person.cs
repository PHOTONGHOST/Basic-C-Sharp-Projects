using System;

namespace AbstractClassAssignment
{
    // This is an abstract class. As an abstract clasd, it cannot be instantiated directly.
    public abstract class Person
    {
        // This property is used to store the person's first name
        public string firstName { get; set; }

        // This property is used to store the person's last name
        public string lastName { get; set; }

        // This is the abstract method declaration. 
        public abstract void SayName();
    }
}

