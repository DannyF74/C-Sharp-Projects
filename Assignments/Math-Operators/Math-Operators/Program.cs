using System;

namespace Math_Operators
{
    internal class Program
    {
        static void Main()
        {
            //Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Please enter a number");
            string num1 = Console.ReadLine();
            int int1 = Convert.ToInt32(num1);
            int answer1 = int1 * 50;
            Console.WriteLine(int1 + " multiplied by 50 is " + answer1);
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();


            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Please enter another number");
            string num2 = Console.ReadLine();
            int int2 = Convert.ToInt32(num2);
            int answer2 = int2 + 25;
            Console.WriteLine(int2 + " plus 25 is " + answer2);
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Please enter another number");
            string num3 = Console.ReadLine();
            double int3 = Convert.ToDouble(num3);
            double answer3 = int3 / 12.5;
            Console.WriteLine(int3 + " divided by 12.5 is " + answer3);
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.
            Console.WriteLine("Please enter another number");
            string num4 = Console.ReadLine();
            int int4 = Convert.ToInt32(num4);
            bool answer4 = int4 > 50;
            Console.WriteLine("Is " + int4 + " greater than 50?");
            Console.WriteLine("Answer: " + answer4);
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, then prints the remainder to the console.
            Console.WriteLine("Please enter another number");
            string num5 = Console.ReadLine();
            int int5 = Convert.ToInt32(num5);
            int answer5 = int5 % 7;
            Console.WriteLine("Does " + int5 + " have a remainder when divided by 7?");
            Console.WriteLine(Convert.ToBoolean(answer5));
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
        }
    }
}
