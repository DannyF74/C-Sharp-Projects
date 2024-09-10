using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the number struct, assigning the Amount value as 1 and printing it to the console.
            number testNum = new number();
            testNum.Amount = 1;
            Console.WriteLine(testNum.Amount);
            Console.ReadLine();
        }

        // Creating a new struct called number and giving it an amount property.
        public struct number
        {
            public decimal Amount { get; set; }
        }
    }
}
