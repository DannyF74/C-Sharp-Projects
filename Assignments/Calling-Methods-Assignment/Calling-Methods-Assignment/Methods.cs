using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    // Creating the class and making it public so it can be accessed from anywhere in the namespace
    public class mathOperations
    {
        // Creating new public methods
        public int addTen(int number)
        {
            return number + 10;
        }

        public int multiplyTwo(int number)
        { 
            return number * 2; 
        }

        public int multiplyTen(int number)
        {
            return number * 10;
        }
    }
}
