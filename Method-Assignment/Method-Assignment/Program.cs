using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating our Calculations class and asking the user for input
            Calculations calculations = new Calculations();
            Console.WriteLine("Please enter your favorite number.");
            int favNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times would you like to add 1 to your favorite number?\n" +
                "(Leave blank for 1 time)");

            // Taking the input of the second value and asking if that input is null or whitespace.
            // If true, run the method with only 1 argument. If false, parse through the input to find
            // the number, convert that input to an integer and run the method with both arguments.
            string times = Console.ReadLine();
            if (string.IsNullOrEmpty(times))
            {
                Console.WriteLine(favNum + " plus 1 is " + calculations.Calc1(favNum));
            }
            else
            {
                int intTimes = int.Parse(times);
                Console.WriteLine(favNum + " plus 1 when run " + times + " times is " + calculations.Calc1(favNum, intTimes));
            }
            Console.ReadLine();
        }
    }
}
