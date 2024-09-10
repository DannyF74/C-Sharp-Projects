using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class with our math methods inside of it from the methods.cs file.
            mathOperations mathOps = new mathOperations();

            // Asking the user for input
            Console.WriteLine("Please enter the number you'd like to perform some math operations on.");
            int number = Convert.ToInt32(Console.ReadLine());

            // Calling each method from the created class
            Console.WriteLine(number + " plus 10 equals " + mathOps.addTen(number));
            Console.WriteLine(number + " multiplied by 2 equals " + mathOps.multiplyTwo(number));
            Console.WriteLine(number + " multiplied by 10 equals " + mathOps.multiplyTen(number));
            Console.ReadLine();
        }
    }
}
