using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    public static class TestingStatic
    {
        // Here we are creating static methods. Static methods
        // can be accessed without the need to instantiate a class.
        public static int staticAdd(int a, int b)
        {
            return a + b; 
        }

        // Here is an example of method overloading. This takes the
        // same method name but changes the outcome depending on
        // what data type is being passed in to it.
        public static string staticAdd(string a, string b)
        {
            string result = (a + " " + b);
            return result;
        }
    }
}
