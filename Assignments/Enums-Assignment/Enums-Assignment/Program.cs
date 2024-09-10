using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While IsDay is false, do the following.
            bool IsDay = false;
            do
            {
                // Try the following code. If there is an exeption, catch and print an error.
                try
                {
                    // User input.
                    Console.WriteLine("Please enter the current day of the week.");
                    string dayInput = Console.ReadLine();

                    // Creates variable day which is a DayOfTheWeek type. This will hold the value of the casted enum
                    // (DayOfTheWeek). Enum.Parse is a method of the Enum class which takes in the type of Enum,
                    // the string dayInput and a boolean value of true which ignores upper and lower case in the input.
                    // If the dayInput can be converted to a value in the DayOfTheWeek enum, this will be assigned to
                    // the day value.
                    DayOfTheWeek day = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), dayInput, true);
                    Console.WriteLine("It is currently " + day);
                    
                    // IsDay is set to true which will break the do while loop.
                    IsDay = true;
                }

                // Catches any exceptions and prints an error.
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.\n");
                }
            }
            while (IsDay == false);
            
            Console.ReadLine();
        }

        // Creating the Enum DayOfTheWeek.
        public enum DayOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
