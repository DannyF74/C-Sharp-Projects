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
            // Then running the quit method from the inherited interface IQuittable
            employee1.SayName();
            employee1.Quit();
            Console.ReadLine();

            // Here we are demonstrating polymorphism to create a quittableEmployee variable of the IQuittable data type.
            // Then we call the Quit method in the IQuittable interface which is defined in the Employee class which
            // uses the data in the employee1 instance.
            IQuittable quittableEmployee1 = employee1;
            quittableEmployee1.Quit();
            Console.ReadLine();
        }
    }
}
