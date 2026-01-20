using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: We create a list of at least 10 employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 3, FirstName = "Sarah", LastName = "Connor" },
                new Employee { Id = 4, FirstName = "Michael", LastName = "Scott" },
                new Employee { Id = 5, FirstName = "Pam", LastName = "Beesly" },
                new Employee { Id = 6, FirstName = "Jim", LastName = "Halpert" },
                new Employee { Id = 7, FirstName = "Dwight", LastName = "Schrute" },
                new Employee { Id = 8, FirstName = "Angela", LastName = "Martin" },
                new Employee { Id = 9, FirstName = "Kevin", LastName = "Malone" },
                new Employee { Id = 10, FirstName = "Oscar", LastName = "Martinez" }
            };

            // Part 2: This foreach loop is used to find all employees named "Joe"
            List<Employee> joeEmployeesForeach = new List<Employee>();

            foreach (Employee employee in employees)
            {
                // Checks the FirstName property of each employee, then adds to the new list if it matches "Joe"
                if (employee.FirstName == "Joe")
                {
                    joeEmployeesForeach.Add(employee);
                }
            }

            // This displays the results from the foreach loop
            Console.WriteLine("Employees named Joe (foreach loop):");
            foreach (Employee joe in joeEmployeesForeach)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (Id: {joe.Id})");
            }

            // Part 3: This time a lambda expression is used to find all employees named "Joe"
            List<Employee> joeEmployeesLambda = employees
                .Where(e => e.FirstName == "Joe")
                .ToList();

            // This will display results from the lambda expression
            Console.WriteLine("\nEmployees named Joe (lambda expression):");
            foreach (Employee joe in joeEmployeesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (Id: {joe.Id})");
            }

            // Part 4: This lambda expression is used to find all employees with Id > 5
            List<Employee> idGreaterThanFive = employees
                .Where(e => e.Id > 5)
                .ToList();

            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee employee in idGreaterThanFive)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} (Id: {employee.Id})");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

