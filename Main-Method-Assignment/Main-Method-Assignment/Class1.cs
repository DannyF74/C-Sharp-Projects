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

        public decimal Calculation(decimal number2)
        {
            return number2 + 10;
        }

        public string Calculation(string stringNumber) 
        {
            int intNumber = Convert.ToInt32(stringNumber);
            intNumber = intNumber + 100;
            stringNumber = Convert.ToString(intNumber);
            return stringNumber;
        }
    }
}
