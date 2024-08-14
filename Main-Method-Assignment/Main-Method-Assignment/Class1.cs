using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Class1
    {
        // Creating new overloaded method called Calculation. This will give a different answer
        // depending on what data type it is being given.
        public int Calculation(int number1)
        {
            return number1 + 1;
        }

        public int Calculation(decimal number2)
        {
            int convert1 = Convert.ToInt32(number2);
            return convert1 + 10;
        }

        public int Calculation(string stringNumber) 
        {
            int intNumber = Convert.ToInt32(stringNumber);
            return intNumber + 100;
        }
    }
}
