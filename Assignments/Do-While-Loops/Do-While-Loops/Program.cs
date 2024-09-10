using System;

namespace Do_While_Loops
{
    internal class Program
    {
        static void Main()
        {
            // Creating a number guessing game and assigning a boolean variable to false
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool correct = false;

            // Do the following set of instructions while correct is false.
            do
            {
                // Passing in the original number variable set above and creating switches from that original number.
                // Every time the user guesses a new number it updates the variable. Once the correct number has been
                // guessed, the correct boolean changes to true which breaks the loop and congratulates the user.
                switch (number)
                {
                    case 41:
                        Console.WriteLine("You Guessed 41. Please try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("You Guessed 12. Well done! That is correct!");
                        correct = true;
                        break;

                    default:
                        Console.WriteLine("That guess is incorrect. Please try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (correct == false);
            Console.ReadLine();
        }
    }
}
