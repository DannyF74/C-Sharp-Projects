using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    public class Calculations
    {
        public int Calc1(int number, int times=1)
        {
            for (int i = 0; i < times; i++)
            {
                number++;
            }
            return number;
        }
    }
}
