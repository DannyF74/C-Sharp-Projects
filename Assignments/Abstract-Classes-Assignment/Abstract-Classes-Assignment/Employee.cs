using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    // Creating a child class, Employee. This inherits from the parent class, Person.
    // We also implement the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        // Defining the inherited abstract method for the employees.
        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {firstName} {lastName}");
        }

        // Defining the Quit method from the IQuittable interface.
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit!");
        }
    }
}
