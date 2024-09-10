using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public abstract class Person
    {
        // Each Person will have a first and last name property
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Each person is required to have a SayName method which will vary depending on the child class.
        // The implementation will be defined in each child class.
        public abstract void SayName();
    }
}
