using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class we just made and named it Calculations.
            Class1 Calculations = new Class1();
            Console.WriteLine("Please enter your favorite number.");
            string userNumber = Console.ReadLine();

            // Takes the users input and runs the overloaded method while converting the input to different data types.
            // Although everything looks the same, the different data types will run different methods and produce
            // different answers.
            Console.WriteLine(userNumber + " as an integer, plus one equals " + Calculations.Calculation(Convert.ToInt32(userNumber)) + " as an integer.");
            Console.WriteLine(userNumber + " as a decimal, plus ten equals " + Calculations.Calculation(Convert.ToDecimal(userNumber)) + " as an integer.");
            Console.WriteLine(userNumber + " as a string, plus one hundred equals " + Calculations.Calculation(userNumber) + " as an integer.");
            Console.ReadLine();
        }
    }
}
