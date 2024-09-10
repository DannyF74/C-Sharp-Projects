using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a variable, setting it to the current time and displaying it to the user.
            DateTime now = DateTime.Now;
            Console.WriteLine("It is currently " + now.ToString());

            // Asking for user input, taking that input and using the AddHours method to add the
            // inputted number to the hours of the current time. Finally displaying the added hours
            // back to the user.
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime addedTime = now.AddHours(userInput);
            Console.WriteLine("In {0} hours it will be {1}", userInput, addedTime.ToString());
            Console.ReadLine();
        }
    }
}
