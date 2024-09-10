using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Assignment
{
    // Creating a new class called Employee which inherits from the Person Class.
    public class Employee : Person
    {
        // Adding a property which is specific to employees.
        public int Id { get; set; }
    }
}
