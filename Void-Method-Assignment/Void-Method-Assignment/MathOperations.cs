using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_Assignment
{
    public class MathOperations
    {
        // Here we are creating a void method which does not return any values but prints to the console
        // from within the method. We are performing a calculation on only one of the parameters. We print
        // the result of that calculation to the console and print the other untouched parameter to the console.
        public void calc1(int x, int y)
        {
            int result = x + 10;

            Console.WriteLine("10 plus " + x + " is " + result);
            Console.WriteLine(y + " is still " + y);
        }
    }
}
