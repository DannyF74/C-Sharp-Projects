using System;
using System.Collections.Generic;

namespace Exception_Handling_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of numbers and then running a try catch block on some code that will 
            // divide each number in the list by the users input. 
            List<int> numberList = new List<int> { 14, 26, 32, 48, 54, 66 };
            try
            {
                Console.WriteLine("Please enter a whole number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberList.Count; i++)
                {
                    Console.WriteLine(numberList[i] + " divided by " + userNumber + " equals " + (numberList[i] / userNumber));
                }
            }

            // If a format exception is thrown, print the following.
            catch (FormatException)
            {
                Console.WriteLine("Formatting error. This program needs a whole number.");
            }

            // If the user inputs 0, print the following.
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not enter 0.");
            }

            // This code will run whether there is an exception or not.
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
