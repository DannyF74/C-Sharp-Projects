using System;
using System.Collections.Generic;


namespace Array_Assignment
{
    internal class Program
    {
        static void Main()
        {
            //Creating a string array and displaying the items in the array to the user in a way that looks friendly to them
            //(starting the list at 1 rather than 0). Then using a Do While loop to control any errors that might occur. I played around
            //with neat ways of writing these loops and the cleanest thing I could write was this loop. I have left my original way in the
            //examples below but this looks a lot more efficient.
            string[] teams = { "Blazers", "Lakers", "Knicks", "Nets" };
            Console.WriteLine("Here are the available teams...\n");
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine(i + 1 + " - " + teams[i]);
            }
            Console.WriteLine("\nPlease choose the team you'd like to pick by entering their number.");
            bool arrayCheck = false;
            do
            {
                int teamChoice = Convert.ToInt32(Console.ReadLine());
                switch (teamChoice) {
                    case int i when i >= 0 && i <= 4:
                        Console.WriteLine("\nYou have chosen the " + teams[teamChoice - 1] + "!");
                        arrayCheck = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Entry. Please try again by entering a number between 0 and 4.");
                        break;
                }
            }
            while (arrayCheck == false);
            Console.ReadLine();




            // Creating an int array and showing the original way I wrote my cases. There is a lot of code duplication here and its
            // not very efficent but still does the job.
            int[] numbers = { 15, 92, 45, 12, 1 };
            bool choiceCheck = false;
            Console.WriteLine("\nPlease enter a number between 0 and 4.");
            do
            {
                int numberChoice = Convert.ToInt32(Console.ReadLine());
                switch (numberChoice)
                {
                    case 0:
                        Console.WriteLine("\nYour secret number is: " + Convert.ToString(numbers[0]));
                        choiceCheck = true;
                        break;
                    case 1:
                        Console.WriteLine("\nYour secret number is: " + Convert.ToString(numbers[1]));
                        choiceCheck = true;
                        break;
                    case 2:
                        Console.WriteLine("\nYour secret number is: " + Convert.ToString(numbers[2]));
                        choiceCheck = true;
                        break;
                    case 3:
                        Console.WriteLine("\nYour secret number is: " + Convert.ToString(numbers[3]));
                        choiceCheck = true;
                        break;
                    case 4:
                        Console.WriteLine("\nYour secret number is: " + Convert.ToString(numbers[4]));
                        choiceCheck = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Entry. Please try again by entering a number between 0 and 4.");
                        break;
                }
            }
            while (choiceCheck == false);
            Console.ReadLine();

            // Doing the same but with a list and adding list items one by one.
            List<string> listChoices = new List<string>();
            listChoices.Add("You have chosen 0");
            listChoices.Add("You have chosen 1");
            listChoices.Add("You have chosen 2");
            listChoices.Add("You have chosen 3");
            listChoices.Add("You have chosen 4");
            bool listCheck = false;
            Console.WriteLine("\nPlease choose another number between 0 and 4");
            do
            {
                int listChoiceSelection = Convert.ToInt32(Console.ReadLine());
                switch (listChoiceSelection)
                {
                    case 0:
                        Console.WriteLine(listChoices[0]);
                        listCheck = true;
                        break;
                    case 1:
                        Console.WriteLine(listChoices[1]);
                        listCheck = true;
                        break;
                    case 2:
                        Console.WriteLine(listChoices[2]);
                        listCheck = true;
                        break;
                    case 3:
                        Console.WriteLine(listChoices[3]);
                        listCheck = true;
                        break;
                    case 4:
                        Console.WriteLine(listChoices[4]);
                        listCheck = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Entry. Please try again by entering a number between 0 and 4.");
                        break;
                }
            }
            while (listCheck == false);
            Console.ReadLine();
        }
    }
}
