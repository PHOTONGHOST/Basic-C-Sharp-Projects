using System;

namespace ConstructorAssignment
{
    // This class is used tp represents a person
    public class Person
    {
        // The property to store the person's name
        public string Name { get; set; }

        // And this is the property to store the person's age
        public int Age { get; set; }

        // Constructor #1; This constructor takes only a name and chains it to the second constructor, providing a default age value.
        public Person(string name) : this(name, 0)
        {
        }

        // Constructor #2; This constructor takes both name and age and assigns them to the respective properties.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
