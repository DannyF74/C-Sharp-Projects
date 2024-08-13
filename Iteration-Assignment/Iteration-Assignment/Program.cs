using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace Iteration_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- PART 1 --- //

            // Requirements: Create an array of strings, ask user for input, add the users input to each element of the array
            // while keeping the original data in the element, create a loop that prints off each string in the array one at a time.

            Console.WriteLine("PART 1");

            // Creating a string array and asking user for their name
            string[] testing = { "test one", "test two", "test three", "test four", "test five" };
            Console.WriteLine("Please enter your name below.");
            string name = Console.ReadLine();

            // Creating a for loop that adds the users name, a space and the original text and saves it to the original element.
            for (int i = 0; i < testing.Length; i++)
            {
                testing[i] = name + " " + testing[i];
            }

            // Printing each element in the array
            foreach (string test in testing)
            {
                Console.WriteLine(test);
            }
            Console.ReadLine();



            // --- Part 2 --- //

            // Requirements: Create an infininte loop, fix the infinite loop so that it executes properly, add comments showing
            // how this was fixed.

            Console.WriteLine("\nPART 2");

            // Here is an infinite loop. This is infinite as we initially set i to 1 and then said while i > 0, i++
            // in the first loop, i (1) > 0 so the console will write i (1) and add 1 to i (i++). Then the second loop,
            // i (2) > 0 so the console will write i (2) and add 1 to i (i++). Etc, etc..

            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // To fix this we would initially set i to 1 and choose a number greater than i for however many times we
            // wanted to go through the loop. In this example 10 times.

            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.ReadLine();



            // --- Part 3 --- //

            // Requirements: Create a loop where the comparison that is used to determine whether to continue iterating the loop
            // is a “<” operator then add another loop where the comparison that’s used to determine whether to continue iterating
            // the loop is a “<=” operator.

            Console.WriteLine("\nPART 3");

            // Here we can use the same example as above for the first loop. The loop will run 10 times.
            // It will only stop when i is no longer less than 10.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.ReadLine();

            // Below we have changed the comparison from i < 10 to i <= 10. This loop will run 11 times.
            // It will only stop when i is not less than or equal to 10.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.ReadLine();



            // --- Part 4 --- //

            // Requirements: Create a list of strings where each item in the list is unique, ask the user to input text to search for
            // in the list, Create a loop that iterates through the list and then displays the index of the list item that contains
            // matching text on the screen, add code to check if the user put in text that isn't on the list and, if they did,
            // tell the user their input is not on the list, add code that stops the loop from executing once a match has been found.

            Console.WriteLine("\nPART 4");

            // Creating a list of major German car manufacturers and setting a boolean value to track if a valid entry has been found. 
            List<string> cars = new List<string> { "audi", "bmw", "mercedes", "opel", "porsche", "vw" };
            Console.WriteLine("Please enter your favorite major German car manufacturer");
            bool isCar = false;

            // Creating a Do While loop that asks for the users input, converts that input to all lower case for data normalization.
            // Then creating a for loop that iterates through the list to check if the users input is in the list. If so, the console
            // prints the users original input before normalization and prints the index that the element was found at. It then sets
            // the boolean to true and breaks the loop. If the input is not found, an error shows to the user and allows the loop
            // to run again until a match is found.
            do
            {
                string carInput = Console.ReadLine();
                string carChoice = carInput.ToLower();
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Equals(carChoice))
                    {
                        Console.WriteLine(carInput + " is a great German car manufacturer and is found at index " + i + "!");
                        isCar = true;
                        break;
                    }
                }
                if (isCar == false)
                {
                    Console.WriteLine("That is not a major German car manufacturer. Please try again.");
                }
            }
            while (isCar == false);
            Console.ReadLine();


            // --- Part 5 --- //

            // Requirements: Create a list of strings that has at least two identical strings in the list. Ask the user to select text to
            // search for in the list. Create a loop that iterates through the list and then displays the indices of the items matching the user
            // selected text. Add code to the loop to check if the user put in text that isn't on the list and, if they did,
            // tells the user their input is not on the list.

            Console.WriteLine("\nPART 5");

            // Creating a list of students with Danny appearing twice.
            List<string> names = new List<string> { "danny", "jesse", "michael", "erik", "danny" };
            Console.WriteLine("Active Students: Danny, Jesse, Michael, Erik and Danny.\n" +
                "Please enter a students name to see their index in the list.");

            // Normalizing the data that will be input by the user
            string nameInput = Console.ReadLine();
            string nameChoice = nameInput.ToLower();

            // Setting up a boolean value to check if a name is present in the list. If the name is present, the name and index will be printed,
            // value will change to true and the loop will keep running and display multiple matches. If the boolean value is still false,
            // there was not a match in the list for the users input and an error will be shown to the user.
            bool namePresent = false;
            for (int i = 0; i < names.Count; i++) 
            {
                if (names[i].Equals(nameChoice))
                {
                    Console.WriteLine(names[i] + " is at position " + i + " in the index.");
                    namePresent = true;
                }                
            }
            if (namePresent == false)
            {
                Console.WriteLine("You have not entered the name of a student.");
            }
            Console.ReadLine();


            // --- Part 6 --- //

            // Requirements: Create a list of strings that has at least two identical strings in the list. Create a foreach loop that
            // evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared
            // in the list.

            Console.WriteLine("\nPART 6");

            // Creating a new list of letters with two identical letters. Then setting up an empty list to track the letters that
            // are duplicates. Then for each letter in the list, if it appears in the duplicate list, add the duplicate string.
            // if the letter does not appear in the duplicate list, it must be new and unique so add the unique string, then add that
            // letter to duplicate list.
            List<string> letters = new List<string> { "A", "B", "C", "D", "C" };
            List<string> duplicateLetters = new List<string>();
            foreach (string letter in letters)
            {
                if (duplicateLetters.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(letter + " - this item is unique");
                    duplicateLetters.Add(letter);
                }   
            }
            Console.ReadLine();
        }
    }
}

