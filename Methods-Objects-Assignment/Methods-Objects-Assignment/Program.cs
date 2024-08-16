using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new instance from our child class and assigning the variables created in the parent class.
            Employee example = new Employee();
            example.firstName = "Sample";
            example.lastName = "Student";

            // Calling the method defined in the parent class from the child class instance.
            example.sayName();
            Console.ReadLine();
        }
    }
}
