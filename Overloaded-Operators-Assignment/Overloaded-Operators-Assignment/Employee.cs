using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Operators_Assignment
{
    public class Employee
    {
        // Creating properties for the Employees
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        // Overriding the == operator to run a check on if employee IDs match
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            Console.WriteLine("Do the IDs of these employees match?");
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Overriding the != to run a check on if employee IDs are different.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            Console.WriteLine("Are the IDs of the employees different?");
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
