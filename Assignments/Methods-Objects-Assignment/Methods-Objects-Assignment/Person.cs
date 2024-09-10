using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Assignment
{
    public class Person
    {
        // Creating two properties, first name and last name.
        public string firstName {  get; set; }
        public string lastName { get; set; }

        // Creating a method to print the first and last names together.
        public void sayName() 
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
