using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we are instantiating the class CreatedMethods, asking the user for input and then
            // running the first method which will print the results of the method on screen.
            CreatedMethods createdMethods = new CreatedMethods();
            Console.WriteLine("Please enter your favorite number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            createdMethods.Divide(userNum1);
            Console.ReadLine();

            // Here we are passing in user input to a method and getting the result of the calculation
            // out of the method and assigning it to the result variable. We then print that to the screen.
            Console.WriteLine("Please enter another number");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int userNum3 = Convert.ToInt32(Console.ReadLine());
            int result;
            createdMethods.outputTest(userNum2, userNum3, out result);
            Console.WriteLine(userNum2 + " plus " + userNum3 + " equals " + result);
            Console.ReadLine();

            // Here we are using a static method. We have not instantiated the TestingStatic class yet we
            // are still able to run this method.
            Console.WriteLine("Please enter another number");
            int userNum4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int userNum5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNum4 + " plus " + userNum5 + " equals " + TestingStatic.staticAdd(userNum4, userNum5));
            Console.ReadLine();

            // Here we are running the same method as above but with strings. This demonstrates method overloading
            // as when we pass in strings to the same method, we are concatinating them rather than adding them as
            // if they were ints.
            Console.WriteLine("Please enter your first name");
            string fName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lName = Console.ReadLine();
            Console.WriteLine(TestingStatic.staticAdd(fName, lName));
            Console.ReadLine();
        }
    }
}
