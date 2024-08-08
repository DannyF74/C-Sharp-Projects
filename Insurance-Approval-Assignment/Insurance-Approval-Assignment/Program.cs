using System;

namespace Insurance_Approval_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval Program");

            //Checks applicants age and converts input to int
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Checks if applicant has a DUI and converts input to boolean
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            //Checks if applicant has speeding ticket and converts input to int
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Checks if applicant is over 15 years old, has not had a DUI and has less than 3 speeding tickets.
            //Returns true only if all three requirements are true. Otherwise, returns false.
            Console.WriteLine("Does this applicant qualify for car insurance?");
            Console.WriteLine(age > 15 && dui == false && tickets < 3);
            Console.ReadLine();
        }
    }
}
