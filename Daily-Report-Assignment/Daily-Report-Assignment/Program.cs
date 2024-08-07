using System;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main()
        {
            //Initial greeting.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //Gathering the information from the user. Using Convert method to change the input from the user to the correct data type.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positives = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            //Displaying the information back to the user along with a closing statement.
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Page Number: " + pageNumber);
            Console.WriteLine("Help Required: " + needsHelp);
            Console.WriteLine("Your Positives: " + positives);
            Console.WriteLine("Your Feedback: " + feedback);
            Console.WriteLine("Hours Studied Today: " + hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            //Keeps the program open for the user to check their information.
            Console.ReadLine();
        }
    }
}