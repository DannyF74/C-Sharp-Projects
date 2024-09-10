using System;

namespace Try_Catch_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we are using a Try Catch block for this simple program. We want the user
            // to enter their age in whole numbers and then display their birth year back to them.
            try
            {
                Console.WriteLine("Please enter your age.");
                string inputAge = Console.ReadLine();

                // If the user enters anything but integers, throw a format exception.
                // Defined below, a format exception asks the user to enter the age
                // in whole numbers.
                if (!int.TryParse(inputAge, out int age))
                {
                    throw new FormatException();
                }

                // If the user enters an age equal to or less than 0, throw anargument exception.
                // Defined below, an argument exception asks the user to enter a valid number.
                if (age <= 0)
                {
                    throw new ArgumentException();
                }

                // If no exceptions are thrown, take the current year and take away the
                // users age. Then display the year of the users birth.
                int currentYear = DateTime.Now.Year;
                int yearOfBirth = currentYear - age;
                Console.WriteLine("You were born in {0}!", yearOfBirth);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter your age in whole numbers.");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid number for your age.");
                Console.ReadLine();
            }

            // Any unexpected errors, display the following message.
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured.");
            }

        }
    }
}
