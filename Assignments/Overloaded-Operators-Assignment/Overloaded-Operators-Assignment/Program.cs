using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two new employees
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            // Assigning values to each objects properties.
            employee1.ID = 1;
            employee1.firstName = "Danny";
            employee1.lastName = "Firth";

            employee2.ID = 2;
            employee2.firstName = "Test";
            employee2.lastName = "Subject";

            // Displaying the values of the objects to the user of the program.
            Console.WriteLine("Employee ID: " + employee1.ID + "\nFirst name: " + employee1.firstName + 
                "\nLast name: " + employee1.lastName);
            Console.WriteLine("\nEmployee ID: " + employee2.ID + "\nFirst name: " + employee2.firstName +
                "\nLast name: " + employee2.lastName);

            // Running the overloaded operators that we defined in our Employee class.
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine(); 
        }
    }
}
