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

            // Takes the users input and runs the overloaded method while converting the input to different data types.
            // Although everything looks the same, the different data types will run different methods and produce
            // different answers.
            Console.WriteLine("Please enter a whole number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNumber + " plus 1 equals " + Calculations.intCalculation(userNumber));

            Console.WriteLine("Please enter a number with two decimal places. (Example: 3.14)");
            decimal userNumber2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(userNumber2 + " plus 10 equals " + Calculations.decCalculation(userNumber2) + " when rounded down to the nearest whole number.");

            Console.WriteLine("Please enter another whole number");
            string userNumber3 = Console.ReadLine();
            Console.WriteLine(userNumber3 + " plus 100 equals " + Calculations.stringCalculation(userNumber3));


            Console.ReadLine();
        }
    }
}
