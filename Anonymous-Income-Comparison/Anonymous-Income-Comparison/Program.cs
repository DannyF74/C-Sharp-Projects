using System;

namespace Anonymous_Income_Comparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter person 1's hourly rate");
            string p1RateEntry = Console.ReadLine();
            double p1Rate = Convert.ToDouble(p1RateEntry);
            Console.WriteLine("Please enter person 1's hours worked per week");
            string p1HoursEntry = Console.ReadLine();
            double p1Hours = Convert.ToDouble(p1HoursEntry);
            double p1YearlyHours = p1Hours * 52;
            double p1Salary = p1YearlyHours * p1Rate;

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter person 2's hourly rate");
            string p2RateEntry = Console.ReadLine();
            double p2Rate = Convert.ToDouble(p2RateEntry);
            Console.WriteLine("Please enter person 2's hours worked per week");
            string p2HoursEntry = Console.ReadLine();
            double p2Hours = Convert.ToDouble(p2HoursEntry);
            double p2YearlyHours = p2Hours * 52;
            double p2Salary = p2YearlyHours * p2Rate;

            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(p1Salary);

            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(p2Salary);

            Console.WriteLine("Does person 1 make more than person 2?");
            Console.WriteLine(p1Salary > p2Salary);
            Console.ReadLine();
        }
    }
}
