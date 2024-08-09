using System;

namespace Price_Quote_Application
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Asking for package weight then using an if else statement to determine if the package is too heavy
            // If too heavy, end program. Else, carry on.
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimensions = length + width + height;

                // Using another if else statement. If dimensions are too large, end program. Else, continue.
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    // Creating calculations for our quote. Firstly multiplying our dimensions, then multiplying that result by the weight
                    // and finally dividing that result by 100. Then convert the calculation to a string using the "C" method which converts
                    // the string to display as currency.
                    int calc = ((length * width * height) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + calc.ToString("C"));
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
