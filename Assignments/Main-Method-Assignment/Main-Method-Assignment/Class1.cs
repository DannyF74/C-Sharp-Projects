using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Class1
    {
        // Creating new methods called Calculation with the data type preceding it. This will give a different answer
        // depending on what data type it is being given.
        public int Calculation(int number1)
        {
            return number1 + 1;
        }

        public int Calculation(decimal number2)
        {
            return Convert.ToInt32(number2) + 10;
        }

        public int Calculation(string stringNumber) 
        {
            int intNumber = Convert.ToInt32(stringNumber);
            return intNumber + 100;
        }
    }
}
