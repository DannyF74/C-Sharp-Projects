using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new list of employees and instantiating 10 new employee objects.
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee { ID = 1, firstName = "Joe", lastName = "Smith" },
                new Employee { ID = 2, firstName = "Jane", lastName = "Doe" },
                new Employee { ID = 3, firstName = "Joe", lastName = "Johnson" },
                new Employee { ID = 4, firstName = "Emily", lastName = "Davis" },
                new Employee { ID = 5, firstName = "Michael", lastName = "Brown" },
                new Employee { ID = 6, firstName = "Sarah", lastName = "Wilson" },
                new Employee { ID = 7, firstName = "David", lastName = "Miller" },
                new Employee { ID = 8, firstName = "Anna", lastName = "Garcia" },
                new Employee { ID = 9, firstName = "Matthew", lastName = "Martinez" },
                new Employee { ID = 10, firstName = "Olivia", lastName = "Rodriguez" }
            };

            // Finding all the employees with the first name Joe and adding them to a new list using a foreach loop.
            Console.WriteLine("USING A FOREACH LOOP.");
            List<Employee> joeList = new List<Employee>();
            foreach (Employee emp in employeeList)
            {
                if (emp.firstName == "Joe")
                {
                    Console.WriteLine(emp.firstName + " " + emp.lastName);
                    joeList.Add(emp);
                }
            };
            Console.ReadLine();

            // Doing the same thing but using a lambda expression. This saves me having to create multiple commands
            // for a new list and then running through each employee in the employeeList to find the Joes.
            // This creates the list and checks for the Joes and adds them to the list in one line of code. 
            // The foreach loop just prints each item in the new lambdaList.
            Console.WriteLine("USING LAMBDA.");    
            List<Employee> lambdaList = employeeList.Where(x => x.firstName == "Joe").ToList();
            foreach (var joe in lambdaList)
            {
                Console.WriteLine($"{joe.firstName} {joe.lastName}");
            }
            Console.ReadLine();

            // Creating another new list using a lambda expression. This time, its looking for employees with
            // an ID greater than 5.
            List<Employee> lambdaList2 = employeeList.Where(x => x.ID > 5).ToList();
            foreach (var emp in lambdaList2)
            {
                Console.WriteLine($"Employee ID: {emp.ID} Name: {emp.firstName} {emp.lastName}");
            }
            Console.ReadLine();
        }
    }
}
