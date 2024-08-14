using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    public class CreatedMethods
    {
        // Here we create a divide method which will take the input
        // and print the original input and the input divided by 2.
        public void Divide(int x) 
        {
            Console.WriteLine(x + " divided by 2 equals " + (x / 2));
        }

        // Here we are making a method which will take 2 inputs,
        // and assign the result of adding them together to an
        // out parameter. This can then be assigned to a variable
        // in our main program when calling this method.
        public void outputTest(int x, int y, out int result)
        {
            result = x + y;
        }
    }
}
