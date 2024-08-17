using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating our employee and assigning the variables inherited by the person class.
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";

            // Running the inherited abstract method SayName that we defined in the child employee class. 
            employee1.SayName();
            Console.ReadLine();
        }
    }
}
