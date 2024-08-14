using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating our class and asking for user input
            MathOperations mathOps = new MathOperations();
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Running our method with implicit parameters
            Console.WriteLine("\nCalculating...");
            mathOps.calc1(num1, num2);
            Console.WriteLine();

            // Running our method with explicit parameters.
            Console.WriteLine("Once again but specifically naming the parameters...");
            mathOps.calc1(x: num1, y: num2);
            Console.ReadLine();
        }
    }
}
