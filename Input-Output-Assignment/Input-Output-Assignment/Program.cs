using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Output_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for user input
            Console.WriteLine("Please enter your favorite number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Using the Streamwriter class create new file writer that creates a test log file to the desktop.
            // The true boolean allows the file to be appended.
            using (StreamWriter file = new StreamWriter (@"C:\users\danny\desktop\testlog\testlog.txt", true))
            {
                // Write the number from the user input to the text file on the desktop.
                file.WriteLine(userInput);
            }
            // Display the users input back to the user.
            Console.WriteLine("The number you entered was {0}", userInput);
            Console.ReadLine();
        }
    }
}
